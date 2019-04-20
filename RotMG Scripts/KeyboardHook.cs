using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RotMG_Scripts {
    /// <summary>
    /// Hooks into the keyboard to be able to register keypresses as hotkeys
    /// </summary>
    public class KeyboardHook {

        /// <summary>
        /// Starts the keyboard hook
        /// </summary>
        public static void StartHook() {
            Console.WriteLine("Hooking.");

            Info.hookId = SetHook(Info.proc);

            if (Info.hookId == IntPtr.Zero) {
                Console.WriteLine("Hook Failed.", Console.logTypes.WARN);
            } else {
                Console.WriteLine("Hook Succeeded: " + Info.hookId);
            }
        }

        /// <summary>
        /// Stops the keyboard hook
        /// </summary>
        public static void StopHook() {
            Console.WriteLine("Unhooking.");

            if (UnhookWindowsHookEx(Info.hookId)) {
                Console.WriteLine("Unhooked.");
            } else {
                Console.WriteLine("Unhook Failed.", Console.logTypes.WARN);
            }

            Info.hookId = IntPtr.Zero;
        }

        /// <summary>
        /// Sets the keyboard hook
        /// </summary>
        /// <param name="proc"></param>
        /// <returns></returns>
        private static IntPtr SetHook(LowLevelKeyboardProc proc) {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule) {
                return SetWindowsHookEx(Info.WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        /// <summary>
        /// Callback for the hook, when any key is pressed
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        public static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam) {
            //Only care about the input if RotMG is active
            if (Info.isFocusedWindow) {
                //If the callback is a keydown event
                if (nCode >= 0 && wParam == (IntPtr)Info.WM_KEYDOWN) {
                    //Pass it on as a hotkey
                    int vkCode = Marshal.ReadInt32(lParam);
                    MainForm.HotkeyPressed((Keys)vkCode);
                }
            }

            return CallNextHookEx(Info.hookId, nCode, wParam, lParam);
        }

        public delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

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
