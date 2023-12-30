using Microsoft.EntityFrameworkCore.Metadata;
using SchoolDance.Class.DB;
using SchoolDance.Class.Logic;
using SchoolDance.Controller;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Admin_Coach : Form
    {
        MainController<Coach> controller = new();

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
                    if (item == null) continue;
                    str_danceStyleId += item.ToString().Split(". ")[0] + ", ";
                }

                double phoneNumber = 0;
                if (!double.TryParse(input_phoneNumber.Text, out phoneNumber) ||
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

                if (controller.Add(obj) == true) 
                    ToolsForm.ShowMessage("Запись добавлена", "Добавление новой записи", MessageBoxIcon.Asterisk);
                else 
                    ToolsForm.ShowMessage("Что-то пошло не так. Возможно такое значение уже занят.");
            
            }
            catch (Exception)
            {
                ToolsForm.ShowMessage("Что-то пошло не так");
            }
        }

        private void PreparingAddView()
        {
            List<DanceStyle> danceStyles = DB_Controller.GetAll<DanceStyle>();
            string[] formattedNames = danceStyles.Select((ds) => $"{ds.Id}. {ds.name}").ToArray();
            box_danceStyle.Items.AddRange(formattedNames);
        }

        // ------

        public Admin_Coach()
        {
            InitializeComponent();

            controller.Update += Update;
            controller.GetDate += GetDate;
            controller.FillDate();

            PreparingAddView();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            
            controller.Change(e.RowIndex);
        }
        private void b_del_Click(object sender, EventArgs e)
        {
            if (controller.Delete(input_id_delete.Text) == true)
                ToolsForm.ShowMessage("Строка успешно удалена", "Удаление строки", MessageBoxIcon.Asterisk);
            else 
                ToolsForm.ShowMessage("Ошибка при удалении из таблицы", "Удаление строки");
        }

        private void Update(object newDataSource)
        {
            DataGrid.DataSource = null;
            DataGrid.DataSource = newDataSource;
        }

        private object GetDate() 
        {
            return DataGrid.DataSource;
        }
    }
}