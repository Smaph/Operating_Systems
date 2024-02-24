namespace Lab1
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x;
            var text = textBox1.Text;

            if (double.TryParse(text, out x))
            {
                label1.Text = "X = " + (x * x - 3 + x).ToString();
            }
            else
            {
                MessageBox.Show("Недопустимый ввод");
            }
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Text = "Пришел";
            button2.Text = "Ушел";
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Text = "Пришел";
            button3.Text = "Ушел";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button3.Text = " ";
            button2.Text = " ";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Text = " ";
            button2.Text = " ";
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }
    }
}