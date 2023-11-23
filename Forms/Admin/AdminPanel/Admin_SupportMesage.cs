using SchoolDance.Class.DB;

namespace SchoolDance.Forms.AdminPanel
{
    public partial class Admin_SupportMesage : Form
    {
        public Admin_SupportMesage()
        {
            InitializeComponent();
            CreateSupportButtons(DB_API.GetAll<SupportMessage>());
        }

        public delegate void ShowOnDelegate(int index, bool isColorGreen);

        void CreateSupportButtons(List<SupportMessage> messages)
        {
            int x = 25;
            int y = 0;

            foreach (var message in messages)
            {
                var button = new Button();
                button.Width = 750;
                button.Height = 70;
                button.Location = new Point(x, y);
                button.Text = "Тема: " + message.typeMessage;

                if (message.isSolved)
                    button.BackColor = Color.Green;
                else
                    button.BackColor = Color.Gray;

                button.Click += (sender, e) => {
                    AdminPanelSupportMessageDeep menu = new(message.Id, ShowOn);
                    menu.Show();
                    this.Hide();
                };

                panel1.Controls.Add(button); 
                y += 90;
            }
        }

        void ChangeButtonColor(int index, bool isColorGreen)
        {
            if (index >= 0 && index < panel1.Controls.Count)
            {
                Button button = (Button)panel1.Controls[index];

                if (isColorGreen)
                    button.BackColor = Color.Green;
                else
                    button.BackColor = Color.Gray;
                button.Refresh();
            }
        }


        void ShowOn(int index, bool isColorGreen)
        {
            ChangeButtonColor(index, isColorGreen);
            this.Show(); 
        }
    }
}
