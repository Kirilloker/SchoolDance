using SchoolDance.Class.DB;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class SupportMessageForUser : Form
    {
        string personName = "";
        public SupportMessageForUser(string personName_)
        {
            InitializeComponent();
            personName = personName_;
            list_topic_problem.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((list_topic_problem.SelectedIndex == -1) || (input_text_user.Text == ""))
            {
                Util.ToolsForm.ShowMessage("Нужно заполнить все поля!");
                return;
            }

            SupportMessage supportMessage = new SupportMessage
            {
                date = DateTime.Now,
                isSolved = false,
                message = input_text_user.Text,
                typeMessage = list_topic_problem.Text,
                personName = personName
            };

            if (DB_Controller.Add(supportMessage) == true)
                ToolsForm.ShowMessage("Сообщение доставлено", "Сообщение об ошибке", MessageBoxIcon.Asterisk);
            else
                ToolsForm.ShowMessage("Что-то пошло не так. Возможно вы уже отсылали такое сообщение.");
        }
    }
}
