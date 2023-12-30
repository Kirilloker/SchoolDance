using SchoolDance.Class.DB;
using SchoolDance.Class.Logic;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            Show_hide_password();
        }
        public delegate void CloseMainWindow();

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
                Person person = DB_Controller.GetPerson(input_login.Text);
                if (person == null)
                {
                    ToolsForm.ShowMessage("Не известный тип пользователя. Обратитесь в поддержку.", "Ошибка");
                    return;
                }

                switch (person.typePerson)
                {
                    case TypePerson.Student:
                        Student_menu student_Menu = new(person.Id, Close_main_window);
                        student_Menu.Show();
                        break;
                    case TypePerson.Coach:
                        Coach_menu coach_Menu = new(person.Id, Close_main_window);
                        coach_Menu.Show();
                        break;
                    case TypePerson.Administrator:
                        Administrator_menu administrator_Menu = new(person.Id, Close_main_window);
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

        private void Close_main_window()
        {
            Close();
        }

        private void b_add_test_date_Click(object sender, EventArgs e)
        {
            ToolsDB.AddNewData();
        }
    }
}
