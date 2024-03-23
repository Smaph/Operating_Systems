namespace Lab5
{
    public partial class Form1 : Form
    {
        private double result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            result = MyLibrary.MyLibrary.Add(10, 5);
            label1.Text = "Результат = " + result.ToString();
        }
    }
}