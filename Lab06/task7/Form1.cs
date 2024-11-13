namespace lab6_task07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1.Interval= 1000;
            timer1.Start();
            label1.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Visible= true;
            label1.Text = DateTime.Now.ToString("dddd, dd MMMM\n\nhh.mm.ss tt");
        }
    }
}
