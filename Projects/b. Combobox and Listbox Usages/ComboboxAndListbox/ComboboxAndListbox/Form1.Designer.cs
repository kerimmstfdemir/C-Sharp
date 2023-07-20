namespace ComboboxAndListbox
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
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button3 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "İstanbul", "Erzurum", "Amasya", "Ankara", "Konya", "Mardin", "Çanakkale", "İzmir", "Tunceli", "Kars" });
            comboBox1.Location = new Point(12, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(135, 31);
            comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 64);
            button1.Name = "button1";
            button1.Size = new Size(135, 31);
            button1.TabIndex = 1;
            button1.Text = "Add Antalya City";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Corbel", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(408, 22);
            button2.Name = "button2";
            button2.Size = new Size(51, 31);
            button2.TabIndex = 2;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(238, 25);
            label1.Name = "label1";
            label1.Size = new Size(53, 23);
            label1.TabIndex = 3;
            label1.Text = "City: ";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(294, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 31);
            textBox1.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Items.AddRange(new object[] { "Teacher", "Doctor", "Engineer", "Nurse" });
            listBox1.Location = new Point(12, 138);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(135, 119);
            listBox1.TabIndex = 5;
            // 
            // button3
            // 
            button3.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(12, 263);
            button3.Name = "button3";
            button3.Size = new Size(135, 29);
            button3.TabIndex = 6;
            button3.Text = "Add New Job";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(294, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 31);
            textBox2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(238, 141);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 8;
            label2.Text = "Job: ";
            label2.Click += label2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Corbel", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(408, 138);
            button4.Name = "button4";
            button4.Size = new Size(51, 31);
            button4.TabIndex = 7;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(628, 339);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Tool Usages";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button3;
        private TextBox textBox2;
        private Label label2;
        private Button button4;
    }
}