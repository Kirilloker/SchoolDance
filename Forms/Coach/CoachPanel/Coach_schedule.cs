using SchoolDance.Class.DB;

namespace SchoolDance.Forms
{
    public partial class Coach_schedule : Form
    {
        public Coach_schedule(int coach_id)
        {
            List<Lesson> lessons = DB_Controller.GetAll<Lesson>().Where(b => b.coachId == coach_id).ToList();
            if (lessons.Count == 0)
                return;

            InitializeComponent();
            CreatePanel(CreateSchedule(lessons));
        }

        string[] weekdays_in_order = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

        static Dictionary<string, List<string>> CreateSchedule(List<Lesson> lessons)
        {
            Dictionary<string, List<string>> schedule = new Dictionary<string, List<string>>();

            foreach (var lesson in lessons.OrderBy(l => l.time_start))
            {
                if (lesson.weekdays == null) continue;
                var days = lesson.weekdays.Split(',').Select(d => d.Trim());

                foreach (var day in days)
                {
                    string lessonInfo = "Время: " + lesson.time_start + "      занятие: " + lesson.className + "      комната: " + GetNameRoom(lesson.danceHallId) + "\r\n";

                    if (!schedule.ContainsKey(day))
                        schedule[day] = new List<string>();

                    schedule[day].Add(lessonInfo);
                }
            }

            return schedule;
        }


        static string GetNameRoom(int danceHallId)
        {
            DanceHall danceHall = DB_Controller.Get<DanceHall>(danceHallId);
            if (danceHall == null) return "Комната не известна";
            return danceHall.roomNumber;
        }


        private void CreatePanel(Dictionary<string, List<string>> dict)
        {
            int i = 0;

            foreach (var week in weekdays_in_order)
            {
                if (dict.ContainsKey(week) == false) continue;
                Panel panel_generate = new Panel();
                panel_generate.Size = new Size(730, 300);
                panel_generate.Location = new Point(13, i * 320 + 13);
                panel_generate.BackColor = Color.CadetBlue;
                panel_generate.Controls.Add(CreateLabel(week));
                panel_generate.Controls.Add(CreateTextBox(dict[week], panel_generate));

                panel1.Controls.Add(panel_generate);
                i++;
            }
        }

        private Label CreateLabel(string week_name)
        {
            Label label = new Label();
            label.Text = week_name;
            label.Font = new Font("Segoe UI", 20f);
            label.Location = new Point(270, 15);
            label.Size = new Size(300, 50);
            return label;
        }

        private TextBox CreateTextBox(List<string> date, Panel panel)
        {
            TextBox textBox_with_schedule = new TextBox();
            textBox_with_schedule.Multiline = true;
            textBox_with_schedule.Size = new Size(680, 200);
            textBox_with_schedule.Location = new Point(25, 80);
            textBox_with_schedule.ReadOnly = true;
            textBox_with_schedule.Font = new Font("Segoe UI", 11f);
            textBox_with_schedule.ScrollBars = ScrollBars.Vertical;

            foreach (var item in date)
                textBox_with_schedule.AppendText(item);

            return textBox_with_schedule;
        }
        static int CountSubstringOccurrences(string input, string substring)
        {
            int count = 0;
            int index = input.IndexOf(substring, StringComparison.Ordinal);

            while (index != -1)
            {
                count++;
                index = input.IndexOf(substring, index + substring.Length, StringComparison.Ordinal);
            }

            return count;
        }

    }
}
