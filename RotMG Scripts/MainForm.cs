using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RotMG_Scripts {
    /// <summary>
    /// The main form
    /// </summary>
    public partial class MainForm : Form {

        //The current hotkey that we're updating, see the hotkeys array above for meanings
        private int updatingHotkey = -1;

        //Timer that runs to ensure that the game is still running and valid
        private Timer updateTimer;

        /// <summary>
        /// Creates the console if we're in debug mode
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public MainForm() {
            InitializeComponent();

            //If we're in debug, add a console and write that we're debugging
            if (Info.debug) {
                AllocConsole();
                Console.WriteLine("Debugging!");
            }

            Data.form = this;

            //Creates the data and log directories
            Directory.CreateDirectory("Data");
            Directory.CreateDirectory("Logs");

            //Doesn't allow resizing or maximizing of the window
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            //Lets the program see keys even when it's not focused (for hotkeys)
            KeyPreview = true;

            //Crates a new RotMGWindow
            Data.window = new RotMGWindow();

            //Disables all the tabs
            ToggleTabs();

            //Gets the version number
            Info.version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            //Adds the version number to the title
            Text += Info.version;

            //Adds events for tabs to be able to disable them
            mainTabControl.Selecting += TabControlSelecting;

            //Adds events for others
            Load += new EventHandler(FormLoaded);
            KeyDown += new KeyEventHandler(KeyPressed);

            Data.loadAllData();
        }

        /// <summary>
        /// Triggers when the form is finished loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLoaded(object sender, EventArgs e) {

            //Start the timer once the form is loaded
            InitTimer();

            //Create a rushing tab
            TabPage firstRushingTab = CreateTab("rushingTabControl", new RushingUserControl(0), 0);

            //If there are more rushing tabs that should be created, create them
            for (int i = 1; i < Data.rushConfigs.Length; i++) {
                if (Data.rushConfigs[i] != null) {
                    CreateTab("rushingTabControl", new RushingUserControl(i), i);
                }
            }

            //Apply the link to the LinkLabels
            GitHubLink.Links.Add(0, 0, "https://github.com/Lilypad-666/RotMGScripts");
            GitHubLink.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkClicked);

            //Update the version label to include the current version number
            VersionLabel.Text += Info.version;

            //Set the current tab as the first one
            rushingTabControl.SelectedTab = firstRushingTab;

            //Add event handlers for when you click hotkey buttons
            HotkeyButton0.Click += new EventHandler(HotkeyButtonClick);

            //Set the paint handler for adding images to the background(s)
            ProgramInfoTab.Paint += new PaintEventHandler(InfoTabPaint);

            //Call event when the text is changed in the process name field
            ProcessName.TextChanged += new EventHandler(ProcessTextChanged);

            //Call event when a key is pressed in the console input to check for an Enter or Arrow key
            ConsoleInput.KeyDown += new KeyEventHandler(ConsoleInputKeyDown);
        }

        /// <summary>
        /// Triggers when a link is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            LinkLabel link = sender as LinkLabel;

            System.Diagnostics.Process.Start(link.Links[0].LinkData.ToString());
        }

        /// <summary>
        /// Triggers when the processing text box gets changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProcessTextChanged(object sender, EventArgs e) {
            TextBox box = sender as TextBox;

            //Make the text lower case
            box.Text = box.Text.ToLower();

            //Store the text into settings
            Data.settings[0] = box.Text;

            //Save the new process to file
            Data.Save("settings.dat", Data.settings);

            //Clear the current window and reset everything
            Data.window.Clear();
            RestoreWindowInfoDefault();
            Data.foundGame = false;
            ToggleTabs();
        }

        /// <summary>
        /// Triggers when the Info tab needs to get repained. Allows me to draw images.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InfoTabPaint(object sender, PaintEventArgs e) {
            //Draws the images on the program info tab
            Graphics g = e.Graphics;
            g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            e.Graphics.DrawImage(Data.images[0], 250, 170, 150, 150);
        }

        /// <summary>
        /// Runs every Data.timerDelay ms, verifies that our RotMG is still running and searches for it if it isn't
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateTimerTick(object sender, EventArgs e) {
            //When the timer ticks, update the RotMG window's location
            UpdateRotMGWindow();

            //If we need to toggle the tabs, do so
            if (Data.toggleTabs) {
                ToggleTabs();
                Data.toggleTabs = false;
            }
        }

        /// <summary>
        /// Handles both updating hotkeys as well as activating hotkeys
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyPressed(object sender, KeyEventArgs e) {
            //If we're updating a hotkey
            if (updatingHotkey >= 0) {
                KeysConverter kc = new KeysConverter();
                //If we're changing the Options key
                if (updatingHotkey == 0) {
                    string key = kc.ConvertToString(e.KeyCode);
                    //Verify that the key can only be set to A-Z, 0-9, and F1-F24
                    Regex regex = new Regex(@"^[0-9]+$");
                    if (key.Length > 1) {
                        if (key.Length > 3 || !key.Substring(0, 1).Equals("F") || !regex.IsMatch(key.Substring(1, key.Length - 1))) {
                            //If it doesn't meet those specifications, set the labels to red
                            OptionsWarningLabel1.ForeColor = Color.DarkRed;
                            OptionsWarningLabel2.ForeColor = Color.DarkRed;

                            //Reset the button to edit
                            Button btn = FindControl<Button>("HotkeyButton" + updatingHotkey);
                            btn.Text = "Edit...";

                            //No longer updating hotkeys
                            updatingHotkey = -1;

                            //Re-enable the form
                            mainTabControl.Enabled = true;

                            string message = "Options key must be A-Z, 0-9, or F1-F24!";
                            string caption = "Invalid Key!";

                            //Show a message saying that the key has to be in specifications
                            MessageBox.Show(message, caption, MessageBoxButtons.OK);

                            return;
                        }
                    }
                }

                //Store the index of the key code
                int oldIndex = Array.IndexOf(Data.hotkeys, e.KeyCode);

                //If it's set to another hotkey
                if (oldIndex != -1) {
                    //Try to find the old hotkey box
                    TextBox oldBox = FindControl<TextBox>("HotkeyBox" + oldIndex);

                    if (oldBox != null) {
                        //If we can, set the text as N/A
                        oldBox.Text = "N/A";
                    }

                    //Then, replace the old hotkey's index with none
                    Data.hotkeys[oldIndex] = Keys.None;
                }

                //Set the new index's hotkey as the key code
                Data.hotkeys[updatingHotkey] = e.KeyCode;

                //Change the text of the hotkey box
                FindControl<TextBox>("HotkeyBox" + updatingHotkey).Text = kc.ConvertToString(e.KeyCode);

                //Reset the button back to edit
                FindControl<Button>("HotkeyButton" + updatingHotkey).Text = "Edit...";

                //Verify that the options labels are back to black
                OptionsWarningLabel1.ForeColor = Color.Black;
                OptionsWarningLabel2.ForeColor = Color.Black;

                //Reset updating hotkey
                updatingHotkey = -1;

                //Save the hotkeys to file
                Data.Save("hotkeys.dat", Data.hotkeys);

                //Re-enable the form
                mainTabControl.Enabled = true;
            } else {
                //We're checking for hotkeys pressed here

            }
        }

        /// <summary>
        /// Doesn't let you switch to disabled tabs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlSelecting(object sender, TabControlCancelEventArgs e) {
            //This is called when the tabpage is disabled, doesn't let the user use the tab
            if (!e.TabPage.Enabled) {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Triggers when the change hotkey button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HotkeyButtonClick(object sender, EventArgs e) {
            Button button = (Button)sender;
            button.Text = "Press Any Key...";

            //Get the index from the regex \d+, which grabs the number at the end of the string
            SetHotkey(int.Parse(Regex.Match(button.Name, @"\d+").Value));
        }

        /// <summary>
        /// Triggers when the send button is pressed on the console
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsoleSendClick(object sender, EventArgs e) {
            ConsoleInputKeyDown(sender, new KeyEventArgs(Keys.Enter));
        }

        /// <summary>
        /// Triggered when a key is pressed while in the console
        /// Handles keyboard controls for the console
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConsoleInputKeyDown(object sender, KeyEventArgs e) {
            //If the string isn't blank and enter is pressed, send the command to the console
            if (e.KeyCode == Keys.Enter) {
                if (ConsoleInput.Text.Length > 0) {
                    Console.SendCommand(ConsoleInput.Text);
                    Data.previousCommands.Insert(0, ConsoleInput.Text);
                    ConsoleInput.Text = "";
                    Data.currentCommand = -1;
                }
            }

            //If up is pressed, shift one command up
            else if (e.KeyCode == Keys.Up) {
                if (Data.currentCommand != Data.previousCommands.Count - 1) {
                    Data.currentCommand++;
                    ConsoleInput.Text = Data.previousCommands[Data.currentCommand];
                }
            }

            //Else if down is pressed, shift one command back
            else if (e.KeyCode == Keys.Down) {
                if (Data.currentCommand <= 0) {
                    Data.currentCommand = -1;
                    ConsoleInput.Text = "";
                    return;
                }

                Data.currentCommand--;
                ConsoleInput.Text = Data.previousCommands[Data.currentCommand];
            }
        }

        /// <summary>
        /// Starts the timer for the update
        /// </summary>
        private void InitTimer() {
            //Creates a timer on a x ms interval
            updateTimer = new Timer();
            updateTimer.Tick += new EventHandler(UpdateTimerTick);
            updateTimer.Interval = Data.timerDelay;
            updateTimer.Start();
        }

        /// <summary>
        /// Toggles whether the tabs are enabled, given foundGame
        /// </summary>
        private void ToggleTabs() {
            //If the active tab isn't the Debugging tab or the Main tab, set the active tab to the Main tab
            if (mainTabControl.SelectedTab != MainTab && mainTabControl.SelectedTab != DebuggingTab) {
                mainTabControl.SelectedTab = MainTab;
            }

            //Toggle the options hotkey panel
            OptionsPanel.Enabled = Data.foundGame;

            //Run through each tab and set it to Data.foundGame unless it's the Main or Debugging tab,
            //As those are always active
            foreach (TabPage tab in mainTabControl.TabPages) {
                if (tab != MainTab && tab != DebuggingTab) {
                    tab.Enabled = Data.foundGame;
                }
            }
        }

        /// <summary>
        /// Restores the window info back to N/A and Not Found.
        /// </summary>
        private void RestoreWindowInfoDefault() {
            WindowXBox.Text = "N/A";
            WindowYBox.Text = "N/A";
            WindowWidthBox.Text = "N/A";
            WindowHeightBox.Text = "N/A";
            RotMGProcess.Text = "Not Found...";
        }

        /// <summary>
        /// Disables the window and sets the current hotkey that we're updating
        /// </summary>
        /// <param name="index">Index of the hotkey that's being changed</param>
        public void SetHotkey(int index) {
            //Disables the window until the hotkey is set
            mainTabControl.Enabled = false;
            updatingHotkey = index;
        }

        /// <summary>
        /// Verifies that the window is a valid process, and attempts to find the valid process if it isn't
        /// Handles the text box/ui side of it
        /// </summary>
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
                Data.window.UpdateWindowRect();

                //Update the given info on the screen
                WindowXBox.Text = Data.window.GetX().ToString();
                WindowYBox.Text = Data.window.GetY().ToString();
                WindowWidthBox.Text = Data.window.GetWidth().ToString();
                WindowHeightBox.Text = Data.window.GetHeight().ToString();
            }

        }

        /// <summary>
        /// Creates a new tab in the tabControl from the uc template.
        /// </summary>
        /// <param name="tabControl">Name of the tabControl to add the tab to</param>
        /// <param name="uc">Template to copy over to the new tab</param>
        /// <param name="index">Index of the new tab</param>
        /// <returns></returns>
        public static TabPage CreateTab(string tabControl, CustomUserControl template, int index) {
            //Creates an "adjusted index" based on the index (0-8) and the offset
            int adjustedIndex = index + template.offset;

            TabPage tp = new TabPage();

            //Copy all the data from the template to the new tab
            tp.Controls.Add(template);

            //Get the tabControl from the given name
            TabControl tc = FindControl<TabControl>(tabControl);

            //Sets the text and name
            tp.Text = "Script " + (index + 1);
            tp.Name = "RushingScript" + adjustedIndex;

            //Allows 8 tabs (0-7) of any given type
            if (index >= 7) {
                if (template is RushingUserControl) {
                    FindControl<Button>("AddScript", tp).Enabled = false;
                }
            }

            //Adds the tab to the tab control
            tc.TabPages.Add(tp);

            //Sets the tab as the currently active tab
            tc.SelectedTab = tp;

            return tp;
        }

        /// <summary>
        /// Recursively finds the first child of the given name
        /// Includes children of children
        /// </summary>
        /// <param name="root">Control to be the top parent</param>
        /// <param name="name">Name to search for</param>
        /// <param name="childrenOfChildren">Whether to recursively search or not</param>
        /// <returns>The first instance found of T with name</returns>
        public static T FindControl<T>(string name, Control root = null, bool childrenOfChildren = true) where T : Control {
            //Sets root to the form if it's null
            root = root == null ? Data.form : root;

            //If root's name matches, return it
            if (root is T && root.Name.Equals(name)) {
                return (root as T);
            }

            //Run through each child in this root's controls
            foreach (Control c in root.Controls) {
                if (childrenOfChildren) {
                    //Recursively call the function on each child
                    T t = FindControl<T>(name, c);

                    //If we found a match, return it
                    if (t != null) {
                        return t;
                    }
                } else {
                    //If the name matches, return it
                    if (c is T && c.Name.Equals(name)) {
                        return (c as T);
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Recursively finds all children who's names contain the given name
        /// </summary>
        /// <param name="root">Control to be the top parent</param>
        /// <param name="name">Name to search for</param>
        /// <param name="childrenOfChildren">Whether to recursively search or not</param>
        /// <returns>A list of all instances of T who's name contain name</returns>
        public static List<T> FindControls<T>(string name, Control root = null, bool childrenOfChildren = true) where T : Control {
            //Sets root to the form if it's null
            root = root == null ? Data.form : root;

            List<T> list = new List<T>();

            //If root's name contains, add it to the list
            if (root is T && root.Name.Contains(name)) {
                list.Add(root as T);
            }

            //Run through each child in this root's controls
            foreach (Control c in root.Controls) {
                if (childrenOfChildren) {
                    //Recursively call the function on each child
                    list.AddRange(FindControls<T>(name, c));
                } else {
                    //If the name matches, return it
                    if (c is T && c.Name.Contains(name)) {
                        list.Add(c as T);
                    }
                }
            }

            return list;
        }
    }
}
