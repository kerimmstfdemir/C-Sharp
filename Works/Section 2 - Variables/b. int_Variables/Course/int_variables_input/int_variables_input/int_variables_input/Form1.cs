namespace int_variables_input
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt16(textBox1.Text);
            label3.Text = number.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox2.Text);
            label8.Text = (number * number).ToString();
            label9.Text = (number * number * number).ToString();
        }
    }
}