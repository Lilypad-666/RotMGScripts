using System;

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

        //List of debuffs to search the save file for
        public static readonly string[] debuffNames = new string[18] { "Quiet", "Slowed", "Dazed", "Paralyzed", "ArmorBroken", "Petrified", "Blind", "Drunk", "Unstable", "Weak", "Sick", "Stunned", "Bleeding", "PetStasis", "Silenced", "Hallucinating", "Confused", "Darkness" };

        //List of others to search the save file for
        public static readonly string[] otherNames = new string[1] { "MobInfo" };

        //List of control offsets
        public static readonly int[] controlOffsets = new int[1] { 1 };

        //Keyboard hooks
        public const int WH_KEYBOARD_LL = 13;
        public const int WM_KEYDOWN = 0x0100;
        public static KeyboardHook.LowLevelKeyboardProc proc = KeyboardHook.HookCallback;
        public static IntPtr hookId = IntPtr.Zero;
        
    }
}
