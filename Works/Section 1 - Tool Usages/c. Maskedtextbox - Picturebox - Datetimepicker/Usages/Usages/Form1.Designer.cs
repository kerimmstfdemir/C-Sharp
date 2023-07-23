namespace Usages
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
            maskedTextBox1 = new MaskedTextBox();
            label1 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            label2 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            label3 = new Label();
            maskedTextBox4 = new MaskedTextBox();
            label4 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            pictureBox1 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(207, 120);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(130, 26);
            maskedTextBox1.TabIndex = 0;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(92, 22);
            label1.Name = "label1";
            label1.Size = new Size(112, 18);
            label1.TabIndex = 1;
            label1.Text = "Phone Number :";
            label1.Click += label1_Click;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(207, 86);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(130, 26);
            maskedTextBox2.TabIndex = 0;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Corbel", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(50, 56);
            label2.Name = "label2";
            label2.Size = new Size(154, 18);
            label2.TabIndex = 1;
            label2.Text = "Identity Number (TR) :";
            label2.Click += label1_Click;
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(207, 52);
            maskedTextBox3.Mask = "00000000000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(130, 26);
            maskedTextBox3.TabIndex = 0;
            maskedTextBox3.ValidatingType = typeof(int);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Corbel", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(157, 90);
            label3.Name = "label3";
            label3.Size = new Size(47, 18);
            label3.TabIndex = 1;
            label3.Text = "Date :";
            label3.Click += label1_Click;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(207, 18);
            maskedTextBox4.Mask = "(999) 000-0000";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(130, 26);
            maskedTextBox4.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Corbel", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(155, 124);
            label4.Name = "label4";
            label4.Size = new Size(49, 18);
            label4.TabIndex = 1;
            label4.Text = "Time :";
            label4.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Corbel", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(207, 152);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 18;
            listBox1.Location = new Point(10, 188);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(542, 166);
            listBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(377, -19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(370, 120);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(182, 26);
            dateTimePicker1.TabIndex = 5;
            // 
            // button2
            // 
            button2.Font = new Font("Corbel", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(370, 152);
            button2.Name = "button2";
            button2.Size = new Size(182, 29);
            button2.TabIndex = 6;
            button2.Text = "Get Date-Time";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(561, 361);
            Controls.Add(button2);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(maskedTextBox4);
            Controls.Add(label3);
            Controls.Add(maskedTextBox3);
            Controls.Add(label2);
            Controls.Add(maskedTextBox2);
            Controls.Add(label1);
            Controls.Add(maskedTextBox1);
            Font = new Font("Corbel", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Maskedtextbox - Picturebox - Datetimepicker";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private MaskedTextBox maskedTextBox2;
        private Label label2;
        private MaskedTextBox maskedTextBox3;
        private Label label3;
        private MaskedTextBox maskedTextBox4;
        private Label label4;
        private Button button1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
    }
}