using System;
using System.Runtime.InteropServices;
using Swincher.Core;

namespace Swincher
{
    class WindowsWindow : Window
    {
        public override bool BringToFront()
        {
            IntPtr windowHandle = Process.MainWindowHandle;

            if (Process.HasExited || windowHandle == IntPtr.Zero)
            {
                return false;
            }

            SetForegroundWindow(windowHandle);
            return true;
        }

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
    }
}
