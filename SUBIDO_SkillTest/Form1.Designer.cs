namespace SUBIDO_SkillTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(170, 30);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 0;
            label1.Text = "Hello, user!";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(21, 95);
            label2.Name = "label2";
            label2.Size = new Size(246, 21);
            label2.TabIndex = 1;
            label2.Text = "Sorting Application Instructions:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(21, 116);
            label3.Name = "label3";
            label3.Size = new Size(447, 21);
            label3.TabIndex = 2;
            label3.Text = "This is the sorting application form. To use it, follow these steps:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(21, 151);
            label4.Name = "label4";
            label4.Size = new Size(287, 15);
            label4.TabIndex = 3;
            label4.Text = "1. Enter your string (note: all spaces will be removed).";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(21, 181);
            label5.Name = "label5";
            label5.Size = new Size(289, 15);
            label5.TabIndex = 4;
            label5.Text = "2. Select a sorting method from the options provided.";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(21, 211);
            label6.Name = "label6";
            label6.Size = new Size(141, 15);
            label6.TabIndex = 5;
            label6.Text = "3. Click the \"Sort\" button.";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(21, 241);
            label7.Name = "label7";
            label7.Size = new Size(244, 15);
            label7.TabIndex = 6;
            label7.Text = "4. View your sorted string in the space below.";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(210, 290);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Proceed";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 341);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Sorting Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}
