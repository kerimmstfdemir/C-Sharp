namespace b._Plane_Ticket_Reservation_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Route: " + comboBox1.Text + " - " + comboBox2.Text + " Date : " + dateTimePicker1.Text + " Time : " + maskedTextBox1.Text + " Passenger Information ~ Name: " + textBox1.Text + " Identity Number : " + maskedTextBox2.Text + " Phone Number: " + maskedTextBox3.Text);
            MessageBox.Show("Passenger registration done successfully.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label9.Text;
        }
    }
}