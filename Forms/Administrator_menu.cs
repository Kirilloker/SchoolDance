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

    }
}
