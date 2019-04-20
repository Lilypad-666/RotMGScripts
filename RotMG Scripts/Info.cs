using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotMG_Scripts {
    /// <summary>
    /// Info that's rarely if ever changed by the code
    /// </summary>
    public class Info {
        //Whether we're in debug mode or not
        public static bool debug;

        //Version of the program
        public static string version;

        //List of debuffs to search the save file for
        public static readonly string[] debuffNames = new string[18] { "Quiet", "Slowed", "Dazed", "Paralyzed", "ArmorBroken", "Petrified", "Blind", "Drunk", "Unstable", "Weak", "Sick", "Stunned", "Bleeding", "PetStasis", "Silenced", "Hallucinating", "Confused", "Darkness" };

        //List of others to search the save file for
        public static readonly string[] otherNames = new string[1] { "MobInfo" };
    }
}
