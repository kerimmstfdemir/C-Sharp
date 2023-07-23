namespace Usages
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(maskedTextBox3.Text + " : " + maskedTextBox4.Text + " - " + maskedTextBox2.Text + " - " + maskedTextBox1.Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add(dateTimePicker1.Text);
        }
    }
}