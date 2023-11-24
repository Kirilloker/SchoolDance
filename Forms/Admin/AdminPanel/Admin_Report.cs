//using SchoolDance.Class.DB;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
//using iText.Kernel.Font;
//using iText.Layout.Element;
//using iText.Layout.Font;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using Ubiety.Dns.Core.Records;
//using Root.Reports;

//using MigraDoc.Rendering;
//using PdfSharp.Drawing;
//using PdfSharp.Pdf;
//using System.Text;

using iTextSharp.text.pdf;
using iTextSharp.text;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using Root.Reports;
using System.Text;
using SchoolDance.Class.DB;
using SchoolDance.Util;
using MySqlX.XDevAPI;

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
            List<Lesson> lessons = DB_API.GetAll<Lesson>();
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
                reportBuilder.AppendLine($"Зал: {DB_API.Get<DanceHall>(lesson.danceHallId).roomNumber}");
                reportBuilder.AppendLine($"Тренер: {DB_API.Get<Coach>(lesson.coachId).fullName}");
                reportBuilder.AppendLine($"Стиль танца: {DB_API.Get<DanceStyle>(lesson.danceStylesId).name}");
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
                        if (DB_API.Get<Student>(student_id).fullName != null)
                            name_student = DB_API.Get<Student>(student_id).fullName;
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
            List<Student> students = DB_API.GetAll<Student>();
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
            List<DanceHall> danceHalls = DB_API.GetAll<DanceHall>();
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
            List<DanceStyle> danceStyles = DB_API.GetAll<DanceStyle>();
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
            List<EventDance> events = DB_API.GetAll<EventDance>();
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
            List<Payment> payments = DB_API.GetAll<Payment>();
            StringBuilder reportBuilder = new StringBuilder();
            reportBuilder.AppendLine("Отчет по платежам:");

            foreach (Payment payment in payments)
            {
                string studentName = "Не известно";

                Student student = DB_API.Get<Student>(payment.studentId.Value);
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
            List<TopUp> topUps = DB_API.GetAll<TopUp>();
            StringBuilder reportBuilder = new StringBuilder();
            reportBuilder.AppendLine("Отчет по пополнениям баланса студентов:");

            foreach (TopUp topUp in topUps)
            {
                string studentName = "Не известно";

                Student student = DB_API.Get<Student>(topUp.studentId);
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
            List<Coach> coaches = DB_API.GetAll<Coach>();
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

                    int  dance_id;
                    if (int.TryParse(item, out dance_id))
                    {
                        if (DB_API.Get<DanceStyle>(dance_id).name != null)
                            name_dance_style = DB_API.Get<DanceStyle>(dance_id).name;
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


        //void Mainy() 
        //{
        //    using (FileStream fs = new FileStream("example.pdf", FileMode.Create))
        //    {
        //        Document document = new Document();
        //        PdfWriter writer = PdfWriter.GetInstance(document, fs);

        //        BaseFont baseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
        //        iTextSharp.text.Font times = new iTextSharp.text.Font(baseFont, 12, iTextSharp.text.Font.ITALIC, BaseColor.RED);

        //        document.Open();

        //        iTextSharp.text.Paragraph paragraph = new iTextSharp.text.Paragraph(PdfHelper.EncodingHack("Привет, мир!"), times);
        //        document.Add(paragraph);

        //        iTextSharp.text.Paragraph heading = new iTextSharp.text.Paragraph("По Эм жикль от руспа", times);
        //        document.Add(heading);

        //        document.Close();
        //        writer.Close();
        //    }

        //}

        //void Mainy()
        //{
        //    // Создаем отчет с использованием PdfFormatter
        //    Report report = new Report(new PdfFormatter());

        //    // Добавляем шрифт, поддерживающий кириллицу (например, Arial Unicode MS)
        //    FontDef fd = new FontDef(report, FontDef.StandardFont.TimesRoman);

        //    // Устанавливаем размер шрифта
        //    FontProp fp = new FontPropMM(fd, 25);

        //    // Создаем страницу
        //    Root.Reports.Page page = new Root.Reports.Page(report);

        //    // Добавляем текст на страницу (Привет мир!)
        //    page.AddCenteredMM(80, new RepString(fp, PdfHelper.EncodingHack("Привет мир!")));

        //    // Генерируем PDF-файл
        //    RT.ViewPDF(report, "HelloWorld.pdf");
        //}

        //private void GeneratePdfButton_Click()
        //{
        //    List<Lesson> data = DB_API.GetAll<Lesson>();

        //    SaveFileDialog saveFileDialog = new SaveFileDialog
        //    {
        //        Filter = "PDF Files|*.pdf",
        //        Title = "Save PDF",
        //        FileName = "output.pdf"
        //    };

        //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        string pdfFilePath = saveFileDialog.FileName;

        //        GenerateLessonReport(data, pdfFilePath);

        //        MessageBox.Show("PDF file generated successfully!");
        //    }
        //}

        //public void GenerateLessonReport(List<Lesson> lessons, string pdfFilePath)
        //{
        //    string outputPath = pdfFilePath;
        //    //GlobalFontSettings.FontResolver = new MyFontResolver();

        //    using (PdfDocument pdfDocument = new PdfDocument())
        //    {
        //        pdfDocument.Info.Title = "Уроки по танцам";

        //        foreach (var lesson in lessons)
        //        {
        //            PdfPage page = pdfDocument.AddPage();
        //            XGraphics gfx = XGraphics.FromPdfPage(page);
        //            XFont font = new XFont("Arial", 12);

        //            gfx.DrawString($"ID урока: {lesson.Id}", font, XBrushes.Black, new XRect(10, 10, page.Width, page.Height), XStringFormats.TopLeft);


        //            gfx.DrawString($"ID урока: {lesson.Id}", font, XBrushes.Black, new XRect(10, 10, page.Width, page.Height), XStringFormats.TopLeft);
        //            gfx.DrawString($"Название класса: {lesson.className}", font, XBrushes.Black, new XRect(10, 30, page.Width, page.Height), XStringFormats.TopLeft);
        //            gfx.DrawString($"Дни недели: {lesson.weekdays}", font, XBrushes.Black, new XRect(10, 50, page.Width, page.Height), XStringFormats.TopLeft);
        //            gfx.DrawString($"ID зала: {lesson.danceHallId}", font, XBrushes.Black, new XRect(10, 70, page.Width, page.Height), XStringFormats.TopLeft);
        //            gfx.DrawString($"ID тренера: {lesson.coachId}", font, XBrushes.Black, new XRect(10, 90, page.Width, page.Height), XStringFormats.TopLeft);
        //            gfx.DrawString($"ID стиля танца: {lesson.danceStylesId}", font, XBrushes.Black, new XRect(10, 110, page.Width, page.Height), XStringFormats.TopLeft);
        //            gfx.DrawString($"Цена: {lesson.price}", font, XBrushes.Black, new XRect(10, 130, page.Width, page.Height), XStringFormats.TopLeft);
        //            gfx.DrawString($"Описание: {lesson.description}", font, XBrushes.Black, new XRect(10, 150, page.Width, page.Height), XStringFormats.TopLeft);
        //            gfx.DrawString($"Время начала: {lesson.time_start}", font, XBrushes.Black, new XRect(10, 170, page.Width, page.Height), XStringFormats.TopLeft);
        //            gfx.DrawString($"ID студента: {lesson.studentId}", font, XBrushes.Black, new XRect(10, 190, page.Width, page.Height), XStringFormats.TopLeft);
        //        }

        //        pdfDocument.Save(outputPath);
        //    }

        //    Console.WriteLine($"Отчет успешно создан и сохранен по пути: {outputPath}");
        //}


        //void Mainnn()
        //{
        //    // Создаем документ PDF
        //    PdfDocument doc = new PdfDocument();

        //    // Добавляем страницу
        //    PdfPage page = doc.AddPage();

        //    // Создаем объект XGraphics для рисования на странице
        //    XGraphics gfx = XGraphics.FromPdfPage(page);

        //    // Устанавливаем шрифт для русского языка (Arial, например)
        //    XFont font = new XFont("Arial", 12, XFontStyle.Regular);

        //    // Рисуем текст с русскими символами
        //    gfx.DrawString("Привет, мир!", font, XBrushes.Black, new XRect(10, 10, page.Width, page.Height), XStringFormats.TopLeft);

        //    // Устанавливаем параметры для создания PDF с поддержкой встраивания шрифта
        //    PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfFontEmbedding.Always);
        //    renderer.Document = doc;

        //    // Рендерим документ
        //    renderer.RenderDocument();

        //    // Сохраняем PDF файл
        //    renderer.PdfDocument.Save("output.pdf");
        //}

        //static void Mainnn()
        //{
        //    // Создаем отчет с использованием PdfFormatter
        //    Report report = new Report(new PdfFormatter());

        //    // Добавляем шрифт, поддерживающий кириллицу (замените на доступный вам шрифт)
        //    FontDef fd = new FontDef(report);

        //    // Устанавливаем размер шрифта
        //    FontProp fp = new FontPropMM(fd, 25);

        //    // Создаем страницу
        //    Root.Reports.Page page = new Root.Reports.Page(report);

        //    // Добавляем текст на страницу (Привет мир!)
        //    page.AddCenteredMM(80, new RepString(fp, "Привет мир!"));

        //    // Генерируем PDF-файл
        //    RT.ViewPDF(report, "HelloWorld.pdf");
        //}


        //void Main2(List<Lesson> lessons)
        //{
        //    Document document = new Document();
        //    PdfWriter.GetInstance(document, new FileStream("MyPDF.pdf", FileMode.Create));
        //    document.Open();

        //    var font = PdfFontFactory.CreateFont("arial.ttf", PdfEncodings.);
        //    document.SetFont(font);
        //    document.Add(new Paragraph("Hello, World!"));
        //    foreach (var lesson in lessons)
        //    {
        //        document.Add(new Paragraph($"Lesson ID: {lesson.Id}"));
        //        document.Add(new Paragraph($"Class Name: {lesson.className}"));
        //        document.Add(new Paragraph($"Weekdays: {lesson.weekdays}"));
        //        document.Add(new Paragraph($"Dance Hall ID: {lesson.danceHallId}"));
        //        document.Add(new Paragraph($"Coach ID: {lesson.coachId}"));
        //        document.Add(new Paragraph($"Dance Styles ID: {lesson.danceStylesId}"));
        //        document.Add(new Paragraph($"Price: {lesson.price}"));
        //        document.Add(new Paragraph($"Description: {lesson.description}"));
        //        document.Add(new Paragraph($"Time Start: {lesson.time_start}"));
        //        document.Add(new Paragraph($"Student ID: {lesson.studentId}"));
        //        document.Add(new Paragraph("\n----------------------------------------\n"));
        //    }

        //    document.Close();
        //}


        //void Mainy()
        //{
        //    // Create a new PDF document
        //    PdfDocument document = new PdfDocument();
        //    document.Info.Title = "Created with PDFsharp";

        //    // Create an empty page
        //    PdfPage page = document.AddPage();

        //    // Get an XGraphics object for drawing
        //    XGraphics gfx = XGraphics.FromPdfPage(page);

        //    // Create a font
        //    XFont font = new XFont("Arial", 20);

        //    // Draw the text
        //    gfx.DrawString(PdfHelper.EncodingHack("автор"), font, XBrushes.Black,
        //      new XRect(0, 0, page.Width, page.Height),
        //      XStringFormats.Center);

        //    // Save the document...
        //    const string filename = "HelloWorld.pdf";
        //    document.Save(filename);
        //    // ...and start a viewer.
        //    //Process.Start(filename);
        //}




        //private void GeneratePdfButton_Click()
        //{
        //    List<Lesson> data = DB_API.GetAll<Lesson>();

        //    SaveFileDialog saveFileDialog = new SaveFileDialog
        //    {
        //        Filter = "PDF Files|*.pdf",
        //        Title = "Save PDF",
        //        FileName = "output.pdf"
        //    };

        //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        string pdfFilePath = saveFileDialog.FileName;

        //        GenerateLessonReport(data, pdfFilePath);

        //        MessageBox.Show("PDF file generated successfully!");
        //    }
        //}


        //public void GenerateLessonReport(List<Lesson> lessons, string outputPath)
        //{
        //    // Создание документа PDF
        //    Document document = new Document();

        //    // Создание писателя PDF
        //    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(outputPath, FileMode.Create));

        //    // Открытие документа
        //    document.Open();

        //    // Настройка шрифта и стиля
        //    Font titleFont = new Font(Font.FontFamily.HELVETICA, 18, Font.BOLD);
        //    Font contentFont = new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL);

        //    // Добавление заголовка
        //    Paragraph title = new Paragraph("Отчет по урокам", titleFont);
        //    title.Alignment = Element.ALIGN_CENTER;
        //    document.Add(title);

        //    // Добавление информации об уроках
        //    foreach (Lesson lesson in lessons)
        //    {
        //        // Добавление ID урока
        //        Paragraph lessonId = new Paragraph($"Урок ID: {lesson.Id}", contentFont);
        //        document.Add(lessonId);

        //        // Добавление названия класса
        //        Paragraph className = new Paragraph($"Название класса: {lesson.className}", contentFont);
        //        document.Add(className);

        //        // Добавление дней недели
        //        Paragraph weekdays = new Paragraph($"Дни недели: {lesson.weekdays}", contentFont);
        //        document.Add(weekdays);

        //        // Добавление ID зала
        //        Paragraph danceHallId = new Paragraph($"ID зала: {lesson.danceHallId}", contentFont);
        //        document.Add(danceHallId);

        //        // Добавление ID тренера
        //        Paragraph coachId = new Paragraph($"ID тренера: {lesson.coachId}", contentFont);
        //        document.Add(coachId);

        //        // Добавление ID стиля танца
        //        Paragraph danceStylesId = new Paragraph($"ID стиля танца: {lesson.danceStylesId}", contentFont);
        //        document.Add(danceStylesId);

        //        // Добавление цены
        //        Paragraph price = new Paragraph($"Цена: {lesson.price}", contentFont);
        //        document.Add(price);

        //        // Добавление описания
        //        Paragraph description = new Paragraph($"Описание: {lesson.description}", contentFont);
        //        document.Add(description);

        //        // Добавление времени начала
        //        Paragraph timeStart = new Paragraph($"Время начала: {lesson.time_start}", contentFont);
        //        document.Add(timeStart);

        //        // Добавление ID студента
        //        Paragraph studentId = new Paragraph($"ID студента: {lesson.studentId}", contentFont);
        //        document.Add(studentId);

        //        // Добавление разделителя
        //        Paragraph separator = new Paragraph("--------------------------------------------------", contentFont);
        //        document.Add(separator);
        //    }

        //    // Закрытие документа
        //    document.Close();
        //}


        //public void GenerateLessonReport(List<Lesson> lessons, string pdfFilePath)
        //{
        //    string outputPath = pdfFilePath;

        //    using (var pdfWriter = new PdfWriter(outputPath))
        //    {
        //        using (var pdfDocument = new PdfDocument(pdfWriter))
        //        {
        //            var document = new Document(pdfDocument);

        //            // Добавим заголовок
        //            document.Add(new Paragraph("Уроки по танцам"));

        //            // Добавим информацию об уроках
        //            foreach (var lesson in lessons)
        //            {
        //                document.Add(new Paragraph($"ID урока: {lesson.Id}"));
        //                document.Add(new Paragraph($"Название класса: {lesson.className}"));
        //                document.Add(new Paragraph($"Дни недели: {lesson.weekdays}"));
        //                document.Add(new Paragraph($"ID зала: {lesson.danceHallId}"));
        //                document.Add(new Paragraph($"ID тренера: {lesson.coachId}"));
        //                document.Add(new Paragraph($"ID стиля танца: {lesson.danceStylesId}"));
        //                document.Add(new Paragraph($"Цена: {lesson.price}"));
        //                document.Add(new Paragraph($"Описание: {lesson.description}"));
        //                document.Add(new Paragraph($"Время начала: {lesson.time_start}"));
        //                document.Add(new Paragraph($"ID студента: {lesson.studentId}"));

        //                document.Add(new AreaBreak());
        //            }
        //        }
        //    }

        //    Console.WriteLine($"Отчет успешно создан и сохранен по пути: {outputPath}");

        //}



        //private void GeneratePdfButton_Click()
        //{
        //    List<string> data = GetYourData();

        //    SaveFileDialog saveFileDialog = new SaveFileDialog
        //    {
        //        Filter = "PDF Files|*.pdf",
        //        Title = "Save PDF",
        //        FileName = "output.pdf"
        //    };

        //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        string pdfFilePath = saveFileDialog.FileName;

        //        GeneratePdf(data, pdfFilePath);

        //        MessageBox.Show("PDF file generated successfully!");
        //    }
        //}

        //private void GeneratePdf(List<string> data, string outputFilePath)
        //{
        //    using (PdfWriter writer = new PdfWriter(outputFilePath))
        //    {
        //        using (PdfDocument pdf = new PdfDocument(writer))
        //        {
        //            Document document = new Document(pdf);

        //            foreach (string item in data)
        //                document.Add(new Paragraph(item));
        //        }
        //    }
        //}

        //private List<string> GetYourData()
        //{
        //    return new List<string> { "Item 1", "Item 2", "Item 3" };
        //}

        //private void b_create_report_Click(object sender, EventArgs e)
        //{
        //    string name_table = (string)list_table.SelectedItem;
        //    if (name_table == "") return;

        //    Console.WriteLine(name_table);

        //    GeneratePdfButton_Click();
        //}


        //private DataTable GetData()
        //{
        //    // Ваш код для получения данных
        //    // В этом примере просто возвращаем пустую таблицу
        //    return DB_API.ExecuteQuery("SELECT * FROM schooldance.students;");
        //}

        //// Функция для сохранения таблицы в PDF
        //private void SaveToPdf(DataTable dataTable, string filePath)
        //{
        //    try
        //    {
        //        using (var pdfWriter = new PdfWriter(filePath))
        //        {
        //            using (var pdf = new PdfDocument(pdfWriter))
        //            {
        //                var document = new Document(pdf);
        //                var table = new Table(dataTable.Columns.Count);

        //                // Добавляем заголовки
        //                foreach (DataColumn column in dataTable.Columns)
        //                {
        //                    table.AddCell(new Cell().Add(new Paragraph(column.ColumnName)));
        //                }

        //                // Добавляем данные
        //                foreach (DataRow row in dataTable.Rows)
        //                {
        //                    foreach (var item in row.ItemArray)
        //                    {
        //                        table.AddCell(new Cell().Add(new Paragraph(item.ToString())));
        //                    }
        //                }

        //                document.Add(table);
        //            }
        //        }

        //        MessageBox.Show("Файл успешно сохранен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void b_create_report_Click(object sender, EventArgs e)
        //{
        //    // Получаем данные из БД
        //    DataTable dataTable = GetData();

        //    if (dataTable.Rows.Count > 0)
        //    {
        //        // Открываем диалог сохранения файла
        //        SaveFileDialog saveFileDialog = new SaveFileDialog();
        //        saveFileDialog.Filter = "PDF файлы (*.pdf)|*.pdf";
        //        saveFileDialog.Title = "Сохранить как PDF";
        //        saveFileDialog.FileName = "Название файла по умолчанию";

        //        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            // Сохраняем данные в PDF
        //            SaveToPdf(dataTable, saveFileDialog.FileName);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Нет данных для сохранения.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}
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
