using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Swincher.WinWindowBringer.Test
{
    [TestClass]
    public class StartupTest
    {
        private struct Point
        {
            public int X;
            public int Y;
        }

        private struct Rectangle
        {
            public int X;
            public int Y;
            public int Width;
            public int Height;
        }

        private struct Windowplacement
        {
            public int length;
            public int flags;
            public int showCmd;
            public Point ptMinPosition;
            public Point ptMaxPosition;
            public Rectangle rcNormalPosition;
        }

        private enum ShowWindowEnum
        {
            Hide = 0,
            ShowNormal = 1, ShowMinimized = 2, ShowMaximized = 3,
            Maximize = 3, ShowNormalNoActivate = 4, Show = 5,
            Minimize = 6, ShowMinNoActivate = 7, ShowNoActivate = 8,
            Restore = 9, ShowDefault = 10, ForceMinimized = 11
        }

        [TestMethod]
        public void TestBringToFront()
        {
            Process p = Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                WindowStyle = ProcessWindowStyle.Minimized
            });
            Program.BringToFront(p.Id);

            Windowplacement placement = new Windowplacement();
            GetWindowPlacement(p.MainWindowHandle, ref placement);

            Assert.AreNotEqual(ShowWindowEnum.ShowMinimized, placement.showCmd);

            p.Kill();
        }

        [DllImport("USER32.DLL")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowPlacement(IntPtr hWnd, ref Windowplacement lpwndpl);
    }
}
