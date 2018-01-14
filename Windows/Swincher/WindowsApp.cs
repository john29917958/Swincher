﻿using System;
using System.Runtime.InteropServices;
using Swincher.Core.Application;

namespace Swincher
{
    class WindowsApp : App
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
