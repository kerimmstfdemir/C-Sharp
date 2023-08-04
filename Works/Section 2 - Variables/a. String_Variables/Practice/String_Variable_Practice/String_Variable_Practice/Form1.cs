namespace String_Variable_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, surname, age, job, gender;

            name = textBox1.Text;
            surname = textBox2.Text;
            age = maskedTextBox1.Text;
            job = textBox4.Text;
            gender = comboBox1.Text;

            listBox1.Items.Add(name + " " + surname + " - " + age + " - " + job + " - " + gender);

            textBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox1.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
        }
    }
}