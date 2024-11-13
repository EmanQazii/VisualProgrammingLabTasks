namespace lab6_task04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            c_textBox.ReadOnly = true;
        }

        private void convert_button_Click(object sender, EventArgs e)
        {
            try
            {
                double fahrenheit = Convert.ToDouble(f_textBox.Text);
                double centigrade = (fahrenheit - 32.0) * 5.0 / 9.0;

                c_textBox.Text = $"{centigrade:F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for Fahrenheit.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
