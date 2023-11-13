using SchoolDance.Class.DB;
using SchoolDance.Class.Logic;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class AdminPanelStudent : Form
    {
        private void b_add_new_rows_Click(object sender, EventArgs e)
        {
            if (input_login.Text == "" || input_password.Text == "" || input_first_name.Text == "" ||
                (radio_female.Checked == false && radio_male.Checked == false))
            {
                ToolsForm.ShowMessage("Нужно заполнить все поля.");
                return;
            }

            Student student = new Student
            {
                login = input_login.Text,
                password = SignInUpLogic.EncodeStringToBase64(input_password.Text),
                fullName = input_first_name.Text,
                gender = radio_male.Checked == true ? "Male" : "Female",
                date = dateTime_birth_date.Value,
                typePerson = TypePerson.Student
            };

            if (DB_API.AddPerson<Student>(student) == true)
            {
                add_data_row<Student>(student);
                ToolsForm.ShowMessage("Запись добавлена", "Добавление новой записи", MessageBoxIcon.Asterisk);
            }
            else
            {
                ToolsForm.ShowMessage("Что-то пошло не так");
            }
        }
        private void fillDate() => DataGrid.DataSource = DB_API.GetAll<Student>();
        private void changeCell(int rowIndex) => DB_API.Update<Student>(((List<Student>)DataGrid.DataSource)[rowIndex]);
        private bool deleteRow(int id) => DB_API.Delete<Student>(id);
        private void deleteRow() => del_data_row<Student>();



        // ---------------------------
        // Наследование не корректно работает
        public AdminPanelStudent()
        {
            InitializeComponent();

            fillDate();
            this.AutoSize = true;
            DataGrid.Dock = DockStyle.Fill;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                changeCell(e.RowIndex);
        }

        private void del_data_row<template>() where template : class
        {
            var listData = (List<template>)DataGrid.DataSource;
            var objectToRemove = listData?.FirstOrDefault(s => s?.GetType().GetProperty("Id")?.GetValue(s).Equals(int.Parse(input_id_delete.Text)) ?? false);

            if (objectToRemove != null)
            {
                listData.Remove(objectToRemove);
                DataGrid.DataSource = null;
                DataGrid.DataSource = listData;
            }
        }

        private void add_data_row<template>(template obj) where template : class
        {
            var listData = (List<template>)DataGrid.DataSource;

            if (obj != null)
            {
                listData.Add(obj);
                DataGrid.DataSource = null;
                DataGrid.DataSource = listData;
            }
        }

        private void b_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (deleteRow(int.Parse(input_id_delete.Text)) == true)
                    deleteRow();
                else ToolsForm.ShowMessage("Ошибка. Такого ID нет", "Удаление строки");
            }
            catch
            {
                ToolsForm.ShowMessage();
            }
        }
    }
}


//// Фильтрация (работает с багами)
//private void FilterDataGridByColumn(int columnIndex)
//{
//    if (DataGrid.Columns[columnIndex].SortMode != DataGridViewColumnSortMode.NotSortable)
//    {
//        // Получаем текущий столбец
//        DataGridViewColumn newColumn = DataGrid.Columns[columnIndex];
//        // Получаем направление сортировки
//        ListSortDirection direction = (newColumn.HeaderCell.SortGlyphDirection == SortOrder.Ascending) ? ListSortDirection.Descending : ListSortDirection.Ascending;

//        // Сбрасываем сортировку для остальных столбцов
//        foreach (DataGridViewColumn column in DataGrid.Columns)
//            column.HeaderCell.SortGlyphDirection = SortOrder.None;

//        // Применяем сортировку к выбранному столбцу
//        newColumn.HeaderCell.SortGlyphDirection = (direction == ListSortDirection.Ascending) ? SortOrder.Ascending : SortOrder.Descending;

//        // Применяем сортировку к DataGrid
//        DataGrid.Sort(DataGrid.Columns[4], ListSortDirection.Ascending);
//    }
//}