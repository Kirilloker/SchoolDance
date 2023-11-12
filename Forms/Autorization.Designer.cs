namespace SchoolDance.Forms
{
    partial class Autorization
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
            text_autorization = new Label();
            text_login = new Label();
            Password_text = new Label();
            input_login = new TextBox();
            text_password = new Label();
            label2 = new Label();
            input_password = new TextBox();
            b_SignIn = new Button();
            background = new Panel();
            b_SignUp = new Button();
            b_help = new Button();
            background.SuspendLayout();
            SuspendLayout();
            // 
            // text_autorization
            // 
            text_autorization.AutoSize = true;
            text_autorization.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            text_autorization.Location = new Point(66, 22);
            text_autorization.Name = "text_autorization";
            text_autorization.Size = new Size(314, 65);
            text_autorization.TabIndex = 0;
            text_autorization.Text = "Авторизация";
            // 
            // text_login
            // 
            text_login.AutoSize = true;
            text_login.BackColor = SystemColors.ActiveCaption;
            text_login.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            text_login.Location = new Point(66, 142);
            text_login.Name = "text_login";
            text_login.Size = new Size(93, 37);
            text_login.TabIndex = 1;
            text_login.Text = "Логин";
            // 
            // Password_text
            // 
            Password_text.AutoSize = true;
            Password_text.Location = new Point(166, 195);
            Password_text.Name = "Password_text";
            Password_text.Size = new Size(0, 15);
            Password_text.TabIndex = 2;
            // 
            // input_login
            // 
            input_login.BackColor = SystemColors.Window;
            input_login.Location = new Point(190, 154);
            input_login.Margin = new Padding(3, 2, 3, 2);
            input_login.Name = "input_login";
            input_login.Size = new Size(206, 23);
            input_login.TabIndex = 3;
            // 
            // text_password
            // 
            text_password.AutoSize = true;
            text_password.BackColor = SystemColors.ActiveCaption;
            text_password.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            text_password.Location = new Point(66, 195);
            text_password.Name = "text_password";
            text_password.Size = new Size(110, 37);
            text_password.TabIndex = 1;
            text_password.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 248);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // input_password
            // 
            input_password.Location = new Point(190, 208);
            input_password.Margin = new Padding(3, 2, 3, 2);
            input_password.Name = "input_password";
            input_password.Size = new Size(206, 23);
            input_password.TabIndex = 3;
            // 
            // b_SignIn
            // 
            b_SignIn.BackColor = Color.PaleGreen;
            b_SignIn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_SignIn.Location = new Point(139, 119);
            b_SignIn.Margin = new Padding(3, 2, 3, 2);
            b_SignIn.Name = "b_SignIn";
            b_SignIn.Size = new Size(118, 51);
            b_SignIn.TabIndex = 4;
            b_SignIn.Text = "Вход";
            b_SignIn.UseVisualStyleBackColor = false;
            b_SignIn.Click += b_SignIn_Click;
            // 
            // background
            // 
            background.BackColor = SystemColors.ActiveCaption;
            background.Controls.Add(b_SignUp);
            background.Controls.Add(b_SignIn);
            background.Location = new Point(51, 129);
            background.Margin = new Padding(3, 2, 3, 2);
            background.Name = "background";
            background.Size = new Size(384, 212);
            background.TabIndex = 5;
            // 
            // b_SignUp
            // 
            b_SignUp.BackColor = SystemColors.ControlLight;
            b_SignUp.Location = new Point(139, 175);
            b_SignUp.Margin = new Padding(3, 2, 3, 2);
            b_SignUp.Name = "b_SignUp";
            b_SignUp.Size = new Size(118, 28);
            b_SignUp.TabIndex = 6;
            b_SignUp.Text = "Регистрация";
            b_SignUp.UseVisualStyleBackColor = false;
            b_SignUp.Click += b_SignUp_Click;
            // 
            // b_help
            // 
            b_help.Location = new Point(190, 400);
            b_help.Margin = new Padding(3, 2, 3, 2);
            b_help.Name = "b_help";
            b_help.Size = new Size(118, 28);
            b_help.TabIndex = 6;
            b_help.Text = "Помощь";
            b_help.UseVisualStyleBackColor = true;
            b_help.Click += b_help_Click;
            // 
            // Autorization
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(b_help);
            Controls.Add(input_password);
            Controls.Add(input_login);
            Controls.Add(label2);
            Controls.Add(Password_text);
            Controls.Add(text_password);
            Controls.Add(text_login);
            Controls.Add(text_autorization);
            Controls.Add(background);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Autorization";
            Text = "Школа танцев";
            background.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label text_autorization;
        private Label text_login;
        private Label Password_text;
        private TextBox input_login;
        private Label text_password;
        private Label label2;
        private TextBox input_password;
        private Button b_SignIn;
        private Panel background;
        private Button b_help;
        private Button b_SignUp;
    }
}