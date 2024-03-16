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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(139, 335);
            button1.Name = "button1";
            button1.Size = new Size(232, 93);
            button1.TabIndex = 1;
            button1.Text = "Запуск";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(613, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(565, 335);
            button2.Name = "button2";
            button2.Size = new Size(232, 93);
            button2.TabIndex = 5;
            button2.Text = "Запуск";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(182, 222);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(139, 29);
            progressBar1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(199, 136);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 561);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        public TextBox textBox1;
        private Button button2;
        public ProgressBar progressBar1;
        private Label label1;
        private Label label2;
    }
}