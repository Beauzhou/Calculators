namespace Calculators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label3.Text = "+";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label3.Text = "-";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                label3.Text = "*";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                label3.Text = "¡Â";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                label3.Text = "%";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox3.Text = Convert.ToString((int.Parse(textBox1.Text)) + (int.Parse(textBox2.Text)));
            }
            if (radioButton2.Checked == true)
            {
                textBox3.Text = Convert.ToString((int.Parse(textBox1.Text)) - (int.Parse(textBox2.Text)));
            }
            if (radioButton3.Checked == true)
            {
                textBox3.Text = Convert.ToString((int.Parse(textBox1.Text)) * (int.Parse(textBox2.Text)));
            }
            if (radioButton4.Checked == true)
            {
                textBox3.Text = Convert.ToString((double.Parse(textBox1.Text)) / (double.Parse(textBox2.Text)));
            }
            if (radioButton5.Checked == true)
            {
                textBox3.Text = Convert.ToString((int.Parse(textBox1.Text)) % (int.Parse(textBox2.Text)));
            }
        }
    }
}