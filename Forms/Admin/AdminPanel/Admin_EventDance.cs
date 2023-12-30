using SchoolDance.Class.DB;
using SchoolDance.Controller;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Admin_EventDance : Form
    {
        MainController<EventDance> controller = new();

        private void b_add_new_rows_Click(object sender, EventArgs e)
        {
            try
            {
                if (input_name.Text == "" ||
                    input_description.Text == "")
                {
                    ToolsForm.ShowMessage("Нужно заполнить все поля.");
                    return;
                }

                if (date_event.Value < (DateTime.Now.AddDays(-1)))
                {
                    ToolsForm.ShowMessage("Дата мероприятие не может быть задана раньше сегоднешнего дня.");
                    return;
                }

                EventDance obj = new EventDance
                {
                    nameEvent = input_name.Text,
                    description = input_description.Text,
                    date = date_event.Value
                };


                Add(obj);
            }
            catch (Exception)
            {
                ToolsForm.ShowMessage("Что-то пошло не так");
                throw;
            }

        }


        private void PreparingAddView()
        {

        }

        private void Add(EventDance entity)
        {
            if (controller.Add(entity) == true)
                ToolsForm.ShowMessage("Запись добавлена", "Добавление новой записи", MessageBoxIcon.Asterisk);
            else
                ToolsForm.ShowMessage("Что-то пошло не так. Возможно такое значение уже занято.");
        }



        // ---------------------------
        public Admin_EventDance()
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