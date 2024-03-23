using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

public class KeyboardHook : NativeWindow
{
    // Константы для управления хуком
    private const int WH_KEYBOARD_LL = 13;
    private const int WM_KEYDOWN = 0x0100;

    // Структура для информации о нажатой клавише
    [StructLayout(LayoutKind.Sequential)]
    private struct KBDLLHOOKSTRUCT
    {
        public Keys key;
    }

    // Делегат для коллбэка хука
    private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);
    private HookProc hookCallback;

    // Идентификатор хука
    private IntPtr hookID = IntPtr.Zero;

    // Событие для оповещения о нажатии клавиши
    public event KeyEventHandler KeyPressed;

    // Инициализация хука
    public void Hook()
    {
        hookCallback = new HookProc(HookCallbackProc);
        using (Process curProcess = Process.GetCurrentProcess())
        using (ProcessModule curModule = curProcess.MainModule)
        {
            hookID = SetWindowsHookEx(WH_KEYBOARD_LL, hookCallback,
                GetModuleHandle(curModule.ModuleName), 0);
        }
    }

    // Удаление хука
    public void Unhook()
    {
        UnhookWindowsHookEx(hookID);
    }

    // Обработчик хука
    private IntPtr HookCallbackProc(int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
        {
            KBDLLHOOKSTRUCT kbd = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(KBDLLHOOKSTRUCT));
            OnKeyPressed(new KeyEventArgs(kbd.key));
        }
        return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
    }

    // Метод для вызова события нажатия клавиши
    protected virtual void OnKeyPressed(KeyEventArgs e)
    {
        KeyPressed?.Invoke(this, e);
    }

    // Подключение библиотеки User32.dll и импорт функций для установки и удаления хука
    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    private static extern IntPtr GetModuleHandle(string lpModuleName);
}
