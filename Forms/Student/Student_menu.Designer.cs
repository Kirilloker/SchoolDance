namespace SchoolDance.Forms
{
    partial class Student_menu : Form
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
            b_personal_info = new Button();
            b_answers = new Button();
            bg1 = new Panel();
            text_role = new Label();
            text_FIO = new Label();
            text_account = new Label();
            bg2 = new Panel();
            bg3 = new Panel();
            b_signUp_lesson = new Button();
            button3 = new Button();
            button2 = new Button();
            b_pay_lesson = new Button();
            b_questions = new Button();
            bg1.SuspendLayout();
            bg2.SuspendLayout();
            SuspendLayout();
            // 
            // b_personal_info
            // 
            b_personal_info.BackColor = Color.Silver;
            b_personal_info.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            b_personal_info.Location = new Point(81, 217);
            b_personal_info.Margin = new Padding(3, 4, 3, 4);
            b_personal_info.Name = "b_personal_info";
            b_personal_info.Size = new Size(296, 59);
            b_personal_info.TabIndex = 0;
            b_personal_info.Text = "Личная информация";
            b_personal_info.UseVisualStyleBackColor = false;
            b_personal_info.Click += button8_Click;
            // 
            // b_answers
            // 
            b_answers.BackColor = SystemColors.ActiveCaption;
            b_answers.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            b_answers.Location = new Point(159, 381);
            b_answers.Margin = new Padding(3, 4, 3, 4);
            b_answers.Name = "b_answers";
            b_answers.Size = new Size(519, 59);
            b_answers.TabIndex = 0;
            b_answers.Text = "Отправить сообщение об ошибке";
            b_answers.UseVisualStyleBackColor = false;
            b_answers.Click += b_answers_Click;
            // 
            // bg1
            // 
            bg1.BackColor = Color.Gold;
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
            text_role.Size = new Size(70, 23);
            text_role.TabIndex = 1;
            text_role.Text = "Ученик";
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
            bg2.BackColor = Color.LemonChiffon;
            bg2.Controls.Add(bg3);
            bg2.Controls.Add(b_signUp_lesson);
            bg2.Controls.Add(button3);
            bg2.Controls.Add(button2);
            bg2.Controls.Add(b_pay_lesson);
            bg2.Controls.Add(b_questions);
            bg2.Controls.Add(b_personal_info);
            bg2.Controls.Add(b_answers);
            bg2.Location = new Point(1, 91);
            bg2.Margin = new Padding(3, 4, 3, 4);
            bg2.Name = "bg2";
            bg2.Size = new Size(849, 512);
            bg2.TabIndex = 2;
            // 
            // bg3
            // 
            bg3.BackColor = Color.FromArgb(192, 192, 0);
            bg3.Location = new Point(0, 475);
            bg3.Margin = new Padding(3, 4, 3, 4);
            bg3.Name = "bg3";
            bg3.Size = new Size(849, 36);
            bg3.TabIndex = 0;
            // 
            // b_signUp_lesson
            // 
            b_signUp_lesson.BackColor = Color.Silver;
            b_signUp_lesson.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            b_signUp_lesson.Location = new Point(438, 38);
            b_signUp_lesson.Margin = new Padding(3, 4, 3, 4);
            b_signUp_lesson.Name = "b_signUp_lesson";
            b_signUp_lesson.Size = new Size(296, 59);
            b_signUp_lesson.TabIndex = 0;
            b_signUp_lesson.Text = "Записаться на занятие";
            b_signUp_lesson.UseVisualStyleBackColor = false;
            b_signUp_lesson.Click += b_signUp_lesosn_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(81, 38);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(296, 59);
            button3.TabIndex = 0;
            button3.Text = "Моё расписание";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(81, 124);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(296, 59);
            button2.TabIndex = 0;
            button2.Text = "Мероприятия";
            button2.UseVisualStyleBackColor = false;
            // 
            // b_pay_lesson
            // 
            b_pay_lesson.BackColor = Color.Silver;
            b_pay_lesson.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            b_pay_lesson.Location = new Point(438, 124);
            b_pay_lesson.Margin = new Padding(3, 4, 3, 4);
            b_pay_lesson.Name = "b_pay_lesson";
            b_pay_lesson.Size = new Size(296, 59);
            b_pay_lesson.TabIndex = 0;
            b_pay_lesson.Text = "Оплатить занятия";
            b_pay_lesson.UseVisualStyleBackColor = false;
            b_pay_lesson.Click += b_pay_lesson_Click;
            // 
            // b_questions
            // 
            b_questions.BackColor = Color.Silver;
            b_questions.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            b_questions.Location = new Point(438, 217);
            b_questions.Margin = new Padding(3, 4, 3, 4);
            b_questions.Name = "b_questions";
            b_questions.Size = new Size(296, 59);
            b_questions.TabIndex = 0;
            b_questions.Text = "Вопросы";
            b_questions.UseVisualStyleBackColor = false;
            b_questions.Click += b_question_click;
            // 
            // Student_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 600);
            Controls.Add(bg1);
            Controls.Add(bg2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Student_menu";
            Text = "Меню администратора";
            bg1.ResumeLayout(false);
            bg1.PerformLayout();
            bg2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button b_personal_info;
        private Button b_answers;
        private Panel bg1;
        private Label text_role;
        private Label text_account;
        private Panel bg2;
        private Label text_FIO;
        private Panel bg3;
        private Button b_signUp_lesson;
        private Button button3;
        private Button button2;
        private Button b_pay_lesson;
        private Button b_questions;
    }
}