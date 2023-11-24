using SchoolDance.Class.DB;
using SchoolDance.Class.Logic;
using SchoolDance.Forms.Admin.AdminPanel;
using SchoolDance.Forms.AdminPanel;
using SchoolDance.Util;
using static SchoolDance.Forms.Authorization;

namespace SchoolDance.Forms
{
    public partial class Administrator_menu : Form
    {
        int id;
        Administrator administrator;
        private CloseMainWindow CloseMainWindowDelegate;
        public Administrator_menu(int id, CloseMainWindow CloseMainWindowDelegate)
        {
            this.CloseMainWindowDelegate = CloseMainWindowDelegate;
            this.id = id;
            InitializeComponent();

            administrator = DB_API.Get<Administrator>(id);

            if (administrator != null && administrator.fullName != null)
            {
                text_FIO.Text = administrator.fullName;
            }
            else
            {
                text_FIO.Text = "Неизвестный пользователь";
                administrator = new();
            }
        }

        private void b_student_Click(object sender, EventArgs e)
        {
            Admin_Student menu = new();
            menu.Show();
        }

        private void b_coach_Click(object sender, EventArgs e)
        {
            Admin_Coach menu = new();
            menu.Show();
        }

        private void b_payment_Click(object sender, EventArgs e)
        {
            Admin_TopUp menu = new();
            menu.Show();
        }

        private void b_hall_Click(object sender, EventArgs e)
        {
            Admin_DanceHall menu = new();
            menu.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Admin_DanceStyle menu = new();
            menu.Show();
        }

        private void b_class_Click(object sender, EventArgs e)
        {
            Admin_Lesson menu = new();
            menu.Show();
        }

        private void b_group_Click(object sender, EventArgs e)
        {
            Admin_Payment menu = new();
            menu.Show();
        }

        private void b_event_Click(object sender, EventArgs e)
        {
            Admin_EventDance menu = new();
            menu.Show();
        }

        private void b_answers_Click(object sender, EventArgs e)
        {
            Admin_SupportMessage menu = new();
            menu.Show();
        }

        private void b_create_report_Click(object sender, EventArgs e)
        {
            Admin_Report menu = new();
            menu.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            CloseMainWindowDelegate();
        }
    }


}
