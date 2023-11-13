using SchoolDance.Class.DB;
using SchoolDance.Class.Logic;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Administrator_menu : Form
    {
        string login = "";
        string password = "";
        public Administrator_menu(string login_, string password_)
        {
            this.login = login_;
            this.password = password_;

            InitializeComponent();

            text_FIO.Text = ToolsDB.getName(login);
        }

        private void b_student_Click(object sender, EventArgs e)
        {
            AdminPanelStudent menu = new();
            menu.Show();
        }

        private void b_coach_Click(object sender, EventArgs e)
        {
            AdminPanelCoach menu = new();
            menu.Show();
        }

        private void b_payment_Click(object sender, EventArgs e)
        {
            AdminPanelPayment menu = new();
            menu.Show();
        }

        private void b_hall_Click(object sender, EventArgs e)
        {
            AdminPanelDanceHall menu = new();
            menu.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminPanelDanceStyle menu = new();
            menu.Show();
        }
    }
}
