namespace SchoolDance.Forms
{
    partial class SupportMessageForUser
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
            input_text_user = new TextBox();
            list_topic_problem = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            send_message = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(131, 9);
            label1.Name = "label1";
            label1.Size = new Size(531, 62);
            label1.TabIndex = 0;
            label1.Text = "Сообщение об ошибке";
            // 
            // input_text_user
            // 
            input_text_user.Location = new Point(33, 97);
            input_text_user.Multiline = true;
            input_text_user.Name = "input_text_user";
            input_text_user.Size = new Size(706, 184);
            input_text_user.TabIndex = 1;
            // 
            // list_topic_problem
            // 
            list_topic_problem.FormattingEnabled = true;
            list_topic_problem.Items.AddRange(new object[] { "Проблемы с авторизацией", "Ошибка при добавлении нового контента", "Сбои в работе оплаты", "Отсутствие доступа к определенным функциям", "Проблемы с интерфейсом пользователя", "Вопросы по настройкам безопасности", "Другие технические вопросы" });
            list_topic_problem.Location = new Point(213, 100);
            list_topic_problem.Name = "list_topic_problem";
            list_topic_problem.Size = new Size(538, 28);
            list_topic_problem.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Bisque;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(45, 100);
            label2.Name = "label2";
            label2.Size = new Size(166, 28);
            label2.TabIndex = 4;
            label2.Text = "Тема сообщения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 74);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 5;
            label3.Text = "Сообщение";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(send_message);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(input_text_user);
            panel1.Location = new Point(12, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 364);
            panel1.TabIndex = 6;
            // 
            // send_message
            // 
            send_message.BackColor = Color.LightCoral;
            send_message.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            send_message.Location = new Point(286, 301);
            send_message.Name = "send_message";
            send_message.Size = new Size(184, 50);
            send_message.TabIndex = 6;
            send_message.Text = "Отправить";
            send_message.UseVisualStyleBackColor = false;
            send_message.Click += button1_Click;
            // 
            // SupportMessageForUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 450);
            Controls.Add(label2);
            Controls.Add(list_topic_problem);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "SupportMessageForUser";
            Text = "Оставить вопрос";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input_text_user;
        private ComboBox list_topic_problem;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Button send_message;
    }
}