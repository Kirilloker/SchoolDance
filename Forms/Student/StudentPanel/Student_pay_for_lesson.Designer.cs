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
            b_refresh = new Button();
            panel1.SuspendLayout();
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
            panel2.AutoScroll = true;
            panel2.BackColor = Color.Khaki;
            panel2.Location = new Point(45, 191);
            panel2.Name = "panel2";
            panel2.Size = new Size(722, 247);
            panel2.TabIndex = 4;
            // 
            // b_refresh
            // 
            b_refresh.BackColor = Color.LemonChiffon;
            b_refresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            b_refresh.Location = new Point(45, 44);
            b_refresh.Name = "b_refresh";
            b_refresh.Size = new Size(97, 28);
            b_refresh.TabIndex = 1;
            b_refresh.Text = "обновить";
            b_refresh.UseVisualStyleBackColor = false;
            b_refresh.Click += Refresh;
            // 
            // Student_pay_for_lesson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(b_refresh);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Student_pay_for_lesson";
            Text = "Student_pay_for_lesson";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button b_add_money;
        private Label text_balance;
        private Panel panel1;
        private Panel panel2;
        private Button b_refresh;
    }
}