namespace SchoolDance.Forms
{
    partial class Student_add_money
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_add_money));
            label1 = new Label();
            input_balance = new TextBox();
            label2 = new Label();
            button1 = new Button();
            imageList1 = new ImageList(components);
            label3 = new Label();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(240, 9);
            label1.Name = "label1";
            label1.Size = new Size(228, 35);
            label1.TabIndex = 0;
            label1.Text = "Пополнение счета";
            // 
            // input_balance
            // 
            input_balance.Location = new Point(449, 75);
            input_balance.Name = "input_balance";
            input_balance.Size = new Size(226, 27);
            input_balance.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(418, 20);
            label2.TabIndex = 2;
            label2.Text = "Введите сумму, на которую хотите пополнить свой баланс";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(218, 183);
            button1.Name = "button1";
            button1.Size = new Size(262, 64);
            button1.TabIndex = 3;
            button1.Text = "Оплатил";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "QR_code_imagejpg.jpg");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 146);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Menu;
            richTextBox1.Location = new Point(18, 114);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(657, 52);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "Оплату производить на карту: 4242 4242 4242 4242. После того, как произвели оплату нажмите кнопку \"Оплатил\"";
            // 
            // Student_add_money
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 259);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(input_balance);
            Controls.Add(label1);
            Name = "Student_add_money";
            Text = "Student_add_money";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input_balance;
        private Label label2;
        private Button button1;
        private ImageList imageList1;
        private Label label3;
        private Label label4;
        private RichTextBox richTextBox1;
    }
}