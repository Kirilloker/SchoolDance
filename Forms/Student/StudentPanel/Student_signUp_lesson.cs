using SchoolDance.Class.DB;
using SchoolDance.Controller;

namespace SchoolDance.Forms
{
    public partial class Student_signUp_lesson : Form
    {
        List<DanceStyle> danceStyles = new();
        int studentId;
        MainController<Lesson> controllerLesson = new();
        MainController<DanceStyle> controllerDanceStyle = new();


        public Student_signUp_lesson(int studentId)
        {
            InitializeComponent();
            danceStyles = controllerDanceStyle.GetDateFromDB();
            this.studentId = studentId;
            CreateLessonPanels(controllerLesson.GetDateFromDB());
        }

        void CreateLessonPanels(List<Lesson> lessons)
        {
            int x = 10;
            int y = 15;

            foreach (var lesson in lessons)
            {
                var lessonPanel = new Panel();
                lessonPanel.BackColor = Color.LemonChiffon;
                lessonPanel.Width = 764;
                lessonPanel.Height = 106;
                lessonPanel.Location = new Point(x, y);

                var nameLabel = new Label();
                nameLabel.Text = "Название: " + lesson.className;
                nameLabel.Size = new Size(500, 20);
                nameLabel.Location = new Point(10, 10);

                var styleLabel = new Label();
                styleLabel.Text = "Стиль танца: " + GetDanceStyleName(lesson.danceStylesId);
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
                    Student_signUp_lesson_deep menu = new(studentId, lesson.Id);
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

        string? GetDanceStyleName(int? danceStyleId)
        {
            DanceStyle? danceStyle = danceStyles.FirstOrDefault(style => style.Id == danceStyleId);
            return danceStyle != null ? danceStyle.name : "Неизвестный стиль";
        }
    }
}
