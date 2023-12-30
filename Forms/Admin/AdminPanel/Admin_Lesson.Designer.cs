namespace SchoolDance.Forms
{
    partial class Admin_Lesson
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
            coachBindingSource = new BindingSource(components);
            b_del = new Button();
            bg_date = new Panel();
            DataGrid = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            className = new DataGridViewTextBoxColumn();
            weekdays = new DataGridViewTextBoxColumn();
            danceHallId = new DataGridViewTextBoxColumn();
            groupId = new DataGridViewTextBoxColumn();
            coachId = new DataGridViewTextBoxColumn();
            DanceStyleId = new DataGridViewTextBoxColumn();
            lessonBindingSource = new BindingSource(components);
            list_coach = new ComboBox();
            label5 = new Label();
            input_id_delete = new TextBox();
            label_delete = new Label();
            bg_delete = new Panel();
            bg_Create = new Panel();
            input_description = new TextBox();
            list_style = new ComboBox();
            label4 = new Label();
            list_danceHall = new ComboBox();
            label2 = new Label();
            list_weekdays = new CheckedListBox();
            label1 = new Label();
            b_add_new_rows = new Button();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            text_login = new Label();
            input_time = new TextBox();
            input_price = new TextBox();
            input_name = new TextBox();
            text_name_data = new Label();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coachBindingSource).BeginInit();
            bg_date.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lessonBindingSource).BeginInit();
            bg_delete.SuspendLayout();
            bg_Create.SuspendLayout();
            SuspendLayout();
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Student);
            // 
            // coachBindingSource
            // 
            coachBindingSource.DataSource = typeof(Coach);
            // 
            // b_del
            // 
            b_del.BackColor = Color.Brown;
            b_del.Location = new Point(495, 17);
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
            bg_date.Location = new Point(12, 454);
            bg_date.Margin = new Padding(3, 4, 3, 4);
            bg_date.Name = "bg_date";
            bg_date.Size = new Size(887, 240);
            bg_date.TabIndex = 2;
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AutoGenerateColumns = false;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, className, weekdays, danceHallId, groupId, coachId, DanceStyleId });
            DataGrid.DataSource = lessonBindingSource;
            DataGrid.Dock = DockStyle.Fill;
            DataGrid.Location = new Point(0, 0);
            DataGrid.Name = "DataGrid";
            DataGrid.RowHeadersWidth = 51;
            DataGrid.RowTemplate.Height = 29;
            DataGrid.Size = new Size(887, 240);
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
            // className
            // 
            className.DataPropertyName = "className";
            className.HeaderText = "className";
            className.MinimumWidth = 6;
            className.Name = "className";
            className.Width = 125;
            // 
            // weekdays
            // 
            weekdays.DataPropertyName = "weekdays";
            weekdays.HeaderText = "weekdays";
            weekdays.MinimumWidth = 6;
            weekdays.Name = "weekdays";
            weekdays.Width = 125;
            // 
            // danceHallId
            // 
            danceHallId.DataPropertyName = "danceHallId";
            danceHallId.HeaderText = "danceHallId";
            danceHallId.MinimumWidth = 6;
            danceHallId.Name = "danceHallId";
            danceHallId.Width = 125;
            // 
            // groupId
            // 
            groupId.DataPropertyName = "groupId";
            groupId.HeaderText = "groupId";
            groupId.MinimumWidth = 6;
            groupId.Name = "groupId";
            groupId.Width = 125;
            // 
            // coachId
            // 
            coachId.DataPropertyName = "coachId";
            coachId.HeaderText = "coachId";
            coachId.MinimumWidth = 6;
            coachId.Name = "coachId";
            coachId.Width = 125;
            // 
            // DanceStyleId
            // 
            DanceStyleId.DataPropertyName = "DanceStyleId";
            DanceStyleId.HeaderText = "DanceStyleId";
            DanceStyleId.MinimumWidth = 6;
            DanceStyleId.Name = "DanceStyleId";
            DanceStyleId.Width = 125;
            // 
            // lessonBindingSource
            // 
            lessonBindingSource.DataSource = typeof(Lesson);
            // 
            // list_coach
            // 
            list_coach.FormattingEnabled = true;
            list_coach.Location = new Point(576, 182);
            list_coach.Name = "list_coach";
            list_coach.Size = new Size(278, 28);
            list_coach.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Beige;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(481, 183);
            label5.Name = "label5";
            label5.Size = new Size(67, 23);
            label5.TabIndex = 33;
            label5.Text = "Тренер";
            // 
            // input_id_delete
            // 
            input_id_delete.Location = new Point(351, 17);
            input_id_delete.Name = "input_id_delete";
            input_id_delete.Size = new Size(125, 27);
            input_id_delete.TabIndex = 1;
            // 
            // label_delete
            // 
            label_delete.AutoSize = true;
            label_delete.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_delete.Location = new Point(19, 16);
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
            bg_delete.Location = new Point(12, 396);
            bg_delete.Name = "bg_delete";
            bg_delete.Size = new Size(887, 60);
            bg_delete.TabIndex = 4;
            // 
            // bg_Create
            // 
            bg_Create.BackColor = Color.Beige;
            bg_Create.Controls.Add(list_coach);
            bg_Create.Controls.Add(label5);
            bg_Create.Controls.Add(input_description);
            bg_Create.Controls.Add(list_style);
            bg_Create.Controls.Add(label4);
            bg_Create.Controls.Add(list_danceHall);
            bg_Create.Controls.Add(label2);
            bg_Create.Controls.Add(list_weekdays);
            bg_Create.Controls.Add(label1);
            bg_Create.Controls.Add(b_add_new_rows);
            bg_Create.Controls.Add(label3);
            bg_Create.Controls.Add(label6);
            bg_Create.Controls.Add(label7);
            bg_Create.Controls.Add(text_login);
            bg_Create.Controls.Add(input_time);
            bg_Create.Controls.Add(input_price);
            bg_Create.Controls.Add(input_name);
            bg_Create.Location = new Point(13, 53);
            bg_Create.Name = "bg_Create";
            bg_Create.Size = new Size(885, 353);
            bg_Create.TabIndex = 5;
            // 
            // input_description
            // 
            input_description.Location = new Point(576, 229);
            input_description.Name = "input_description";
            input_description.Size = new Size(278, 27);
            input_description.TabIndex = 50;
            // 
            // list_style
            // 
            list_style.FormattingEnabled = true;
            list_style.Location = new Point(203, 122);
            list_style.Name = "list_style";
            list_style.Size = new Size(231, 28);
            list_style.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Beige;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 127);
            label4.Name = "label4";
            label4.Size = new Size(56, 23);
            label4.TabIndex = 46;
            label4.Text = "Стиль";
            // 
            // list_danceHall
            // 
            list_danceHall.FormattingEnabled = true;
            list_danceHall.Location = new Point(203, 64);
            list_danceHall.Name = "list_danceHall";
            list_danceHall.Size = new Size(231, 28);
            list_danceHall.TabIndex = 49;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Beige;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 69);
            label2.Name = "label2";
            label2.Size = new Size(37, 23);
            label2.TabIndex = 47;
            label2.Text = "Зал";
            // 
            // list_weekdays
            // 
            list_weekdays.FormattingEnabled = true;
            list_weekdays.Items.AddRange(new object[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" });
            list_weekdays.Location = new Point(666, 7);
            list_weekdays.Name = "list_weekdays";
            list_weekdays.Size = new Size(188, 158);
            list_weekdays.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Beige;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(481, 15);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 44;
            label1.Text = "Дни недели";
            // 
            // b_add_new_rows
            // 
            b_add_new_rows.BackColor = Color.DarkKhaki;
            b_add_new_rows.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            b_add_new_rows.Location = new Point(408, 287);
            b_add_new_rows.Name = "b_add_new_rows";
            b_add_new_rows.Size = new Size(122, 43);
            b_add_new_rows.TabIndex = 36;
            b_add_new_rows.Text = "Создать";
            b_add_new_rows.UseVisualStyleBackColor = false;
            b_add_new_rows.Click += b_add_new_rows_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Beige;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(481, 233);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 37;
            label3.Text = "Описание";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Beige;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(30, 233);
            label6.Name = "label6";
            label6.Size = new Size(121, 23);
            label6.TabIndex = 38;
            label6.Text = "Время начала";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Beige;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(30, 183);
            label7.Name = "label7";
            label7.Size = new Size(94, 23);
            label7.TabIndex = 39;
            label7.Text = "Стоимость";
            // 
            // text_login
            // 
            text_login.AutoSize = true;
            text_login.BackColor = Color.Beige;
            text_login.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            text_login.Location = new Point(30, 11);
            text_login.Name = "text_login";
            text_login.Size = new Size(86, 23);
            text_login.TabIndex = 40;
            text_login.Text = "Название";
            // 
            // input_time
            // 
            input_time.BackColor = SystemColors.Window;
            input_time.Location = new Point(203, 229);
            input_time.Name = "input_time";
            input_time.Size = new Size(231, 27);
            input_time.TabIndex = 41;
            // 
            // input_price
            // 
            input_price.BackColor = SystemColors.Window;
            input_price.Location = new Point(203, 179);
            input_price.Name = "input_price";
            input_price.Size = new Size(231, 27);
            input_price.TabIndex = 42;
            // 
            // input_name
            // 
            input_name.BackColor = SystemColors.Window;
            input_name.Location = new Point(203, 11);
            input_name.Name = "input_name";
            input_name.Size = new Size(231, 27);
            input_name.TabIndex = 43;
            // 
            // text_name_data
            // 
            text_name_data.AutoSize = true;
            text_name_data.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            text_name_data.Location = new Point(405, 9);
            text_name_data.Name = "text_name_data";
            text_name_data.Size = new Size(126, 41);
            text_name_data.TabIndex = 6;
            text_name_data.Text = "Занятие";
            // 
            // Admin_Lesson
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
            Name = "Admin_Lesson";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)coachBindingSource).EndInit();
            bg_date.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)lessonBindingSource).EndInit();
            bg_delete.ResumeLayout(false);
            bg_delete.PerformLayout();
            bg_Create.ResumeLayout(false);
            bg_Create.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource studentBindingSource;
        private Button b_del;
        private Panel bg_date;
        private DataGridViewCheckBoxColumn isMaleDataGridViewCheckBoxColumn;
        private TextBox input_id_delete;
        private Label label_delete;
        private Panel bg_delete;
        private Panel bg_Create;
        private Label text_name_data;
        private BindingSource coachBindingSource;
        private DataGridView DataGrid;
        private ComboBox list_coach;
        private Label label5;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn className;
        private DataGridViewTextBoxColumn weekdays;
        private DataGridViewTextBoxColumn danceHallId;
        private DataGridViewTextBoxColumn groupId;
        private DataGridViewTextBoxColumn coachId;
        private DataGridViewTextBoxColumn DanceStyleId;
        private BindingSource lessonBindingSource;
        private TextBox input_description;
        private ComboBox list_style;
        private Label label4;
        private ComboBox list_danceHall;
        private Label label2;
        private CheckedListBox list_weekdays;
        private Label label1;
        private Button b_add_new_rows;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label text_login;
        private TextBox input_time;
        private TextBox input_price;
        private TextBox input_name;
    }
}