namespace lab6_task01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        private double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        private double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        private double Divide(double num1, double num2)
        {
            if (num2 == 0)
            {
                MessageBox.Show("Cannot divide by zero.");
                return 0;
            }
            return num1 / num2;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = Add(num1, num2);
            textBox3.Text = result.ToString();
        }

        private void subtractbutton_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = Subtract(num1, num2);
            textBox3.Text = result.ToString();
        }

        private void multiplybutton_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = Multiply(num1, num2);
            textBox3.Text =  result.ToString();
        }

        private void divbutton_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double result = Divide(num1, num2);
            textBox3.Text = result.ToString();
        }
    }
}
