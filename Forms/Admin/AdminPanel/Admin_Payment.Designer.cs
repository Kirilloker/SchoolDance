namespace SchoolDance.Forms
{
    partial class Admin_Payment
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
            paymentBindingSource = new BindingSource(components);
            danceStyleBindingSource = new BindingSource(components);
            danceHallBindingSource = new BindingSource(components);
            b_del = new Button();
            bg_date = new Panel();
            input_id_delete = new TextBox();
            label_delete = new Label();
            bg_delete = new Panel();
            bg_Create = new Panel();
            list_lesson = new ComboBox();
            list_student = new ComboBox();
            date_end_payment = new DateTimePicker();
            b_add_new_rows = new Button();
            label1 = new Label();
            label2 = new Label();
            text_login = new Label();
            text_name_data = new Label();
            eventDanceBindingSource = new BindingSource(components);
            paymentBindingSource1 = new BindingSource(components);
            paymentBindingSource2 = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lessonIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateendsubscriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)danceStyleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)danceHallBindingSource).BeginInit();
            bg_date.SuspendLayout();
            bg_delete.SuspendLayout();
            bg_Create.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eventDanceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)paymentBindingSource2).BeginInit();
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
            DataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, studentIdDataGridViewTextBoxColumn, lessonIdDataGridViewTextBoxColumn, dateendsubscriptionDataGridViewTextBoxColumn });
            DataGrid.DataSource = paymentBindingSource2;
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
            // paymentBindingSource
            // 
            paymentBindingSource.DataSource = typeof(TopUp);
            // 
            // danceStyleBindingSource
            // 
            danceStyleBindingSource.DataSource = typeof(DanceStyle);
            // 
            // danceHallBindingSource
            // 
            danceHallBindingSource.DataSource = typeof(DanceHall);
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
            bg_Create.Controls.Add(list_lesson);
            bg_Create.Controls.Add(list_student);
            bg_Create.Controls.Add(date_end_payment);
            bg_Create.Controls.Add(b_add_new_rows);
            bg_Create.Controls.Add(label1);
            bg_Create.Controls.Add(label2);
            bg_Create.Controls.Add(text_login);
            bg_Create.Location = new Point(13, 69);
            bg_Create.Name = "bg_Create";
            bg_Create.Size = new Size(885, 174);
            bg_Create.TabIndex = 5;
            // 
            // list_lesson
            // 
            list_lesson.FormattingEnabled = true;
            list_lesson.Location = new Point(452, 50);
            list_lesson.Name = "list_lesson";
            list_lesson.Size = new Size(250, 28);
            list_lesson.TabIndex = 20;
            // 
            // list_student
            // 
            list_student.FormattingEnabled = true;
            list_student.Location = new Point(452, 12);
            list_student.Name = "list_student";
            list_student.Size = new Size(250, 28);
            list_student.TabIndex = 20;
            // 
            // date_end_payment
            // 
            date_end_payment.Location = new Point(452, 89);
            date_end_payment.Name = "date_end_payment";
            date_end_payment.Size = new Size(250, 27);
            date_end_payment.TabIndex = 19;
            // 
            // b_add_new_rows
            // 
            b_add_new_rows.BackColor = Color.DarkKhaki;
            b_add_new_rows.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            b_add_new_rows.Location = new Point(396, 122);
            b_add_new_rows.Name = "b_add_new_rows";
            b_add_new_rows.Size = new Size(122, 43);
            b_add_new_rows.TabIndex = 0;
            b_add_new_rows.Text = "Добавить";
            b_add_new_rows.UseVisualStyleBackColor = false;
            b_add_new_rows.Click += b_add_new_rows_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Beige;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(241, 89);
            label1.Name = "label1";
            label1.Size = new Size(200, 23);
            label1.TabIndex = 14;
            label1.Text = "Дата окончания оплаты";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Beige;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(241, 50);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 18;
            label2.Text = "Занятие";
            // 
            // text_login
            // 
            text_login.AutoSize = true;
            text_login.BackColor = Color.Beige;
            text_login.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            text_login.Location = new Point(241, 12);
            text_login.Name = "text_login";
            text_login.Size = new Size(71, 23);
            text_login.TabIndex = 18;
            text_login.Text = "Студент";
            // 
            // text_name_data
            // 
            text_name_data.AutoSize = true;
            text_name_data.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            text_name_data.Location = new Point(415, 9);
            text_name_data.Name = "text_name_data";
            text_name_data.Size = new Size(116, 41);
            text_name_data.TabIndex = 6;
            text_name_data.Text = "Оплата";
            // 
            // eventDanceBindingSource
            // 
            eventDanceBindingSource.DataSource = typeof(EventDance);
            // 
            // paymentBindingSource1
            // 
            paymentBindingSource1.DataSource = typeof(Payment);
            // 
            // paymentBindingSource2
            // 
            paymentBindingSource2.DataSource = typeof(Payment);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            studentIdDataGridViewTextBoxColumn.DataPropertyName = "studentId";
            studentIdDataGridViewTextBoxColumn.HeaderText = "studentId";
            studentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            studentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // lessonIdDataGridViewTextBoxColumn
            // 
            lessonIdDataGridViewTextBoxColumn.DataPropertyName = "lessonId";
            lessonIdDataGridViewTextBoxColumn.HeaderText = "lessonId";
            lessonIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            lessonIdDataGridViewTextBoxColumn.Name = "lessonIdDataGridViewTextBoxColumn";
            lessonIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateendsubscriptionDataGridViewTextBoxColumn
            // 
            dateendsubscriptionDataGridViewTextBoxColumn.DataPropertyName = "date_end_subscription";
            dateendsubscriptionDataGridViewTextBoxColumn.HeaderText = "date_end_subscription";
            dateendsubscriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateendsubscriptionDataGridViewTextBoxColumn.Name = "dateendsubscriptionDataGridViewTextBoxColumn";
            dateendsubscriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // Admin_Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 686);
            Controls.Add(text_name_data);
            Controls.Add(bg_Create);
            Controls.Add(bg_delete);
            Controls.Add(bg_date);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin_Payment";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)danceStyleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)danceHallBindingSource).EndInit();
            bg_date.ResumeLayout(false);
            bg_delete.ResumeLayout(false);
            bg_delete.PerformLayout();
            bg_Create.ResumeLayout(false);
            bg_Create.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eventDanceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)paymentBindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource studentBindingSource;
        private DataGridView DataGrid;
        private Button b_del;
        private Panel bg_date;
        private DataGridViewCheckBoxColumn isMaleDataGridViewCheckBoxColumn;
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
        private TextBox input_password;
        private Label text_first_name;
        private TextBox input_login;
        private BindingSource danceHallBindingSource;
        private BindingSource danceStyleBindingSource;
        private ComboBox list_student;
        private BindingSource paymentBindingSource;
        private DataGridViewTextBoxColumn endDateTopUpDataGridViewTextBoxColumn;
        private ComboBox list_lesson;
        private DateTimePicker date_end_payment;
        private Label label1;
        private Label label2;
        private BindingSource paymentBindingSource1;
        private BindingSource eventDanceBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lessonIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateendsubscriptionDataGridViewTextBoxColumn;
        private BindingSource paymentBindingSource2;
    }
}