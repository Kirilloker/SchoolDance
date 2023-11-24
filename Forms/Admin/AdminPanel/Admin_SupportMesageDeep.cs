using SchoolDance.Class.DB;
using static SchoolDance.Forms.AdminPanel.Admin_SupportMessage;

namespace SchoolDance.Forms.AdminPanel
{
    public partial class AdminPanelSupportMessageDeep : Form
    {
        int idMessage;
        SupportMessage? supportMessage;
        private ShowOnDelegate showOnDelegate;


        public AdminPanelSupportMessageDeep(int _idMessage, ShowOnDelegate showOnDelegate)
        {
            InitializeComponent();
            this.showOnDelegate = showOnDelegate;
            idMessage = _idMessage;


            supportMessage = DB_API.Get<SupportMessage>(idMessage);

            text_topic.Text = "Тема: " + supportMessage.typeMessage;
            text_status.Text = "Статус: " + (supportMessage.isSolved == true ? "Решено" : "Не решено");
            text_user_name.Text = "Пользователь: " + supportMessage.personName;

            if (supportMessage.date == null) text_date.Text = DateTime.MinValue.ToString();
            else text_date.Text = "Дата: " + supportMessage.date.Value.ToString();

            input_text_user.Text = supportMessage.message;
        }

        private void b_solved_Click(object sender, EventArgs e)
        {
            supportMessage.isSolved = true;
            DB_API.Update<SupportMessage>(supportMessage);
            showOnDelegate(idMessage - 1, true);
            this.Close();
        }

        private void b_no_solved_Click(object sender, EventArgs e)
        {
            supportMessage.isSolved = false;
            DB_API.Update<SupportMessage>(supportMessage);
            showOnDelegate(idMessage - 1, false);
            this.Close();
        }
    }
}
