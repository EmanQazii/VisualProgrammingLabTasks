namespace lab6_task05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.ReadOnly = true;
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(textBox1.Text);

                if (number < 0)
                {
                    MessageBox.Show("Factorial is not defined for negative numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                long result = 1;
                if (number == 0 || number == 1) 
                    result=1;

                for (int i = 2; i <= number; i++)
                {
                    result *= i;
                }

                textBox2.Text = result.ToString();


            }
            catch (FormatException)
            {
               
                MessageBox.Show("Please enter a valid integer.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
