namespace lab6_task06
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            startbutton = new Button();
            timer_button = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 110);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 0;
            label1.Text = "Set Timer(s) :";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(179, 110);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(85, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // startbutton
            // 
            startbutton.BackColor = SystemColors.ButtonHighlight;
            startbutton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startbutton.Location = new Point(54, 163);
            startbutton.Name = "startbutton";
            startbutton.Size = new Size(233, 40);
            startbutton.TabIndex = 2;
            startbutton.Text = "Quiz Start";
            startbutton.UseVisualStyleBackColor = false;
            startbutton.Click += startbutton_Click;
            // 
            // timer_button
            // 
            timer_button.AutoSize = true;
            timer_button.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            timer_button.Location = new Point(54, 247);
            timer_button.Name = "timer_button";
            timer_button.Size = new Size(74, 30);
            timer_button.TabIndex = 3;
            timer_button.Text = "Timer ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(131, 49);
            label3.Name = "label3";
            label3.Size = new Size(80, 32);
            label3.TabIndex = 4;
            label3.Text = "Timer";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(363, 379);
            Controls.Add(label3);
            Controls.Add(timer_button);
            Controls.Add(startbutton);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button startbutton;
        private Label timer_button;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}
