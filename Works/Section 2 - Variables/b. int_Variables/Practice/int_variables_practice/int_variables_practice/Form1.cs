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
            int a, b, area, perimeter;
            a = 10; 
            b = 20;

            area = a * b;
            perimeter = 2 * (a + b);

            listBox1.Items.Add("Area : " + area + " - Perimeter : " + perimeter);
        }
    }
}