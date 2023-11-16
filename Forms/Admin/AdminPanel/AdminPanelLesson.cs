using SchoolDance.Class.DB;
using SchoolDance.Class.Logic;
using SchoolDance.Util;
using System.Windows.Forms;

namespace SchoolDance.Forms
{
    public partial class AdminPanelLesson : Form
    {
        private void b_add_new_rows_Click(object sender, EventArgs e)
        {
            try
            {
                if (input_name.Text == "" ||
                    list_danceHall.SelectedItem == null ||
                    list_coach.SelectedItem == null ||
                    list_group.SelectedItem == null ||
                    list_style.SelectedItem == null)
                {
                    ToolsForm.ShowMessage("Нужно заполнить все поля.");
                    return;
                }


                List<string> selectedItems = new List<string>();
                foreach (var item in list_weekdays.CheckedItems)
                {
                    selectedItems.Add(item.ToString());
                }
                string weekdays = string.Join(", ", selectedItems);


                string danceHall = (string)list_danceHall.SelectedItem;
                int id_dance = int.Parse(danceHall.Split(". ")[0]);

                string coach = (string)list_coach.SelectedItem;
                int id_coach = int.Parse(coach.Split(". ")[0]);

                string group = (string)list_group.SelectedItem;
                int id_group = int.Parse(group.Split(". ")[0]);

                string style = (string)list_style.SelectedItem;
                int id_style = int.Parse(style.Split(". ")[0]);

                Lesson obj = new Lesson
                {
                    className = input_name.Text,
                    weekdays = weekdays,
                    danceHallId = id_dance,
                    groupId = id_group,
                    coachId = id_coach,
                    danceStylesId = id_style
                };


                if (DB_API.AddLesson(obj) == true)
                {
                    add_data_row<Lesson>(obj);
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


        // -------

        private void fillDate() => DataGrid.DataSource = DB_API.GetAll<Lesson>();
        private void changeCell(int rowIndex) => DB_API.Update<Lesson>(((List<Lesson>)DataGrid.DataSource)[rowIndex]);
        private bool deleteRow(int id) => DB_API.Delete<Lesson>(id);
        private void deleteRow() => del_data_row<Lesson>();



        // ---------------------------
        // Наследование не корректно работает
        public AdminPanelLesson()
        {
            InitializeComponent();

            list_coach.DropDownStyle = ComboBoxStyle.DropDownList;
            list_group.DropDownStyle = ComboBoxStyle.DropDownList;
            list_style.DropDownStyle = ComboBoxStyle.DropDownList;
            list_danceHall.DropDownStyle = ComboBoxStyle.DropDownList;

            fillDate();
            this.AutoSize = true;
            DataGrid.Dock = DockStyle.Fill;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            List<Group> groups = DB_API.GetAll<Group>();
            string[] formattedNames = groups.Select((ds) => $"{ds.Id}. {ds.nameGroup}").ToArray();
            list_group.Items.AddRange(formattedNames);

            List<DanceHall> danceHalls = DB_API.GetAll<DanceHall>();
            formattedNames = danceHalls.Select((ds) => $"{ds.Id}. {ds.roomNumber}").ToArray();
            list_danceHall.Items.AddRange(formattedNames);

            List<DanceStyle> danceStyles = DB_API.GetAll<DanceStyle>();
            formattedNames = danceStyles.Select((ds) => $"{ds.Id}. {ds.name}").ToArray();
            list_style.Items.AddRange(formattedNames);

            List<Coach> coaches = DB_API.GetAll<Coach>();
            formattedNames = coaches.Select((ds) => $"{ds.Id}. {ds.fullName}").ToArray();
            list_coach.Items.AddRange(formattedNames);
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