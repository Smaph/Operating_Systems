using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab4
{
    public static class FirstThread
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
                    mainForm.label1.Text += " - ";
                    mainForm.label1.Text += thread.Priority.ToString();
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
                mainForm.progressBar1.Value = i;
                Thread.Sleep(50);
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
            mainForm.label1.Text = "Поток 1";
            mainForm.label1.Text += " - ";
            mainForm.label1.Text += thread.Priority.ToString();
        }
    }
}
