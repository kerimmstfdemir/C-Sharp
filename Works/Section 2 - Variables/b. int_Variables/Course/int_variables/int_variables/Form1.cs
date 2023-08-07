namespace int_variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edge, area, perimeter;
            edge = 10;
            area = edge * edge;
            perimeter = edge * 4;
            label1.Text = "Area : " + area + " Perimeter : " + perimeter;
        }
    }
}