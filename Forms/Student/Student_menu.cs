using SchoolDance.Class.DB;


namespace SchoolDance.Forms
{
    public partial class Student_menu : Form
    {
        int id;
        public Student_menu(int id)
        {
            this.id = id;
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
    }
}
