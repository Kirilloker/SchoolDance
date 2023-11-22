using Org.BouncyCastle.Crypto.Macs;
using SchoolDance.Class.DB;
using SchoolDance.Util;
using static SchoolDance.Forms.Authorization;

namespace SchoolDance.Forms
{
    public partial class Coach_menu : Form
    {
        int coach_id;
        Coach coach;
        private CloseMainWindow CloseMainWindowDelegate;
        public Coach_menu(int coach_id, CloseMainWindow closeMainWindow)
        {
            this.CloseMainWindowDelegate = closeMainWindow; 
            this.coach_id = coach_id;

            InitializeComponent();
            
            coach = DB_API.Get<Coach>(coach_id);

            if (coach != null && coach.fullName != null)
            {
                text_FIO.Text = coach.fullName;
            }
            else 
            {
                text_FIO.Text = "Неизвестный пользователь";
                coach = new Coach();
            }
        }

        private void b_answers_Click(object sender, EventArgs e)
        {
            SupportMessageForUser forms = new(text_FIO.Text);
            forms.Show();
        }


        private void b_create_lesson_Click(object sender, EventArgs e)
        {
            Coach_create_lesson forms = new(coach_id);
            forms.Show();
        }


        private void button8_Click(object sender, EventArgs e)
        {
            Coach_personal_info forms = new(coach_id);
            forms.Show();
        }

        private void my_lesson_Click(object sender, EventArgs e)
        {
            Coach_my_lesson forms = new(coach_id);
            forms.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            CloseMainWindowDelegate();
        }
    }
}
