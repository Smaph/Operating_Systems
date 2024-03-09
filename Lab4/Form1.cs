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
        // Метод для обновления текста на главной форме из разных потоков
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
            // Создаем и запускаем второй поток из вспомогательного файла
            SecondThread.Start(this);
        }

        // Обработчик события нажатия кнопки
        private void button1_Click(object sender, EventArgs e)
        {
            // Создаем и запускаем первый поток из вспомогательного файла
            FirstThread.Start(this);
        }
    }
}