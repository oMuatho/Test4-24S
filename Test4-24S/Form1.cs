using Microsoft.VisualBasic.Devices;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Policy;

namespace Test4_24S
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Enabled == true)
                textBox1.Enabled = false;

            else
            {
                textBox1.Enabled = true;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = textBox1.Text;
            string y = textBox2.Text;
            string z = textBox3.Text;
            string q = textBox4.Text;
            y = x; z = q; x = z;
            textBox2.Text = x.ToString(); textBox3.Text = y.ToString(); textBox4.Text = z.ToString();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
