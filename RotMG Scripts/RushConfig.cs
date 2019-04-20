using System;

namespace RotMG_Scripts {
    /// <summary>
    /// A single config for rushing, stores the debuffs and other settings
    /// </summary>
    [Serializable]
    public class RushConfig {
        /// <summary>
        /// List of all the debuffs and whether they are on or not for the given config
        /// </summary>
        private bool[] Debuffs = new bool[18];

        /// <summary>
        /// Getter and setter for the debuffs
        /// </summary>
        public bool[] debuffs {
            get {
                return Debuffs;
            }
            set {
                Debuffs = value;
            }
        }

        /// <summary>
        /// List of the other settings and whether they are on or not for the given config
        /// </summary>
        private bool[] Others = new bool[1];

        /// <summary>
        /// Getter and setter for the debuffs
        /// </summary>
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
