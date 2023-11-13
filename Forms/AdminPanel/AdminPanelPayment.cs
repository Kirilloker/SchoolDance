using SchoolDance.Class.DB;
using SchoolDance.Class.Logic;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class AdminPanelPayment : Form
    {
        private void b_add_new_rows_Click(object sender, EventArgs e)
        {
            if (date_payment_time.Value > date_endpayment_time.Value)
            {
                ToolsForm.ShowMessage("Дата окончания платежа не может быть раньше даты оплаты!");
                return;
            }

            Payment obj = new Payment
            {
                studentId = DB_API.GetStudentId((string)list_student.Items[0]),
                paymentTime = date_payment_time.Value,
                endDatePayment = date_endpayment_time.Value
            };

            if (DB_API.AddPayment(obj) == true)
            {
                add_data_row<Payment>(obj);
                ToolsForm.ShowMessage("Запись добавлена", "Добавление новой записи", MessageBoxIcon.Asterisk);
            }
            else
            {
                ToolsForm.ShowMessage("Что-то пошло не так. Возможно такое значение уже занят.");
            }
        }
        private void fillDate() => DataGrid.DataSource = DB_API.GetAll<Payment>();
        private void changeCell(int rowIndex) => DB_API.Update<Payment>(((List<Payment>)DataGrid.DataSource)[rowIndex]);
        private bool deleteRow(int id) => DB_API.Delete<Payment>(id);
        private void deleteRow() => del_data_row<Payment>();



        // ---------------------------
        // Наследование не корректно работает
        public AdminPanelPayment()
        {
            InitializeComponent();

            fillDate();
            this.AutoSize = true;
            DataGrid.Dock = DockStyle.Fill;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            list_student.DropDownStyle = ComboBoxStyle.DropDownList;

            List<Student> danceStyles = DB_API.GetAll<Student>();
            list_student.Items.AddRange(danceStyles.Select(ds => ds.fullName).ToArray());
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
