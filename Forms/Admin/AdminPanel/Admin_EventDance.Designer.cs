namespace SchoolDance.Forms
{
    partial class Admin_EventDance
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
            EventDanceBindingSource = new BindingSource(components);
            input_id_delete = new TextBox();
            label_delete = new Label();
            bg_delete = new Panel();
            bg_Create = new Panel();
            date_event = new DateTimePicker();
            b_add_new_rows = new Button();
            label2 = new Label();
            label1 = new Label();
            text_login = new Label();
            input_description = new TextBox();
            input_name = new TextBox();
            text_name_data = new Label();
            eventDanceBindingSource1 = new BindingSource(components);
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameEventDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coachBindingSource).BeginInit();
            bg_date.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EventDanceBindingSource).BeginInit();
            bg_delete.SuspendLayout();
            bg_Create.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)eventDanceBindingSource1).BeginInit();
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
            bg_date.Location = new Point(12, 337);
            bg_date.Margin = new Padding(3, 4, 3, 4);
            bg_date.Name = "bg_date";
            bg_date.Size = new Size(887, 357);
            bg_date.TabIndex = 2;
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AutoGenerateColumns = false;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, nameEventDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, studentIdDataGridViewTextBoxColumn });
            DataGrid.DataSource = eventDanceBindingSource1;
            DataGrid.Location = new Point(19, 22);
            DataGrid.Name = "DataGrid";
            DataGrid.RowHeadersWidth = 51;
            DataGrid.RowTemplate.Height = 29;
            DataGrid.Size = new Size(851, 188);
            DataGrid.TabIndex = 0;
            DataGrid.CellValueChanged += dataGridView1_CellValueChanged;
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
            bg_delete.Location = new Point(12, 279);
            bg_delete.Name = "bg_delete";
            bg_delete.Size = new Size(887, 60);
            bg_delete.TabIndex = 4;
            // 
            // bg_Create
            // 
            bg_Create.BackColor = Color.Beige;
            bg_Create.Controls.Add(date_event);
            bg_Create.Controls.Add(b_add_new_rows);
            bg_Create.Controls.Add(label2);
            bg_Create.Controls.Add(label1);
            bg_Create.Controls.Add(text_login);
            bg_Create.Controls.Add(input_description);
            bg_Create.Controls.Add(input_name);
            bg_Create.Location = new Point(13, 69);
            bg_Create.Name = "bg_Create";
            bg_Create.Size = new Size(885, 214);
            bg_Create.TabIndex = 5;
            // 
            // date_event
            // 
            date_event.Location = new Point(392, 110);
            date_event.Name = "date_event";
            date_event.Size = new Size(253, 27);
            date_event.TabIndex = 23;
            // 
            // b_add_new_rows
            // 
            b_add_new_rows.BackColor = Color.DarkKhaki;
            b_add_new_rows.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            b_add_new_rows.Location = new Point(415, 161);
            b_add_new_rows.Name = "b_add_new_rows";
            b_add_new_rows.Size = new Size(122, 43);
            b_add_new_rows.TabIndex = 0;
            b_add_new_rows.Text = "Добавить";
            b_add_new_rows.UseVisualStyleBackColor = false;
            b_add_new_rows.Click += b_add_new_rows_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Beige;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(278, 113);
            label2.Name = "label2";
            label2.Size = new Size(47, 23);
            label2.TabIndex = 18;
            label2.Text = "Дата";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Beige;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(278, 60);
            label1.Name = "label1";
            label1.Size = new Size(89, 23);
            label1.TabIndex = 18;
            label1.Text = "Описание";
            // 
            // text_login
            // 
            text_login.AutoSize = true;
            text_login.BackColor = Color.Beige;
            text_login.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            text_login.Location = new Point(278, 13);
            text_login.Name = "text_login";
            text_login.Size = new Size(86, 23);
            text_login.TabIndex = 18;
            text_login.Text = "Название";
            // 
            // input_description
            // 
            input_description.BackColor = SystemColors.Window;
            input_description.Location = new Point(392, 59);
            input_description.Name = "input_description";
            input_description.Size = new Size(253, 27);
            input_description.TabIndex = 22;
            // 
            // input_name
            // 
            input_name.BackColor = SystemColors.Window;
            input_name.Location = new Point(392, 12);
            input_name.Name = "input_name";
            input_name.Size = new Size(253, 27);
            input_name.TabIndex = 22;
            // 
            // text_name_data
            // 
            text_name_data.AutoSize = true;
            text_name_data.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            text_name_data.Location = new Point(372, 9);
            text_name_data.Name = "text_name_data";
            text_name_data.Size = new Size(209, 41);
            text_name_data.TabIndex = 6;
            text_name_data.Text = "Мероприятие";
            // 
            // eventDanceBindingSource1
            // 
            eventDanceBindingSource1.DataSource = typeof(EventDance);
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // nameEventDataGridViewTextBoxColumn
            // 
            nameEventDataGridViewTextBoxColumn.DataPropertyName = "nameEvent";
            nameEventDataGridViewTextBoxColumn.HeaderText = "nameEvent";
            nameEventDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameEventDataGridViewTextBoxColumn.Name = "nameEventDataGridViewTextBoxColumn";
            nameEventDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            dateDataGridViewTextBoxColumn.HeaderText = "date";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            studentIdDataGridViewTextBoxColumn.DataPropertyName = "studentId";
            studentIdDataGridViewTextBoxColumn.HeaderText = "studentId";
            studentIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            studentIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // AdminPanelEventDance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 686);
            Controls.Add(text_name_data);
            Controls.Add(bg_Create);
            Controls.Add(bg_delete);
            Controls.Add(bg_date);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminPanelEventDance";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)coachBindingSource).EndInit();
            bg_date.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)EventDanceBindingSource).EndInit();
            bg_delete.ResumeLayout(false);
            bg_delete.PerformLayout();
            bg_Create.ResumeLayout(false);
            bg_Create.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)eventDanceBindingSource1).EndInit();
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
        private Button b_add_new_rows;
        private Label text_login;
        private TextBox input_name;
        private BindingSource coachBindingSource;
        private DataGridView DataGrid;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private BindingSource EventDanceBindingSource;
        private Label label1;
        private TextBox input_description;
        private DateTimePicker date_event;
        private Label label2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameEventDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private BindingSource eventDanceBindingSource1;
    }
}