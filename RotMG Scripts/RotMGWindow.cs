using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;

namespace RotMG_Scripts {
    /// <summary>
    /// The window that RotMG is running on
    /// </summary>
    public class RotMGWindow {

        /// <summary>
        /// Gets the rectangle from the given handle
        /// </summary>
        /// <param name="hWnd">Handle to get rect of</param>
        /// <param name="lpRect">Out: RECT to get back out</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        /// <summary>
        /// Rectangle to temproraily use for GetWindowRect
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public struct RECT {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        //Process of the flashplayer
        private Process flashplayerProcess = null;

        //Handle of the window of the flashplayer
        private IntPtr flashplayerHandle;

        //Rectangle of the window of the flashplayer
        private Rectangle flashplayerRect;

        //Name of the flashplayer
        private string flashplayerName = "";

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
            
            //Process found, so get the main window handle from that process
            flashplayerHandle = flashplayerProcess.MainWindowHandle;

            //Get the name from the main window as well
            flashplayerName = flashplayerProcess.MainWindowTitle;

            //Update the flashplayer rectangle with the newly found window's info
            flashplayerRect = GetWindowRect(flashplayerHandle);

            return true;

        }

        /// <summary>
        /// A way for other classes to tell the window to verify that the coordinates are correct
        /// </summary>
        public void UpdateWindowRect() {
            flashplayerRect = GetWindowRect(flashplayerHandle);
        }

        /// <summary>
        /// Returns a rectangle of the given handle's window
        /// </summary>
        private Rectangle GetWindowRect(IntPtr handle) {
            RECT rct;

            GetWindowRect(handle, out rct);

            Rectangle rect = new Rectangle();

            rect.X = rct.Left;
            rect.Y = rct.Top;
            rect.Width = rct.Right - rct.Left;
            rect.Height = rct.Bottom - rct.Top;

            return rect;
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
    }
}
