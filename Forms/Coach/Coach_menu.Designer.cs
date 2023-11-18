namespace SchoolDance.Forms
{
    partial class Coach_menu
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
            b_answers = new Button();
            bg1 = new Panel();
            text_role = new Label();
            text_FIO = new Label();
            text_account = new Label();
            bg2 = new Panel();
            button8 = new Button();
            bg3 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            bg1.SuspendLayout();
            bg2.SuspendLayout();
            SuspendLayout();
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
            bg1.BackColor = Color.LightSeaGreen;
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
            text_role.Size = new Size(69, 23);
            text_role.TabIndex = 1;
            text_role.Text = "Тренер";
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
            bg2.BackColor = Color.PaleTurquoise;
            bg2.Controls.Add(button2);
            bg2.Controls.Add(button4);
            bg2.Controls.Add(button3);
            bg2.Controls.Add(button1);
            bg2.Controls.Add(button8);
            bg2.Controls.Add(bg3);
            bg2.Controls.Add(b_answers);
            bg2.Location = new Point(1, 91);
            bg2.Margin = new Padding(3, 4, 3, 4);
            bg2.Name = "bg2";
            bg2.Size = new Size(849, 512);
            bg2.TabIndex = 2;
            // 
            // button8
            // 
            button8.BackColor = Color.Silver;
            button8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(279, 274);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(296, 59);
            button8.TabIndex = 1;
            button8.Text = "Личная информация";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // bg3
            // 
            bg3.BackColor = Color.DarkSlateGray;
            bg3.Location = new Point(0, 475);
            bg3.Margin = new Padding(3, 4, 3, 4);
            bg3.Name = "bg3";
            bg3.Size = new Size(849, 36);
            bg3.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(279, 196);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(296, 59);
            button1.TabIndex = 1;
            button1.Text = "Просмотр всех занятий";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button8_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(461, 29);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(296, 59);
            button2.TabIndex = 1;
            button2.Text = "Занятия";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button8_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(84, 113);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(296, 59);
            button3.TabIndex = 1;
            button3.Text = "Расписание";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button8_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(461, 113);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(296, 59);
            button4.TabIndex = 1;
            button4.Text = "Мероприятия";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button8_Click;
            // 
            // Coach_menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 600);
            Controls.Add(bg1);
            Controls.Add(bg2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Coach_menu";
            Text = "Меню администратора";
            bg1.ResumeLayout(false);
            bg1.PerformLayout();
            bg2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button b_answers;
        private Panel bg1;
        private Label text_role;
        private Label text_account;
        private Panel bg2;
        private Label text_FIO;
        private Panel bg3;
        private Button button8;
        private Button button2;
        private Button button4;
        private Button button3;
        private Button button1;
    }
}