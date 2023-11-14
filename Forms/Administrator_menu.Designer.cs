namespace SchoolDance.Forms
{
    partial class Administrator_menu
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
            b_student = new Button();
            b_coach = new Button();
            b_payment = new Button();
            b_group = new Button();
            b_event = new Button();
            b_class = new Button();
            b_hall = new Button();
            button8 = new Button();
            b_answers = new Button();
            bg1 = new Panel();
            text_role = new Label();
            text_FIO = new Label();
            text_account = new Label();
            bg2 = new Panel();
            bg3 = new Panel();
            bg1.SuspendLayout();
            bg2.SuspendLayout();
            SuspendLayout();
            // 
            // b_student
            // 
            b_student.BackColor = Color.Silver;
            b_student.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            b_student.Location = new Point(18, 153);
            b_student.Margin = new Padding(3, 4, 3, 4);
            b_student.Name = "b_student";
            b_student.Size = new Size(191, 59);
            b_student.TabIndex = 0;
            b_student.Text = "Ученики";
            b_student.UseVisualStyleBackColor = false;
            b_student.Click += b_student_Click;
            // 
            // b_coach
            // 
            b_coach.BackColor = Color.Silver;
            b_coach.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            b_coach.Location = new Point(227, 153);
            b_coach.Margin = new Padding(3, 4, 3, 4);
            b_coach.Name = "b_coach";
            b_coach.Size = new Size(174, 59);
            b_coach.TabIndex = 0;
            b_coach.Text = "Тренера";
            b_coach.UseVisualStyleBackColor = false;
            b_coach.Click += b_coach_Click;
            // 
            // b_payment
            // 
            b_payment.BackColor = Color.Silver;
            b_payment.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            b_payment.Location = new Point(423, 153);
            b_payment.Margin = new Padding(3, 4, 3, 4);
            b_payment.Name = "b_payment";
            b_payment.Size = new Size(174, 59);
            b_payment.TabIndex = 0;
            b_payment.Text = "Платеж";
            b_payment.UseVisualStyleBackColor = false;
            b_payment.Click += b_payment_Click;
            // 
            // b_group
            // 
            b_group.BackColor = Color.Silver;
            b_group.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            b_group.Location = new Point(634, 153);
            b_group.Margin = new Padding(3, 4, 3, 4);
            b_group.Name = "b_group";
            b_group.Size = new Size(174, 59);
            b_group.TabIndex = 0;
            b_group.Text = "Группа";
            b_group.UseVisualStyleBackColor = false;
            b_group.Click += b_group_Click;
            // 
            // b_event
            // 
            b_event.BackColor = Color.Silver;
            b_event.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            b_event.Location = new Point(18, 241);
            b_event.Margin = new Padding(3, 4, 3, 4);
            b_event.Name = "b_event";
            b_event.Size = new Size(191, 59);
            b_event.TabIndex = 0;
            b_event.Text = "Мероприятия";
            b_event.UseVisualStyleBackColor = false;
            b_event.Click += b_event_Click;
            // 
            // b_class
            // 
            b_class.BackColor = Color.Silver;
            b_class.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            b_class.Location = new Point(227, 241);
            b_class.Margin = new Padding(3, 4, 3, 4);
            b_class.Name = "b_class";
            b_class.Size = new Size(174, 59);
            b_class.TabIndex = 0;
            b_class.Text = "Занятия";
            b_class.UseVisualStyleBackColor = false;
            b_class.Click += b_class_Click;
            // 
            // b_hall
            // 
            b_hall.BackColor = Color.Silver;
            b_hall.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            b_hall.Location = new Point(423, 241);
            b_hall.Margin = new Padding(3, 4, 3, 4);
            b_hall.Name = "b_hall";
            b_hall.Size = new Size(174, 59);
            b_hall.TabIndex = 0;
            b_hall.Text = "Зал";
            b_hall.UseVisualStyleBackColor = false;
            b_hall.Click += b_hall_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Silver;
            button8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(634, 241);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(174, 59);
            button8.TabIndex = 0;
            button8.Text = "Другое";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // b_answers
            // 
            b_answers.BackColor = SystemColors.ActiveCaption;
            b_answers.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            b_answers.Location = new Point(227, 460);
            b_answers.Margin = new Padding(3, 4, 3, 4);
            b_answers.Name = "b_answers";
            b_answers.Size = new Size(369, 59);
            b_answers.TabIndex = 0;
            b_answers.Text = "Присланные вопросы";
            b_answers.UseVisualStyleBackColor = false;
            b_answers.Click += b_answers_Click;
            // 
            // bg1
            // 
            bg1.BackColor = Color.LightSalmon;
            bg1.Controls.Add(text_role);
            bg1.Controls.Add(text_FIO);
            bg1.Controls.Add(text_account);
            bg1.Location = new Point(1, 0);
            bg1.Margin = new Padding(3, 4, 3, 4);
            bg1.Name = "bg1";
            bg1.Size = new Size(849, 91);
            bg1.TabIndex = 1;
            // 
            // text_role
            // 
            text_role.AutoSize = true;
            text_role.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            text_role.Location = new Point(17, 55);
            text_role.Name = "text_role";
            text_role.Size = new Size(144, 23);
            text_role.TabIndex = 1;
            text_role.Text = "Администратор";
            // 
            // text_FIO
            // 
            text_FIO.AutoSize = true;
            text_FIO.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_FIO.Location = new Point(111, 12);
            text_FIO.Name = "text_FIO";
            text_FIO.Size = new Size(24, 32);
            text_FIO.TabIndex = 0;
            text_FIO.Text = "-";
            // 
            // text_account
            // 
            text_account.AutoSize = true;
            text_account.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_account.Location = new Point(13, 12);
            text_account.Name = "text_account";
            text_account.Size = new Size(113, 32);
            text_account.TabIndex = 0;
            text_account.Text = "Аккаунт: ";
            // 
            // bg2
            // 
            bg2.BackColor = Color.MistyRose;
            bg2.Controls.Add(bg3);
            bg2.Location = new Point(1, 91);
            bg2.Margin = new Padding(3, 4, 3, 4);
            bg2.Name = "bg2";
            bg2.Size = new Size(849, 512);
            bg2.TabIndex = 2;
            // 
            // bg3
            // 
            bg3.BackColor = Color.FromArgb(255, 192, 128);
            bg3.Location = new Point(0, 475);
            bg3.Margin = new Padding(3, 4, 3, 4);
            bg3.Name = "bg3";
            bg3.Size = new Size(849, 36);
            bg3.TabIndex = 0;
            // 
            // Administrator_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 600);
            Controls.Add(bg1);
            Controls.Add(button8);
            Controls.Add(b_hall);
            Controls.Add(b_answers);
            Controls.Add(b_class);
            Controls.Add(b_event);
            Controls.Add(b_group);
            Controls.Add(b_payment);
            Controls.Add(b_coach);
            Controls.Add(b_student);
            Controls.Add(bg2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Administrator_menu";
            Text = "Меню администратора";
            bg1.ResumeLayout(false);
            bg1.PerformLayout();
            bg2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button b_student;
        private Button b_coach;
        private Button b_payment;
        private Button b_group;
        private Button b_event;
        private Button b_class;
        private Button b_hall;
        private Button button8;
        private Button b_answers;
        private Panel bg1;
        private Label text_role;
        private Label text_account;
        private Panel bg2;
        private Label text_FIO;
        private Panel bg3;
    }
}