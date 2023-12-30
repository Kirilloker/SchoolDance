namespace SchoolDance.Forms
{
    partial class Admin_Student
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
            components = new System.ComponentModel.Container();
            studentBindingSource = new BindingSource(components);
            DataGrid = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typePersonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            loginDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            b_del = new Button();
            bg_date = new Panel();
            dateTime_birth_date = new DateTimePicker();
            radio_female = new RadioButton();
            radio_male = new RadioButton();
            text_gender = new Label();
            text_birth_date = new Label();
            input_id_delete = new TextBox();
            label_delete = new Label();
            bg_delete = new Panel();
            bg_Create = new Panel();
            b_add_new_rows = new Button();
            text_login = new Label();
            input_balance = new Label();
            input_password = new TextBox();
            label1 = new Label();
            text_first_name = new Label();
            input_login = new TextBox();
            input_balance_1 = new TextBox();
            input_first_name = new TextBox();
            text_name_data = new Label();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            bg_date.SuspendLayout();
            bg_delete.SuspendLayout();
            bg_Create.SuspendLayout();
            SuspendLayout();
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Student);
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AllowUserToDeleteRows = false;
            DataGrid.AllowUserToResizeRows = false;
            DataGrid.AutoGenerateColumns = false;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, typePersonDataGridViewTextBoxColumn, loginDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn });
            DataGrid.DataSource = studentBindingSource;
            DataGrid.Dock = DockStyle.Fill;
            DataGrid.Location = new Point(0, 0);
            DataGrid.Margin = new Padding(3, 4, 3, 4);
            DataGrid.Name = "DataGrid";
            DataGrid.RowHeadersWidth = 51;
            DataGrid.RowTemplate.Height = 25;
            DataGrid.Size = new Size(887, 357);
            DataGrid.TabIndex = 0;
            DataGrid.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "fullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "fullName";
            fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            dateDataGridViewTextBoxColumn.HeaderText = "date";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // typePersonDataGridViewTextBoxColumn
            // 
            typePersonDataGridViewTextBoxColumn.DataPropertyName = "typePerson";
            typePersonDataGridViewTextBoxColumn.HeaderText = "typePerson";
            typePersonDataGridViewTextBoxColumn.MinimumWidth = 6;
            typePersonDataGridViewTextBoxColumn.Name = "typePersonDataGridViewTextBoxColumn";
            typePersonDataGridViewTextBoxColumn.Width = 125;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            loginDataGridViewTextBoxColumn.HeaderText = "login";
            loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            passwordDataGridViewTextBoxColumn.HeaderText = "password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // b_del
            // 
            b_del.BackColor = Color.Brown;
            b_del.Location = new Point(453, 12);
            b_del.Margin = new Padding(3, 4, 3, 4);
            b_del.Name = "b_del";
            b_del.Size = new Size(86, 31);
            b_del.TabIndex = 1;
            b_del.Text = "Удалить";
            b_del.UseVisualStyleBackColor = false;
            b_del.Click += b_del_Click;
            // 
            // bg_date
            // 
            bg_date.BackColor = SystemColors.ActiveCaption;
            bg_date.Controls.Add(DataGrid);
            bg_date.Location = new Point(12, 302);
            bg_date.Margin = new Padding(3, 4, 3, 4);
            bg_date.Name = "bg_date";
            bg_date.Size = new Size(887, 357);
            bg_date.TabIndex = 2;
            // 
            // dateTime_birth_date
            // 
            dateTime_birth_date.Location = new Point(577, 66);
            dateTime_birth_date.Margin = new Padding(3, 4, 3, 4);
            dateTime_birth_date.Name = "dateTime_birth_date";
            dateTime_birth_date.Size = new Size(188, 27);
            dateTime_birth_date.TabIndex = 28;
            // 
            // radio_female
            // 
            radio_female.AutoSize = true;
            radio_female.Location = new Point(577, 20);
            radio_female.Margin = new Padding(3, 4, 3, 4);
            radio_female.Name = "radio_female";
            radio_female.Size = new Size(92, 24);
            radio_female.TabIndex = 26;
            radio_female.TabStop = true;
            radio_female.Text = "Женский";
            radio_female.UseVisualStyleBackColor = true;
            // 
            // radio_male
            // 
            radio_male.AutoSize = true;
            radio_male.Location = new Point(675, 20);
            radio_male.Margin = new Padding(3, 4, 3, 4);
            radio_male.Name = "radio_male";
            radio_male.Size = new Size(93, 24);
            radio_male.TabIndex = 27;
            radio_male.TabStop = true;
            radio_male.Text = "Мужской";
            radio_male.UseVisualStyleBackColor = true;
            // 
            // text_gender
            // 
            text_gender.AutoSize = true;
            text_gender.BackColor = Color.Beige;
            text_gender.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            text_gender.Location = new Point(403, 21);
            text_gender.Name = "text_gender";
            text_gender.Size = new Size(41, 23);
            text_gender.TabIndex = 16;
            text_gender.Text = "Пол";
            // 
            // text_birth_date
            // 
            text_birth_date.AutoSize = true;
            text_birth_date.BackColor = Color.Beige;
            text_birth_date.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            text_birth_date.Location = new Point(403, 69);
            text_birth_date.Name = "text_birth_date";
            text_birth_date.Size = new Size(132, 23);
            text_birth_date.TabIndex = 15;
            text_birth_date.Text = "Дата рождения";
            // 
            // input_id_delete
            // 
            input_id_delete.Location = new Point(309, 12);
            input_id_delete.Name = "input_id_delete";
            input_id_delete.Size = new Size(125, 27);
            input_id_delete.TabIndex = 1;
            // 
            // label_delete
            // 
            label_delete.AutoSize = true;
            label_delete.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_delete.Location = new Point(1, 11);
            label_delete.Name = "label_delete";
            label_delete.Size = new Size(302, 25);
            label_delete.TabIndex = 3;
            label_delete.Text = "ID объекта, который будет удален: ";
            // 
            // bg_delete
            // 
            bg_delete.BackColor = SystemColors.AppWorkspace;
            bg_delete.Controls.Add(label_delete);
            bg_delete.Controls.Add(input_id_delete);
            bg_delete.Controls.Add(b_del);
            bg_delete.Location = new Point(12, 244);
            bg_delete.Name = "bg_delete";
            bg_delete.Size = new Size(887, 60);
            bg_delete.TabIndex = 4;
            // 
            // bg_Create
            // 
            bg_Create.BackColor = Color.Beige;
            bg_Create.Controls.Add(b_add_new_rows);
            bg_Create.Controls.Add(dateTime_birth_date);
            bg_Create.Controls.Add(text_login);
            bg_Create.Controls.Add(text_birth_date);
            bg_Create.Controls.Add(radio_female);
            bg_Create.Controls.Add(input_balance);
            bg_Create.Controls.Add(radio_male);
            bg_Create.Controls.Add(input_password);
            bg_Create.Controls.Add(text_gender);
            bg_Create.Controls.Add(label1);
            bg_Create.Controls.Add(text_first_name);
            bg_Create.Controls.Add(input_login);
            bg_Create.Controls.Add(input_balance_1);
            bg_Create.Controls.Add(input_first_name);
            bg_Create.Location = new Point(13, 69);
            bg_Create.Name = "bg_Create";
            bg_Create.Size = new Size(885, 174);
            bg_Create.TabIndex = 5;
            // 
            // b_add_new_rows
            // 
            b_add_new_rows.BackColor = Color.DarkKhaki;
            b_add_new_rows.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            b_add_new_rows.Location = new Point(613, 115);
            b_add_new_rows.Name = "b_add_new_rows";
            b_add_new_rows.Size = new Size(122, 43);
            b_add_new_rows.TabIndex = 0;
            b_add_new_rows.Text = "Добавить";
            b_add_new_rows.UseVisualStyleBackColor = false;
            b_add_new_rows.Click += b_add_new_rows_Click;
            // 
            // text_login
            // 
            text_login.AutoSize = true;
            text_login.BackColor = Color.Beige;
            text_login.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            text_login.Location = new Point(18, 12);
            text_login.Name = "text_login";
            text_login.Size = new Size(58, 23);
            text_login.TabIndex = 18;
            text_login.Text = "Логин";
            // 
            // input_balance
            // 
            input_balance.AutoSize = true;
            input_balance.BackColor = Color.Beige;
            input_balance.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            input_balance.Location = new Point(18, 45);
            input_balance.Name = "input_balance";
            input_balance.Size = new Size(69, 23);
            input_balance.TabIndex = 14;
            input_balance.Text = "Пароль";
            // 
            // input_password
            // 
            input_password.Location = new Point(132, 44);
            input_password.Name = "input_password";
            input_password.Size = new Size(239, 27);
            input_password.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Beige;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 115);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 20;
            label1.Text = "Баланс";
            // 
            // text_first_name
            // 
            text_first_name.AutoSize = true;
            text_first_name.BackColor = Color.Beige;
            text_first_name.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            text_first_name.Location = new Point(18, 81);
            text_first_name.Name = "text_first_name";
            text_first_name.Size = new Size(48, 23);
            text_first_name.TabIndex = 20;
            text_first_name.Text = "ФИО";
            // 
            // input_login
            // 
            input_login.BackColor = SystemColors.Window;
            input_login.Location = new Point(132, 11);
            input_login.Name = "input_login";
            input_login.Size = new Size(239, 27);
            input_login.TabIndex = 22;
            // 
            // input_balance_1
            // 
            input_balance_1.BackColor = SystemColors.Window;
            input_balance_1.Location = new Point(132, 114);
            input_balance_1.Name = "input_balance_1";
            input_balance_1.Size = new Size(239, 27);
            input_balance_1.TabIndex = 25;
            // 
            // input_first_name
            // 
            input_first_name.BackColor = SystemColors.Window;
            input_first_name.Location = new Point(132, 77);
            input_first_name.Name = "input_first_name";
            input_first_name.Size = new Size(239, 27);
            input_first_name.TabIndex = 25;
            // 
            // text_name_data
            // 
            text_name_data.AutoSize = true;
            text_name_data.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            text_name_data.Location = new Point(405, 9);
            text_name_data.Name = "text_name_data";
            text_name_data.Size = new Size(146, 41);
            text_name_data.TabIndex = 6;
            text_name_data.Text = "Студенты";
            // 
            // Admin_Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(911, 686);
            Controls.Add(text_name_data);
            Controls.Add(bg_Create);
            Controls.Add(bg_delete);
            Controls.Add(bg_date);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin_Student";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            bg_date.ResumeLayout(false);
            bg_delete.ResumeLayout(false);
            bg_delete.PerformLayout();
            bg_Create.ResumeLayout(false);
            bg_Create.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource studentBindingSource;
        private DataGridView DataGrid;
        private Button b_del;
        private Panel bg_date;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isMaleDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn typePersonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private TextBox input_id_delete;
        private Label label_delete;
        private Panel bg_delete;
        private Panel bg_Create;
        private Label text_name_data;
        private Button b_add_new_rows;
        private DateTimePicker dateTime_birth_date;
        private RadioButton radio_female;
        private RadioButton radio_male;
        private Label text_gender;
        private Label text_birth_date;
        private Label text_login;
        private Label input_balance;
        private TextBox input_password;
        private Label text_first_name;
        private TextBox input_login;
        private TextBox input_first_name;
        private Label label1;
        private TextBox input_balance_1;
    }
}