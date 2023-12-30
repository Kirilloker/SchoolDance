using SchoolDance.Class.DB;
using SchoolDance.Controller;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Admin_TopUp : Form
    {
        MainController<TopUp> controller = new();
        MainController<Student> controllerStudent = new();

        private void b_add_new_rows_Click(object sender, EventArgs e)
        {
            try
            {
                string name_student = (string)list_student.SelectedItem;
                int id_student = int.Parse(name_student.Split(". ")[0]);
                int price_ = 0;
                if (!int.TryParse(input_price.Text, out price_))
                {
                    ToolsForm.ShowMessage("В поле Максимальная вместимость, нужно ввести число.");
                    return;
                }

                TopUp obj = new TopUp
                {
                    studentId = id_student,
                    paymentTime = date_payment_time.Value,
                    price = price_
                };

                Add(obj);
            }
            catch (Exception)
            {
                ToolsForm.ShowMessage("Что-то пошло не так");
            }
        }
        private void PreparingAddView()
        {
            list_student.DropDownStyle = ComboBoxStyle.DropDownList;

            List<Student> students = controllerStudent.GetDateFromDB();
            string[] formattedNames = students.Select((ds) => $"{ds.Id}. {ds.fullName}").ToArray();
            list_student.Items.AddRange(formattedNames);
        }

        private void Add(TopUp entity)
        {
            if (controller.Add(entity) == true)
                ToolsForm.ShowMessage("Запись добавлена", "Добавление новой записи", MessageBoxIcon.Asterisk);
            else
                ToolsForm.ShowMessage("Что-то пошло не так. Возможно такое значение уже занято.");
        }



        // ---------------------------
        public Admin_TopUp()
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
