using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotMG_Scripts {
    /// <summary>
    /// Data that's often changed by the code, easy way to access everything
    /// </summary>
    public class Data {

        //0 - Options
        //1 - Configure
        //2-9 - Rushing
        public static Keys[] hotkeys = new Keys[10];

        //Settings
        //0 - Process Name
        public static string[] settings = new string[1];

        //The 8 rushing configs to save/load from file
        public static RushConfig[] rushConfigs = new RushConfig[8];

        //Images that are used throughout the project
        public static Bitmap[] images = new Bitmap[1];

        //Keep track of the previous command
        public static List<string> previousCommands = new List<string>();
        public static int currentCommand = -1;

        //Window of RotMG
        public static RotMGWindow window = null;

        //Location of the RotMG save
        public static string saveLocation = "";

        //Bool to keep track of finding game
        public static bool foundGame = false;
        public static bool toggleTabs = false;

        //List of debuffs in their current state
        public static int[] debuffSettings = new int[18];

        //List of other settings in their current state
        public static int[] otherSettings = new int[1];

        //Delay for the timer
        public static int timerDelay = 500;

        //A reference to the main form
        public static MainForm form = null;

        /// <summary>
        /// Saves the given data to the file as binary
        /// </summary>
        /// <typeparam name="T">Type of object to write</typeparam>
        /// <param name="filePath">Name of the file to save to</param>
        /// <param name="objectToWrite">Object to write</param>
        public static void Save<T>(string filePath, T objectToWrite) {
            using (Stream stream = File.Open("Data/" + filePath, FileMode.Create)) {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        /// <summary>
        /// Reads the data from the file back to type T
        /// </summary>
        /// <typeparam name="T">Type of object to read to</typeparam>
        /// <param name="filePath">Name of the file to read from</param>
        /// <returns></returns>
        public static T Load<T>(string filePath) {
            using (Stream stream = File.Open("Data/" + filePath, FileMode.Open)) {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }

        /// <summary>
        /// Loads all the data from file and links
        /// </summary>
        public static void loadAllData() {
            int count = 0;

            //Locates the RotMG save
            while (!FindRotMGSaveLocation()) {
                count++;

                if (count <= 3) {
                    //Write to the console with an error to give the user a chance to exit
                    Console.WriteLine("Can't find your RotMG save data, attempt " + count + ".", Console.logTypes.ERROR);
                } else { 
                    //Tried 3 times, no data there
                    Console.WriteLine("There is no locatable RotMG save data. Aborting.", Console.logTypes.FATAL);
                }
            }

            //Load data from the game's save and from this program's saves
            LoadData();

            //Load our images from URLs
            LoadImages();
        }

        /// <summary>
        /// Attempts to locates the RotMG save data
        /// </summary>
        private static bool FindRotMGSaveLocation() {
            //If the save location isn't valid
            if (saveLocation == "" || !File.Exists(saveLocation)) {
                //Clear it
                saveLocation = "";

                //Get the known path
                string partialPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Macromedia\Flash Player\#SharedObjects\");
                
                //Get all paths to files called AssembleeGameClientOptions.sol
                string[] paths = Directory.GetFiles(partialPath, "AssembleeGameClientOptions.sol", SearchOption.AllDirectories);

                //Find the one that contains localhost in the name, as that seems to be the correct one
                foreach (string s in paths) {
                    if (s.Contains("localhost")) {
                        saveLocation = s;
                        break;
                    }
                }
            }

            //If there's still no valid save location
            if (saveLocation == "" || !File.Exists(saveLocation)) {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Loads all data, both in the Data folder and from the RotMG save
        /// </summary>
        private static void LoadData() {
            //Keybinds
            if (File.Exists("Data/hotkeys.dat")) {
                Console.WriteLine("Loading hotkeys file");
                //If the file exists, read it to the hotkeys array
                hotkeys = Load<Keys[]>("hotkeys.dat");
                List<TextBox> boxes = MainForm.FindControls<TextBox>("HotkeyBox");

                for (int i = 0; i < Data.hotkeys.Length; i++) {
                    //If the hotkey isn't set to "None"
                    if (i < boxes.Count && hotkeys[i] != Keys.None) {
                        //Set the Hotkey's box (if it exists) to the correct string
                        TextBox box = boxes[i];

                        if (box != null) {
                            KeysConverter kc = new KeysConverter();
                            box.Text = kc.ConvertToString(hotkeys[i]);
                        }
                    }
                }
            } else {
                Console.WriteLine("Hotkeys file not found");
                //If the file doesn't exist, set default options key to "O"
                hotkeys[0] = Keys.O;
                form.HotkeyBox0.Text = "O";
            }

            //Rush configs
            if (File.Exists("Data/rushconfigs.dat")) {
                Console.WriteLine("Loading rush configs file");
                rushConfigs = Load<RushConfig[]>("rushconfigs.dat");
            } else {
                Console.WriteLine("Rush configs file not found");
            }

            //Other settings
            if (File.Exists("Data/settings.dat")) {
                Console.WriteLine("Loading settings file");
                settings = Load<string[]>("settings.dat");
                form.ProcessName.Text = settings[0];
            } else {
                Console.WriteLine("Settings file not found");
                settings[0] = "flashplayer";
            }

            //RotMG Data
            if (File.Exists(saveLocation)) {
                //Load the file into a byte array
                byte[] byteArray = File.ReadAllBytes(saveLocation);

                //Convert that byte array into chars
                string charString = Encoding.Default.GetString(byteArray);

                //Run through each debuff
                for (int i = 0; i < Info.debuffNames.Length; i++) {
                    //Get the name of the debuff
                    string name = Info.debuffNames[i];

                    //Get the index of that name in the save file
                    int index = charString.IndexOf(name);

                    //Get the hex byte of the value directly after the name ends
                    byte hex = byteArray[index + name.Length];

                    if (hex == 3) {
                        //Enabled
                        debuffSettings[i] = 1;
                    } else if (hex == 2) {
                        //Disabled
                        debuffSettings[i] = -1;
                    } else {
                        //Should never happen
                        debuffSettings[i] = 0;
                        Console.WriteLine(name + " IS " + hex + "! PLEASE REPORT THIS ASAP!", Console.logTypes.ERROR);
                    }
                }

                //Run through each other option
                for (int i = 0; i < Info.otherNames.Length; i++) {
                    //Get the name of the setting
                    string name = Info.otherNames[i];

                    //Get the index of that name in the save file
                    int index = charString.IndexOf(name);

                    //Get the hex byte of the value directly after the name ends
                    byte hex = byteArray[index + name.Length];

                    if (hex == 3) {
                        //Enabled
                        otherSettings[i] = 1;
                    } else if (hex == 2) {
                        //Disabled
                        otherSettings[i] = -1;
                    } else {
                        //Should never happen
                        otherSettings[i] = 0;
                        Console.WriteLine(name + " IS " + hex + "! PLEASE REPORT THIS ASAP!", Console.logTypes.ERROR);
                    }
                }
            } else {
                //Save location isn't valid so try to re-locate it.
                FindRotMGSaveLocation();
            }
        }

        /// <summary>
        /// Loads all our images into an array for easy access later
        /// </summary>
        private static void LoadImages() {
            images[0] = new Bitmap(WebRequest.Create("http://drive.google.com/uc?export=view&id=1-cB9ogUaib_1ZwPSXMHzY8jtTuzicobt").GetResponse().GetResponseStream());
        }
    }
}
