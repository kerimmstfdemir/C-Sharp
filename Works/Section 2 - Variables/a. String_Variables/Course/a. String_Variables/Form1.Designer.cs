namespace a._String_Variables
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(33, 94);
            button1.Name = "button1";
            button1.Size = new Size(78, 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 29);
            label1.Name = "label1";
            label1.Size = new Size(111, 19);
            label1.TabIndex = 1;
            label1.Text = "Name Surname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 61);
            label2.Name = "label2";
            label2.Size = new Size(33, 19);
            label2.TabIndex = 2;
            label2.Text = "Job";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(265, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(147, 27);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(265, 61);
            label3.Name = "label3";
            label3.Size = new Size(119, 19);
            label3.TabIndex = 4;
            label3.Text = "Textbox Content";
            // 
            // button2
            // 
            button2.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(265, 94);
            button2.Name = "button2";
            button2.Size = new Size(78, 29);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 377);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Corbel", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button button2;
    }
}