using SchoolDance.Class.DB;
using SchoolDance.Controller;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Admin_Payment : Form
    {
        MainController<Payment> controller = new();

        private void b_add_new_rows_Click(object sender, EventArgs e)
        {
            string name_student = (string)list_student.SelectedItem;
            int id_student = int.Parse(name_student.Split(". ")[0]);

            string name_lesson = (string)list_lesson.SelectedItem;
            int id_lesson = int.Parse(name_lesson.Split(". ")[0]);

            Payment obj = new Payment
            {
                studentId = id_student,
                lessonId = id_lesson,
                date_end_subscription = date_end_payment.Value
            };

            Add(obj);
        }
        private void PreparingAddView()
        {
            list_student.DropDownStyle = ComboBoxStyle.DropDownList;
            list_lesson.DropDownStyle = ComboBoxStyle.DropDownList;

            List<Student> students = DB_Controller.GetAll<Student>();
            string[] formattedNames = students.Select((ds) => $"{ds.Id}. {ds.fullName}").ToArray();
            list_student.Items.AddRange(formattedNames);

            List<Lesson> lessons = DB_Controller.GetAll<Lesson>();
            string[] formattedlesson = lessons.Select((ds) => $"{ds.Id}. {ds.className}").ToArray();
            list_lesson.Items.AddRange(formattedlesson);
        }

        private void Add(Payment entity)
        {
            if (controller.Add(entity) == true)
                ToolsForm.ShowMessage("Запись добавлена", "Добавление новой записи", MessageBoxIcon.Asterisk);
            else
                ToolsForm.ShowMessage("Что-то пошло не так. Возможно такое значение уже занято.");
        }


        // ---------------------------
        public Admin_Payment()
        {
            InitializeComponent();
            InitClass();
        }

        private void InitClass()
        {
            controller.Update += Update;
            controller.GetDate += GetDate;
            controller.FillDate();

            PreparingAddView();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            controller.Change(e.RowIndex);
        }
        private void b_del_Click(object sender, EventArgs e)
        {
            if (controller.Delete(input_id_delete.Text) == true)
                ToolsForm.ShowMessage("Строка успешно удалена", "Удаление строки", MessageBoxIcon.Asterisk);
            else
                ToolsForm.ShowMessage("Ошибка при удалении из таблицы", "Удаление строки");
        }

        private void Update(object newDataSource)
        {
            DataGrid.DataSource = null;
            DataGrid.DataSource = newDataSource;
        }

        private object GetDate()
        {
            return DataGrid.DataSource;
        }

    }
}
