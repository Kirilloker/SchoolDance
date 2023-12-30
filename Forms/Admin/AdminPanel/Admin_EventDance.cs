using SchoolDance.Class.DB;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Admin_EventDance : Form
    {
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


                if (DB_Controller.AddEventDance(obj) == true)
                {
                    add_data_row<EventDance>(obj);
                    ToolsForm.ShowMessage("Запись добавлена", "Добавление новой записи", MessageBoxIcon.Asterisk);
                }
                else
                {
                    ToolsForm.ShowMessage("Что-то пошло не так. Возможно такое значение уже занят.");
                }
            }
            catch (Exception)
            {
                ToolsForm.ShowMessage("Что-то пошло не так");
                throw;
            }

        }


        private void fillDate() => DataGrid.DataSource = DB_Controller.GetAll<EventDance>();
        private void changeCell(int rowIndex) => DB_Controller.Update<EventDance>(((List<EventDance>)DataGrid.DataSource)[rowIndex]);
        private bool deleteRow(int id) => DB_Controller.Delete<EventDance>(id);
        private void deleteRow() => del_data_row<EventDance>();



        // ---------------------------
        // Наследование не корректно работает
        public Admin_EventDance()
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