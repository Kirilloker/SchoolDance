using SchoolDance.Class.DB;
using SchoolDance.Class.Logic;
using SchoolDance.Forms.AdminPanel;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Coach_menu : Form
    {
        string login = "";
        string password = "";
        public Coach_menu(string login_, string password_)
        {
            this.login = login_;
            this.password = password_;

            InitializeComponent();
            text_FIO.Text = ToolsDB.getName(login);
        }

        private void b_answers_Click(object sender, EventArgs e)
        {
            SupportMessageForUser supportMessageForUser = new(text_FIO.Text);
            supportMessageForUser.Show();
        }
    }
}
