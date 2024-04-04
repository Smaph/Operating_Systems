using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshWindowList();
        }       

        private void RefreshWindowList()
        {
            listBox1.Items.Clear();
            Process[] processes = Process.GetProcesses();
            foreach (Process process in processes)
            {
                if (process.MainWindowHandle != IntPtr.Zero)
                {
                    listBox1.Items.Add($"{process.ProcessName} - {process.MainWindowTitle}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshWindowList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                int index = selectedItem.IndexOf(" - ");
                if (index != -1)
                {
                    string processName = selectedItem.Substring(0, index);
                    Process[] processes = Process.GetProcessesByName(processName);
                    foreach (Process process in processes)
                    {
                        process.CloseMainWindow();
                    }
                    RefreshWindowList();
                }
            }
        }
    }
}
