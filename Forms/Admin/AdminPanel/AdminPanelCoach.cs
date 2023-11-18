using SchoolDance.Class.DB;
using SchoolDance.Class.Logic;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class AdminPanelCoach : Form
    {
        private void b_add_new_rows_Click(object sender, EventArgs e)
        {
            try
            {
                if (input_login.Text == "" || input_password.Text == "" || input_first_name.Text == "" ||
                (radio_female.Checked == false && radio_male.Checked == false) ||
                input_position.Text == "" || input_phoneNumber.Text == "" ||
                input_workExperience.Text == "")
                {
                    ToolsForm.ShowMessage("Нужно заполнить все поля.");
                    return;
                }


                string str_danceStyleId = "";

                List<string> list_danceStyle = new();
                foreach (var item in box_danceStyle.SelectedItems)
                {
                    str_danceStyleId += item.ToString().Split(". ")[0] + ", ";
                }

                Double phoneNumber = 0;
                if (!Double.TryParse(input_phoneNumber.Text, out phoneNumber) ||
                    input_phoneNumber.Text.Length != 11)
                {
                    ToolsForm.ShowMessage("Номер введен не корректно. Пример: 79101351393");
                    return;
                }

                int workExp = 0;
                if (!int.TryParse(input_workExperience.Text, out workExp))
                {
                    ToolsForm.ShowMessage("В поле стаж, нужно ввести число.");
                    return;
                }

                Coach obj = new Coach
                {
                    login = input_login.Text,
                    password = SignInUpLogic.EncodeStringToBase64(input_password.Text),
                    fullName = input_first_name.Text,
                    gender = radio_male.Checked == true ? "Male" : "Female",
                    date = dateTime_birth_date.Value,
                    typePerson = TypePerson.Coach,
                    danceStylesId = str_danceStyleId,
                    position = input_position.Text,
                    phoneNumber = input_phoneNumber.Text,
                    workExperienceMonth = workExp
                };


                if (DB_API.AddCoach(obj) == true)
                {
                    add_data_row<Coach>(obj);
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

        private void fillDate() => DataGrid.DataSource = DB_API.GetAll<Coach>();
        private void changeCell(int rowIndex) => DB_API.Update<Coach>(((List<Coach>)DataGrid.DataSource)[rowIndex]);
        private bool deleteRow(int id) => DB_API.Delete<Coach>(id);
        private void deleteRow() => del_data_row<Coach>();



        // ---------------------------
        // Наследование не корректно работает
        public AdminPanelCoach()
        {
            InitializeComponent();

            fillDate();
            this.AutoSize = true;
            DataGrid.Dock = DockStyle.Fill;
            DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            List<DanceStyle> danceStyles = DB_API.GetAll<DanceStyle>();
            string[] formattedNames = danceStyles.Select((ds) => $"{ds.Id}. {ds.name}").ToArray();
            box_danceStyle.Items.AddRange(formattedNames);
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