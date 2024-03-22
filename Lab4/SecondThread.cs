using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab4
{
    public static class SecondThread
    {
        public static Form1 mainForm = new Form1();
        public static Thread thread = new Thread(ThreadMethod);
        public static ManualResetEvent pauseEvent = new ManualResetEvent(true);

        public static void Start(Form1 f1)
        {
            mainForm = f1;
            if (thread.IsAlive)
            {
                MessageBox.Show("Поток уже запущен");
                return;
            }
            else
            {
                try
                {
                    thread.Start();
                    mainForm.label2.Text += " - ";
                    mainForm.label2.Text += thread.Priority.ToString();
                }
                catch
                {
                    MessageBox.Show("Поток выполнен");
                }
            }
        }

        public static void ThreadMethod()
        {
            for (int i = 0; i <= 100; i++)
            {
                mainForm.textBox1.Text = i.ToString();
                Thread.Sleep(100);
                pauseEvent.WaitOne();
            }
        }

        public static void Pause()
        {
            pauseEvent.Reset();
        }

        public static void Resume()
        {
            pauseEvent.Set();
        }

        public static void Priority(ThreadPriority priority)
        {
            thread.Priority = priority;
            mainForm.label2.Text = "Поток 2";
            mainForm.label2.Text += " - ";
            mainForm.label2.Text += thread.Priority.ToString();
        }
    }
}
