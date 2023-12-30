using SchoolDance.Class.DB;
using SchoolDance.Controller;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Admin_Lesson : Form
    {
        MainController<Lesson> controller = new();
        private void b_add_new_rows_Click_1(object sender, EventArgs e)
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
                {
                    if (item == null) continue;
                    selectedItems.Add(item.ToString());
                }
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


                Add(obj);
            }
            catch (Exception)
            {
                ToolsForm.ShowMessage("Что-то пошло не так");
                throw;
            }

        }


        private void PreparingAddView()
        {
            list_coach.DropDownStyle = ComboBoxStyle.DropDownList;
            list_style.DropDownStyle = ComboBoxStyle.DropDownList;
            list_danceHall.DropDownStyle = ComboBoxStyle.DropDownList;

            List<DanceHall> danceHalls = DB_Controller.GetAll<DanceHall>();
            string[] formattedNames = danceHalls.Select((ds) => $"{ds.Id}. {ds.roomNumber}").ToArray();
            list_danceHall.Items.AddRange(formattedNames);

            List<DanceStyle> danceStyles = DB_Controller.GetAll<DanceStyle>();
            formattedNames = danceStyles.Select((ds) => $"{ds.Id}. {ds.name}").ToArray();
            list_style.Items.AddRange(formattedNames);

            List<Coach> coaches = DB_Controller.GetAll<Coach>();
            formattedNames = coaches.Select((ds) => $"{ds.Id}. {ds.fullName}").ToArray();
            list_coach.Items.AddRange(formattedNames);
        }

        private void Add(Lesson entity)
        {
            if (controller.Add(entity) == true)
                ToolsForm.ShowMessage("Запись добавлена", "Добавление новой записи", MessageBoxIcon.Asterisk);
            else
                ToolsForm.ShowMessage("Что-то пошло не так. Возможно такое значение уже занято.");
        }



        // ---------------------------
        public Admin_Lesson()
        {
            InitializeComponent();
            InitClass();
        }

        private void InitClass()
        {
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

        private bool correct_time(string input)
        {
            if (input.Length != 5)
                return false;

            if (input[2] != ':')
                return false;

            if (!char.IsDigit(input[0]) || !char.IsDigit(input[1]) || !char.IsDigit(input[4]) || !char.IsDigit(input[5]))
                return false;

            return true;
        }

    }
}