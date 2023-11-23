namespace SchoolDance.Forms
{
    partial class Admin_DanceHall
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
            b_del = new Button();
            bg_date = new Panel();
            input_id_delete = new TextBox();
            label_delete = new Label();
            bg_delete = new Panel();
            bg_Create = new Panel();
            b_add_new_rows = new Button();
            text_login = new Label();
            text_password = new Label();
            input_roomNumber = new TextBox();
            input_capacity = new TextBox();
            text_name_data = new Label();
            danceHallBindingSource = new BindingSource(components);
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roomNumber = new DataGridViewTextBoxColumn();
            capacity = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            bg_date.SuspendLayout();
            bg_delete.SuspendLayout();
            bg_Create.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danceHallBindingSource).BeginInit();
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
            DataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, roomNumber, capacity });
            DataGrid.DataSource = danceHallBindingSource;
            DataGrid.Location = new Point(16, 29);
            DataGrid.Margin = new Padding(3, 4, 3, 4);
            DataGrid.Name = "DataGrid";
            DataGrid.RowHeadersWidth = 51;
            DataGrid.RowTemplate.Height = 25;
            DataGrid.Size = new Size(850, 64);
            DataGrid.TabIndex = 0;
            DataGrid.CellValueChanged += dataGridView1_CellValueChanged;
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
            bg_Create.Controls.Add(b_add_new_rows);
            bg_Create.Controls.Add(text_login);
            bg_Create.Controls.Add(text_password);
            bg_Create.Controls.Add(input_roomNumber);
            bg_Create.Controls.Add(input_capacity);
            bg_Create.Location = new Point(13, 69);
            bg_Create.Name = "bg_Create";
            bg_Create.Size = new Size(885, 174);
            bg_Create.TabIndex = 5;
            // 
            // b_add_new_rows
            // 
            b_add_new_rows.BackColor = Color.DarkKhaki;
            b_add_new_rows.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            b_add_new_rows.Location = new Point(416, 112);
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
            text_login.Location = new Point(240, 18);
            text_login.Name = "text_login";
            text_login.Size = new Size(136, 23);
            text_login.TabIndex = 18;
            text_login.Text = "Номер комнаты";
            // 
            // text_password
            // 
            text_password.AutoSize = true;
            text_password.BackColor = Color.Beige;
            text_password.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            text_password.Location = new Point(240, 61);
            text_password.Name = "text_password";
            text_password.Size = new Size(233, 23);
            text_password.TabIndex = 14;
            text_password.Text = "Максимальная вместимость";
            // 
            // input_roomNumber
            // 
            input_roomNumber.Location = new Point(492, 18);
            input_roomNumber.Name = "input_roomNumber";
            input_roomNumber.Size = new Size(239, 27);
            input_roomNumber.TabIndex = 21;
            // 
            // input_capacity
            // 
            input_capacity.BackColor = SystemColors.Window;
            input_capacity.Location = new Point(492, 60);
            input_capacity.Name = "input_capacity";
            input_capacity.Size = new Size(239, 27);
            input_capacity.TabIndex = 25;
            // 
            // text_name_data
            // 
            text_name_data.AutoSize = true;
            text_name_data.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            text_name_data.Location = new Point(346, 9);
            text_name_data.Name = "text_name_data";
            text_name_data.Size = new Size(269, 41);
            text_name_data.TabIndex = 6;
            text_name_data.Text = "Танцевальный зал";
            // 
            // danceHallBindingSource
            // 
            danceHallBindingSource.DataSource = typeof(DanceHall);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomNumber
            // 
            roomNumber.DataPropertyName = "roomNumber";
            roomNumber.HeaderText = "roomNumber";
            roomNumber.MinimumWidth = 6;
            roomNumber.Name = "roomNumber";
            roomNumber.Width = 125;
            // 
            // capacity
            // 
            capacity.DataPropertyName = "capacity";
            capacity.HeaderText = "capacity";
            capacity.MinimumWidth = 6;
            capacity.Name = "capacity";
            capacity.Width = 125;
            // 
            // AdminPanelDanceHall
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 686);
            Controls.Add(text_name_data);
            Controls.Add(bg_Create);
            Controls.Add(bg_delete);
            Controls.Add(bg_date);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminPanelDanceHall";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            bg_date.ResumeLayout(false);
            bg_delete.ResumeLayout(false);
            bg_delete.PerformLayout();
            bg_Create.ResumeLayout(false);
            bg_Create.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)danceHallBindingSource).EndInit();
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
        private Label text_password;
        private TextBox input_password;
        private TextBox input_roomNumber;
        private Label text_first_name;
        private TextBox input_login;
        private TextBox input_capacity;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomNumber;
        private DataGridViewTextBoxColumn capacity;
        private BindingSource danceHallBindingSource;
    }
}