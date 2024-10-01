namespace SUBIDO_SkillTest
{
    partial class Form2
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
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Input string below:";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(12, 37);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(268, 122);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 6F);
            label2.Location = new Point(12, 162);
            label2.Name = "label2";
            label2.Size = new Size(255, 11);
            label2.TabIndex = 2;
            label2.Text = "Note: All spaces and numbers will be placed in front after the sorting.";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(12, 190);
            label3.Name = "label3";
            label3.Size = new Size(135, 15);
            label3.TabIndex = 3;
            label3.Text = "Choose sorting method:";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bubble Sort", "Quick Sort", "Merge Sort" });
            comboBox1.Location = new Point(12, 208);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(268, 23);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "Bubble Sort (Default)";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(304, 19);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 5;
            label4.Text = "Output:";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(304, 37);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(268, 122);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(416, 207);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "Sort";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(497, 207);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 8;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 6F);
            label5.Location = new Point(304, 162);
            label5.Name = "label5";
            label5.Size = new Size(237, 11);
            label5.TabIndex = 9;
            label5.Text = "Note: The textboxes may be refreshed by using the clear button.";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 261);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Sorting Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Label label5;
    }
}