using SchoolDance.Class.DB;

namespace SchoolDance.Forms
{
    public partial class Student_event : Form
    {
        public Student_event()
        {
            InitializeComponent();

            List<EventDance> all_event = DB_Controller.GetAll<EventDance>();
            CreatePanel(all_event);
        }

        private void CreatePanel(List<EventDance> events)
        {
            int i = 0;

            foreach (var event_ in events)
            {
                if (event_.nameEvent == null || event_.description == null) continue;

                Panel panel_generate = new Panel();
                panel_generate.Size = new Size(730, 300);
                panel_generate.Location = new Point(13, i * 320 + 13);
                panel_generate.BackColor = Color.Khaki;
                panel_generate.Controls.Add(CreateLabel(event_.nameEvent));
                panel_generate.Controls.Add(CreateTextBox(event_.description));
                panel_generate.Controls.Add(CreateDate(event_.date));

                panel11.Controls.Add(panel_generate);
                i++;
            }
        }

        private Label CreateLabel(string event_name)
        {
            Label label = new Label();
            label.Text = event_name;
            label.Font = new Font("Segoe UI", 20f);
            label.Location = new Point(25, 15);
            label.Size = new Size(300, 50);
            return label;
        }

        private Label CreateDate(DateTime event_date)
        {
            Label label = new Label();
            label.Text = "Дата: " + event_date.ToString("dd.MM.yyyy");
            label.Font = new Font("Segoe UI", 20f);
            label.Location = new Point(25, 65);
            label.Size = new Size(300, 50);
            return label;
        }

        private TextBox CreateTextBox(string description)
        {
            TextBox textBox_with_schedule = new TextBox();
            textBox_with_schedule.Multiline = true;
            textBox_with_schedule.Size = new Size(680, 150);
            textBox_with_schedule.Location = new Point(25, 130);
            textBox_with_schedule.ReadOnly = true;
            textBox_with_schedule.Font = new Font("Segoe UI", 11f);
            textBox_with_schedule.ScrollBars = ScrollBars.Vertical;
            textBox_with_schedule.AppendText(description);

            return textBox_with_schedule;
        }
    }
}
