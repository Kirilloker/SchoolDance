using SchoolDance.Class.DB;
using SchoolDance.Controller;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Admin_DanceHall : Form
    {
        MainController<DanceHall> controller = new();

        private void b_add_new_rows_Click(object sender, EventArgs e)
        {
            if (input_roomNumber.Text == "" || input_capacity.Text == "")
            {
                ToolsForm.ShowMessage("Нужно заполнить все поля.");
                return;
            }

            int capacity = 0;
            if (!int.TryParse(input_capacity.Text, out capacity))
            {
                ToolsForm.ShowMessage("В поле Максимальная вместимость, нужно ввести число.");
                return;
            }

            DanceHall obj = new DanceHall
            {
                roomNumber = input_roomNumber.Text,
                capacity = capacity
            };

            Add(obj);
        }


        private void PreparingAddView()
        {

        }

        private void Add(DanceHall entity)
        {
            if (controller.Add(entity) == true)
                ToolsForm.ShowMessage("Запись добавлена", "Добавление новой записи", MessageBoxIcon.Asterisk);
            else
                ToolsForm.ShowMessage("Что-то пошло не так. Возможно такое значение уже занято.");
        }



        // ---------------------------


        public Admin_DanceHall()
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
