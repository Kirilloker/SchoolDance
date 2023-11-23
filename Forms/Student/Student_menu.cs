using SchoolDance.Class.DB;
using static SchoolDance.Forms.Authorization;

namespace SchoolDance.Forms
{
    public partial class Student_menu : Form
    {
        int id;
        private CloseMainWindow CloseMainWindowDelegate;
        public Student_menu(int id, CloseMainWindow CloseMainWindowDelegate_)
        {
            this.id = id;
            this.CloseMainWindowDelegate = CloseMainWindowDelegate_;
            InitializeComponent();
            text_FIO.Text = DB_API.Get<Student>(id).fullName;
        }


        private void b_answers_Click(object sender, EventArgs e)
        {
            SupportMessageForUser forms = new(text_FIO.Text);
            forms.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Student_personal_info forms = new(id);
            forms.Show();
        }

        private void b_question_click(object sender, EventArgs e)
        {
            Student_question forms = new();
            forms.Show();
        }

        private void b_signUp_lesosn_Click(object sender, EventArgs e)
        {
            Student_signUp_lesson forms = new(id);
            forms.Show();
        }

        private void b_pay_lesson_Click(object sender, EventArgs e)
        {
            Student_pay_for_lesson forms = new(id);
            forms.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            CloseMainWindowDelegate();
        }

        private void b_my_schedule_Click(object sender, EventArgs e)
        {
            Student_schedule forms = new(id);
            forms.Show();
        }
        private void b_event_Click(object sender, EventArgs e)
        {
            Student_event forms = new();
            forms.Show();
        }
    }
}
