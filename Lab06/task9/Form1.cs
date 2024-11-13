namespace lab6_task09
{
    public partial class Form1 : Form
    {
        private const int MaxCharacters = 160;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = $"Characters Left: {MaxCharacters}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string currentText=textBox1.Text;
            if (currentText.Length > MaxCharacters)
            {
                textBox1.Text = currentText.Substring(0, MaxCharacters);
                textBox1.SelectionStart = textBox1.Text.Length;
                MessageBox.Show("You have reached the word limit : 160 ");
            }

            label1 .Text = $"Characters Left: {MaxCharacters - textBox1.TextLength}";
        }
    }
}
