using System.Data;

namespace lab6_task02
{
    public partial class Form1 : Form
    {
        string currentExpression = "";  

        public Form1()
        {
            InitializeComponent();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            currentExpression += addbutton.Text;
            textBox1.Text = currentExpression;
        }

        private void subtractbutton_Click(object sender, EventArgs e)
        {
            currentExpression += subtractbutton.Text;
            textBox1.Text = currentExpression;
        }

        private void multiplybutton_Click(object sender, EventArgs e)
        {
            currentExpression += "*";
            textBox1.Text = currentExpression;
        }

        private void divbutton_Click(object sender, EventArgs e)
        {
            currentExpression += divbutton.Text;
            textBox1.Text = currentExpression;
        }

        private void resultbutton_Click(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(currentExpression, null);
                textBox1.Text = result.ToString();
                currentExpression = result.ToString();
            }
            catch (Exception ex)
            {
                textBox1.Text = "Error";
                currentExpression = "";
            }
        }
        private double EvaluateExpression(string expression)
        {
            var table = new System.Data.DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {

            currentExpression = "";
            textBox1.Text = "0";

        }

        private void decimalbutton_Click(object sender, EventArgs e)
        {
            currentExpression += decimalbutton.Text;
            textBox1.Text = currentExpression;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            currentExpression += button_0.Text;
            textBox1.Text = currentExpression;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            currentExpression += button_1.Text;
            textBox1.Text = currentExpression;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            currentExpression += button_2.Text;
            textBox1.Text = currentExpression;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            currentExpression += button_3.Text;
            textBox1.Text = currentExpression;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            currentExpression += button_4.Text;
            textBox1.Text = currentExpression;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            currentExpression += button_5.Text;
            textBox1.Text = currentExpression;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            currentExpression += button_6.Text;
            textBox1.Text = currentExpression;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            currentExpression += button_7.Text;
            textBox1.Text = currentExpression;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            currentExpression += button_8.Text;
            textBox1.Text = currentExpression;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            currentExpression += button_9.Text;
            textBox1.Text = currentExpression;
        }
    }
}
