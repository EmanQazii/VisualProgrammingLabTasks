namespace lab6_task03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.AppendText("Number\tSquare\r\n");
            for (int i = 1; i <= 10; i++)
            {
                int square = i * i;
                textBox1.AppendText($"{i}\t{square}\r\n");
            }
        }
    }
}
