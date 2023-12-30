using SchoolDance.Class.DB;
using SchoolDance.Class.Logic;
using SchoolDance.Controller;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Admin_Student : Form
    {
        MainController<Student> controller = new();

        private void b_add_new_rows_Click(object sender, EventArgs e)
        {
            try
            {
                if (input_login.Text == "" || input_password.Text == "" || input_first_name.Text == "" || input_balance.Text == "" ||
                    (radio_female.Checked == false && radio_male.Checked == false))
                {
                    ToolsForm.ShowMessage("Нужно заполнить все поля.");
                    return;
                }


                int balance = 0;
                if (!int.TryParse(input_balance_1.Text, out balance))
                {
                    ToolsForm.ShowMessage("В поле Баланс, нужно ввести число.");
                    return;
                }

                Student obj = new Student
                {
                    login = input_login.Text,
                    password = SignInUpLogic.EncodeStringToBase64(input_password.Text),
                    fullName = input_first_name.Text,
                    gender = radio_male.Checked == true ? "Male" : "Female",
                    date = dateTime_birth_date.Value,
                    typePerson = TypePerson.Student,
                    balance = balance
                };

                Add(obj);
            }
            catch (Exception)
            {
                ToolsForm.ShowMessage("Что-то пошло не так");
            }

        }
        private void PreparingAddView()
        {

        }

        private void Add(Student entity)
        {
            if (controller.Add(entity) == true)
                ToolsForm.ShowMessage("Запись добавлена", "Добавление новой записи", MessageBoxIcon.Asterisk);
            else
                ToolsForm.ShowMessage("Что-то пошло не так. Возможно такое значение уже занято.");
        }


        // ---------------------------
        public Admin_Student()
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
    }
}

