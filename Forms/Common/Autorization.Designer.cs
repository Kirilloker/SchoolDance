namespace SchoolDance.Forms
{
    partial class Authorization
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
            show_password = new CheckBox();
            b_SignUp = new Button();
            b_help = new Button();
            background.SuspendLayout();
            SuspendLayout();
            // 
            // text_autorization
            // 
            text_autorization.AutoSize = true;
            text_autorization.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            text_autorization.Location = new Point(75, 29);
            text_autorization.Name = "text_autorization";
            text_autorization.Size = new Size(395, 81);
            text_autorization.TabIndex = 0;
            text_autorization.Text = "Авторизация";
            // 
            // text_login
            // 
            text_login.AutoSize = true;
            text_login.BackColor = SystemColors.ActiveCaption;
            text_login.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            text_login.Location = new Point(17, 21);
            text_login.Name = "text_login";
            text_login.Size = new Size(116, 46);
            text_login.TabIndex = 1;
            text_login.Text = "Логин";
            // 
            // Password_text
            // 
            Password_text.AutoSize = true;
            Password_text.Location = new Point(190, 260);
            Password_text.Name = "Password_text";
            Password_text.Size = new Size(0, 20);
            Password_text.TabIndex = 2;
            // 
            // input_login
            // 
            input_login.BackColor = SystemColors.Window;
            input_login.Location = new Point(159, 37);
            input_login.Name = "input_login";
            input_login.Size = new Size(235, 27);
            input_login.TabIndex = 3;
            // 
            // text_password
            // 
            text_password.AutoSize = true;
            text_password.BackColor = SystemColors.ActiveCaption;
            text_password.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            text_password.Location = new Point(17, 92);
            text_password.Name = "text_password";
            text_password.Size = new Size(136, 46);
            text_password.TabIndex = 1;
            text_password.Text = "Пароль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 331);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // input_password
            // 
            input_password.Location = new Point(159, 109);
            input_password.Name = "input_password";
            input_password.Size = new Size(235, 27);
            input_password.TabIndex = 3;
            // 
            // b_SignIn
            // 
            b_SignIn.BackColor = Color.PaleGreen;
            b_SignIn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_SignIn.Location = new Point(159, 213);
            b_SignIn.Name = "b_SignIn";
            b_SignIn.Size = new Size(135, 68);
            b_SignIn.TabIndex = 4;
            b_SignIn.Text = "Вход";
            b_SignIn.UseVisualStyleBackColor = false;
            b_SignIn.Click += b_SignIn_Click;
            // 
            // background
            // 
            background.BackColor = SystemColors.ActiveCaption;
            background.Controls.Add(b_help);
            background.Controls.Add(show_password);
            background.Controls.Add(input_password);
            background.Controls.Add(b_SignUp);
            background.Controls.Add(input_login);
            background.Controls.Add(b_SignIn);
            background.Controls.Add(text_login);
            background.Controls.Add(text_password);
            background.Location = new Point(58, 136);
            background.Name = "background";
            background.Size = new Size(439, 352);
            background.TabIndex = 5;
            // 
            // show_password
            // 
            show_password.AutoSize = true;
            show_password.Location = new Point(159, 142);
            show_password.Name = "show_password";
            show_password.Size = new Size(150, 24);
            show_password.TabIndex = 15;
            show_password.Text = "Показать пароль";
            show_password.UseVisualStyleBackColor = true;
            show_password.CheckedChanged += show_password_CheckedChanged_1;
            // 
            // b_SignUp
            // 
            b_SignUp.BackColor = SystemColors.ControlLight;
            b_SignUp.Location = new Point(159, 297);
            b_SignUp.Name = "b_SignUp";
            b_SignUp.Size = new Size(135, 37);
            b_SignUp.TabIndex = 6;
            b_SignUp.Text = "Регистрация";
            b_SignUp.UseVisualStyleBackColor = false;
            b_SignUp.Click += b_SignUp_Click;
            // 
            // b_help
            // 
            b_help.BackColor = SystemColors.GradientActiveCaption;
            b_help.Location = new Point(358, 297);
            b_help.Name = "b_help";
            b_help.Size = new Size(78, 37);
            b_help.TabIndex = 6;
            b_help.Text = "Помощь";
            b_help.UseVisualStyleBackColor = false;
            b_help.Click += b_help_Click;
            // 
            // Autorization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(553, 539);
            Controls.Add(label2);
            Controls.Add(Password_text);
            Controls.Add(text_autorization);
            Controls.Add(background);
            Name = "Autorization";
            Text = "Школа танцев";
            background.ResumeLayout(false);
            background.PerformLayout();
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
        private CheckBox show_password;
    }
}