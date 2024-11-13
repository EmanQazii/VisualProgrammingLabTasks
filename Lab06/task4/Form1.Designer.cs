namespace lab6_task04
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
            label1 = new Label();
            label2 = new Label();
            f_textBox = new TextBox();
            c_textBox = new TextBox();
            convert_button = new Button();
            button2 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 105);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Fahrenheit :  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 151);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Celsius :  ";
            // 
            // f_textBox
            // 
            f_textBox.Location = new Point(153, 106);
            f_textBox.Name = "f_textBox";
            f_textBox.Size = new Size(100, 23);
            f_textBox.TabIndex = 2;
            // 
            // c_textBox
            // 
            c_textBox.Location = new Point(153, 152);
            c_textBox.Name = "c_textBox";
            c_textBox.ReadOnly = true;
            c_textBox.Size = new Size(100, 23);
            c_textBox.TabIndex = 3;
            // 
            // convert_button
            // 
            convert_button.BackColor = SystemColors.ButtonFace;
            convert_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            convert_button.Location = new Point(37, 215);
            convert_button.Name = "convert_button";
            convert_button.Size = new Size(122, 38);
            convert_button.TabIndex = 4;
            convert_button.Text = "Convert";
            convert_button.UseVisualStyleBackColor = false;
            convert_button.Click += convert_button_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(178, 215);
            button2.Name = "button2";
            button2.Size = new Size(118, 38);
            button2.TabIndex = 5;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(77, 56);
            label3.Name = "label3";
            label3.Size = new Size(176, 20);
            label3.TabIndex = 6;
            label3.Text = "Temperature Converter ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(329, 313);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(convert_button);
            Controls.Add(c_textBox);
            Controls.Add(f_textBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox f_textBox;
        private TextBox c_textBox;
        private Button convert_button;
        private Button button2;
        private Label label3;
    }
}
