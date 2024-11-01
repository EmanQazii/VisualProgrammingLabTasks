namespace Assignment02_233531
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Name : {textBox1.Text}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bold_button_Click(object sender, EventArgs e)
        {
            Font oldfont = this.richTextBox1.SelectionFont;
            Font newfont;

            if (oldfont.Bold)
            {
                newfont = new Font(oldfont, oldfont.Style & ~FontStyle.Bold);
            }
            else
            {
                newfont = new Font(oldfont, oldfont.Style | FontStyle.Bold);
            }

            this.richTextBox1.SelectionFont = newfont;
            this.richTextBox1.Focus();

        }

        private void italic_button_Click(object sender, EventArgs e)
        {
            Font oldfont = this.richTextBox1.SelectionFont;
            Font newfont;

            if (oldfont.Italic)
            {
                newfont = new Font(oldfont, oldfont.Style & ~FontStyle.Italic);
            }
            else
            {
                newfont = new Font(oldfont, oldfont.Style | FontStyle.Italic);
            }

            this.richTextBox1.SelectionFont = newfont;
            this.richTextBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string items = string.Empty;

            if (checkBox1.Checked)
            {
                items += "\n Cupcake";
            }
            if (checkBox2.Checked)
            {
                items += "\n Pencil";
            }
            if (checkBox3.Checked)
            {
                items += "\n Book";
            }

            MessageBox.Show("You Bought : " + items, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string text = string.Empty;
            if (radioButton1.Checked)
            {
                text = "Male";
            }
            else
            {
                text = "Female";
            }

            MessageBox.Show($"You Selected : " + text);
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {

            decimal price = numericUpDown1.Value;

            int quantity = (int)numericUpDown2.Value;

            decimal total = price * quantity;

            MessageBox.Show($" The total price is : Rs {total}");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(o.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] items = { "Lahore", "Multan", "Karachi", "Islamabad" };

            foreach (var item in items)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label17.Text = dateTimePicker1.Text.TrimStart();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            label18.Text = monthCalendar1.SelectionStart.ToLongDateString();
        }
    }
}

