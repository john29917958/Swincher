using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Swincher.ProcessManager
{
    public class Startup
    {
        private enum ShowWindowEnum
        {
            Hide = 0,
            ShowNormal = 1, ShowMinimized = 2, ShowMaximized = 3,
            Maximize = 3, ShowNormalNoActivate = 4, Show = 5,
            Minimize = 6, ShowMinNoActivate = 7, ShowNoActivate = 8,
            Restore = 9, ShowDefault = 10, ForceMinimized = 11
        }

        private struct Windowplacement
        {
            public int length;
            public int flags;
            public int showCmd;
            public System.Drawing.Point ptMinPosition;
            public System.Drawing.Point ptMaxPosition;
            public System.Drawing.Rectangle rcNormalPosition;
        }

        public async Task<object> Invoke(dynamic input)
        {
            IDictionary<string, object> data = input;
            int pid = Convert.ToInt32(data["pid"]);

            Process process = Process.GetProcessById(pid);

            Windowplacement placement = new Windowplacement();
            GetWindowPlacement(process.MainWindowHandle, ref placement);

            // Check if window is minimized
            if (placement.showCmd == 2)
            {
                // Restore hidden window
                ShowWindow(process.MainWindowHandle, ShowWindowEnum.Restore);
            }

            SetForegroundWindow(process.MainWindowHandle);

            return 0;
        }

        [DllImport("USER32.DLL")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("USER32.DLL")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowWindow(IntPtr hWnd, ShowWindowEnum flags);

        [DllImport("USER32.DLL")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowPlacement(IntPtr hWnd, ref Windowplacement lpwndpl);
    }
}
