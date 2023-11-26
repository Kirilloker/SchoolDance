using SchoolDance.Class.DB;
using SchoolDance.Util;
namespace SchoolDance.Forms
{
    public partial class Coach_create_lesson : Form
    {
        private void b_add_new_rows_Click(object sender, EventArgs e)
        {
            try
            {
                if (input_name.Text == "" ||
                    input_description.Text == "" ||
                    input_price.Text == "" ||
                    input_time.Text == "" ||
                    list_danceHall.SelectedItem == null ||
                    list_style.SelectedItem == null)
                {
                    ToolsForm.ShowMessage("Нужно заполнить все поля.");
                    return;
                }

                int price = 0;
                if (!int.TryParse(input_price.Text, out price))
                {
                    ToolsForm.ShowMessage("В поле Стоимость, нужно ввести число.");
                    return;
                }

                if (correct_time(input_time.Text) == false)
                {
                    ToolsForm.ShowMessage("В поле Время начала, нужно ввести время, когда начинается занятие. Например: 12:30");
                    return;
                }

                List<string> selectedItems = new List<string>();

                foreach (var item in list_weekdays.CheckedItems)
                {
                    if (item == null) continue;
                    selectedItems.Add(item.ToString());
                }

                if (selectedItems.Count == 0)
                {
                    ToolsForm.ShowMessage("Нужно выбрать хотя бы один день недели");
                    return;
                }

                string weekdays = string.Join(", ", selectedItems);

                string danceHall = (string)list_danceHall.SelectedItem;
                int id_dance = int.Parse(danceHall.Split(". ")[0]);

                string style = (string)list_style.SelectedItem;
                int id_style = int.Parse(style.Split(". ")[0]);

                Lesson obj = new Lesson
                {
                    className = input_name.Text,
                    weekdays = weekdays,
                    danceHallId = id_dance,
                    danceStylesId = id_style,
                    coachId = coach_id,
                    price = price,
                    description = input_description.Text,
                    time_start = input_time.Text
                };

                if (CheckCorrectLesson(obj) == false)
                {
                    ToolsForm.ShowMessage("Данный зал занят в этом время.", "Добавление нового занятия");
                    return;
                }

                if (DB_API.AddLesson(obj) == true)
                    ToolsForm.ShowMessage("Новое занятие создалось успешно", "Добавление нового занятия", MessageBoxIcon.Asterisk);
                else
                    ToolsForm.ShowMessage("Что-то пошло не так");
            }
            catch (Exception)
            {
                ToolsForm.ShowMessage("Что-то пошло не так");
                throw;
            }

        }

        int coach_id;
        public Coach_create_lesson(int coach_id)
        {
            this.coach_id = coach_id;
            InitializeComponent();

            list_style.DropDownStyle = ComboBoxStyle.DropDownList;
            list_danceHall.DropDownStyle = ComboBoxStyle.DropDownList;

            List<DanceHall> danceHalls = DB_API.GetAll<DanceHall>();
            string[] formattedNames = danceHalls.Select((ds) => $"{ds.Id}. {ds.roomNumber}").ToArray();
            list_danceHall.Items.AddRange(formattedNames);

            List<DanceStyle> danceStyles = DB_API.GetAll<DanceStyle>();
            formattedNames = danceStyles.Select((ds) => $"{ds.Id}. {ds.name}").ToArray();
            list_style.Items.AddRange(formattedNames);
        }

        private bool correct_time(string input)
        {
            if (input.Length != 5)
                return false;

            if (input[2] != ':')
                return false;

            if (!char.IsDigit(input[0]) || !char.IsDigit(input[1]) || !char.IsDigit(input[3]) || !char.IsDigit(input[4]))
                return false;

            return true;
        }

        private bool CheckCorrectLesson(Lesson lesson)
        {
            List<Lesson> lessons = DB_API.GetAll<Lesson>();

            foreach (Lesson existingLesson in lessons)
            {
                if (existingLesson.danceHallId == lesson.danceHallId)
                {
                    if (existingLesson.weekdays == null || lesson.weekdays == null)
                        continue;
                    // Проверяем пересечение дней недели
                    string[] existingLessonWeekdays = existingLesson.weekdays.Split(',');
                    string[] newLessonWeekdays = lesson.weekdays.Split(',');

                    foreach (string existingWeekday in existingLessonWeekdays)
                    {
                        foreach (string newWeekday in newLessonWeekdays)
                        {
                            if ((existingWeekday.Trim() == newWeekday.Trim())
                                &&
                                existingLesson.time_start != null
                                &&
                                lesson.time_start != null
                                )
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