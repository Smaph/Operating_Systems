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
        public static void Start(Form1 mainForm)
        {
            Thread thread = new Thread(() => ThreadMethod(mainForm));
            thread.Start();
        }

        public static void ThreadMethod(Form1 mainForm)
        {
            for (int i = 0; i <= 100; i++)
            {
                mainForm.progressBar1.Value = i;
                Thread.Sleep(50);
            }
        }
    }
}
