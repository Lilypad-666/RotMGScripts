using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace RotMG_Scripts {

    /// <summary>
    /// Handles moving the mouse and clicking for changing settings
    /// </summary>
    public class MouseOperations {

        /// <summary>
        /// The input type
        /// </summary>
        internal struct INPUT {
            public UInt32 Type;
            public MOUSEKEYBDHARDWAREINPUT Data;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct MOUSEKEYBDHARDWAREINPUT {

            [FieldOffset(0)]
            public MOUSEINPUT Mouse;
        }

#pragma warning disable CS0649

        /// <summary>
        /// Info of the mouse input
        /// </summary>
        internal struct MOUSEINPUT {
            public Int32 X;
            public Int32 Y;
            public UInt32 MouseData;
            public UInt32 Flags;
            public UInt32 Time;
            public IntPtr ExtraInfo;
        }

        /// <summary>
        /// Moves the mouse to the given position on the given window
        /// </summary>
        /// <param name="wndHandle">Window to move the mouse on</param>
        /// <param name="clientPoint">Point to move the mouse to</param>
        public static void SetCursorPosition(IntPtr wndHandle, Point clientPoint) {
            var oldPos = Cursor.Position;

            //Set cursor on coords
            Cursor.Position = new Point(clientPoint.X, clientPoint.Y);
        }

        /// <summary>
        /// Moves the mouse to the given position and left clicks
        /// </summary>
        /// <param name="wndHandle">Window to move the mouse on</param>
        /// <param name="clientPoint">Point to click</param>
        public static void LeftMouseClick(IntPtr wndHandle, Point clientPoint) {
            var oldPos = Cursor.Position;

            //Set cursor on coords, and press mouse
            Cursor.Position = new Point(clientPoint.X, clientPoint.Y);

            var inputMouseDown = new INPUT();
            inputMouseDown.Type = 0; /// input type mouse
            inputMouseDown.Data.Mouse.Flags = 0x0002; /// left button down

            var inputMouseUp = new INPUT();
            inputMouseUp.Type = 0; /// input type mouse
            inputMouseUp.Data.Mouse.Flags = 0x0004; /// left button up

            var inputs = new INPUT[] { inputMouseDown, inputMouseUp };
            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(INPUT)));

            /// return mouse
            Cursor.Position = oldPos;
        }

        [DllImport("user32.dll")]
        internal static extern uint SendInput(uint nInputs, [MarshalAs(UnmanagedType.LPArray), In] INPUT[] pInputs, int cbSize);
    }
}