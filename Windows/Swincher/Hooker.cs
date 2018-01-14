﻿using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Swincher
{
    class Hooker
    {
        public delegate void KeyEnteredEvent(Keys[] keys);

        public KeyEnteredEvent OnKeyEntered { get; set; }

        private const int WindowsHookKeyboardLl = 13;

        private const int WmKeydown = 0x0100;

        private IntPtr _hookId = IntPtr.Zero;

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private readonly LowLevelKeyboardProc _proc;

        public Hooker()
        {
            _proc = HookCallback;
        }

        public void Hook()
        {
            _hookId = SetHook(_proc);
        }

        public void UnHook()
        {
            UnhookWindowsHookEx(_hookId);
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);


        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process p = Process.GetCurrentProcess())
            using (ProcessModule m = p.MainModule)
            {
                return SetWindowsHookEx(WindowsHookKeyboardLl, proc, GetModuleHandle(m.ModuleName), 0);
            }
        }

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WmKeydown)
            {
                int vkCode = Marshal.ReadInt32(lParam);

                if (OnKeyEntered != null)
                {
                    OnKeyEntered(new[] {(Keys) vkCode});
                }
            }

            return CallNextHookEx(_hookId, nCode, wParam, lParam);
        }
    }
}
