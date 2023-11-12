namespace SchoolDance.Forms
{
    partial class Registration
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
            text_registration = new Label();
            input_password = new TextBox();
            input_login = new TextBox();
            label2 = new Label();
            Password_text = new Label();
            text_password = new Label();
            text_login = new Label();
            background = new Panel();
            dateTime_birth_date = new DateTimePicker();
            radio_female = new RadioButton();
            radio_male = new RadioButton();
            b_SignUp = new Button();
            input_patronymic = new TextBox();
            input_second_name = new TextBox();
            input_first_name = new TextBox();
            text_birth_date = new Label();
            text_gender = new Label();
            text_patronymic = new Label();
            text_second_name = new Label();
            text_first_name = new Label();
            background.SuspendLayout();
            SuspendLayout();
            // 
            // text_registration
            // 
            text_registration.AutoSize = true;
            text_registration.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            text_registration.Location = new Point(94, -10);
            text_registration.Name = "text_registration";
            text_registration.Size = new Size(301, 65);
            text_registration.TabIndex = 1;
            text_registration.Text = "Регистрация";
            // 
            // input_password
            // 
            input_password.Location = new Point(135, 62);
            input_password.Margin = new Padding(3, 2, 3, 2);
            input_password.Name = "input_password";
            input_password.Size = new Size(210, 23);
            input_password.TabIndex = 10;
            // 
            // input_login
            // 
            input_login.BackColor = SystemColors.Window;
            input_login.Location = new Point(135, 16);
            input_login.Margin = new Padding(3, 2, 3, 2);
            input_login.Name = "input_login";
            input_login.Size = new Size(210, 23);
            input_login.TabIndex = 11;
            input_login.TextChanged += input_login_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 243);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 8;
            // 
            // Password_text
            // 
            Password_text.AutoSize = true;
            Password_text.Location = new Point(165, 190);
            Password_text.Name = "Password_text";
            Password_text.Size = new Size(0, 15);
            Password_text.TabIndex = 9;
            // 
            // text_password
            // 
            text_password.AutoSize = true;
            text_password.BackColor = SystemColors.ActiveCaption;
            text_password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_password.Location = new Point(28, 57);
            text_password.Name = "text_password";
            text_password.Size = new Size(78, 25);
            text_password.TabIndex = 6;
            text_password.Text = "Пароль";
            // 
            // text_login
            // 
            text_login.AutoSize = true;
            text_login.BackColor = SystemColors.ActiveCaption;
            text_login.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_login.Location = new Point(28, 16);
            text_login.Name = "text_login";
            text_login.Size = new Size(65, 25);
            text_login.TabIndex = 7;
            text_login.Text = "Логин";
            // 
            // background
            // 
            background.BackColor = SystemColors.ActiveCaption;
            background.Controls.Add(dateTime_birth_date);
            background.Controls.Add(radio_female);
            background.Controls.Add(radio_male);
            background.Controls.Add(input_password);
            background.Controls.Add(b_SignUp);
            background.Controls.Add(input_login);
            background.Controls.Add(input_patronymic);
            background.Controls.Add(text_password);
            background.Controls.Add(input_second_name);
            background.Controls.Add(input_first_name);
            background.Controls.Add(text_birth_date);
            background.Controls.Add(text_gender);
            background.Controls.Add(text_patronymic);
            background.Controls.Add(text_login);
            background.Controls.Add(text_second_name);
            background.Controls.Add(text_first_name);
            background.Location = new Point(50, 57);
            background.Margin = new Padding(3, 2, 3, 2);
            background.Name = "background";
            background.Size = new Size(384, 393);
            background.TabIndex = 12;
            // 
            // dateTime_birth_date
            // 
            dateTime_birth_date.Location = new Point(180, 283);
            dateTime_birth_date.Name = "dateTime_birth_date";
            dateTime_birth_date.Size = new Size(165, 23);
            dateTime_birth_date.TabIndex = 13;
            // 
            // radio_female
            // 
            radio_female.AutoSize = true;
            radio_female.Location = new Point(135, 252);
            radio_female.Name = "radio_female";
            radio_female.Size = new Size(75, 19);
            radio_female.TabIndex = 12;
            radio_female.TabStop = true;
            radio_female.Text = "Женский";
            radio_female.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            radio_male.AutoSize = true;
            radio_male.Location = new Point(268, 252);
            radio_male.Name = "radio_male";
            radio_male.Size = new Size(77, 19);
            radio_male.TabIndex = 12;
            radio_male.TabStop = true;
            radio_male.Text = "Мужской";
            radio_male.UseVisualStyleBackColor = true;
            // 
            // b_SignUp
            // 
            b_SignUp.BackColor = Color.PaleGreen;
            b_SignUp.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_SignUp.Location = new Point(90, 331);
            b_SignUp.Margin = new Padding(3, 2, 3, 2);
            b_SignUp.Name = "b_SignUp";
            b_SignUp.Size = new Size(219, 51);
            b_SignUp.TabIndex = 4;
            b_SignUp.Text = "Зарегистрироваться";
            b_SignUp.UseVisualStyleBackColor = false;
            b_SignUp.Click += b_SignIn_Click;
            // 
            // input_patronymic
            // 
            input_patronymic.BackColor = SystemColors.Window;
            input_patronymic.Location = new Point(135, 208);
            input_patronymic.Margin = new Padding(3, 2, 3, 2);
            input_patronymic.Name = "input_patronymic";
            input_patronymic.Size = new Size(210, 23);
            input_patronymic.TabIndex = 11;
            // 
            // input_second_name
            // 
            input_second_name.BackColor = SystemColors.Window;
            input_second_name.Location = new Point(135, 167);
            input_second_name.Margin = new Padding(3, 2, 3, 2);
            input_second_name.Name = "input_second_name";
            input_second_name.Size = new Size(210, 23);
            input_second_name.TabIndex = 11;
            // 
            // input_first_name
            // 
            input_first_name.BackColor = SystemColors.Window;
            input_first_name.Location = new Point(135, 127);
            input_first_name.Margin = new Padding(3, 2, 3, 2);
            input_first_name.Name = "input_first_name";
            input_first_name.Size = new Size(210, 23);
            input_first_name.TabIndex = 11;
            // 
            // text_birth_date
            // 
            text_birth_date.AutoSize = true;
            text_birth_date.BackColor = SystemColors.ActiveCaption;
            text_birth_date.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_birth_date.Location = new Point(28, 281);
            text_birth_date.Name = "text_birth_date";
            text_birth_date.Size = new Size(146, 25);
            text_birth_date.TabIndex = 7;
            text_birth_date.Text = "Дата рождения";
            // 
            // text_gender
            // 
            text_gender.AutoSize = true;
            text_gender.BackColor = SystemColors.ActiveCaption;
            text_gender.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_gender.Location = new Point(30, 246);
            text_gender.Name = "text_gender";
            text_gender.Size = new Size(47, 25);
            text_gender.TabIndex = 7;
            text_gender.Text = "Пол";
            // 
            // text_patronymic
            // 
            text_patronymic.AutoSize = true;
            text_patronymic.BackColor = SystemColors.ActiveCaption;
            text_patronymic.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_patronymic.Location = new Point(28, 208);
            text_patronymic.Name = "text_patronymic";
            text_patronymic.Size = new Size(93, 25);
            text_patronymic.TabIndex = 7;
            text_patronymic.Text = "Отчество";
            // 
            // text_second_name
            // 
            text_second_name.AutoSize = true;
            text_second_name.BackColor = SystemColors.ActiveCaption;
            text_second_name.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_second_name.Location = new Point(28, 167);
            text_second_name.Name = "text_second_name";
            text_second_name.Size = new Size(91, 25);
            text_second_name.TabIndex = 7;
            text_second_name.Text = "Фамилия";
            // 
            // text_first_name
            // 
            text_first_name.AutoSize = true;
            text_first_name.BackColor = SystemColors.ActiveCaption;
            text_first_name.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_first_name.Location = new Point(28, 127);
            text_first_name.Name = "text_first_name";
            text_first_name.Size = new Size(49, 25);
            text_first_name.TabIndex = 7;
            text_first_name.Text = "Имя";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(label2);
            Controls.Add(Password_text);
            Controls.Add(background);
            Controls.Add(text_registration);
            Name = "Registration";
            Text = "Registration";
            background.ResumeLayout(false);
            background.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label text_registration;
        private TextBox input_password;
        private TextBox input_login;
        private Label label2;
        private Label Password_text;
        private Label text_password;
        private Label text_login;
        private Panel background;
        private Button b_SignUp;
        private TextBox input_patronymic;
        private TextBox input_second_name;
        private TextBox input_first_name;
        private Label text_patronymic;
        private Label text_second_name;
        private Label text_first_name;
        private RadioButton radio_female;
        private RadioButton radio_male;
        private Label text_gender;
        private DateTimePicker dateTime_birth_date;
        private Label text_birth_date;
    }
}