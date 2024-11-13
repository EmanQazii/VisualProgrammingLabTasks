namespace lab6_task01
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
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            addbutton = new Button();
            subtractbutton = new Button();
            divbutton = new Button();
            multiplybutton = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 100);
            label1.Name = "label1";
            label1.Size = new Size(167, 23);
            label1.TabIndex = 0;
            label1.Text = "Enter first number :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 149);
            label2.Name = "label2";
            label2.Size = new Size(193, 23);
            label2.TabIndex = 1;
            label2.Text = "Enter second number :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(166, 199);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 2;
            label3.Text = "Result :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(257, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(257, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(257, 199);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(132, 23);
            textBox3.TabIndex = 5;
            // 
            // addbutton
            // 
            addbutton.BackColor = Color.Snow;
            addbutton.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addbutton.Location = new Point(105, 267);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(126, 46);
            addbutton.TabIndex = 6;
            addbutton.Text = "Add";
            addbutton.UseVisualStyleBackColor = false;
            addbutton.Click += addbutton_Click;
            // 
            // subtractbutton
            // 
            subtractbutton.BackColor = Color.Snow;
            subtractbutton.Font = new Font("Candara", 12F);
            subtractbutton.Location = new Point(273, 267);
            subtractbutton.Name = "subtractbutton";
            subtractbutton.Size = new Size(126, 46);
            subtractbutton.TabIndex = 7;
            subtractbutton.Text = "Subtract";
            subtractbutton.UseVisualStyleBackColor = false;
            subtractbutton.Click += subtractbutton_Click;
            // 
            // divbutton
            // 
            divbutton.BackColor = Color.Snow;
            divbutton.Font = new Font("Candara", 12F);
            divbutton.Location = new Point(273, 352);
            divbutton.Name = "divbutton";
            divbutton.Size = new Size(126, 46);
            divbutton.TabIndex = 8;
            divbutton.Text = "Divide";
            divbutton.UseVisualStyleBackColor = false;
            divbutton.Click += divbutton_Click;
            // 
            // multiplybutton
            // 
            multiplybutton.BackColor = Color.Snow;
            multiplybutton.Font = new Font("Candara", 12F);
            multiplybutton.Location = new Point(105, 352);
            multiplybutton.Name = "multiplybutton";
            multiplybutton.Size = new Size(126, 46);
            multiplybutton.TabIndex = 9;
            multiplybutton.Text = "Multiply";
            multiplybutton.UseVisualStyleBackColor = false;
            multiplybutton.Click += multiplybutton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(175, 35);
            label4.Name = "label4";
            label4.Size = new Size(153, 23);
            label4.TabIndex = 10;
            label4.Text = "Simple Calculator";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(515, 450);
            Controls.Add(label4);
            Controls.Add(multiplybutton);
            Controls.Add(divbutton);
            Controls.Add(subtractbutton);
            Controls.Add(addbutton);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button addbutton;
        private Button subtractbutton;
        private Button divbutton;
        private Button multiplybutton;
        private Label label4;
    }
}
