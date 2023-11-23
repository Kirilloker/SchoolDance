using SchoolDance.Class.DB;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Admin_Payment : Form
    {
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

            if (DB_API.AddPayment(obj) == true)
            {
                add_data_row<Payment>(obj);
                ToolsForm.ShowMessage("Оплата добавлена", "Добавление новой оплаты", MessageBoxIcon.Asterisk);
            }
            else
            {
                ToolsForm.ShowMessage("Что-то пошло не так. Возможно такое значение уже занято.");
            }
        }
        private void fillDate() => DataGrid.DataSource = DB_API.GetAll<Payment>();
        private void changeCell(int rowIndex) => DB_API.Update<Payment>(((List<Payment>)DataGrid.DataSource)[rowIndex]);
        private bool deleteRow(int id) => DB_API.Delete<Payment>(id);
        private void deleteRow() => del_data_row<Payment>();



        // ---------------------------
        // Наследование не корректно работает
        public Admin_Payment()
        {
            InitializeComponent();

            fillDate();
            this.AutoSize = true;
            DataGrid.Dock = DockStyle.Fill;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            list_student.DropDownStyle = ComboBoxStyle.DropDownList;
            list_lesson.DropDownStyle = ComboBoxStyle.DropDownList;

            List<Student> students = DB_API.GetAll<Student>();
            string[] formattedNames = students.Select((ds) => $"{ds.Id}. {ds.fullName}").ToArray();
            list_student.Items.AddRange(formattedNames);

            List<Lesson> lessons = DB_API.GetAll<Lesson>();
            string[] formattedlesson = lessons.Select((ds) => $"{ds.Id}. {ds.className}").ToArray();
            list_lesson.Items.AddRange(formattedlesson);
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
