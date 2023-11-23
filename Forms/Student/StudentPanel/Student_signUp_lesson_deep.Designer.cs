namespace SchoolDance.Forms
{
    partial class Student_signUp_lesson_deep
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
            label2 = new Label();
            text_dance_style_lesson = new Label();
            text_week_days = new Label();
            text_time_start_lesson = new Label();
            text_price = new Label();
            label7 = new Label();
            text_description = new TextBox();
            panel1 = new Panel();
            text_name_lesson = new Label();
            text_number_free_place = new Label();
            text_dancehall = new Label();
            panel2 = new Panel();
            list_dance_style = new ListBox();
            label12 = new Label();
            text_position = new Label();
            text_work_experience = new Label();
            text_name_coach = new Label();
            b_signUp_lesson = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(248, 9);
            label1.Name = "label1";
            label1.Size = new Size(317, 38);
            label1.TabIndex = 0;
            label1.Text = "Информация о занятии";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 9);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "О тренере";
            // 
            // text_dance_style_lesson
            // 
            text_dance_style_lesson.AutoSize = true;
            text_dance_style_lesson.Location = new Point(3, 44);
            text_dance_style_lesson.Name = "text_dance_style_lesson";
            text_dance_style_lesson.Size = new Size(100, 20);
            text_dance_style_lesson.TabIndex = 1;
            text_dance_style_lesson.Text = "Стиль танца: ";
            // 
            // text_week_days
            // 
            text_week_days.AutoSize = true;
            text_week_days.Location = new Point(3, 77);
            text_week_days.Name = "text_week_days";
            text_week_days.Size = new Size(98, 20);
            text_week_days.TabIndex = 1;
            text_week_days.Text = "Дни недели: ";
            // 
            // text_time_start_lesson
            // 
            text_time_start_lesson.AutoSize = true;
            text_time_start_lesson.Location = new Point(3, 111);
            text_time_start_lesson.Name = "text_time_start_lesson";
            text_time_start_lesson.Size = new Size(114, 20);
            text_time_start_lesson.TabIndex = 1;
            text_time_start_lesson.Text = "Время начала: ";
            // 
            // text_price
            // 
            text_price.AutoSize = true;
            text_price.Location = new Point(3, 144);
            text_price.Name = "text_price";
            text_price.Size = new Size(52, 20);
            text_price.TabIndex = 1;
            text_price.Text = "Цена: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 296);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 1;
            label7.Text = "Описание";
            // 
            // text_description
            // 
            text_description.BackColor = Color.PaleGoldenrod;
            text_description.Location = new Point(26, 319);
            text_description.Multiline = true;
            text_description.Name = "text_description";
            text_description.ReadOnly = true;
            text_description.Size = new Size(762, 103);
            text_description.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkKhaki;
            panel1.Controls.Add(text_name_lesson);
            panel1.Controls.Add(text_number_free_place);
            panel1.Controls.Add(text_dancehall);
            panel1.Controls.Add(text_price);
            panel1.Controls.Add(text_time_start_lesson);
            panel1.Controls.Add(text_week_days);
            panel1.Controls.Add(text_dance_style_lesson);
            panel1.Location = new Point(26, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 232);
            panel1.TabIndex = 3;
            // 
            // text_name_lesson
            // 
            text_name_lesson.AutoSize = true;
            text_name_lesson.Location = new Point(3, 9);
            text_name_lesson.Name = "text_name_lesson";
            text_name_lesson.Size = new Size(84, 20);
            text_name_lesson.TabIndex = 1;
            text_name_lesson.Text = "Название: ";
            // 
            // text_number_free_place
            // 
            text_number_free_place.AutoSize = true;
            text_number_free_place.Location = new Point(3, 203);
            text_number_free_place.Name = "text_number_free_place";
            text_number_free_place.Size = new Size(133, 20);
            text_number_free_place.TabIndex = 1;
            text_number_free_place.Text = "Количество мест: ";
            // 
            // text_dancehall
            // 
            text_dancehall.AutoSize = true;
            text_dancehall.Location = new Point(3, 173);
            text_dancehall.Name = "text_dancehall";
            text_dancehall.Size = new Size(40, 20);
            text_dancehall.TabIndex = 1;
            text_dancehall.Text = "Зал: ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkKhaki;
            panel2.Controls.Add(list_dance_style);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(text_position);
            panel2.Controls.Add(text_work_experience);
            panel2.Controls.Add(text_name_coach);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(433, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(355, 232);
            panel2.TabIndex = 4;
            // 
            // list_dance_style
            // 
            list_dance_style.BackColor = Color.PaleGoldenrod;
            list_dance_style.FormattingEnabled = true;
            list_dance_style.ItemHeight = 20;
            list_dance_style.Location = new Point(174, 130);
            list_dance_style.Name = "list_dance_style";
            list_dance_style.Size = new Size(178, 84);
            list_dance_style.TabIndex = 2;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 130);
            label12.Name = "label12";
            label12.Size = new Size(169, 20);
            label12.TabIndex = 1;
            label12.Text = "Список стилей танцев: ";
            // 
            // text_position
            // 
            text_position.AutoSize = true;
            text_position.Location = new Point(3, 99);
            text_position.Name = "text_position";
            text_position.Size = new Size(93, 20);
            text_position.TabIndex = 1;
            text_position.Text = "Должность: ";
            // 
            // text_work_experience
            // 
            text_work_experience.AutoSize = true;
            text_work_experience.Location = new Point(3, 65);
            text_work_experience.Name = "text_work_experience";
            text_work_experience.Size = new Size(109, 20);
            text_work_experience.TabIndex = 1;
            text_work_experience.Text = "Опыт работы: ";
            // 
            // text_name_coach
            // 
            text_name_coach.AutoSize = true;
            text_name_coach.Location = new Point(3, 35);
            text_name_coach.Name = "text_name_coach";
            text_name_coach.Size = new Size(46, 20);
            text_name_coach.TabIndex = 1;
            text_name_coach.Text = "Имя: ";
            // 
            // b_signUp_lesson
            // 
            b_signUp_lesson.BackColor = Color.OliveDrab;
            b_signUp_lesson.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            b_signUp_lesson.Location = new Point(302, 442);
            b_signUp_lesson.Name = "b_signUp_lesson";
            b_signUp_lesson.Size = new Size(223, 55);
            b_signUp_lesson.TabIndex = 5;
            b_signUp_lesson.Text = "Записаться";
            b_signUp_lesson.UseVisualStyleBackColor = false;
            b_signUp_lesson.Click += b_signUp_lesson_Click;
            // 
            // Student_signUp_lesson_deep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(800, 509);
            Controls.Add(b_signUp_lesson);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(text_description);
            Controls.Add(label7);
            Controls.Add(label1);
            Name = "Student_signUp_lesson_deep";
            Text = "Student_signUp_lesson_deep";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label text_dance_style_lesson;
        private Label text_week_days;
        private Label text_time_start_lesson;
        private Label text_price;
        private Label label7;
        private TextBox text_description;
        private Panel panel1;
        private Label text_name_lesson;
        private Panel panel2;
        private Label text_position;
        private Label text_work_experience;
        private Label text_name_coach;
        private Label label12;
        private ListBox list_dance_style;
        private Button b_signUp_lesson;
        private Label text_number_free_place;
        private Label text_dancehall;
    }
}