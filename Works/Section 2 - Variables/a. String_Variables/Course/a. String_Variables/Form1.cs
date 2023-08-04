namespace a._String_Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name_surneme, job;

            name_surneme = "Kerim Mustafa DEMÝR";
            job = "Software Engineer";

            label1.Text = name_surneme;
            label2.Text = job;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string var;
            var = textBox1.Text;
            label3.Text = var;
        }
    }
}