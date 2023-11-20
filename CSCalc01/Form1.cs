using System.Globalization;

namespace Calc01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(new System.Data.DataTable().Compute(textBox1.Text, null));
            textBox1.Text = result.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("en-us"));
            //textBox1.Text = result.ToString("0.######");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int tamanho = textBox1.TextLength;
            textBox1.Text = (textBox1.Text).Substring(0, tamanho - 1);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*" + textBox1.Text;
            button17_Click(sender, e);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(textBox1.Text);
            result = Math.Sqrt(result);
            textBox1.Text = result.ToString("0.######");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            double result = Convert.ToDouble(textBox1.Text);
            result = Math.Cbrt(result);
            textBox1.Text = result.ToString("0.######");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + (sender as Button).Text;
        }
    }
}