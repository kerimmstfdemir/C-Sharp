namespace b._Plane_Ticket_Reservation_System
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
            groupBox1 = new GroupBox();
            label9 = new Label();
            button2 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            label7 = new Label();
            maskedTextBox3 = new MaskedTextBox();
            label6 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            listBox1 = new ListBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(31, 130);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(405, 197);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Flight Informations";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(304, 61);
            label9.Name = "label9";
            label9.Size = new Size(50, 18);
            label9.TabIndex = 8;
            label9.Text = "label9";
            label9.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(256, 56);
            button2.Name = "button2";
            button2.Size = new Size(46, 29);
            button2.TabIndex = 6;
            button2.Text = "<>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(90, 143);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(154, 26);
            maskedTextBox1.TabIndex = 7;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 146);
            label4.Name = "label4";
            label4.Size = new Size(54, 18);
            label4.TabIndex = 6;
            label4.Text = "Time :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(90, 108);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(154, 26);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 111);
            label3.Name = "label3";
            label3.Size = new Size(50, 18);
            label3.TabIndex = 4;
            label3.Text = "Date :";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "İstanbul", "Ankara", "İzmir", "Erzurum", "Konya", "Mardin", "Samsun" });
            comboBox2.Location = new Point(90, 73);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(154, 26);
            comboBox2.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "İstanbul", "Ankara", "İzmir", "Erzurum", "Konya", "Mardin", "Samsun" });
            comboBox1.Location = new Point(90, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 26);
            comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 76);
            label2.Name = "label2";
            label2.Size = new Size(36, 18);
            label2.TabIndex = 1;
            label2.Text = "To :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 41);
            label1.Name = "label1";
            label1.Size = new Size(56, 18);
            label1.TabIndex = 0;
            label1.Text = "From :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(maskedTextBox3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(maskedTextBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(482, 130);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(405, 198);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Passenger Informations";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(206, 144);
            button1.Name = "button1";
            button1.Size = new Size(154, 34);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 107);
            label7.Name = "label7";
            label7.Size = new Size(124, 18);
            label7.TabIndex = 5;
            label7.Text = "Phone Number :";
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(206, 104);
            maskedTextBox3.Mask = "(999) 000-0000";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(154, 26);
            maskedTextBox3.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 74);
            label6.Name = "label6";
            label6.Size = new Size(187, 18);
            label6.TabIndex = 3;
            label6.Text = "Identity Number (TRY) :";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(206, 71);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(154, 26);
            maskedTextBox2.TabIndex = 2;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 26);
            textBox1.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 41);
            label5.Name = "label5";
            label5.Size = new Size(138, 18);
            label5.TabIndex = 0;
            label5.Text = "Name - Surname :";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 18;
            listBox1.Location = new Point(31, 343);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(856, 130);
            listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(31, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(856, 100);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(460, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Script", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(133, 27);
            label8.Name = "label8";
            label8.Size = new Size(272, 48);
            label8.TabIndex = 0;
            label8.Text = "Jupiter Airlines";
            label8.Click += label8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 499);
            Controls.Add(panel1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private Label label5;
        private Label label7;
        private MaskedTextBox maskedTextBox3;
        private Label label6;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private Panel panel1;
        private Label label8;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label9;
    }
}