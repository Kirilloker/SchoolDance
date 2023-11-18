using SchoolDance.Class.DB;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Coach_menu : Form
    {
        int id;
        public Coach_menu(int id)
        {
            this.id = id;

            InitializeComponent();
            text_FIO.Text = DB_API.Get<Coach>(id).fullName;
        }

        private void b_answers_Click(object sender, EventArgs e)
        {
            SupportMessageForUser supportMessageForUser = new(text_FIO.Text);
            supportMessageForUser.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Coach_personal_info forms = new(id);
            forms.Show();
        }
    }
}
