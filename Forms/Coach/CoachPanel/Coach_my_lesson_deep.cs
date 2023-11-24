using SchoolDance.Class.DB;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Coach_my_lesson_deep : Form
    {
        Lesson lesson;
        public Coach_my_lesson_deep(Lesson lesson)
        {
            InitializeComponent();
            this.lesson = lesson;

            text_name_lesson.Text += lesson.className;
            text_dance_style_lesson.Text += GetDanceStyleName(lesson.danceStylesId);
            text_week_days.Text += lesson.weekdays;
            text_time_start_lesson.Text += lesson.time_start;
            text_price.Text += lesson.price.ToString();
            text_description.Text = lesson.description;
            text_dancehall.Text += GetDanceHallName(lesson.danceHallId);
            text_number_free_place.Text += GetNumberFreePlace(lesson);

            create_payments();
        }

        string? GetDanceStyleName(int? danceStyleId)
        {
            DanceStyle? danceStyle = DB_API.GetAll<DanceStyle>().FirstOrDefault(style => style.Id == danceStyleId);
            return danceStyle != null ? danceStyle.name : "Неизвестный стиль";
        }

        string? GetDanceHallName(int? danceHallId)
        {
            DanceHall? danceHall = DB_API.GetAll<DanceHall>().FirstOrDefault(style => style.Id == danceHallId);
            return danceHall != null ? danceHall.roomNumber : "Неизвестный стиль";
        }

        string? GetNumberFreePlace(Lesson lesson)
        {
            DanceHall? danceHall = DB_API.GetAll<DanceHall>().FirstOrDefault(style => style.Id == lesson.danceHallId);
            if (danceHall == null) return "?/?";
            if (lesson.studentId == null) return "0/" + danceHall.capacity.ToString();

            return
                (lesson.studentId.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Length.ToString())
                + "/" + danceHall.capacity.ToString();
        }

        private string? GetNameStudent(int studentId)
        {
            Student student = DB_API.Get<Student>(studentId);
            if (student == null || student.fullName == null) return "Неизвестный студент";
            return student.fullName;
        }


        private void create_payments()
        {
            List<Payment> payments = DB_API.GetAll<Payment>().Where(p => p.lessonId == lesson.Id).ToList();

            int panelX = 20;
            int panelY = 10;

            foreach (Payment payment in payments)
            {
                if ((payment == null) || (payment.studentId == null))
                    continue;

                TimeSpan difference = DateTime.Now.Subtract(payment.date_end_subscription);
                int differenceInDays = Math.Abs((int)difference.TotalDays);

                Color BackColor_panel = Color.Cornsilk;
                if (differenceInDays > 15)
                    BackColor_panel = Color.LightGreen;
                if (differenceInDays < 6)
                    BackColor_panel = Color.LightCoral;

                Panel panel = new Panel
                {
                    Location = new Point(panelX, panelY),
                    Size = new Size(500, 80),
                    BackColor = BackColor_panel
                };

                Label lessonLabel = new Label
                {
                    Location = new Point(10, 10),
                    Text = "Студент: " + GetNameStudent((int)payment.studentId),
                    Font = new Font("Segoe UI", 10),
                    AutoSize = true
                };

                Label endDateLabel = new Label
                {
                    Location = new Point(10, 40),
                    Text = "Продлен до: " + payment.date_end_subscription.ToString("dd.MM.yyyy"),
                    Font = new Font("Segoe UI", 10),
                    AutoSize = true
                };

                panel.Controls.Add(lessonLabel);
                panel.Controls.Add(endDateLabel);
                panel.Size = new Size(675, 100);

                panel2.Controls.Add(panel);

                panelY += 120;
            }

        }
    }
}

