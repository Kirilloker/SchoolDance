using SchoolDance.Class.DB;
using SchoolDance.Class.Logic;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class AdminPanelDanceStyle : Form
    {
        private void b_add_new_rows_Click(object sender, EventArgs e)
        {
            if (input_name.Text == "" || input_description.Text == "")
            {
                ToolsForm.ShowMessage("Нужно заполнить все поля.");
                return;
            }

            DanceStyle obj = new DanceStyle
            {
                name = input_name.Text,
                description = input_description.Text
            };

            if (DB_API.AddDanceStyle(obj) == true)
            {
                add_data_row<DanceStyle>(obj);
                ToolsForm.ShowMessage("Запись добавлена", "Добавление новой записи", MessageBoxIcon.Asterisk);
            }
            else
            {
                ToolsForm.ShowMessage("Что-то пошло не так. Возможно такое значение уже занят.");
            }
        }
        private void fillDate() => DataGrid.DataSource = DB_API.GetAll<DanceStyle>();
        private void changeCell(int rowIndex) => DB_API.Update<DanceStyle>(((List<DanceStyle>)DataGrid.DataSource)[rowIndex]);
        private bool deleteRow(int id) => DB_API.Delete<DanceStyle>(id);
        private void deleteRow() => del_data_row<DanceStyle>();



        // ---------------------------
        // Наследование не корректно работает
        public AdminPanelDanceStyle()
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
