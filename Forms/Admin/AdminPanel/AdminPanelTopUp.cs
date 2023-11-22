using SchoolDance.Class.DB;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class AdminPanelTopUp : Form
    {
        private void b_add_new_rows_Click(object sender, EventArgs e)
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

            if (DB_API.AddTopUp(obj) == true)
            {
                add_data_row<TopUp>(obj);
                ToolsForm.ShowMessage("Запись добавлена", "Добавление новой записи", MessageBoxIcon.Asterisk);
            }
            else
            {
                ToolsForm.ShowMessage("Что-то пошло не так. Возможно такое значение уже занято.");
            }
        }
        private void fillDate() => DataGrid.DataSource = DB_API.GetAll<TopUp>();
        private void changeCell(int rowIndex) => DB_API.Update<TopUp>(((List<TopUp>)DataGrid.DataSource)[rowIndex]);
        private bool deleteRow(int id) => DB_API.Delete<TopUp>(id);
        private void deleteRow() => del_data_row<TopUp>();



        // ---------------------------
        // Наследование не корректно работает
        public AdminPanelTopUp()
        {
            InitializeComponent();

            fillDate();
            this.AutoSize = true;
            DataGrid.Dock = DockStyle.Fill;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            list_student.DropDownStyle = ComboBoxStyle.DropDownList;

            List<Student> students = DB_API.GetAll<Student>();
            string[] formattedNames = students.Select((ds) => $"{ds.Id}. {ds.fullName}").ToArray();
            list_student.Items.AddRange(formattedNames);
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
