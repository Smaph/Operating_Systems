namespace Lab4
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
            button1 = new Button();
            textBox1 = new TextBox();
            button2 = new Button();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(142, 307);
            button1.Name = "button1";
            button1.Size = new Size(232, 93);
            button1.TabIndex = 1;
            button1.Text = "Запуск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(613, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 51);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(568, 307);
            button2.Name = "button2";
            button2.Size = new Size(232, 93);
            button2.TabIndex = 5;
            button2.Text = "Запуск";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(176, 222);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(163, 50);
            progressBar1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(203, 136);
            label1.Name = "label1";
            label1.Size = new Size(104, 38);
            label1.TabIndex = 7;
            label1.Text = "Поток 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(624, 136);
            label2.Name = "label2";
            label2.Size = new Size(104, 38);
            label2.TabIndex = 8;
            label2.Text = "Поток 2";
            // 
            // button3
            // 
            button3.Location = new Point(34, 222);
            button3.Name = "button3";
            button3.Size = new Size(105, 50);
            button3.TabIndex = 9;
            button3.Text = "Пауза";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(778, 222);
            button4.Name = "button4";
            button4.Size = new Size(105, 50);
            button4.TabIndex = 10;
            button4.Text = "Пауза";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(422, 215);
            button5.Name = "button5";
            button5.Size = new Size(111, 64);
            button5.TabIndex = 11;
            button5.Text = "Приоритет";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 561);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        public TextBox textBox1;
        private Button button2;
        public ProgressBar progressBar1;
        public Label label1;
        public Label label2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}