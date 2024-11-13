namespace lab6_task08
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            next_button = new Button();
            prev_button = new Button();
            phNo_label = new Label();
            label = new Label();
            textBox1 = new TextBox();
            slct_folder_button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(32, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(581, 329);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // next_button
            // 
            next_button.BackColor = SystemColors.ButtonHighlight;
            next_button.Location = new Point(483, 406);
            next_button.Name = "next_button";
            next_button.Size = new Size(130, 23);
            next_button.TabIndex = 3;
            next_button.Text = "Next";
            next_button.UseVisualStyleBackColor = false;
            next_button.Click += next_button_Click;
            // 
            // prev_button
            // 
            prev_button.BackColor = SystemColors.ButtonHighlight;
            prev_button.Location = new Point(32, 405);
            prev_button.Name = "prev_button";
            prev_button.Size = new Size(138, 24);
            prev_button.TabIndex = 4;
            prev_button.Text = "previous";
            prev_button.UseVisualStyleBackColor = false;
            prev_button.Click += prev_button_Click;
            // 
            // phNo_label
            // 
            phNo_label.AutoSize = true;
            phNo_label.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phNo_label.ForeColor = SystemColors.ControlLightLight;
            phNo_label.Location = new Point(34, 474);
            phNo_label.Name = "phNo_label";
            phNo_label.Size = new Size(105, 20);
            phNo_label.TabIndex = 5;
            phNo_label.Text = "Total Photos : ";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.ControlLightLight;
            label.Location = new Point(60, 437);
            label.Name = "label";
            label.Size = new Size(79, 20);
            label.TabIndex = 1;
            label.Text = "Location : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 437);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(405, 23);
            textBox1.TabIndex = 2;
            // 
            // slct_folder_button
            // 
            slct_folder_button.BackColor = SystemColors.ButtonHighlight;
            slct_folder_button.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            slct_folder_button.Location = new Point(134, 28);
            slct_folder_button.Name = "slct_folder_button";
            slct_folder_button.Size = new Size(390, 37);
            slct_folder_button.TabIndex = 6;
            slct_folder_button.Text = "Select Folder To Upload Images";
            slct_folder_button.UseVisualStyleBackColor = false;
            slct_folder_button.Click += slct_folder_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(650, 517);
            Controls.Add(slct_folder_button);
            Controls.Add(phNo_label);
            Controls.Add(prev_button);
            Controls.Add(next_button);
            Controls.Add(textBox1);
            Controls.Add(label);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button next_button;
        private Button prev_button;
        private Label phNo_label;
        private Label label;
        private TextBox textBox1;
        private Button slct_folder_button;
    }
}
