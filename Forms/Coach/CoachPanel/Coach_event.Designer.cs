namespace SchoolDance.Forms
{
    partial class Coach_event
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
            panel11 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(296, 20);
            label1.Name = "label1";
            label1.Size = new Size(208, 41);
            label1.TabIndex = 0;
            label1.Text = "Мероприятия";
            // 
            // panel11
            // 
            panel11.AutoScroll = true;
            panel11.BackColor = Color.PowderBlue;
            panel11.Location = new Point(36, 94);
            panel11.Name = "panel11";
            panel11.Size = new Size(778, 344);
            panel11.TabIndex = 1;
            // 
            // Coach_event
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(826, 450);
            Controls.Add(panel11);
            Controls.Add(label1);
            Name = "Coach_event";
            Text = "Student_event";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel11;
    }
}