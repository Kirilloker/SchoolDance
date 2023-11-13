namespace SchoolDance.Forms
{
    partial class AdminPanel
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
            input_id_delete = new TextBox();
            label_delete = new Label();
            bg_delete = new Panel();
            bg_Create = new Panel();
            b_add_new_rows = new Button();
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
            DataGrid.AllowUserToResizeRows = false;
            DataGrid.AutoGenerateColumns = false;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, typePersonDataGridViewTextBoxColumn, loginDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn });
            DataGrid.DataSource = studentBindingSource;
            DataGrid.Location = new Point(16, 29);
            DataGrid.Margin = new Padding(3, 4, 3, 4);
            DataGrid.Name = "DataGrid";
            DataGrid.RowHeadersWidth = 51;
            DataGrid.RowTemplate.Height = 25;
            DataGrid.Size = new Size(850, 64);
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
            bg_Create.Location = new Point(13, 69);
            bg_Create.Name = "bg_Create";
            bg_Create.Size = new Size(885, 174);
            bg_Create.TabIndex = 5;
            // 
            // b_add_new_rows
            // 
            b_add_new_rows.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            b_add_new_rows.Location = new Point(771, 64);
            b_add_new_rows.Name = "b_add_new_rows";
            b_add_new_rows.Size = new Size(94, 29);
            b_add_new_rows.TabIndex = 0;
            b_add_new_rows.Text = "Добавить";
            b_add_new_rows.UseVisualStyleBackColor = true;
            b_add_new_rows.Click += b_add_new_rows_Click;
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
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 686);
            Controls.Add(text_name_data);
            Controls.Add(bg_Create);
            Controls.Add(bg_delete);
            Controls.Add(bg_date);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminPanel";
            Text = "Панель администратора";
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            bg_date.ResumeLayout(false);
            bg_delete.ResumeLayout(false);
            bg_delete.PerformLayout();
            bg_Create.ResumeLayout(false);
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
    }
}