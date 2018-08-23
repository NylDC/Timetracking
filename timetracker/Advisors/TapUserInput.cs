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
    public class TapUserInput : ITimerAdvisor
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WH_MOUSE_LL = 14;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelProc _proc = HookCallbackKeyBoard;
        private static LowLevelProc _MouseProc = HookCallbackMouse;
        private static IntPtr _hookID = IntPtr.Zero;
        private static IntPtr _MouseHookID = IntPtr.Zero;
        
        private static DateTime LastKeyboardAction;
        private static DateTime LastMouseAction;

        private enum MouseMessages
        {
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_MOUSEMOVE = 0x0200,
            WM_MOUSEWHEEL = 0x020A,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205
        }
        
        private bool TapMouse = false;
        private bool TapKeyboard = false;

        private int VideoFPS => Configuration.VideoFPS;
        private int MaxKeyboardIdleInterval => Configuration.MaxKeyboardIdleInterval;
        private int MaxMouseIdleInterval => Configuration.MaxMouseIdleInterval;

        public TapUserInput(bool tapKeyboard, bool tapMouse)
        {
            TapMouse = tapMouse;
            TapKeyboard = tapKeyboard;
        }


        public bool AdviseIfCanCount()
        {
            DateTime Now = DateTime.Now;
            bool _mouseYes = (!TapMouse || TapMouse && LastMouseAction != null && Now.Subtract(LastMouseAction).TotalSeconds < MaxMouseIdleInterval);
            bool _kbYes = (!TapKeyboard || TapKeyboard && LastKeyboardAction != null && Now.Subtract(LastKeyboardAction).TotalSeconds < MaxKeyboardIdleInterval);
           // Console.WriteLine("Keyboard " + (_kbYes ? "YES" : "NO"));
           // Console.WriteLine("Mouse    " + (_mouseYes ? "YES" : "NO"));
            return _mouseYes || _kbYes;
        }

        public void OnTimerStart()
        {
            if(TapKeyboard)
                _hookID = SetKeyboardHook(_proc);

            if (TapMouse)
                _MouseHookID = SetMouseHook(_MouseProc);
        }

        public void OnTimerStop()
        {
            if (TapKeyboard)
                UnhookWindowsHookEx(_hookID);
            if (TapMouse)
                UnhookWindowsHookEx(_MouseHookID);
        }



        /*
         * Derived from https://stackoverflow.com/questions/604410/global-keyboard-capture-in-c-sharp-application
         */
        private static IntPtr SetKeyboardHook(LowLevelProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

 
        private static IntPtr SetMouseHook (LowLevelProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_MOUSE_LL, proc,
                GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelProc(int nCode, IntPtr wParam, IntPtr lParam);
        
        private static IntPtr HookCallbackKeyBoard(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
               // Console.WriteLine((Keys)vkCode);
                LastKeyboardAction = DateTime.Now;
            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        [StructLayout(LayoutKind.Sequential)]

        private struct POINT

        {

            public int x;

            public int y;

        }


        [StructLayout(LayoutKind.Sequential)]
        private struct MSLLHOOKSTRUCT

        {

            public POINT pt;

            public uint mouseData;

            public uint flags;

            public uint time;

            public IntPtr dwExtraInfo;

        }

        private static IntPtr HookCallbackMouse(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 &&
                MouseMessages.WM_LBUTTONDOWN == (MouseMessages)wParam || MouseMessages.WM_MOUSEMOVE == (MouseMessages)wParam)
            {
                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
               // Console.WriteLine(hookStruct.pt.x + ", " + hookStruct.pt.y);
                LastMouseAction = DateTime.Now;
            }

            return CallNextHookEx(_MouseHookID, nCode, wParam, lParam);

        }



      

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelProc lpfn, IntPtr hMod, uint dwThreadId);

        //private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
