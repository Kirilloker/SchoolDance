using SchoolDance.Class.DB;
using SchoolDance.Class.Logic;
using SchoolDance.Forms.AdminPanel;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Administrator_menu : Form
    {
        int id;
        public Administrator_menu(int id)
        {
            this.id = id;
            InitializeComponent();
            text_FIO.Text = DB_API.Get<Administrator>(id).fullName;
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

        private void b_class_Click(object sender, EventArgs e)
        {
            AdminPanelLesson menu = new();
            menu.Show();
        }

        private void b_group_Click(object sender, EventArgs e)
        {
            AdminPanelGroup menu = new();
            menu.Show();
        }

        private void b_event_Click(object sender, EventArgs e)
        {
            AdminPanelEventDance menu = new();
            menu.Show();
        }

        private void b_answers_Click(object sender, EventArgs e)
        {
            AdminPanelSupportMesage menu = new();
            menu.Show();
        }
    }
}
