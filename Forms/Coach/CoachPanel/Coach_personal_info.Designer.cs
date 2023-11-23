namespace SchoolDance.Forms
{
    partial class Coach_personal_info
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
            box_danceStyle = new ListBox();
            show_password = new CheckBox();
            dateTime_birth_date = new DateTimePicker();
            radio_female = new RadioButton();
            radio_male = new RadioButton();
            b_Save_changes = new Button();
            input_patronymic = new TextBox();
            input_second_name = new TextBox();
            input_position = new TextBox();
            input_work_experience = new TextBox();
            input_phone_number = new TextBox();
            input_first_name = new TextBox();
            text_birth_date = new Label();
            text_gender = new Label();
            text_patronymic = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            text_second_name = new Label();
            text_first_name = new Label();
            background.SuspendLayout();
            SuspendLayout();
            // 
            // text_registration
            // 
            text_registration.AutoSize = true;
            text_registration.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            text_registration.Location = new Point(255, -8);
            text_registration.Name = "text_registration";
            text_registration.Size = new Size(611, 81);
            text_registration.TabIndex = 1;
            text_registration.Text = "Личная информация";
            // 
            // input_password
            // 
            input_password.Location = new Point(163, 359);
            input_password.Name = "input_password";
            input_password.Size = new Size(275, 27);
            input_password.TabIndex = 10;
            // 
            // input_login
            // 
            input_login.BackColor = SystemColors.Window;
            input_login.Location = new Point(163, 299);
            input_login.Name = "input_login";
            input_login.Size = new Size(275, 27);
            input_login.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 324);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 8;
            // 
            // Password_text
            // 
            Password_text.AutoSize = true;
            Password_text.Location = new Point(189, 253);
            Password_text.Name = "Password_text";
            Password_text.Size = new Size(0, 20);
            Password_text.TabIndex = 9;
            // 
            // text_password
            // 
            text_password.AutoSize = true;
            text_password.BackColor = Color.SteelBlue;
            text_password.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_password.Location = new Point(41, 354);
            text_password.Name = "text_password";
            text_password.Size = new Size(96, 32);
            text_password.TabIndex = 6;
            text_password.Text = "Пароль";
            // 
            // text_login
            // 
            text_login.AutoSize = true;
            text_login.BackColor = Color.SteelBlue;
            text_login.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_login.Location = new Point(41, 299);
            text_login.Name = "text_login";
            text_login.Size = new Size(81, 32);
            text_login.TabIndex = 7;
            text_login.Text = "Логин";
            // 
            // background
            // 
            background.BackColor = Color.SteelBlue;
            background.Controls.Add(box_danceStyle);
            background.Controls.Add(show_password);
            background.Controls.Add(dateTime_birth_date);
            background.Controls.Add(radio_female);
            background.Controls.Add(radio_male);
            background.Controls.Add(input_password);
            background.Controls.Add(b_Save_changes);
            background.Controls.Add(input_login);
            background.Controls.Add(input_patronymic);
            background.Controls.Add(text_password);
            background.Controls.Add(input_second_name);
            background.Controls.Add(input_position);
            background.Controls.Add(input_work_experience);
            background.Controls.Add(input_phone_number);
            background.Controls.Add(input_first_name);
            background.Controls.Add(text_birth_date);
            background.Controls.Add(text_gender);
            background.Controls.Add(text_patronymic);
            background.Controls.Add(text_login);
            background.Controls.Add(label5);
            background.Controls.Add(label3);
            background.Controls.Add(label4);
            background.Controls.Add(label1);
            background.Controls.Add(text_second_name);
            background.Controls.Add(text_first_name);
            background.Location = new Point(73, 76);
            background.Name = "background";
            background.Size = new Size(947, 556);
            background.TabIndex = 12;
            // 
            // box_danceStyle
            // 
            box_danceStyle.FormattingEnabled = true;
            box_danceStyle.ItemHeight = 20;
            box_danceStyle.Location = new Point(708, 83);
            box_danceStyle.Name = "box_danceStyle";
            box_danceStyle.SelectionMode = SelectionMode.MultiSimple;
            box_danceStyle.Size = new Size(205, 184);
            box_danceStyle.TabIndex = 32;
            // 
            // show_password
            // 
            show_password.AutoSize = true;
            show_password.Location = new Point(163, 392);
            show_password.Name = "show_password";
            show_password.Size = new Size(150, 24);
            show_password.TabIndex = 14;
            show_password.Text = "Показать пароль";
            show_password.UseVisualStyleBackColor = true;
            show_password.CheckedChanged += show_password_CheckedChanged;
            // 
            // dateTime_birth_date
            // 
            dateTime_birth_date.Location = new Point(243, 240);
            dateTime_birth_date.Margin = new Padding(3, 4, 3, 4);
            dateTime_birth_date.Name = "dateTime_birth_date";
            dateTime_birth_date.Size = new Size(195, 27);
            dateTime_birth_date.TabIndex = 13;
            // 
            // radio_female
            // 
            radio_female.AutoSize = true;
            radio_female.Location = new Point(161, 196);
            radio_female.Margin = new Padding(3, 4, 3, 4);
            radio_female.Name = "radio_female";
            radio_female.Size = new Size(92, 24);
            radio_female.TabIndex = 12;
            radio_female.TabStop = true;
            radio_female.Text = "Женский";
            radio_female.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            radio_male.AutoSize = true;
            radio_male.Location = new Point(275, 196);
            radio_male.Margin = new Padding(3, 4, 3, 4);
            radio_male.Name = "radio_male";
            radio_male.Size = new Size(93, 24);
            radio_male.TabIndex = 12;
            radio_male.TabStop = true;
            radio_male.Text = "Мужской";
            radio_male.UseVisualStyleBackColor = true;
            // 
            // b_Save_changes
            // 
            b_Save_changes.BackColor = Color.CadetBlue;
            b_Save_changes.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_Save_changes.Location = new Point(290, 451);
            b_Save_changes.Name = "b_Save_changes";
            b_Save_changes.Size = new Size(395, 68);
            b_Save_changes.TabIndex = 4;
            b_Save_changes.Text = "Сохранить изменения";
            b_Save_changes.UseVisualStyleBackColor = false;
            b_Save_changes.Click += b_SignIn_Click;
            // 
            // input_patronymic
            // 
            input_patronymic.BackColor = SystemColors.Window;
            input_patronymic.Location = new Point(161, 137);
            input_patronymic.Name = "input_patronymic";
            input_patronymic.Size = new Size(277, 27);
            input_patronymic.TabIndex = 11;
            // 
            // input_second_name
            // 
            input_second_name.BackColor = SystemColors.Window;
            input_second_name.Location = new Point(161, 83);
            input_second_name.Name = "input_second_name";
            input_second_name.Size = new Size(277, 27);
            input_second_name.TabIndex = 11;
            // 
            // input_position
            // 
            input_position.BackColor = SystemColors.Window;
            input_position.ForeColor = SystemColors.GrayText;
            input_position.Location = new Point(708, 354);
            input_position.Name = "input_position";
            input_position.ReadOnly = true;
            input_position.Size = new Size(205, 27);
            input_position.TabIndex = 11;
            input_position.Text = " ";
            // 
            // input_work_experience
            // 
            input_work_experience.BackColor = SystemColors.Window;
            input_work_experience.ForeColor = SystemColors.GrayText;
            input_work_experience.Location = new Point(708, 299);
            input_work_experience.Name = "input_work_experience";
            input_work_experience.ReadOnly = true;
            input_work_experience.Size = new Size(205, 27);
            input_work_experience.TabIndex = 11;
            input_work_experience.Text = " ";
            // 
            // input_phone_number
            // 
            input_phone_number.BackColor = SystemColors.Window;
            input_phone_number.Location = new Point(708, 27);
            input_phone_number.Name = "input_phone_number";
            input_phone_number.Size = new Size(205, 27);
            input_phone_number.TabIndex = 11;
            input_phone_number.Text = " ";
            // 
            // input_first_name
            // 
            input_first_name.BackColor = SystemColors.Window;
            input_first_name.Location = new Point(161, 29);
            input_first_name.Name = "input_first_name";
            input_first_name.Size = new Size(277, 27);
            input_first_name.TabIndex = 11;
            // 
            // text_birth_date
            // 
            text_birth_date.AutoSize = true;
            text_birth_date.BackColor = Color.SteelBlue;
            text_birth_date.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_birth_date.Location = new Point(39, 235);
            text_birth_date.Name = "text_birth_date";
            text_birth_date.Size = new Size(184, 32);
            text_birth_date.TabIndex = 7;
            text_birth_date.Text = "Дата рождения";
            // 
            // text_gender
            // 
            text_gender.AutoSize = true;
            text_gender.BackColor = Color.SteelBlue;
            text_gender.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_gender.Location = new Point(41, 188);
            text_gender.Name = "text_gender";
            text_gender.Size = new Size(58, 32);
            text_gender.TabIndex = 7;
            text_gender.Text = "Пол";
            // 
            // text_patronymic
            // 
            text_patronymic.AutoSize = true;
            text_patronymic.BackColor = Color.SteelBlue;
            text_patronymic.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_patronymic.Location = new Point(39, 137);
            text_patronymic.Name = "text_patronymic";
            text_patronymic.Size = new Size(117, 32);
            text_patronymic.TabIndex = 7;
            text_patronymic.Text = "Отчество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.SteelBlue;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(528, 354);
            label5.Name = "label5";
            label5.Size = new Size(137, 32);
            label5.TabIndex = 7;
            label5.Text = "Должность";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SteelBlue;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(528, 83);
            label3.Name = "label3";
            label3.Size = new Size(163, 32);
            label3.TabIndex = 7;
            label3.Text = "Стили танцев";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.SteelBlue;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(528, 292);
            label4.Name = "label4";
            label4.Size = new Size(157, 32);
            label4.TabIndex = 7;
            label4.Text = "Стаж работы";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SteelBlue;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(528, 22);
            label1.Name = "label1";
            label1.Size = new Size(110, 32);
            label1.TabIndex = 7;
            label1.Text = "Телефон";
            // 
            // text_second_name
            // 
            text_second_name.AutoSize = true;
            text_second_name.BackColor = Color.SteelBlue;
            text_second_name.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_second_name.Location = new Point(39, 83);
            text_second_name.Name = "text_second_name";
            text_second_name.Size = new Size(113, 32);
            text_second_name.TabIndex = 7;
            text_second_name.Text = "Фамилия";
            // 
            // text_first_name
            // 
            text_first_name.AutoSize = true;
            text_first_name.BackColor = Color.SteelBlue;
            text_first_name.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            text_first_name.Location = new Point(39, 29);
            text_first_name.Name = "text_first_name";
            text_first_name.Size = new Size(61, 32);
            text_first_name.TabIndex = 7;
            text_first_name.Text = "Имя";
            // 
            // Coach_personal_info
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(1066, 642);
            Controls.Add(label2);
            Controls.Add(Password_text);
            Controls.Add(background);
            Controls.Add(text_registration);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Coach_personal_info";
            Text = "Школа танцев";
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
        private Button b_Save_changes;
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
        private CheckBox show_password;
        private TextBox input_phone_number;
        private Label label3;
        private Label label1;
        private ListBox box_danceStyle;
        private TextBox input_position;
        private TextBox input_work_experience;
        private Label label5;
        private Label label4;
    }
}