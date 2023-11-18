using SchoolDance.Class.DB;
using SchoolDance.Class.Logic;
using SchoolDance.Forms.AdminPanel;
using SchoolDance.Util;

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
            SupportMessageForUser supportMessageForUser = new(text_FIO.Text);
            supportMessageForUser.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Student_personal_info forms = new(id);
            forms.Show();
        }
    }
}
