using SchoolDance.Class.DB;
using System.Data;

namespace SchoolDance.Forms
{
    public partial class Coach_my_lesson : Form
    {
        int coach_id;
        public Coach_my_lesson(int coach_id_)
        {
            coach_id = coach_id_;
            InitializeComponent();
            CreateLessonPanels(DB_API.GetAll<Lesson>().Where(p => p.coachId == coach_id).ToList());
        }

        void CreateLessonPanels(List<Lesson> lessons)
        {
            int x = 10;
            int y = 15;

            foreach (var lesson in lessons)
            {
                if ((lesson == null) || (lesson.className == null) || (lesson.danceStylesId == null))
                    continue;

                var lessonPanel = new Panel();
                lessonPanel.BackColor = Color.LightSkyBlue;
                lessonPanel.Width = 764;
                lessonPanel.Height = 106;
                lessonPanel.Location = new Point(x, y);

                var nameLabel = new Label();
                nameLabel.Text = "Название: " + lesson.className;
                nameLabel.Size = new Size(500, 20);
                nameLabel.Location = new Point(10, 10);

                var styleLabel = new Label();
                styleLabel.Text = "Количество мест: " + GetNumberFreePlace(lesson, lesson.danceStylesId);
                styleLabel.Location = new Point(10, 40);
                styleLabel.Size = new Size(500, 20);

                var weekdaysLabel = new Label();
                weekdaysLabel.Text = "Цена: " + lesson.price.ToString();
                weekdaysLabel.Location = new Point(10, 70);
                weekdaysLabel.Size = new Size(500, 20);

                var detailsButton = new Button();
                detailsButton.Text = "Подробнее";
                detailsButton.Location = new Point(539, 25);
                detailsButton.Size = new Size(210, 50);
                detailsButton.BackColor = Color.White;
                detailsButton.Font = new Font("Segoe UI", 16);

                detailsButton.Click += (sender, e) =>
                {
                    Coach_my_lesson_deep menu = new(lesson);
                    menu.Show();
                };

                lessonPanel.Controls.Add(nameLabel);
                lessonPanel.Controls.Add(styleLabel);
                lessonPanel.Controls.Add(weekdaysLabel);
                lessonPanel.Controls.Add(detailsButton);

                panel1.Controls.Add(lessonPanel);

                y += 130;
            }
        }

        string? GetNumberFreePlace(Lesson lesson, int? danceHallId)
        {
            DanceHall? danceHall = DB_API.GetAll<DanceHall>().FirstOrDefault(style => style.Id == danceHallId);
            if (danceHall == null) return "?/?";
            if (lesson.studentId == null) return "0/" + danceHall.capacity.ToString();

            return
                (lesson.studentId.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Length.ToString())
                + "/" + danceHall.capacity.ToString();
        }

    }
}
