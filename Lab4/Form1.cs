using System.Runtime.CompilerServices;

namespace Lab4
{
    //Доделать управление потоками:
    //Остановка потока,
    //Возобновление потока,
    //Изменение приоритета

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void UpdateText(string newText)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateText), newText);
                return;
            }
            textBox1.Text = newText;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SecondThread.Start(this);
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            FirstThread.Start(this);
        }
    }
}