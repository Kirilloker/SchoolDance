namespace SchoolDance.Forms.AdminPanel
{
    partial class AdminPanelSupportMessageDeep
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
            label2 = new Label();
            panel1 = new Panel();
            text_date = new Label();
            text_status = new Label();
            text_user_name = new Label();
            text_topic = new Label();
            panel2 = new Panel();
            input_text_user = new TextBox();
            b_solved = new Button();
            b_no_solved = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(157, 9);
            label2.Name = "label2";
            label2.Size = new Size(464, 54);
            label2.TabIndex = 1;
            label2.Text = "Сообщения об ошибках";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(text_date);
            panel1.Controls.Add(text_status);
            panel1.Controls.Add(text_user_name);
            panel1.Controls.Add(text_topic);
            panel1.Location = new Point(21, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(758, 211);
            panel1.TabIndex = 2;
            // 
            // text_date
            // 
            text_date.AutoSize = true;
            text_date.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            text_date.Location = new Point(26, 146);
            text_date.Name = "text_date";
            text_date.Size = new Size(74, 31);
            text_date.TabIndex = 0;
            text_date.Text = "Дата: ";
            // 
            // text_status
            // 
            text_status.AutoSize = true;
            text_status.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            text_status.Location = new Point(26, 101);
            text_status.Name = "text_status";
            text_status.Size = new Size(85, 31);
            text_status.TabIndex = 0;
            text_status.Text = "Статус:";
            // 
            // text_user_name
            // 
            text_user_name.AutoSize = true;
            text_user_name.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            text_user_name.Location = new Point(26, 58);
            text_user_name.Name = "text_user_name";
            text_user_name.Size = new Size(170, 31);
            text_user_name.TabIndex = 0;
            text_user_name.Text = "Пользователь: ";
            // 
            // text_topic
            // 
            text_topic.AutoSize = true;
            text_topic.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            text_topic.Location = new Point(26, 16);
            text_topic.Name = "text_topic";
            text_topic.Size = new Size(77, 31);
            text_topic.TabIndex = 0;
            text_topic.Text = "Тема: ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Bisque;
            panel2.Controls.Add(input_text_user);
            panel2.Location = new Point(21, 283);
            panel2.Name = "panel2";
            panel2.Size = new Size(758, 184);
            panel2.TabIndex = 3;
            // 
            // input_text_user
            // 
            input_text_user.Location = new Point(49, 23);
            input_text_user.Multiline = true;
            input_text_user.Name = "input_text_user";
            input_text_user.Size = new Size(660, 130);
            input_text_user.TabIndex = 0;
            // 
            // b_solved
            // 
            b_solved.BackColor = Color.SpringGreen;
            b_solved.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_solved.Location = new Point(223, 497);
            b_solved.Name = "b_solved";
            b_solved.Size = new Size(166, 48);
            b_solved.TabIndex = 4;
            b_solved.Text = "Решено";
            b_solved.UseVisualStyleBackColor = false;
            b_solved.Click += b_solved_Click;
            // 
            // b_no_solved
            // 
            b_no_solved.BackColor = Color.IndianRed;
            b_no_solved.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            b_no_solved.Location = new Point(450, 497);
            b_no_solved.Name = "b_no_solved";
            b_no_solved.Size = new Size(166, 48);
            b_no_solved.TabIndex = 4;
            b_no_solved.Text = "Не решено";
            b_no_solved.UseVisualStyleBackColor = false;
            b_no_solved.Click += b_no_solved_Click;
            // 
            // AdminPanelSupportMessageDeep
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 570);
            Controls.Add(b_no_solved);
            Controls.Add(b_solved);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Name = "AdminPanelSupportMessageDeep";
            Text = "AdminPanelSupportMesageDeep";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Label text_topic;
        private Label text_status;
        private Label text_user_name;
        private Panel panel2;
        private TextBox input_text_user;
        private Button b_solved;
        private Button b_no_solved;
        private Label text_date;
    }
}