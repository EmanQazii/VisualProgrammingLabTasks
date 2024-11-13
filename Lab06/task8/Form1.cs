using System.Windows.Forms;

namespace lab6_task08
{
    public partial class Form1 : Form
    {
        private string[] photoFiles;
        private int currentIndex = 0;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            prev_button.Visible = false;
            next_button.Visible = false;
            label.Visible = false;
            textBox1.Visible = false;
            phNo_label.Visible = false;
        }

        private void slct_folder_button_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    photoFiles = Directory.GetFiles(folderDialog.SelectedPath, "*.jpg")
                   .Concat(Directory.GetFiles(folderDialog.SelectedPath, "*.png")).ToArray();

                    prev_button.Visible = true;
                    next_button.Visible = true;
                    label.Visible = true;
                    textBox1.Visible = true;
                    phNo_label.Visible = true;

                    phNo_label.Text = $"Total Photos:       {photoFiles.Length}";

                    if (photoFiles.Length > 0)
                    {
                        DisplayPhoto(currentIndex);
                    }
                    else
                    {
                        MessageBox.Show("No photos found in the selected folder.");
                    }
                }
            }
        }

        private void DisplayPhoto(int index)
        {
            if (photoFiles != null && photoFiles.Length > 0)
            {
                pictureBox1.ImageLocation = photoFiles[index];
                textBox1.Text = photoFiles[index].ToString();
            }
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            if (photoFiles != null && photoFiles.Length > 0)
            {
                currentIndex = (currentIndex + 1) % photoFiles.Length; 
                DisplayPhoto(currentIndex);
            }
        }

        private void prev_button_Click(object sender, EventArgs e)
        {
            if (photoFiles != null && photoFiles.Length > 0)
            {
                currentIndex = (currentIndex - 1 + photoFiles.Length) % photoFiles.Length;  
                DisplayPhoto(currentIndex);
            }
        }
    }
}
