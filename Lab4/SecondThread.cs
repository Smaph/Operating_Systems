using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public static class SecondThread
    {
        public static void Start(Form1 mainForm)
        {
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    mainForm.UpdateText($"Second Thread: {i}");
                    Thread.Sleep(500);
                }
            });
            thread.Start();
        }
    }
}
