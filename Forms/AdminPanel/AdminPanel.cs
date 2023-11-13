using SchoolDance.Class.DB;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();

            fillDate();
            this.AutoSize = true;
            DataGrid.Dock = DockStyle.Fill;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        protected void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                changeCell(e.RowIndex);
        }

        protected void del_data_row<template>() where template : class
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

        protected void b_del_Click(object sender, EventArgs e)
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

        protected void b_add_new_rows_Click(object sender, EventArgs e)
        {
            add_new_rows();
        }

        protected virtual void fillDate() => DataGrid.DataSource = DB_API.GetAllStudent();
        protected virtual void changeCell(int rowIndex) => DB_API.UpdateStudent(((List<Student>)DataGrid.DataSource)[rowIndex]);
        protected virtual bool deleteRow(int id) => DB_API.DeleteStudent(id);
        protected virtual void deleteRow() => del_data_row<Student>();
        protected virtual void add_new_rows() => Console.WriteLine("-");
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