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

        private void button1_Click(object sender, EventArgs e)
        {
            FirstThread.Start(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SecondThread.Start(this);
        }
    }
}