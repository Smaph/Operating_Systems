namespace Lab3
{
    public partial class Form1 : Form
    {
        OpenFileDialog fileDialog = new OpenFileDialog();
        FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
        string filePath;
        bool isActive = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
            textBox1.Text = fileDialog.SafeFileName;
            filePath = fileDialog.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            string folderPath = folderBrowserDialog.SelectedPath.ToString();
            File.Copy(filePath, folderPath + "\\" + "copied_" + textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            string folderPath = folderBrowserDialog.SelectedPath.ToString();
            File.Move(filePath, folderPath + "\\" + textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            if (isActive)
            {
                File.Move(filePath, fileInfo.DirectoryName + "\\" + textBox1.Text);
                isActive = false;
                textBox1.Enabled = false;
            }
            else
            {
                isActive = true;
                textBox1.Enabled = true;
                textBox1.Select();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "DELETED";
            File.Delete(filePath);
        }
    }
}