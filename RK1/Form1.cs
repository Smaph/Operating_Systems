using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace RK1
{
    public partial class Form1 : Form
    {
        OpenFileDialog fileDialog = new OpenFileDialog();
        string filePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fileDialog.SafeFileName;
                filePath = fileDialog.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Выберите существующий файл.");
                return;
            }

            int numParts;
            if (!int.TryParse(textBox2.Text, out numParts) || numParts <= 0)
            {
                MessageBox.Show("Введите корректное количество частей.");
                return;
            }

            double fileSize = new FileInfo(filePath).Length;
            double partSize = fileSize / numParts;

            FileStream inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);     
            for (int i = 0; i < numParts; i++)
            {
                string partFileName = $"{filePath}_part{i + 1}";

                FileStream outputStream = new FileStream(partFileName, FileMode.Create, FileAccess.Write);              
                byte[] buffer = new byte[4096];
                int bytesRead;
                double bytesRemaining = partSize;
                while ((bytesRead = inputStream.Read(buffer, 0, (int)Math.Min(bytesRemaining, buffer.Length))) > 0)
                {
                    outputStream.Write(buffer, 0, bytesRead);
                    bytesRemaining -= bytesRead;
                    if (bytesRemaining <= 0)
                        break;
                }
            }

            MessageBox.Show("Файл успешно разбит на части.");
        }
    }
}