using SchoolDance.Class.Logic;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }


        private void b_SignIn_Click(object sender, EventArgs e)
        {
            if (input_login.Text == "" || input_password.Text == "" || input_first_name.Text == "" || input_second_name.Text == "" ||
                input_patronymic.Text == "" || (radio_female.Checked == false && radio_male.Checked == false))
            {
                ToolsForm.ShowMessage("Нужно заполнить все поля.");
                return;
            }

            if (input_login.Text.Length < 3 || input_password.Text.Length < 3)
            {
                ToolsForm.ShowMessage("Логин и пароль должны содержать хотя бы 3 символа.");
                return;
            }

            if (SignInUpLogic.signUpNewStudent(input_login.Text, input_password.Text, input_first_name.Text, input_second_name.Text,
                input_patronymic.Text, radio_male.Checked, dateTime_birth_date.Value) == true)
                ToolsForm.ShowMessage("Регистрация успешно завершена!", "Регистрация", MessageBoxIcon.Asterisk);
            else
                ToolsForm.ShowMessage("Пользователь с таким логином уже существует.");
        }
    }
}
