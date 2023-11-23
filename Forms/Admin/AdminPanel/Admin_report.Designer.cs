namespace SchoolDance.Forms.Admin.AdminPanel
{
    partial class Admin_Report
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
            label1 = new Label();
            list_table = new ComboBox();
            label2 = new Label();
            mySqlCommandBuilder1 = new MySqlConnector.MySqlCommandBuilder();
            b_create_report = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(246, 20);
            label1.Name = "label1";
            label1.Size = new Size(329, 41);
            label1.TabIndex = 0;
            label1.Text = "Формирование отчета";
            // 
            // list_table
            // 
            list_table.FormattingEnabled = true;
            list_table.Items.AddRange(new object[] { "Занятия", "Мероприятия", "Оплата", "Пополнение счета", "Студенты", "Тренеры", "Танцевальные стили", "Танцевальные залы" });
            list_table.Location = new Point(379, 101);
            list_table.Name = "list_table";
            list_table.Size = new Size(231, 28);
            list_table.TabIndex = 51;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MistyRose;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(165, 101);
            label2.Name = "label2";
            label2.Size = new Size(169, 28);
            label2.TabIndex = 50;
            label2.Text = "Выбрать таблицу";
            // 
            // mySqlCommandBuilder1
            // 
            mySqlCommandBuilder1.DataAdapter = null;
            mySqlCommandBuilder1.QuotePrefix = "`";
            mySqlCommandBuilder1.QuoteSuffix = "`";
            // 
            // b_create_report
            // 
            b_create_report.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            b_create_report.Location = new Point(237, 157);
            b_create_report.Name = "b_create_report";
            b_create_report.Size = new Size(351, 75);
            b_create_report.TabIndex = 52;
            b_create_report.Text = "Сформировать отчет";
            b_create_report.UseVisualStyleBackColor = true;
            // 
            // Admin_report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 244);
            Controls.Add(b_create_report);
            Controls.Add(list_table);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Admin_report";
            Text = "Admin_report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox list_table;
        private Label label2;
        private MySqlConnector.MySqlCommandBuilder mySqlCommandBuilder1;
        private Button b_create_report;
    }
}