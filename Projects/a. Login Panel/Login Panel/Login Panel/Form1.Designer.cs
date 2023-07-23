namespace Login_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            checkBox1 = new CheckBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(11, 121);
            label1.Name = "label1";
            label1.Size = new Size(204, 21);
            label1.TabIndex = 0;
            label1.Text = "Turkish Identity Number :";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(221, 121);
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(196, 27);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 27);
            textBox1.TabIndex = 2;
            textBox1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(125, 156);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 3;
            label2.Text = "Password :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(428, 104);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 34);
            label3.Name = "label3";
            label3.Size = new Size(289, 40);
            label3.TabIndex = 8;
            label3.Text = "Online Admin Panel";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Bisque;
            panel2.Location = new Point(-1, 258);
            panel2.Name = "panel2";
            panel2.Size = new Size(428, 24);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(221, 214);
            button1.Name = "button1";
            button1.Size = new Size(110, 29);
            button1.TabIndex = 6;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.Location = new Point(221, 187);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(130, 21);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Forgot Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(298, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 283);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "User Login Panel";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private CheckBox checkBox1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}