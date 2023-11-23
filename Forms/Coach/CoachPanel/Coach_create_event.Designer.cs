namespace SchoolDance.Forms
{
    partial class Coach_create_event
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
            input_name_event = new TextBox();
            input_description = new TextBox();
            date_event = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            b_create_event = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(319, 41);
            label1.TabIndex = 0;
            label1.Text = "Создать мероприятие";
            // 
            // input_name_event
            // 
            input_name_event.Location = new Point(200, 97);
            input_name_event.Name = "input_name_event";
            input_name_event.Size = new Size(429, 27);
            input_name_event.TabIndex = 1;
            // 
            // input_description
            // 
            input_description.Location = new Point(200, 216);
            input_description.Multiline = true;
            input_description.Name = "input_description";
            input_description.Size = new Size(429, 122);
            input_description.TabIndex = 2;
            // 
            // date_event
            // 
            date_event.Location = new Point(200, 152);
            date_event.Name = "date_event";
            date_event.Size = new Size(429, 27);
            date_event.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Turquoise;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 22);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 4;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Turquoise;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(15, 79);
            label3.Name = "label3";
            label3.Size = new Size(69, 31);
            label3.TabIndex = 4;
            label3.Text = "Дата ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Turquoise;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 147);
            label4.Name = "label4";
            label4.Size = new Size(118, 31);
            label4.TabIndex = 4;
            label4.Text = "Описание";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(b_create_event);
            panel1.Location = new Point(25, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(645, 371);
            panel1.TabIndex = 5;
            // 
            // b_create_event
            // 
            b_create_event.BackColor = Color.Teal;
            b_create_event.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            b_create_event.Location = new Point(233, 275);
            b_create_event.Name = "b_create_event";
            b_create_event.Size = new Size(224, 78);
            b_create_event.TabIndex = 0;
            b_create_event.Text = "Создать мероприятие";
            b_create_event.UseVisualStyleBackColor = false;
            b_create_event.Click += b_create_event_Click;
            // 
            // Coach_create_event
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(694, 452);
            Controls.Add(date_event);
            Controls.Add(input_description);
            Controls.Add(input_name_event);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Coach_create_event";
            Text = "Coach_create_event";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input_name_event;
        private TextBox input_description;
        private DateTimePicker date_event;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Button b_create_event;
    }
}