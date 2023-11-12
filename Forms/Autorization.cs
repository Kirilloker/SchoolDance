using SchoolDance.Class.Logic;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }


        private void b_SignUp_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
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
