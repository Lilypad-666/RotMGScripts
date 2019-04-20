using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotMG_Scripts {
    class Data {
        //0 - Options
        //1 - Configure
        //2-9 - Rushing
        public static Keys[] hotkeys = new Keys[10];

        //Settings
        //0 - Process Name
        public static string[] settings = new string[1];

        //Window of RotMG
        public static RotMGWindow window = null;

        //Location of the RotMG save
        public static string saveLocation = "";

        //Bool to keep track of finding game
        public static bool foundGame = false;
        public static bool toggleTabs = false;

        //List of debuffs in their current state
        public static int[] debuffSettings = new int[18];
    }
}
