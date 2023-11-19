
using SchoolDance.Class.DB;

namespace SchoolDance.Forms
{
    public partial class Student_pay_for_lesson : Form
    {
        int student_id;
        private System.Windows.Forms.Timer labelUpdateTimer;
        public Student_pay_for_lesson(int student_id)
        {
            InitializeComponent();
            this.student_id = student_id;

            // Таймер который обновляет баланс каждые 3 секунды
            labelUpdateTimer = new System.Windows.Forms.Timer();
            labelUpdateTimer.Interval = 3000;
            labelUpdateTimer.Tick += UpdateBalance;
            labelUpdateTimer.Start();
        }

        private void b_add_money_Click(object sender, EventArgs e)
        {
            Student_add_money form = new(student_id);
            form.Show();
        }

        private void UpdateBalance(object sender, EventArgs e)
        {
            Student student = DB_API.Get<Student>(student_id);
            text_balance.Text = "Баланс: " + student.balance.ToString() + " рублей";
        }

    }
}
