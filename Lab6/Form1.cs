namespace Lab6
{
    public partial class Form1 : Form
    {
        private KeyboardHook keyboardHook;

        public Form1()
        {
            InitializeComponent();

            keyboardHook = new KeyboardHook();
            keyboardHook.KeyPressed += KeyboardHook_KeyPressed;
        }

        private void KeyboardHook_KeyPressed(object sender, KeyEventArgs e)
        {
            // Обработка нажатия клавиши
            MessageBox.Show($"Pressed Key: {e.KeyCode}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            keyboardHook.Hook();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            keyboardHook.Unhook();
        }
    }
}