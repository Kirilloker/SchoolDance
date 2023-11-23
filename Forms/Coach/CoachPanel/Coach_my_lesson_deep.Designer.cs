namespace SchoolDance.Forms
{
    partial class Coach_my_lesson_deep
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
            label2 = new Label();
            panel1.SuspendLayout();
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
            label7.Location = new Point(412, 63);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 1;
            label7.Text = "Описание";
            // 
            // text_description
            // 
            text_description.BackColor = Color.SkyBlue;
            text_description.Location = new Point(412, 86);
            text_description.Multiline = true;
            text_description.Name = "text_description";
            text_description.ReadOnly = true;
            text_description.Size = new Size(376, 207);
            text_description.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
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
            panel2.AutoScroll = true;
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Location = new Point(26, 336);
            panel2.Name = "panel2";
            panel2.Size = new Size(762, 263);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 313);
            label2.Name = "label2";
            label2.Size = new Size(161, 20);
            label2.TabIndex = 1;
            label2.Text = "Записаны на занятия:";
            // 
            // Coach_my_lesson_deep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 611);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(text_description);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Name = "Coach_my_lesson_deep";
            Text = "Student_signUp_lesson_deep";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label text_dance_style_lesson;
        private Label text_week_days;
        private Label text_time_start_lesson;
        private Label text_price;
        private Label label7;
        private TextBox text_description;
        private Panel panel1;
        private Label text_name_lesson;
        private Label text_number_free_place;
        private Label text_dancehall;
        private Panel panel2;
        private Label label2;
    }
}