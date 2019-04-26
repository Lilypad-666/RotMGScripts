using System;

namespace RotMG_Scripts {

    /// <summary>
    /// Static info to keep track of
    /// </summary>
    public class Info {

        /// <summary>
        /// Whether we're in debug mode or not
        /// </summary>
        public static bool debug;

        /// <summary>
        /// Bool to keep track of finding game
        /// </summary>
        public static bool foundGame = false;

        /// <summary>
        /// Whether we're toggling tabs
        /// </summary>
        public static bool toggleTabs = false;

        /// <summary>
        /// Bool to keep track of active window
        /// </summary>
        public static bool isFocusedWindow = false;

        /// <summary>
        /// Version of the program
        /// </summary>
        public static string version;

        /// <summary>
        /// Delay for the search timer
        /// </summary>
        public static int searchDelay = 2000;

        /// <summary>
        /// Delay for the update timer
        /// </summary>
        public static int updateDelay = 250;

        /// <summary>
        /// The current delay for the timer
        /// </summary>
        public static int currentDelay = 2000;

        /// <summary>
        /// Count of debuff options
        /// </summary>
        public const int debuffsCount = 18;

        /// <summary>
        /// Count of other options
        /// </summary>
        public const int othersCount = 5;

        /// <summary>
        /// Names of the different in-game option categories
        /// </summary>
        public enum headerNames {
            None = 0,
            Debuffs = 1,
            Visual = 2,
            World = 3
        }

        /// <summary>
        /// Location of the close options button
        /// </summary>
        public static readonly PercentPoint closeOptions = new PercentPoint(50, 92);

        /// <summary>
        /// Locations of the in-game options categories
        /// </summary>
        public static readonly PercentPoint[] headerPoints = new PercentPoint[3] {
            new PercentPoint(5.5f, 14),
            new PercentPoint(69.75f, 14),
            new PercentPoint(44, 14)
        };

        /// <summary>
        /// List of debuffs to search the save file for
        /// </summary>
        public static readonly string[] debuffNames = new string[debuffsCount] {
            "Quiet",
            "Slowed",
            "Dazed",
            "Paralyzed",
            "ArmorBroken",
            "Petrified",
            "Blind",
            "Drunk",
            "Unstable",
            "Weak",
            "Sick",
            "Stunned",
            "Bleeding",
            "PetStasis",
            "Silenced",
            "Hallucinating",
            "Confused",
            "Darkness" };

        /// <summary>
        /// List of in-game debuff locations
        /// </summary>
        public static readonly PercentPoint[] debuffPoints = new PercentPoint[debuffsCount] {
            new PercentPoint(7, 23),
            new PercentPoint(7, 30.5f),
            new PercentPoint(7, 37.25f),
            new PercentPoint(7, 45),
            new PercentPoint(7, 52.25f),
            new PercentPoint(7, 59.5f),
            new PercentPoint(7, 67),
            new PercentPoint(7, 74.25f),
            new PercentPoint(7, 81.5f),
            new PercentPoint(57, 23),
            new PercentPoint(57, 30.5f),
            new PercentPoint(57, 37.25f),
            new PercentPoint(57, 45),
            new PercentPoint(57, 52.25f),
            new PercentPoint(57, 59.5f),
            new PercentPoint(57, 67),
            new PercentPoint(57, 74.25f),
            new PercentPoint(57, 81.5f)
        };

        /// <summary>
        /// List of others to search the save file for
        /// </summary>
        public static readonly string[] otherNames = new string[othersCount] {
            "MobInfo",
            "ethDisable",
            "Colossus",
            "cultiststaffDisable",
            "VoidBow"
        };

        /// <summary>
        /// List of other in-game setting locations
        /// </summary>
        public static readonly PercentPoint[] otherPoints = new PercentPoint[othersCount] {
            new PercentPoint(57, 45),
            new PercentPoint(7, 23),
            new PercentPoint(7, 30.5f),
            new PercentPoint(57, 23),
            new PercentPoint(57, 30.5f)
        };

        /// <summary>
        /// List of control offsets
        /// </summary>
        public static readonly int[] controlOffsets = new int[2] { 1, 9 };

        //Keyboard hooks
        public const int WH_KEYBOARD_LL = 13;
        public const int WM_KEYDOWN = 0x0100;
        public static KeyboardHook.LowLevelKeyboardProc proc = KeyboardHook.HookCallback;
        public static IntPtr hookId = IntPtr.Zero;

        /// <summary>
        /// A struct to handle points in percent, 0-100
        /// </summary>
        public struct PercentPoint {
            public float X;
            public float Y;

            /// <summary>
            /// Create a percent point
            /// </summary>
            /// <param name="x">Percet of x, 0-100</param>
            /// <param name="y">Percent of y, 0-100</param>
            public PercentPoint(float x, float y) {
                X = x;
                Y = y;

                if (X < 0) {
                    X = 0;
                }

                if (X > 100) {
                    X = 100;
                }

                if (Y < 0) {
                    Y = 0;
                }

                if (Y > 100) {
                    Y = 100;
                }
            }
        }
    }
}