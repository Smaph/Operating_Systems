using System.Runtime.Serialization;
using System.Timers;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] dir = DriveInfo.GetDrives();
            label1.Text = dir[0].Name;
            label1.Text += "  ";
            label1.Text += dir[0].DriveType;
            label1.Text += "  ";
            label1.Text += Math.Round((float)(dir[0].TotalFreeSpace) / 1073741824.0, 3);
            label1.Text += "gb  ";
            label1.Text += Math.Round((float)(dir[0].AvailableFreeSpace) / 1073741824.0, 3);
            label1.Text += "gb";

            label2.Text = dir[1].Name;
            label2.Text += "  ";
            label2.Text += dir[1].DriveType;
            label2.Text += "  ";
            label2.Text += Math.Round((float)(dir[1].TotalFreeSpace) / 1073741824.0, 3);
            label2.Text += "gb  ";
            label2.Text += Math.Round((float)(dir[1].AvailableFreeSpace) / 1073741824.0, 3);
            label2.Text += "gb";
        }
    }
}