using SchoolDance.Class.DB;
using SchoolDance.Class.Logic;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Student_personal_info : Form
    {
        int id_person;
        Student student;
        public Student_personal_info(int id_person)
        {
            InitializeComponent();
            this.id_person = id_person;

            student = DB_API.Get<Student>(id_person);

            input_login.Text = student.login;
            // input_password.Text = student.password;

            dateTime_birth_date.Value = student.date;

            if (student.gender == "Male")
                radio_male.Checked = true;
            else
                radio_female.Checked = true;


            Show_hide_password();

            string[] words = student.fullName.Split(' ');
            if (words.Length >= 1)
                input_first_name.Text = words[0];
            if (words.Length >= 2)
                input_second_name.Text = words[1];
            if (words.Length >= 3)
                input_patronymic.Text = words[2];

        }

        private void Show_hide_password()
        {
            input_password.UseSystemPasswordChar = !input_password.UseSystemPasswordChar;
        }

        private void b_SignIn_Click(object sender, EventArgs e)
        {
            if (input_login.Text == "" || input_first_name.Text == "" || input_second_name.Text == "" ||
                input_patronymic.Text == "" || (radio_female.Checked == false && radio_male.Checked == false))
            {
                ToolsForm.ShowMessage("Не все поля заполнены.");
                return;
            }

            if (input_login.Text.Length < 3 || (input_password.Text.Length >= 1 && input_password.Text.Length < 3))
            {
                ToolsForm.ShowMessage("Логин и пароль должны содержать хотя бы 3 символа.");
                return;
            }

            Student student_new_info = new Student
            {
                login = input_login.Text,
                password = student.password,
                fullName = input_first_name.Text + " " + input_second_name.Text + " " + input_patronymic.Text,
                gender = radio_male.Checked == true ? "Male" : "Female",
                date = dateTime_birth_date.Value,
                typePerson = TypePerson.Student,
                Id = student.Id
            };

            if (input_password.Text != "")
                student_new_info.password = SignInUpLogic.EncodeStringToBase64(input_password.Text);

            DB_API.Delete<Student>(student.Id);
            if (DB_API.AddStudent(student_new_info) == true) 
            {
                ToolsForm.ShowMessage("Данные успешно изменены!", "Изменение данных", MessageBoxIcon.Asterisk);
                student = student_new_info;
            }
            else 
            {
                ToolsForm.ShowMessage("Пользователь с таким логином уже существует.");
                DB_API.AddStudent(student);
            }
        }

        private void show_password_CheckedChanged(object sender, EventArgs e)
        {
            Show_hide_password();
        }
    }
}
