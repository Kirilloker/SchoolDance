using SchoolDance.Class.DB;
using SchoolDance.Util;
using System.Text;

namespace SchoolDance.Forms.Admin.AdminPanel
{
    public partial class Admin_Report : Form
    {
        public Admin_Report()
        {
            InitializeComponent();

            list_table.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void generateReportLesson()
        {
            List<Lesson> lessons = DB_Controller.GetAll<Lesson>();
            StringBuilder reportBuilder = new StringBuilder();
            reportBuilder.AppendLine("Отчет по занятиям:");

            foreach (Lesson lesson in lessons)
            {
                if (lesson.className == null) lesson.className = "Не известно";
                if (lesson.weekdays == null) lesson.weekdays = "Не известно";
                if (lesson.description == null) lesson.description = "Не известно";
                if (lesson.time_start == null) lesson.time_start = "Не известно";
                if (lesson.studentId == null) lesson.studentId = "Не известно";


                reportBuilder.AppendLine($"Название класса: {lesson.className}");
                reportBuilder.AppendLine($"Дни недели: {lesson.weekdays}");
                reportBuilder.AppendLine($"Зал: {DB_Controller.Get<DanceHall>(lesson.danceHallId).roomNumber}");
                reportBuilder.AppendLine($"Тренер: {DB_Controller.Get<Coach>(lesson.coachId).fullName}");
                reportBuilder.AppendLine($"Стиль танца: {DB_Controller.Get<DanceStyle>(lesson.danceStylesId).name}");
                reportBuilder.AppendLine($"Цена: {lesson.price}");
                reportBuilder.AppendLine($"Описание: {lesson.description}");
                reportBuilder.AppendLine($"Время начала: {lesson.time_start}");

                string students = "";
                var student_array = lesson.studentId.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in student_array)
                {
                    string name_student = "";

                    int student_id;
                    if (int.TryParse(item, out student_id))
                    {
                        if (DB_Controller.Get<Student>(student_id).fullName != null)
                            name_student = DB_Controller.Get<Student>(student_id).fullName;
                        else
                            name_student = "Не известно";
                    }
                    else
                        name_student = "Не известно";

                    students += name_student + ", ";
                }

                reportBuilder.AppendLine($"Студенты: {students}");
                reportBuilder.AppendLine();
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|PDF Files|*.pdf";
            saveFileDialog.Title = "Сохранить отчет";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, reportBuilder.ToString(), Encoding.UTF8);
                MessageBox.Show($"Отчет успешно сохранен по пути: {filePath}", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void generateReportStudent()
        {
            List<Student> students = DB_Controller.GetAll<Student>();
            StringBuilder reportBuilder = new StringBuilder();
            reportBuilder.AppendLine("Отчет по студентам:");

            foreach (Student student in students)
            {
                if (student.fullName == null) student.fullName = "Не известно";
                if (student.gender == null) student.gender = "Не известно";

                string gender = "";
                if (student.gender == "Male") gender = "Мужской";
                else if (student.gender == "Female") gender = "Женский";

                reportBuilder.AppendLine($"ФИО студента: {student.fullName}");
                reportBuilder.AppendLine($"Баланс: {student.balance}");
                reportBuilder.AppendLine($"Пол: {gender}");
                reportBuilder.AppendLine($"Дата рождения: {student.date}");

                reportBuilder.AppendLine();
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|PDF Files|*.pdf";
            saveFileDialog.Title = "Сохранить отчет";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, reportBuilder.ToString(), Encoding.UTF8);
                MessageBox.Show($"Отчет успешно сохранен по пути: {filePath}", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void generateReportDanceHall()
        {
            List<DanceHall> danceHalls = DB_Controller.GetAll<DanceHall>();
            StringBuilder reportBuilder = new StringBuilder();
            reportBuilder.AppendLine("Отчет по залам для танцев:");

            foreach (DanceHall danceHall in danceHalls)
            {
                if (danceHall.roomNumber == null) danceHall.roomNumber = "Не известно";

                reportBuilder.AppendLine($"Номер зала: {danceHall.roomNumber}");
                reportBuilder.AppendLine($"Вместимость: {danceHall.capacity}");

                reportBuilder.AppendLine();
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|PDF Files|*.pdf";
            saveFileDialog.Title = "Сохранить отчет";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, reportBuilder.ToString(), Encoding.UTF8);
                MessageBox.Show($"Отчет успешно сохранен по пути: {filePath}", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void generateReportDanceStyle()
        {
            List<DanceStyle> danceStyles = DB_Controller.GetAll<DanceStyle>();
            StringBuilder reportBuilder = new StringBuilder();
            reportBuilder.AppendLine("Отчет по стилям танцев:");

            foreach (DanceStyle danceStyle in danceStyles)
            {
                if (danceStyle.name == null) danceStyle.name = "Не известно";

                reportBuilder.AppendLine($"Название стиля танца: {danceStyle.name}");
                reportBuilder.AppendLine($"Описание: {danceStyle.description ?? "Отсутствует"}");

                reportBuilder.AppendLine();
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|PDF Files|*.pdf";
            saveFileDialog.Title = "Сохранить отчет";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, reportBuilder.ToString(), Encoding.UTF8);
                MessageBox.Show($"Отчет успешно сохранен по пути: {filePath}", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void generateReportEventDance()
        {
            List<EventDance> events = DB_Controller.GetAll<EventDance>();
            StringBuilder reportBuilder = new StringBuilder();
            reportBuilder.AppendLine("Отчет по мероприятиям:");

            foreach (EventDance eventDance in events)
            {
                if (eventDance.nameEvent == null) eventDance.nameEvent = "Не известно";

                reportBuilder.AppendLine($"Название мероприятия: {eventDance.nameEvent}");
                reportBuilder.AppendLine($"Описание: {eventDance.description ?? "Отсутствует"}");
                reportBuilder.AppendLine($"Дата: {eventDance.date.ToString("dd.MM.yyyy")}");

                reportBuilder.AppendLine();
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|PDF Files|*.pdf";
            saveFileDialog.Title = "Сохранить отчет";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, reportBuilder.ToString(), Encoding.UTF8);
                MessageBox.Show($"Отчет успешно сохранен по пути: {filePath}", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void generateReportPayment()
        {
            List<Payment> payments = DB_Controller.GetAll<Payment>();
            StringBuilder reportBuilder = new StringBuilder();
            reportBuilder.AppendLine("Отчет по платежам:");

            foreach (Payment payment in payments)
            {
                string studentName = "Не известно";

                Student student = DB_Controller.Get<Student>(payment.studentId.Value);
                if (student.fullName != null)
                    studentName = student.fullName;


                reportBuilder.AppendLine($"Студент: {studentName}");
                reportBuilder.AppendLine($"Идентификатор занятия: {payment.lessonId}");
                reportBuilder.AppendLine($"Дата окончания подписки: {payment.date_end_subscription.ToString("dd.MM.yyyy")}");

                reportBuilder.AppendLine();
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|PDF Files|*.pdf";
            saveFileDialog.Title = "Сохранить отчет";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, reportBuilder.ToString(), Encoding.UTF8);
                MessageBox.Show($"Отчет успешно сохранен по пути: {filePath}", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void generateReportTopUp()
        {
            List<TopUp> topUps = DB_Controller.GetAll<TopUp>();
            StringBuilder reportBuilder = new StringBuilder();
            reportBuilder.AppendLine("Отчет по пополнениям баланса студентов:");

            foreach (TopUp topUp in topUps)
            {
                string studentName = "Не известно";

                Student student = DB_Controller.Get<Student>(topUp.studentId);
                if (student != null && student.fullName != null)
                    studentName = student.fullName;

                reportBuilder.AppendLine($"Студент: {studentName}");
                reportBuilder.AppendLine($"Дата платежа: {topUp.paymentTime}");
                reportBuilder.AppendLine($"Сумма пополнения: {topUp.price}");

                reportBuilder.AppendLine();
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|PDF Files|*.pdf";
            saveFileDialog.Title = "Сохранить отчет";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, reportBuilder.ToString(), Encoding.UTF8);
                MessageBox.Show($"Отчет успешно сохранен по пути: {filePath}", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void generateReportCoach()
        {
            List<Coach> coaches = DB_Controller.GetAll<Coach>();
            StringBuilder reportBuilder = new StringBuilder();
            reportBuilder.AppendLine("Отчет по тренерам:");

            foreach (Coach coach in coaches)
            {
                if (coach.fullName == null) coach.fullName = "Не известно";
                if (coach.phoneNumber == null) coach.phoneNumber = "Не известно";
                if (coach.position == null) coach.position = "Не известно";
                if (coach.danceStylesId == null) coach.danceStylesId = "Не известно";


                string gender = "";
                if (coach.gender == "Male") gender = "Мужской";
                else if (coach.gender == "Female") gender = "Женский";


                string danceStyles = "";
                var danceStyles_array = coach.danceStylesId.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in danceStyles_array)
                {
                    string name_dance_style = "";

                    int dance_id;
                    if (int.TryParse(item, out dance_id))
                    {
                        if (DB_Controller.Get<DanceStyle>(dance_id).name != null)
                            name_dance_style = DB_Controller.Get<DanceStyle>(dance_id).name;
                        else
                            name_dance_style = "Не известно";
                    }
                    else
                        name_dance_style = "Не известно";

                    danceStyles += name_dance_style + ", ";
                }



                reportBuilder.AppendLine($"ФИО тренера: {coach.fullName}");
                reportBuilder.AppendLine($"Дата рождения: {coach.date}");
                reportBuilder.AppendLine($"Пол: {gender}");
                reportBuilder.AppendLine($"Опыт работы (месяцы): {coach.workExperienceMonth}");
                reportBuilder.AppendLine($"Номер телефона: {coach.phoneNumber}");
                reportBuilder.AppendLine($"Должность: {coach.position}");
                reportBuilder.AppendLine($"Стили танца: {danceStyles}");

                reportBuilder.AppendLine();
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|PDF Files|*.pdf";
            saveFileDialog.Title = "Сохранить отчет";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, reportBuilder.ToString(), Encoding.UTF8);
                MessageBox.Show($"Отчет успешно сохранен по пути: {filePath}", "Сохранено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void b_create_report_Click(object sender, EventArgs e)
        {
            if (list_table.SelectedIndex < 0)
            {
                ToolsForm.ShowMessage("Нужно выбрать таблицу, для которого сформируется отчет");
                return;
            }

            switch ((string)list_table.SelectedItem)
            {
                case "Занятия":
                    generateReportLesson();
                    break;
                case "Мероприятия":
                    generateReportEventDance();
                    break;
                case "Оплата":
                    generateReportPayment();
                    break;
                case "Пополнение счета":
                    generateReportTopUp();
                    break;
                case "Студенты":
                    generateReportStudent();
                    break;
                case "Тренеры":
                    generateReportCoach();
                    break;
                case "Танцевальные стили":
                    generateReportDanceStyle();
                    break;
                case "Танцевальные залы":
                    generateReportDanceHall();
                    break;
                default:
                    ToolsForm.ShowMessage("Что-то пошло не так");
                    Console.WriteLine();
                    break;
            }
        }
    }
}





public static class PdfHelper
{
    public static string EncodingHack(string str)
    {
        var encoding = Encoding.ASCII;
        var bytes = encoding.GetBytes(str);
        return Convert.ToBase64String(bytes);
    }
}
