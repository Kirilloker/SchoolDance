using SchoolDance.Class.DB;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Admin_Group : Form
    {
        private void b_add_new_rows_Click(object sender, EventArgs e)
        {
            if (input_name_group.Text == "")
            {
                ToolsForm.ShowMessage("Нужно заполнить все поля.");
                return;
            }

            int number_max_student = 0;
            if (!int.TryParse(input_number_max_student.Text, out number_max_student))
            {
                ToolsForm.ShowMessage("В поле Максимальное количество студентов, нужно ввести число.");
                return;
            }

            List<int> selectedIds = new List<int>();
            foreach (int index in list_students.CheckedIndices)
            {
                string name = (string)list_students.Items[index];
                int id = int.Parse(name.Split(". ")[0]);
                selectedIds.Add(id);
            }

            if (selectedIds.Count > number_max_student)
            {
                ToolsForm.ShowMessage("Количество студентов, не может привышать максимального возможного количества студентов!");
                return;
            }

            string student_id = string.Join(", ", selectedIds);

            Group obj = new Group
            {
                nameGroup = input_name_group.Text,
                maxNumberStudent = number_max_student,
                studentId = student_id
            };

            if (DB_API.AddGroup(obj) == true)
            {
                add_data_row<Group>(obj);
                ToolsForm.ShowMessage("Запись добавлена", "Добавление новой записи", MessageBoxIcon.Asterisk);
            }
            else
            {
                ToolsForm.ShowMessage("Что-то пошло не так. Возможно такое значение уже занято.");
            }
        }
        private void fillDate() => DataGrid.DataSource = DB_API.GetAll<Group>();
        private void changeCell(int rowIndex) => DB_API.Update<Group>(((List<Group>)DataGrid.DataSource)[rowIndex]);
        private bool deleteRow(int id) => DB_API.Delete<Group>(id);
        private void deleteRow() => del_data_row<Group>();



        // ---------------------------
        // Наследование не корректно работает
        public Admin_Group()
        {
            InitializeComponent();

            fillDate();
            this.AutoSize = true;
            DataGrid.Dock = DockStyle.Fill;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            List<Student> danceStyles = DB_API.GetAll<Student>();

            string[] formattedNames = danceStyles
            .Select((ds) => $"{ds.Id}. {ds.fullName}")
            .ToArray();

            list_students.Items.AddRange(formattedNames);
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

        private void list_students_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
