using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[assembly: InternalsVisibleTo("WinWindowBringer.Test")]

namespace Swincher.WinWindowBringer
{
    class Program
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

        static int Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("PID should be provided");
                return 1;
            }

            try
            {
                int pid = Convert.ToInt32(args[0]);
                BringToFront(pid);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 1;
            }

            return 0;
        }

        internal static void BringToFront(int pid)
        {
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
