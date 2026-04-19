using System.Runtime.InteropServices;
using System.Windows;

namespace LibraryTask;

public static class Task1Class
{
    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    public static extern int MessageBox(IntPtr hWnd, string msg, string caption, uint type);
}