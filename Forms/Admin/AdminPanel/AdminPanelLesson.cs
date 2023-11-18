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
                    input_description.Text == "" ||
                    input_price.Text == "" ||
                    input_time.Text == "" ||
                    list_danceHall.SelectedItem == null ||
                    list_style.SelectedItem == null)
                {
                    ToolsForm.ShowMessage("Нужно заполнить все поля.");
                    return;
                }

                int price = 0;
                if (!int.TryParse(input_price.Text, out price))
                {
                    ToolsForm.ShowMessage("В поле Стоимость, нужно ввести число.");
                    return;
                }

                if (correct_time(input_time.Text) == false)
                {
                    ToolsForm.ShowMessage("В поле Время начала, нужно ввести время, когда начинается занятие. Например: 12:30");
                    return;
                }

                List<string> selectedItems = new List<string>();
                foreach (var item in list_weekdays.CheckedItems)
                    selectedItems.Add(item.ToString());
                string weekdays = string.Join(", ", selectedItems);

                string danceHall = (string)list_danceHall.SelectedItem;
                int id_dance = int.Parse(danceHall.Split(". ")[0]);


                string coach = (string)list_coach.SelectedItem;
                int id_coach = int.Parse(coach.Split(". ")[0]);


                string style = (string)list_style.SelectedItem;
                int id_style = int.Parse(style.Split(". ")[0]);

                Lesson obj = new Lesson
                {
                    className = input_name.Text,
                    weekdays = weekdays,
                    danceHallId = id_dance,
                    danceStylesId = id_style,
                    coachId = id_coach,
                    price = price,
                    description = input_description.Text,
                    time_start = input_time.Text
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
            list_style.DropDownStyle = ComboBoxStyle.DropDownList;
            list_danceHall.DropDownStyle = ComboBoxStyle.DropDownList;

            fillDate();
            this.AutoSize = true;
            DataGrid.Dock = DockStyle.Fill;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            List<DanceHall> danceHalls = DB_API.GetAll<DanceHall>();
            string[] formattedNames = danceHalls.Select((ds) => $"{ds.Id}. {ds.roomNumber}").ToArray();
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

        private void b_add_new_rows_Click_1(object sender, EventArgs e)
        {

        }

        private bool correct_time(string input)
        {
            if (input.Length != 6)
                return false;

            if (input[2] != ':')
                return false;

            if (!char.IsDigit(input[0]) || !char.IsDigit(input[1]) || !char.IsDigit(input[4]) || !char.IsDigit(input[5]))
                return false;

            return true;
        }
    }
}