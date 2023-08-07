namespace int_variables_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int a, b, area, perimeter;
            a = 10;
            b = 20;

            area = a * b;
            perimeter = 2 * (a + b);

            listBox1.Items.Add("Area : " + area + " - Perimeter : " + perimeter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            int note1, note2, note3, mean;
            note1 = 90;
            note2 = 82;
            note3 = 75;

            mean = (note1 + note2 + note3) / 3;

            listBox2.Items.Add("Average Note : " + mean);

        }
    }
}