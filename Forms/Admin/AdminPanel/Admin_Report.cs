using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using SchoolDance.Class.DB;

namespace SchoolDance.Forms.Admin.AdminPanel
{
    public partial class Admin_Report : Form
    {
        public Admin_Report()
        {
            InitializeComponent();

            list_table.DropDownStyle = ComboBoxStyle.DropDownList;
        }
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
