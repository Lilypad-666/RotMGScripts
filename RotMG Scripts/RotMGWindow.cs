using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace RotMG_Scripts {

    /// <summary>
    /// The window that RotMG is running on
    /// </summary>
    public class RotMGWindow {

        /// <summary>
        /// Process of the flashplayer
        /// </summary>
        private Process flashplayerProcess = null;

        /// <summary>
        /// Handle of the window of the flashplayer
        /// </summary>
        private IntPtr flashplayerHandle;

        /// <summary>
        /// Rectangle of the window of the flashplayer
        /// </summary>
        private Rectangle flashplayerRect;

        /// <summary>
        /// Name of the flashplayer
        /// </summary>
        private string flashplayerName = "";

        private const int WM_KEYDOWN = 0x100;
        private const int WM_KEYUP = 0x101;
        private const int WM_CHAR = 0x105;

        /// <summary>
        /// Resets everything back to default
        /// </summary>
        public void Clear() {
            flashplayerProcess = null;
            flashplayerHandle = IntPtr.Zero;
            flashplayerRect = new Rectangle();
            flashplayerName = "";
        }

        /// <summary>
        /// Returns true if the focused window is the one we want
        /// </summary>
        /// <returns></returns>
        public bool IsFocusedWindow() {
            string title = GetActiveWindowTitle();

            if (title != null) {
                return title.Equals(flashplayerName);
            }

            return false;
        }

        /// <summary>
        /// Returns the title of the currently active window
        /// </summary>
        /// <returns></returns>
        private string GetActiveWindowTitle() {
            const int nChars = 256;
            StringBuilder Buff = new StringBuilder(nChars);
            IntPtr handle = GetForegroundWindow();

            if (GetWindowText(handle, Buff, nChars) > 0) {
                return Buff.ToString();
            }
            return null;
        }

        /// <summary>
        /// Returns whether the current flashplayer process is valid
        /// </summary>
        /// <returns></returns>
        public bool ValidflashplayerProcess() {
            //If the flashplayer process is null or has exited
            if (flashplayerProcess == null || flashplayerProcess.HasExited) {
                return false;
            }

            //Or if the name is empty
            if (flashplayerName == "") {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Attempts to locate the flashplayer running RotMG
        /// </summary>
        /// <returns></returns>
        public bool FindflashplayerProcess() {
            //Force the process name to be something
            if (((string)Data.settings[0]).Length < 1) {
                return false;
            }

            //Get all matching processes
            IEnumerable<Process> processes = Process.GetProcesses().Where(x => x.ProcessName.ToLower().StartsWith((string)Data.settings[0]));

            //Force the process to have something to do with flash or realm
            processes = processes.Where(x => x.ProcessName.ToLower().Contains("flashplayer") || x.ProcessName.ToLower().Contains("rotmg") || x.ProcessName.ToLower().Contains("realm"));

            //Verify that the process isn't this program
            flashplayerProcess = processes.Where(x => !x.ProcessName.Equals(Process.GetCurrentProcess().ProcessName)).FirstOrDefault();

            //If there are no processes, return false
            if (flashplayerProcess == null) {
                return false;
            }

            //Process found, so get the main window handle from that process
            flashplayerHandle = flashplayerProcess.MainWindowHandle;

            //Get the name from the main window as well
            flashplayerName = flashplayerProcess.MainWindowTitle;

            //Update the flashplayer rectangle with the newly found window's info
            GetWindowSize();

            return true;
        }

        /// <summary>
        /// A way for other classes to tell the window to verify that the coordinates are correct
        /// </summary>
        public void UpdateWindowRect() {
            bool mouseIsDown = GetAsyncKeyState(VK_LBUTTON) < 0;
            if (!mouseIsDown) {
                GetWindowSize();
            }
        }

        /// <summary>
        /// Gets the window's rect and stores it
        /// </summary>
        private void GetWindowSize() {
            RECT rct;

            //Gets the width and height of the window
            GetClientRect(flashplayerHandle, out rct);

            flashplayerRect.Width = rct.Right;
            flashplayerRect.Height = rct.Bottom;

            //Gets the x and y of the window on the screen
            GetWindowRect(flashplayerHandle, ref rct);

            flashplayerRect.X = rct.Left + 9;
            flashplayerRect.Y = rct.Top + 2;

            if (flashplayerName != "" && (int)Data.settings[3] != 3) {
                bool validResize = true;
                foreach (Screen s in Screen.AllScreens) {
                    if (flashplayerRect.Width == s.Bounds.Width && flashplayerRect.Height == s.Bounds.Height) {
                        validResize = false;
                    }
                }

                if (validResize) {
                    ResizeWindow((int)Data.settings[3]);
                }
            }
        }

        /// <summary>
        /// Resizes the window to the requested aspect ratio
        /// </summary>
        /// <param name="ratio"></param>
        public void ResizeWindow(int ratio) {
            bool validResize = false;
            //Get the window's placement to tell if maximized or minimized
            WINDOWPLACEMENT placement = new WINDOWPLACEMENT();
            GetWindowPlacement(flashplayerHandle, ref placement);
            //If not minizimed or maximized
            validResize = placement.showCmd.Equals(1);

            if (validResize) {
                float idealWidth = 0;

                //4:3
                if (ratio == 0) {
                    idealWidth = flashplayerRect.Height * (4f / 3f);

                    if (idealWidth < 300) {
                        idealWidth = 300;
                        flashplayerRect.Height = (int)(idealWidth * (3f / 4f));

                        flashplayerRect.Y -= 2;
                        flashplayerRect.X -= 9;
                    }
                }

                //16:9
                if (ratio == 1) {
                    idealWidth = flashplayerRect.Height * (16f / 9f);

                    if (idealWidth < 300) {
                        idealWidth = 300;
                        flashplayerRect.Height = (int)(idealWidth * (9f / 16f));

                        flashplayerRect.Y -= 2;
                        flashplayerRect.X -= 9;
                    }
                }

                //1:1
                if (ratio == 2) {
                    idealWidth = flashplayerRect.Height * (1f / 1f);

                    if (idealWidth < 300) {
                        idealWidth = 300;
                        flashplayerRect.Height = 300;

                        flashplayerRect.Y -= 2;
                        flashplayerRect.X -= 9;
                    }
                }

                if (Math.Abs(idealWidth - flashplayerRect.Width) > 10) {
                    idealWidth += 4;
                    MoveWindow(flashplayerHandle, flashplayerRect.X, flashplayerRect.Y, (int)idealWidth, flashplayerRect.Height + 50, true);
                    flashplayerRect.Width = (int)idealWidth;
                }
            }
        }

        /// <summary>
        /// Opens the game settings
        /// </summary>
        public void OpenSettings() {
            //Send the settings key
            SendMessage(flashplayerHandle, WM_KEYDOWN, Convert.ToInt32(Data.hotkeys[0]), 0);
            SendMessage(flashplayerHandle, WM_KEYUP, Convert.ToInt32(Data.hotkeys[0]), 0);
        }

        /// <summary>
        /// Changes to the given tab
        /// </summary>
        /// <param name="location"></param>
        public void SettingsTab(Info.headerNames location) {
            ClickMouse(Info.headerPoints[(int)location - 1]);
        }

        /// <summary>
        /// Clicks the close settings button
        /// </summary>
        public void CloseSettings() {
            //Close the settings if they're open
            ClickMouse(Info.closeOptions);
        }

        /// <summary>
        /// Clicks the mouse at the given x and y percent
        /// </summary>
        /// <param name="xPercent">x percent to click at, 0-100</param>
        /// <param name="yPercent">y percent to click at, 0-100</param>
        public void ClickMouse(float xPercent, float yPercent) {
            Point absolute = RelativeToAbsolute(xPercent, yPercent);

            MouseOperations.LeftMouseClick(flashplayerHandle, absolute);
        }

        /// <summary>
        /// Clicks the mouse at the given percent point
        /// </summary>
        /// <param name="pointPercent">percent point to click at</param>
        public void ClickMouse(Info.PercentPoint pointPercent) {
            Point absolute = RelativeToAbsolute(pointPercent.X, pointPercent.Y);

            MouseOperations.LeftMouseClick(flashplayerHandle, absolute);
        }

        /// <summary>
        /// Moves the mouse to the given x and y percent
        /// </summary>
        /// <param name="xPercent">x percent to move mouse to, 0-100</param>
        /// <param name="yPercent">y percent to move mouse to, 0-100</param>
        public void MoveMouse(float xPercent, float yPercent) {
            Point absolute = RelativeToAbsolute(xPercent, yPercent);

            MouseOperations.SetCursorPosition(flashplayerHandle, absolute);
        }

        /// <summary>
        /// Moves the mouse to the given percent point
        /// </summary>
        /// <param name="pointPercent">percent point to move mouse to</param>
        public void MoveMouse(Info.PercentPoint pointPercent) {
            Point absolute = RelativeToAbsolute(pointPercent.X, pointPercent.Y);

            MouseOperations.SetCursorPosition(flashplayerHandle, absolute);
        }

        /// <summary>
        /// Clicks the given debuff
        /// </summary>
        /// <param name="index">index of the debuff to click</param>
        public void ClickDebuff(int index) {
            Point absolute = RelativeToAbsolute(Info.debuffPoints[index]);

            MouseOperations.LeftMouseClick(flashplayerHandle, absolute);
        }

        /// <summary>
        /// Clicks the given "other" setting
        /// </summary>
        /// <param name="index">index of the other setting to click</param>
        public void ClickOther(int index) {
            Point absolute = RelativeToAbsolute(Info.otherPoints[index]);

            MouseOperations.LeftMouseClick(flashplayerHandle, absolute);
        }

        /// <summary>
        /// Converts a percent point to an absolute point
        /// </summary>
        /// <param name="percentPoint">percent point to convert to absolute</param>
        /// <returns></returns>
        public Point RelativeToAbsolute(Info.PercentPoint percentPoint) {
            return RelativeToAbsolute(percentPoint.X, percentPoint.Y);
        }

        /// <summary>
        /// Converts a relative point to an absolute point
        /// </summary>
        /// <param name="x">x point to convert to absolute</param>
        /// <param name="y">y point to convert to absolute</param>
        /// <returns></returns>
        public Point RelativeToAbsolute(float x, float y) {
            //Convert the x and y to percents
            float percentX = x / 100f;
            float percentY = y / 100f;

            //Get the starting x and y
            float startingX = flashplayerRect.X;
            float startingY = flashplayerRect.Y + 50;

            //Get the starting width and height
            float width = flashplayerRect.Width;
            float height = flashplayerRect.Height;

            //Convert the percents to real x and y values
            int totalX = (int)(startingX + (width * percentX));
            int totalY = (int)(startingY + (height * percentY));

            return new Point(totalX, totalY);
        }

        /// <summary>
        /// Returns the X coordinate of the window
        /// </summary>
        /// <returns></returns>
        public int GetX() {
            return flashplayerRect.X;
        }

        /// <summary>
        /// Returns the Y coordinate of the window
        /// </summary>
        /// <returns></returns>
        public int GetY() {
            return flashplayerRect.Y;
        }

        /// <summary>
        /// Returns the Width of the window
        /// </summary>
        /// <returns></returns>
        public int GetWidth() {
            return flashplayerRect.Width;
        }

        /// <summary>
        /// Returns the Height of the window
        /// </summary>
        /// <returns></returns>
        public int GetHeight() {
            return flashplayerRect.Height;
        }

        /// <summary>
        /// Returns the name of the window
        /// </summary>
        /// <returns></returns>
        public string GetWindowName() {
            return flashplayerName;
        }

        public const int VK_LBUTTON = 0x01;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpwndpl);

        [DllImport("user32.dll")]
        private static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref RECT rectangle);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);

        private struct WINDOWPLACEMENT {
            public int length;
            public int flags;
            public int showCmd;
            public Point ptMinPosition;
            public Point ptMaxPosition;
            public Rectangle rcNormalPosition;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }
    }
}