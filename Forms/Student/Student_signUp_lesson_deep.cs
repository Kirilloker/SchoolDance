using SchoolDance.Class.DB;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Student_signUp_lesson_deep : Form
    {
        int studentId;
        Lesson lesson;
        public Student_signUp_lesson_deep(int studentId, int lessonId)
        {
            this.studentId = studentId;
            InitializeComponent();

            lesson = DB_API.Get<Lesson>(lessonId);

            text_name_lesson.Text += lesson.className;
            text_dance_style_lesson.Text += GetDanceStyleName(lesson.danceStylesId);
            text_week_days.Text += lesson.weekdays;
            text_time_start_lesson.Text += lesson.time_start;
            text_price.Text += lesson.price.ToString();
            text_description.Text = lesson.description;
            text_dancehall.Text += GetDanceHallName(lesson.danceHallId);
            text_number_free_place.Text += GetNumberFreePlace(lesson.danceHallId);

            Coach coach = DB_API.Get<Coach>(lesson.coachId);

            text_name_coach.Text += coach.fullName;
            text_work_experience.Text += coach.workExperienceMonth.ToString();
            text_position.Text += coach.position;


            string[] danceStylesIdArray = coach.danceStylesId.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] danceStylesIdIntegers = Array.ConvertAll(danceStylesIdArray, int.Parse);

            List<string> formattedNames = new();
            foreach (var item in danceStylesIdIntegers)
                formattedNames.Add(GetDanceStyleName(item));

            list_dance_style.Items.AddRange(formattedNames.ToArray());
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

        string? GetNumberFreePlace(int? danceHallId)
        {
            DanceHall? danceHall = DB_API.GetAll<DanceHall>().FirstOrDefault(style => style.Id == danceHallId);
            return
                (lesson.studentId.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Length.ToString())
                + "/" + danceHall.capacity.ToString();
        }

        private void b_signUp_lesson_Click(object sender, EventArgs e)
        {
            string[] elements = lesson.studentId.Split(", ");

            if (elements.Contains(studentId.ToString()) == true)
            {
                ToolsForm.ShowMessage("Вы уже записаны на это занятие.", "Запись на занятие");
                return;
            }

            if (CheckCorrectLesson(lesson) == false) 
            {
                ToolsForm.ShowMessage("У Вас есть пересечения с другими занятиями. К сожалению по расписанию оно вам не подходит.", "Запись на занятие");
                return;
            }

            if (CheckFreePlace(GetNumberFreePlace(lesson.danceHallId)) == false)
            {
                ToolsForm.ShowMessage("Свободных мест нет.", "Запись на занятие");
                return;
            }
            Student student = DB_API.Get<Student>(studentId);
            if (student.balance < lesson.price)
            {
                ToolsForm.ShowMessage("У Вас недостаточно средств на балансе.", "Запись на занятие");
                return;
            }

            string result = "";

            if (elements[0] == "")
                result = studentId.ToString();
            else 
            {
                Array.Resize(ref elements, elements.Length + 1);
                elements[elements.Length - 1] = studentId.ToString();
                result = string.Join(", ", elements);
            }

            lesson.studentId = result;

            var result_choice = MessageBox.Show("С вашего баланса спишется " + lesson.price.ToString() + " рублей, вы уверены?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result_choice == DialogResult.Yes)
            {
                student.balance -= lesson.price;
                DB_API.Update<Lesson>(lesson);
                DB_API.Update<Student>(student);
                ToolsForm.ShowMessage("Вы записались на новое занятие", "Запись на занятие", MessageBoxIcon.Asterisk);
            }
        }

        public bool CheckFreePlace(string input)
        {
            string[] parts = input.Split('/'); 

            if (parts.Length != 2) 
                return false;

            if (!int.TryParse(parts[0], out int leftNumber) || !int.TryParse(parts[1], out int rightNumber))
                return false; 

            return leftNumber < rightNumber;
        }

        private List<Lesson> GetAllStudentLesson(int studentId_) 
        {
            return DB_API.GetAll<Lesson>()
                .Where(lesson => lesson.studentId.Split(new[] { ", " }, StringSplitOptions.None)
                                   .Contains(studentId_.ToString()))
                .ToList();
        }

        private bool CheckCorrectLesson(Lesson lesson)
        {
            List<Lesson> lessons = GetAllStudentLesson(studentId);

            foreach (Lesson existingLesson in lessons)
            {
                if (existingLesson.danceHallId == lesson.danceHallId)
                {
                    // Проверяем пересечение дней недели
                    string[] existingLessonWeekdays = existingLesson.weekdays.Split(',');
                    string[] newLessonWeekdays = lesson.weekdays.Split(',');

                    foreach (string existingWeekday in existingLessonWeekdays)
                    {
                        foreach (string newWeekday in newLessonWeekdays)
                        {
                            if (existingWeekday.Trim() == newWeekday.Trim())
                            {
                                // Проверяем пересечение времени старта
                                string[] existingStartTimeParts = existingLesson.time_start.Split(':');
                                string[] newStartTimeParts = lesson.time_start.Split(':');

                                int existingStartHour = int.Parse(existingStartTimeParts[0]);
                                int existingStartMinute = int.Parse(existingStartTimeParts[1]);

                                int newStartHour = int.Parse(newStartTimeParts[0]);
                                int newStartMinute = int.Parse(newStartTimeParts[1]);

                                int existingStartTotalMinutes = existingStartHour * 60 + existingStartMinute;
                                int newStartTotalMinutes = newStartHour * 60 + newStartMinute;

                                // Проверяем разницу во времени старта
                                if (Math.Abs(existingStartTotalMinutes - newStartTotalMinutes) < 89)
                                {
                                    // Найдено пересечение
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            // Нет пересечений
            return true;
        }
    }
}

