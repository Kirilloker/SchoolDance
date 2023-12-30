using SchoolDance.Class.DB;
using SchoolDance.Util;

namespace SchoolDance.Forms
{
    public partial class Student_pay_for_lesson : Form
    {
        int student_id;
        public Student_pay_for_lesson(int student_id)
        {
            InitializeComponent();
            this.student_id = student_id;
            Refresh();
        }

        private void b_add_money_Click(object sender, EventArgs e)
        {
            Student_add_money form = new(student_id);
            form.Show();
        }

        private void UpdateBalance()
        {
            Student student = DB_Controller.Get<Student>(student_id);
            text_balance.Text = "Баланс: " + student.balance.ToString() + " рублей";
        }

        private void Refresh(object sender = null, EventArgs e = null)
        {
            foreach (Control control in panel2.Controls)
                control.Dispose();

            panel2.Controls.Clear();

            UpdateBalance();
            create_payments();
        }

        private void create_payments()
        {
            List<Payment> payments = DB_Controller.GetAll<Payment>();
            List<Payment> filteredPayments = payments.Where(p => p.studentId == student_id).ToList();


            int panelX = 20;
            int panelY = 10;

            foreach (Payment payment in filteredPayments)
            {
                Lesson lesson = DB_Controller.Get<Lesson>(payment.lessonId);

                TimeSpan difference = DateTime.Now.Subtract(payment.date_end_subscription);
                int differenceInDays = Math.Abs((int)difference.TotalDays);

                Color BackColor_panel = Color.Cornsilk;
                if (differenceInDays > 15)
                    BackColor_panel = Color.LightGreen;
                if (differenceInDays < 6)
                    BackColor_panel = Color.LightCoral;

                Panel panel = new Panel
                {
                    Location = new Point(panelX, panelY),
                    Size = new Size(500, 80),
                    BackColor = BackColor_panel
                };

                Label lessonLabel = new Label
                {
                    Location = new Point(10, 10),
                    Text = "Занятие: " + lesson.className,
                    Font = new Font("Segoe UI", 10),
                    AutoSize = true
                };

                Label endDateLabel = new Label
                {
                    Location = new Point(10, 40),
                    Text = "Продлен до: " + payment.date_end_subscription.ToString("dd.MM.yyyy"),
                    Font = new Font("Segoe UI", 10),
                    AutoSize = true
                };

                Label priceLabel = new Label
                {
                    Location = new Point(10, 70),
                    Text = "Цена: " + lesson.price,
                    Font = new Font("Segoe UI", 10),
                    AutoSize = true
                };

                Button extendButton = new Button
                {
                    Location = new Point(450, 25),
                    Text = "Продлить на 1 месяц",
                    Font = new Font("Segoe UI", 12),
                    Size = new Size(215, 50),
                    BackColor = Color.LightGray

                };

                extendButton.Click += (sender, e) =>
                {
                    Student student = DB_Controller.Get<Student>(student_id);
                    if (student.balance < lesson.price)
                    {
                        ToolsForm.ShowMessage("Не достаточно средств");
                        return;
                    }

                    var result_choice = MessageBox.Show("С вашего баланса спишется " + lesson.price.ToString() + " рублей, вы уверены?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result_choice == DialogResult.Yes)
                    {
                        student.balance -= lesson.price;

                        payment.date_end_subscription = payment.date_end_subscription.AddMonths(1);

                        DB_Controller.Update(student);
                        DB_Controller.Update(payment);
                        ToolsForm.ShowMessage("Вы продлили занятие", "Продление занятия", MessageBoxIcon.Asterisk);
                    }
                };

                panel.Controls.Add(lessonLabel);
                panel.Controls.Add(endDateLabel);
                panel.Controls.Add(extendButton);
                panel.Controls.Add(priceLabel);
                panel.Size = new Size(675, 100);

                panel2.Controls.Add(panel);

                panelY += 120;
            }
        }
    }
}
