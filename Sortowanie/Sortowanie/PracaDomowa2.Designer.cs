namespace PracaDomowa3
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
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(419, 55);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(419, 152);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 1;
            button1.Text = "Generuj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(52, 152);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 2;
            button2.Text = "Konwertuj";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(52, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 23);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 296);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 5;
            label1.Text = "Czas sortowania:";
            // 
            // button3
            // 
            button3.Location = new Point(52, 371);
            button3.Name = "button3";
            button3.Size = new Size(95, 42);
            button3.TabIndex = 6;
            button3.Text = "Insertion sort";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(202, 371);
            button4.Name = "button4";
            button4.Size = new Size(95, 42);
            button4.TabIndex = 7;
            button4.Text = "Bubble sort";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(354, 371);
            button5.Name = "button5";
            button5.Size = new Size(95, 42);
            button5.TabIndex = 8;
            button5.Text = "Merge sort";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 252);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 9;
            label2.Text = "Posortowane liczby:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(202, 252);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 10;
            label3.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(202, 296);
            label4.Name = "label4";
            label4.Size = new Size(12, 15);
            label4.TabIndex = 11;
            label4.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}