using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public static class FirstThread
    {
        public static void Start(Form1 mainForm)
        {
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    // Обновляем текст на главной форме
                    mainForm.UpdateText($"First Thread: {i}");

                    // Приостанавливаем выполнение потока на 300 мс
                    Thread.Sleep(300);
                }
            });
            thread.Start();
        }
    }
}
