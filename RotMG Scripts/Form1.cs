using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RotMG_Scripts {
    public partial class RotMGHotkeys : Form {

        public static string version;

        //The 8 rushing configs to save/load from file
        public RushConfig[] rushConfigs = new RushConfig[8];

        //The current hotkey that we're updating, see the hotkeys array above for meanings
        private int updatingHotkey = -1;

        //Timer that runs to ensure that the game is still running and valid
        private Timer updateTimer;

        public RotMGHotkeys() {
            InitializeComponent();

            //Creates the data directory
            Directory.CreateDirectory("Data");

            //Doesn't allow resizing or maximizing of the window
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            //Lets the program see keys even when it's not focused (for hotkeys)
            KeyPreview = true;

            //Crates a new RotMGWindow
            Data.window = new RotMGWindow();

            ToggleTabs();

            //Adds events for tabs to be able to disable them
            mainTabControl.Selecting += MainTabControlSelecting;

            //Adds events for others
            Load += new EventHandler(FormLoaded);
            KeyDown += new KeyEventHandler(KeyPressed);

            version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            Text += version;

            findSaveLocation();

            //Loads any save data if it exists
            LoadSavedData();

            //Load data from the game
            LoadRotMGData();
        }

        public void findSaveLocation() {
            if (Data.saveLocation == "" || !File.Exists(Data.saveLocation)) {
                Data.saveLocation = "";
                string partialPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Macromedia\Flash Player\#SharedObjects\");
                string[] paths = Directory.GetFiles(partialPath, "AssembleeGameClientOptions.sol", SearchOption.AllDirectories);

                foreach (string s in paths) {
                    if (s.Contains("localhost")) {
                        Data.saveLocation = s;
                    }
                }
            }

            if (Data.saveLocation == "") {
                string message = "Can't find your save data, the program will now exit.";
                string caption = "No Save!";

                MessageBox.Show(message, caption, MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        private void LoadRotMGData() {
            if (File.Exists(Data.saveLocation)) {
                byte[] byteArray = File.ReadAllBytes(Data.saveLocation);

                string charString = Encoding.Default.GetString(byteArray);

                for (int i = 0; i < Info.debuffNames.Length; i++) {
                    string name = Info.debuffNames[i];
                    int index = charString.IndexOf(name);
                    byte hex = byteArray[index + name.Length];

                    if (hex == 3) {
                        //Enabled
                        Data.debuffSettings[i] = 1;
                    } else if (hex == 2) {
                        //Disabled
                        Data.debuffSettings[i] = -1;
                    } else {
                        //Should never happen
                        Data.debuffSettings[i] = 0;
                        Console.WriteLine("ERROR: " + name + " IS " + hex + "! PLEASE REPORT THIS ASAP!");
                    }
                }
            } else {
                findSaveLocation();
            }


        }

        private void LoadSavedData() {
            //Keybinds
            if (File.Exists("Data/hotkeys.dat")) {
                //If the file exists, read it to the hotkeys array
                Data.hotkeys = ReadFromBinaryFile<Keys[]>("hotkeys.dat");

                for (int i = 0; i < Data.hotkeys.Length; i++) {
                    //If the hotkey isn't set to "None"
                    if (Data.hotkeys[i] != Keys.None) {
                        //Set the Hotkey's box (if it exists) to the correct string
                        Control[] controls = Controls.Find("HotkeyBox" + i, true);

                        if (controls != null && controls.Length > 0) {
                            KeysConverter kc = new KeysConverter();
                            controls[0].Text = kc.ConvertToString(Data.hotkeys[i]);
                        }
                    }
                }
            } else {
                //If the file doesn't exist, set default options key to "O"
                Data.hotkeys[0] = Keys.O;
                Controls.Find("HotkeyBox0", true)[0].Text = "O";
            }

            //Rush configs
            if (File.Exists("Data/rushconfigs.dat")) {
                rushConfigs = ReadFromBinaryFile<RushConfig[]>("rushconfigs.dat");
            }

            //Other settings
            if (File.Exists("Data/settings.dat")) {
                Data.settings = ReadFromBinaryFile<string[]>("settings.dat");
                ProcessName.Text = Data.settings[0];
            } else {
                Data.settings[0] = "flashplayer";
            }
        }

        public void FormLoaded(object sender, EventArgs e) {
            //Start the timer once the form is loaded
            InitTimer();

            TabPage firstRushingTab = CreateTab("rushingTabControl", new RushingUserControl(this, 0), 0);

            for (int i = 1; i < rushConfigs.Length; i++) {
                if (rushConfigs[i] != null) {
                    CreateTab("rushingTabControl", new RushingUserControl(this, i), i);
                }
            }

            rushingTabControl.SelectedTab = firstRushingTab;

            HotkeyButton0.Click += new EventHandler(HotkeyButtonClick);
            HotkeyButton1.Click += new EventHandler(HotkeyButtonClick);

            ConfigButton.Click += new EventHandler(ConfigClick);

            ProgramInfoTab.Paint += new PaintEventHandler(InfoTabPaint);

            ProcessName.TextChanged += new EventHandler(ProcessTextChanged);

            (ProgramInfoTab.Controls.Find("VersionLabel", true)[0] as Label).Text += version;
        }

        private void ProcessTextChanged(object sender, EventArgs e) {
            TextBox box = sender as TextBox;
            box.Text = box.Text.ToLower();
            Data.settings[0] = box.Text;
            WriteToBinaryFile("settings.dat", Data.settings);
            Data.window.clear();
            RestoreWindowInfoDefault();
            Data.foundGame = false;
            ToggleTabs();
        }

        private void InfoTabPaint(object sender, PaintEventArgs e) {
            //Draws the images on the program info tab
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream stream = assembly.GetManifestResourceStream("RotMG_Scripts.Images.Lilypad-666.png");
            Bitmap bitmap = new Bitmap(stream);

            Graphics g = e.Graphics;
            g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;

            e.Graphics.DrawImage(bitmap, 250, 170, 150, 150);
        }

        private void InitTimer() {
            //Creates a timer on a x ms interval
            updateTimer = new Timer();
            updateTimer.Tick += new EventHandler(UpdateTimerTick);
            updateTimer.Interval = 500;
            updateTimer.Start();
        }

        private void UpdateTimerTick(object sender, EventArgs e) {
            //When the timer ticks, update the RotMG window's location
            UpdateRotMGWindow();

            if (Data.toggleTabs) {
                ToggleTabs();
                Data.toggleTabs = false;
            }
        }

        private void UpdateRotMGWindow() {
            //If the window is no longer a valid process
            if (!Data.window.ValidflashplayerProcess()) {

                //Try to find the new flashplayer window
                if (Data.window.FindflashplayerProcess()) {

                    //If the process is found but the window handle isn't, don't enable anything
                    if (Data.window.GetWindowName() == "") {
                        return;
                    }

                    //If found, set the text and enable the panels and tabs
                    RotMGProcess.Text = Data.window.GetWindowName();

                    Data.foundGame = true;
                    Data.toggleTabs = true;
                } else {
                    RestoreWindowInfoDefault();
                }
            } else {
                //The window is still a valid process, so verify that the Data.window's dimensions are correct
                //We don't care about x and y because the clicks are all relative
                Data.window.UpdateWindowLoc();

                //Update the given info on the screen
                windowXBox.Text = Data.window.GetX().ToString();
                windowYBox.Text = Data.window.GetY().ToString();
                windowWidthBox.Text = Data.window.GetWidth().ToString();
                windowHeightBox.Text = Data.window.GetHeight().ToString();
            }

        }

        private void ToggleTabs() {
            if (mainTabControl.SelectedTab != MainTab && mainTabControl.SelectedTab != ProgramInfoTab) {
                mainTabControl.SelectedTab = MainTab;
            }

            FoundPanel.Enabled = Data.foundGame;

            foreach (TabPage tab in mainTabControl.TabPages) {
                if (tab != MainTab && tab != ProgramInfoTab) {
                    tab.Enabled = Data.foundGame;
                }
            }
        }

        private void RestoreWindowInfoDefault() {
            //Sets the window info back to default
            windowXBox.Text = "N/A";
            windowYBox.Text = "N/A";
            windowWidthBox.Text = "N/A";
            windowHeightBox.Text = "N/A";
            RotMGProcess.Text = "Not Found...";
        }

        private void MainTabControlSelecting(object sender, TabControlCancelEventArgs e) {
            //This is called when the tabpage is disabled, doesn't let the user use the tab
            if (!e.TabPage.Enabled) {
                e.Cancel = true;
            }
        }

        public void SetHotkey(int index) {
            //Disables the window until the hotkey is set
            mainTabControl.Enabled = false;
            updatingHotkey = index;
        }

        private void KeyPressed(object sender, KeyEventArgs e) {

            if (updatingHotkey >= 0) {
                KeysConverter kc = new KeysConverter();
                if (updatingHotkey == 0) {
                    string key = kc.ConvertToString(e.KeyCode);
                    Regex regex = new Regex(@"^[0-9]+$");
                    //Only allows A-Z, 0-9, and F1-F24
                    if (key.Length > 1) {
                        if (key.Length > 3 || !key.Substring(0, 1).Equals("F") || !regex.IsMatch(key.Substring(1, key.Length - 1))) {
                            OptionsWarningLabel1.ForeColor = Color.DarkRed;
                            OptionsWarningLabel2.ForeColor = Color.DarkRed;

                            Button btn = Controls.Find("HotkeyButton" + updatingHotkey, true)[0] as Button;
                            btn.Text = "Edit...";

                            updatingHotkey = -1;

                            //Re-enable the form
                            mainTabControl.Enabled = true;

                            string message = "Options key must be A-Z, 0-9, or F1-F24!";
                            string caption = "Invalid Key!";

                            MessageBox.Show(message, caption, MessageBoxButtons.OK);

                            return;
                        }
                    }
                }

                int oldIndex = Array.IndexOf(Data.hotkeys, e.KeyCode);

                if (oldIndex != -1) {
                    Control[] temp = Controls.Find("HotkeyBox" + oldIndex, true);

                    if (temp != null && temp.Length > 0) {
                        TextBox oldBox = temp[0] as TextBox;
                        oldBox.Text = "N/A";
                    }

                    Data.hotkeys[oldIndex] = Keys.None;
                }

                Data.hotkeys[updatingHotkey] = e.KeyCode;

                TextBox newBox = Controls.Find("HotkeyBox" + updatingHotkey, true)[0] as TextBox;

                newBox.Text = kc.ConvertToString(e.KeyCode);

                Button button = Controls.Find("HotkeyButton" + updatingHotkey, true)[0] as Button;
                button.Text = "Edit...";

                OptionsWarningLabel1.ForeColor = Color.Black;
                OptionsWarningLabel2.ForeColor = Color.Black;

                updatingHotkey = -1;

                WriteToBinaryFile("hotkeys.dat", Data.hotkeys);

                //Re-enable the form
                mainTabControl.Enabled = true;
            } else {
                //We're checking for hotkeys pressed here

            }
        }

        public TabPage CreateTab(string tabControl, CustomUserControl uc, int index) {
            //Creates an "adjusted index" based on the index (0-8) and the offset
            int adjustedIndex = index + uc.offset;

            TabPage tp = new TabPage();

            tp.Controls.Add(uc);

            TabControl tc = Controls.Find(tabControl, true)[0] as TabControl;

            //Sets the text and name
            tp.Text = "Script " + (index + 1);
            tp.Name = "RushingScript" + adjustedIndex;

            //Allows 8 tabs (0-7) of any given type
            if (index >= 7) {
                if (uc is RushingUserControl) {
                    Button button = tp.Controls.Find("RushAddScript", true)[0] as Button;
                    button.Enabled = false;
                }
            }

            tc.TabPages.Add(tp);

            tc.SelectedTab = tp;

            return tp;
        }

        private void HotkeyButtonClick(object sender, EventArgs e) {
            Button button = (Button)sender;
            button.Text = "Press Any Key...";
            SetHotkey(int.Parse(Regex.Match(button.Name, @"\d+").Value));
        }

        private void ConfigClick(object sender, EventArgs e) {
            //Send options key
            Data.window.SendKeystroke(Data.hotkeys[0]);
        }

        //Completely ripped from stack exchange, too lazy to get json working so binary will do
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false) {
            using (Stream stream = File.Open("Data/" + filePath, append ? FileMode.Append : FileMode.Create)) {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        //""
        public static T ReadFromBinaryFile<T>(string filePath) {
            using (Stream stream = File.Open("Data/" + filePath, FileMode.Open)) {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
    }
}
