using System;
using System.Threading;

namespace RotMG_Scripts {
    /// <summary>
    /// Info to keep track of
    /// </summary>
    public class Info {
        //Whether we're in debug mode or not
        public static bool debug;

        //Bool to keep track of finding game
        public static bool foundGame = false;
        public static bool toggleTabs = false;

        //Bool to keep track of active window
        public static bool isFocusedWindow = false;

        //Version of the program
        public static string version;

        //Delays for the timer
        public static int searchDelay = 1000;
        public static int updateDelay = 200;
        public static int currentDelay = 1000;

        //Count of options
        public const int debuffsCount = 18;
        public const int othersCount = 5;

        public enum headerNames {
            None = 0,
            Debuffs = 1,
            Visual = 2,
            World = 3
        }

        public static readonly PercentPoint closeOptions = new PercentPoint(50, 92);

        public static readonly PercentPoint[] headerPoints = new PercentPoint[3] {
            new PercentPoint(5.5f, 14),
            new PercentPoint(69.75f, 14),
            new PercentPoint(44, 14)
        };

        //List of debuffs to search the save file for
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

        //List of others to search the save file for
        public static readonly string[] otherNames = new string[othersCount] {
            "MobInfo",
            "ethDisable",
            "Colossus",
            "cultiststaffDisable",
            "VoidBow"
        };

        public static readonly PercentPoint[] otherPoints = new PercentPoint[othersCount] {
            new PercentPoint(57, 45),
            new PercentPoint(7, 23),
            new PercentPoint(7, 30.5f),
            new PercentPoint(57, 23),
            new PercentPoint(57, 30.5f)
        };

        //List of control offsets
        public static readonly int[] controlOffsets = new int[2] { 1, 9 };

        //Keyboard hooks
        public const int WH_KEYBOARD_LL = 13;
        public const int WM_KEYDOWN = 0x0100;
        public static KeyboardHook.LowLevelKeyboardProc proc = KeyboardHook.HookCallback;
        public static IntPtr hookId = IntPtr.Zero;

        public struct PercentPoint {
            public float X;
            public float Y;

            public PercentPoint(float x, float y) {
                X = x;
                Y = y;
            }
        }
    }
}
