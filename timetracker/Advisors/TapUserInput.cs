using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using timetracker.Services;

namespace timetracker.Advisors
{
    class TapUserInput : ITimerAdvisor
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        private static DateTime LastKeyboardAction;
        private static DateTime LastMouseAction;

        private bool TapMouse = false;
        private bool TapKeyboard = false;

        private int MaxKeyboardIdleInterval => Configuration.MaxKeyboardIdleInterval;
        private int MaxMouseIdleInterval = 5;

        public TapUserInput(bool tapKeyboard, bool tapMouse)
        {
            TapMouse = tapMouse;
            TapKeyboard = tapKeyboard;
        }

        public bool AdviseIfCanCount()
        {
            DateTime Now = DateTime.Now;
            return TapKeyboard && LastKeyboardAction != null && Now.Subtract(LastKeyboardAction).TotalSeconds < MaxKeyboardIdleInterval;
        }

        public void OnTimerStart()
        {
            if(TapKeyboard)
                _hookID = SetKeyboardHook(_proc);
        }

        public void OnTimerStop()
        {
            if (TapKeyboard)
                UnhookWindowsHookEx(_hookID);
        }



        /*
         * Derived from https://stackoverflow.com/questions/604410/global-keyboard-capture-in-c-sharp-application
         */
        private static IntPtr SetKeyboardHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Console.WriteLine((Keys)vkCode);
                LastKeyboardAction = DateTime.Now;
            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
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
    }
}
