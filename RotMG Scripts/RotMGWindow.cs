using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotMG_Scripts {
    class RotMGWindow {

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        private Process flashplayerProcess = null;
        private IntPtr flashplayerHandle;
        private Rectangle flashplayerRect;

        private string flashplayerName = "";

        public RotMGWindow() {
        }

        public void clear() {
            flashplayerProcess = null;
            flashplayerHandle = IntPtr.Zero;
            flashplayerRect = new Rectangle();
            flashplayerName = "";
        }

        public bool ValidflashplayerProcess() {
            if (flashplayerProcess == null || flashplayerProcess.HasExited) {
                return false;
            }

            if (flashplayerName == "") {
                return false;
            }

            return true;
        }

        public bool FindflashplayerProcess() {
            //Force the process name to be something
            if (Data.settings[0].Length < 1) {
                return false;
            }

            //Get all matching processes
            IEnumerable<Process> processes = Process.GetProcesses().Where(x => x.ProcessName.ToLower().StartsWith(Data.settings[0]));
            //Force the process to have something to do with flash or realm
            processes = processes.Where(x => x.ProcessName.ToLower().Contains("flashplayer") || x.ProcessName.ToLower().Contains("rotmg") || x.ProcessName.ToLower().Contains("realm"));
            //Verify that the process isn't this program
            flashplayerProcess = processes.Where(x => !x.ProcessName.Equals(Process.GetCurrentProcess().ProcessName)).FirstOrDefault();

            //If there are no processes, return false
            if (flashplayerProcess == null) {
                return false;
            }
            
            flashplayerHandle = flashplayerProcess.MainWindowHandle;
            flashplayerName = flashplayerProcess.MainWindowTitle;

            UpdateWindowLoc();

            return true;

        }

        public void UpdateWindowLoc() {
            RECT rct;

            GetWindowRect(flashplayerHandle, out rct);

            flashplayerRect.X = rct.Left;
            flashplayerRect.Y = rct.Top;
            flashplayerRect.Width = rct.Right - rct.Left;
            flashplayerRect.Height = rct.Bottom - rct.Top;
        }

        public void SendKeystroke(Keys key) {

        }

        public void UpdateWindowName() {
            flashplayerName = flashplayerProcess.MainWindowTitle;
        }

        public int GetX() {
            return flashplayerRect.X;
        }

        public int GetY() {
            return flashplayerRect.Y;
        }

        public int GetWidth() {
            return flashplayerRect.Width;
        }

        public int GetHeight() {
            return flashplayerRect.Height;
        }

        public string GetWindowName() {
            return flashplayerName;
        }

        public static string KeyConverter(Keys key) {
            switch (key) {
                case Keys.F1:
                    return "{F1}";
                case Keys.F2:
                    return "{F2}";
                case Keys.F3:
                    return "{F3}";
                case Keys.F4:
                    return "{F4}";
                case Keys.F5:
                    return "{F5}";
                case Keys.F6:
                    return "{F6}";
                case Keys.F7:
                    return "{F7}";
                case Keys.F8:
                    return "{F8}";
                case Keys.F9:
                    return "{F9}";
                case Keys.F10:
                    return "{F10}";
                case Keys.F11:
                    return "{F11}";
                case Keys.F12:
                    return "{F12}";
                case Keys.F13:
                    return "{F13}";
                case Keys.F14:
                    return "{F14}";
                case Keys.F15:
                    return "{F15}";
                case Keys.F16:
                    return "{F16}";
                case Keys.F17:
                    return "{F17}";
                case Keys.F18:
                    return "{F18}";
                case Keys.F19:
                    return "{F19}";
                case Keys.F20:
                    return "{F20}";
                case Keys.F21:
                    return "{F21}";
                case Keys.F22:
                    return "{F22}";
                case Keys.F23:
                    return "{F23}";
                case Keys.F24:
                    return "{F24}";
                default:
                    return key.ToString().ToLower();
            }
        }
    }
}
