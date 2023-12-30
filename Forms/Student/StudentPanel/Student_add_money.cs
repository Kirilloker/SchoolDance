using SchoolDance.Class.DB;
using SchoolDance.Controller;
using SchoolDance.Util;
using static Dapper.SqlMapper;

namespace SchoolDance.Forms
{
    public partial class Student_add_money : Form
    {
        MainController<TopUp> controllerTop = new();
        MainController<Student> controllerStudent= new();
        int student_id;
        public Student_add_money(int student_id)
        {
            InitializeComponent();
            this.student_id = student_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (input_balance.Text == "")
            {
                ToolsForm.ShowMessage("Нужно ввести количество рублей, на которое вы хотите пополнить баланс.");
                return;
            }

            int balance = 0;
            if (!int.TryParse(input_balance.Text, out balance) || balance < 0)
            {
                ToolsForm.ShowMessage("В поле Баланс, нужно ввести положительное число.");
                return;
            }

            Student student = controllerStudent.GetEntityByID(student_id);
            student.balance += balance;

            ToolsForm.ShowMessage("Пополнение баланса прошло успешно, теперь ваш баланс составляет: " + student.balance.ToString() + " рублей",
                "Пополнение баланса", MessageBoxIcon.Asterisk);

            controllerStudent.ChangeFromDB(student);

            TopUp payment = new TopUp
            {
                studentId = student_id,
                price = balance,
                paymentTime = DateTime.Now
            };

            controllerTop.AddFromDB(payment);
        }
    }
}
