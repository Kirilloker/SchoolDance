using SchoolDance.Class.DB;
using SchoolDance.Class.Logic;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
            Show_hide_password();
        }


        private void b_SignUp_Click(object sender, EventArgs e)
        {
            Registration registration = new();
            registration.Show();
        }

        private void b_SignIn_Click(object sender, EventArgs e)
        {
            if (input_login.Text == "" || input_password.Text == "")
            {
                ToolsForm.ShowMessage("Пожалуйста, заполните все поля", "Ошибка");
                return;
            }

            if (SignInUpLogic.correctSignIn(input_login.Text, input_password.Text))
            {
                Person person = DB_API.GetPerson(input_login.Text);

                switch (person.typePerson)
                {
                    case TypePerson.Student:
                        Student_menu student_Menu = new(person.Id);
                        student_Menu.Show();
                        break;
                    case TypePerson.Coach:
                        Coach_menu coach_Menu = new(person.Id);
                        coach_Menu.Show();
                        break;
                    case TypePerson.Administrator:
                        Administrator_menu administrator_Menu = new(person.Id);
                        administrator_Menu.Show();
                        break;
                    default:
                        ToolsForm.ShowMessage("Не известный тип пользователя. Обратитесь в поддержку.", "Ошибка");
                        return;
                }

                this.Hide();
            }
            else
                ToolsForm.ShowMessage("Пользователь не найден", "Ошибка");
        }

        private void b_help_Click(object sender, EventArgs e)
        {
            ToolsForm.ShowMessage("Если возникли трудности с приложением, пожалуйста, напишите нам на почту: schoolDanceNN.ru", "Помощь", MessageBoxIcon.Question);
        }

        private void Show_hide_password()
        {
            input_password.UseSystemPasswordChar = !input_password.UseSystemPasswordChar;
        }

        private void show_password_CheckedChanged_1(object sender, EventArgs e)
        {
            Show_hide_password();
        }
    }
}
