namespace SchoolDance.Forms
{
    partial class Coach_create_lesson
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
            lessonBindingSource = new BindingSource(components);
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
            label5 = new Label();
            text_login = new Label();
            input_time = new TextBox();
            input_price = new TextBox();
            input_name = new TextBox();
            text_name_data = new Label();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coachBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lessonBindingSource).BeginInit();
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
            // lessonBindingSource
            // 
            lessonBindingSource.DataSource = typeof(Lesson);
            // 
            // bg_Create
            // 
            bg_Create.BackColor = Color.LightBlue;
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
            bg_Create.Controls.Add(label5);
            bg_Create.Controls.Add(text_login);
            bg_Create.Controls.Add(input_time);
            bg_Create.Controls.Add(input_price);
            bg_Create.Controls.Add(input_name);
            bg_Create.Location = new Point(13, 69);
            bg_Create.Name = "bg_Create";
            bg_Create.Size = new Size(885, 366);
            bg_Create.TabIndex = 5;
            // 
            // input_description
            // 
            input_description.Location = new Point(564, 177);
            input_description.Multiline = true;
            input_description.Name = "input_description";
            input_description.Size = new Size(278, 83);
            input_description.TabIndex = 35;
            // 
            // list_style
            // 
            list_style.FormattingEnabled = true;
            list_style.Location = new Point(191, 126);
            list_style.Name = "list_style";
            list_style.Size = new Size(231, 28);
            list_style.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightBlue;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 131);
            label4.Name = "label4";
            label4.Size = new Size(56, 23);
            label4.TabIndex = 33;
            label4.Text = "Стиль";
            // 
            // list_danceHall
            // 
            list_danceHall.FormattingEnabled = true;
            list_danceHall.Location = new Point(191, 68);
            list_danceHall.Name = "list_danceHall";
            list_danceHall.Size = new Size(231, 28);
            list_danceHall.TabIndex = 34;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightBlue;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 73);
            label2.Name = "label2";
            label2.Size = new Size(37, 23);
            label2.TabIndex = 33;
            label2.Text = "Зал";
            // 
            // list_weekdays
            // 
            list_weekdays.FormattingEnabled = true;
            list_weekdays.Items.AddRange(new object[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" });
            list_weekdays.Location = new Point(654, 11);
            list_weekdays.Name = "list_weekdays";
            list_weekdays.Size = new Size(188, 158);
            list_weekdays.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightBlue;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(469, 19);
            label1.Name = "label1";
            label1.Size = new Size(103, 23);
            label1.TabIndex = 31;
            label1.Text = "Дни недели";
            // 
            // b_add_new_rows
            // 
            b_add_new_rows.BackColor = Color.DarkKhaki;
            b_add_new_rows.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            b_add_new_rows.Location = new Point(396, 291);
            b_add_new_rows.Name = "b_add_new_rows";
            b_add_new_rows.Size = new Size(122, 43);
            b_add_new_rows.TabIndex = 0;
            b_add_new_rows.Text = "Создать";
            b_add_new_rows.UseVisualStyleBackColor = false;
            b_add_new_rows.Click += b_add_new_rows_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightBlue;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(469, 178);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 18;
            label3.Text = "Описание";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightBlue;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(18, 237);
            label6.Name = "label6";
            label6.Size = new Size(121, 23);
            label6.TabIndex = 18;
            label6.Text = "Время начала";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightBlue;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 187);
            label5.Name = "label5";
            label5.Size = new Size(94, 23);
            label5.TabIndex = 18;
            label5.Text = "Стоимость";
            // 
            // text_login
            // 
            text_login.AutoSize = true;
            text_login.BackColor = Color.LightBlue;
            text_login.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            text_login.Location = new Point(18, 15);
            text_login.Name = "text_login";
            text_login.Size = new Size(86, 23);
            text_login.TabIndex = 18;
            text_login.Text = "Название";
            // 
            // input_time
            // 
            input_time.BackColor = SystemColors.Window;
            input_time.Location = new Point(191, 233);
            input_time.Name = "input_time";
            input_time.Size = new Size(231, 27);
            input_time.TabIndex = 22;
            // 
            // input_price
            // 
            input_price.BackColor = SystemColors.Window;
            input_price.Location = new Point(191, 183);
            input_price.Name = "input_price";
            input_price.Size = new Size(231, 27);
            input_price.TabIndex = 22;
            // 
            // input_name
            // 
            input_name.BackColor = SystemColors.Window;
            input_name.Location = new Point(191, 15);
            input_name.Name = "input_name";
            input_name.Size = new Size(231, 27);
            input_name.TabIndex = 22;
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
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // Coach_create_lesson
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(911, 464);
            Controls.Add(text_name_data);
            Controls.Add(bg_Create);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Coach_create_lesson";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)coachBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)lessonBindingSource).EndInit();
            bg_Create.ResumeLayout(false);
            bg_Create.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource studentBindingSource;
        private DataGridViewCheckBoxColumn isMaleDataGridViewCheckBoxColumn;
        private Panel bg_Create;
        private Label text_name_data;
        private Button b_add_new_rows;
        private Label text_login;
        private TextBox input_name;
        private BindingSource coachBindingSource;
        private CheckedListBox list_weekdays;
        private Label label1;
        private ComboBox list_style;
        private Label label4;
        private ComboBox list_danceHall;
        private Label label2;
        private BindingSource lessonBindingSource;
        private TextBox input_description;
        private Label label3;
        private Label label6;
        private Label label5;
        private TextBox input_time;
        private TextBox input_price;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}