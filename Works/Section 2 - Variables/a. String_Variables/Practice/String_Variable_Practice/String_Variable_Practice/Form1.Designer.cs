namespace String_Variable_Practice
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(43, 18);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(23, 48);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Surname :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(57, 78);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 2;
            label3.Text = "Age :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(60, 108);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 1;
            label4.Text = "Job :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(34, 138);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 2;
            label5.Text = "Gender :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(119, 48);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(119, 108);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(119, 78);
            maskedTextBox1.Mask = "00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(100, 23);
            maskedTextBox1.TabIndex = 4;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(144, 177);
            button1.Name = "button1";
            button1.Size = new Size(75, 24);
            button1.TabIndex = 5;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(238, 17);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(528, 184);
            listBox1.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboBox1.Location = new Point(119, 137);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 222);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox4;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private ListBox listBox1;
        private ComboBox comboBox1;
    }
}