using SchoolDance.Class.Logic;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
            input_password.UseSystemPasswordChar = true;
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
                TypePerson typePerson = SignInUpLogic.getTypePerson(input_login.Text);

                switch (typePerson)
                {
                    case TypePerson.Student:
                        Administrator_menu student_Menu = new(input_login.Text, input_password.Text);
                        student_Menu.Show();
                        break;
                    case TypePerson.Coach:
                        Administrator_menu coach_Menu = new(input_login.Text, input_password.Text);
                        coach_Menu.Show();
                        break;
                    case TypePerson.Administrator:
                        Administrator_menu administrator_Menu = new(input_login.Text, input_password.Text);
                        administrator_Menu.Show();
                        break;
                    default:
                        ToolsForm.ShowMessage("Не известный тип пользователя. Обратитесь в поддержку.", "Ошибка");
                        return;
                }

                this.Hide();
                Console.WriteLine(typePerson);
            }
            else
                ToolsForm.ShowMessage("Пользователь не найден", "Ошибка");
        }

        private void b_help_Click(object sender, EventArgs e)
        {
            ToolsForm.ShowMessage("Если возникли трудности с приложением, пожалуйста, напишите нам на почту: schoolDanceNN.ru", "Помощь", MessageBoxIcon.Question);
        }
    }
}
