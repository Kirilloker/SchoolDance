namespace SchoolDance.Forms
{
    partial class Student_pay_for_lesson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            b_add_money = new Button();
            text_balance = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(252, 9);
            label1.Name = "label1";
            label1.Size = new Size(264, 46);
            label1.TabIndex = 0;
            label1.Text = "Оплата занятий";
            // 
            // b_add_money
            // 
            b_add_money.BackColor = Color.LemonChiffon;
            b_add_money.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            b_add_money.Location = new Point(504, 10);
            b_add_money.Name = "b_add_money";
            b_add_money.Size = new Size(195, 71);
            b_add_money.TabIndex = 1;
            b_add_money.Text = "Пополнить";
            b_add_money.UseVisualStyleBackColor = false;
            b_add_money.Click += b_add_money_Click;
            // 
            // text_balance
            // 
            text_balance.AutoSize = true;
            text_balance.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            text_balance.Location = new Point(35, 25);
            text_balance.Name = "text_balance";
            text_balance.Size = new Size(119, 41);
            text_balance.TabIndex = 2;
            text_balance.Text = "Баланс:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(text_balance);
            panel1.Controls.Add(b_add_money);
            panel1.Location = new Point(45, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(722, 98);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Khaki;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(45, 191);
            panel2.Name = "panel2";
            panel2.Size = new Size(722, 247);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Cornsilk;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(23, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(676, 72);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Занятие: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 40);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 1;
            label3.Text = "Продлен до: ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(448, 11);
            button1.Name = "button1";
            button1.Size = new Size(215, 49);
            button1.TabIndex = 2;
            button1.Text = "Продлить на 1 месяц";
            button1.UseVisualStyleBackColor = true;
            // 
            // Student_pay_for_lesson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Student_pay_for_lesson";
            Text = "Student_pay_for_lesson";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button b_add_money;
        private Label text_balance;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Label label3;
        private Label label2;
    }
}