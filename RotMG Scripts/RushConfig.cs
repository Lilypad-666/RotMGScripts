using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Scripts {
    [Serializable]
    public class RushConfig {
        private bool[] Debuffs = new bool[19];

        public bool[] debuffs {
            get {
                return Debuffs;
            }
            set {
                Debuffs = value;
            }
        }

        private bool[] Others = new bool[1];

        public bool[] others {
            get {
                return Others;
            }

            set {
                Others = value;
            }
        }
    }
}
