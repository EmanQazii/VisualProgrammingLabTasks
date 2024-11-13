namespace lab6_task06
{
    public partial class Form1 : Form
    {
        private int countdownTime;
        public Form1()
        {
            InitializeComponent();
            timer_button.Visible = false;
            timer1.Interval=1000;
        }

        private void startbutton_Click(object sender, EventArgs e)
        {
            countdownTime = (int)numericUpDown1.Value;
            if (countdownTime <= 0)
            {
                MessageBox.Show("Please select a positive number for the time.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            timer_button.Visible=true;
            timer_button.Text= $"Time Left : {countdownTime.ToString()} seconds";

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdownTime--;
            timer_button.Text= $"Time Left : {countdownTime.ToString()} seconds";
            if (countdownTime <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Time's up!", "Countdown Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
