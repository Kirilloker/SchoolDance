using Org.BouncyCastle.Crypto.Macs;
using SchoolDance.Class.DB;
using SchoolDance.Class.Logic;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Coach_personal_info : Form
    {
        Coach coach;
        public Coach_personal_info(int id_person)
        {
            InitializeComponent();

            coach = DB_API.Get<Coach>(id_person);
            if (coach == null)
                coach = new() { Id = -1};

            input_login.Text = coach.login;

            dateTime_birth_date.Value = coach.date;

            if (coach.gender == "Male")
                radio_male.Checked = true;
            else
                radio_female.Checked = true;
            Show_hide_password();

            if (coach.fullName == null) coach.fullName = "Неизвестный пользователь";

            string[] words = coach.fullName.Split(' ');
            if (words.Length >= 1)
                input_first_name.Text = words[0];
            if (words.Length >= 2)
                input_second_name.Text = words[1];
            if (words.Length >= 3)
                input_patronymic.Text = words[2];

            input_phone_number.Text = coach.phoneNumber;
            input_work_experience.Text = coach.workExperienceMonth.ToString();
            input_position.Text = coach.position;

            List<DanceStyle> danceStyles = DB_API.GetAll<DanceStyle>();
            string[] formattedNames = danceStyles.Select((ds) => $"{ds.Id}. {ds.name}").ToArray();
            box_danceStyle.Items.AddRange(formattedNames);

            if (coach.danceStylesId == null) coach.danceStylesId = "";

            string[] danceStylesIdArray = coach.danceStylesId.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] danceStylesIdIntegers = Array.ConvertAll(danceStylesIdArray, int.Parse);

            foreach (int index in danceStylesIdIntegers)
                if ((index - 1) >= 0 && (index - 1) < box_danceStyle.Items.Count)
                    box_danceStyle.SetSelected(index - 1, true);
        }

        private void Show_hide_password()
        {
            input_password.UseSystemPasswordChar = !input_password.UseSystemPasswordChar;
        }

        private void b_SignIn_Click(object sender, EventArgs e)
        {
            if (input_login.Text == "" || input_first_name.Text == "" || input_second_name.Text == "" ||
                input_patronymic.Text == "" || (radio_female.Checked == false && radio_male.Checked == false)
                || input_phone_number.Text == ""
                )
            {
                ToolsForm.ShowMessage("Не все поля заполнены.");
                return;
            }

            if (input_login.Text.Length < 3 || (input_password.Text.Length >= 1 && input_password.Text.Length < 3))
            {
                ToolsForm.ShowMessage("Логин и пароль должны содержать хотя бы 3 символа.");
                return;
            }

            Double phoneNumber = 0;
            if (!Double.TryParse(input_phone_number.Text, out phoneNumber) ||
                input_phone_number.Text.Length != 11)
            {
                ToolsForm.ShowMessage("Номер введен не корректно. Пример: 79101351393");
                return;
            }

            string str_danceStyleId = "";

            List<string> list_danceStyle = new();
            foreach (var item in box_danceStyle.SelectedItems)
            {
                if (item == null) continue; 
                str_danceStyleId += item.ToString().Split(". ")[0] + ", ";
            }

            Coach coach_new_info = new Coach
            {
                login = input_login.Text,
                password = coach.password,
                fullName = input_first_name.Text + " " + input_second_name.Text + " " + input_patronymic.Text,
                gender = radio_male.Checked == true ? "Male" : "Female",
                date = dateTime_birth_date.Value,
                typePerson = TypePerson.Coach,
                Id = coach.Id,
                danceStylesId = str_danceStyleId,
                workExperienceMonth = coach.workExperienceMonth,
                position = coach.position,
                phoneNumber = input_phone_number.Text,
            };

            if (input_password.Text != "")
                coach_new_info.password = SignInUpLogic.EncodeStringToBase64(input_password.Text);

            DB_API.Delete<Coach>(coach.Id);
            if (DB_API.AddCoach(coach_new_info) == true)
            {
                ToolsForm.ShowMessage("Данные успешно изменены!", "Изменение данных", MessageBoxIcon.Asterisk);
                coach = coach_new_info;
            }
            else
            {
                ToolsForm.ShowMessage("Пользователь с таким логином уже существует.");
                DB_API.AddCoach(coach);
            }
        }

        private void show_password_CheckedChanged(object sender, EventArgs e)
        {
            Show_hide_password();
        }
    }
}
