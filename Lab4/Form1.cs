using System.Runtime.CompilerServices;

namespace Lab4
{
    //Доделать управление потоками:
    //Остановка потока,
    //Возобновление потока,
    //Изменение приоритета

    public partial class Form1 : Form
    {
        private bool isPaused1 = false;
        private bool isPaused2 = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstThread.Start(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecondThread.Start(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!isPaused1)
            {
                FirstThread.Pause();
                button3.Text = "Продолжить";
                isPaused1 = true;
            }
            else
            {
                FirstThread.Resume();
                button3.Text = "Пауза";
                isPaused1 = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!isPaused2)
            {
                SecondThread.Pause();
                button4.Text = "Продолжить";
                isPaused2 = true;
            }
            else
            {
                SecondThread.Resume();
                button4.Text = "Пауза";
                isPaused2 = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FirstThread.Priority(ThreadPriority.Highest);
            SecondThread.Priority(ThreadPriority.Lowest);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}