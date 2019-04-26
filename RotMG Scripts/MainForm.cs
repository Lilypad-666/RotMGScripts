using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace RotMG_Scripts {

    /// <summary>
    /// The main form!
    /// </summary>
    public partial class MainForm : Form {
        
        /// <summary>
        /// Timer that runs to ensure that the game is still running and valid
        /// </summary>
        private System.Windows.Forms.Timer updateTimer;

        /// <summary>
        /// Creates the main form
        /// </summary>
        public MainForm() {
            InitializeComponent();

            Data.form = this;

            //Creates the data and log directories
            Directory.CreateDirectory("Data");
            Directory.CreateDirectory("Logs");


            //Doesn't allow resizing or maximizing of the window
            if (!Info.debug) {
                FormBorderStyle = FormBorderStyle.None;
            }

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
            TitleLabel.Text += Info.version;

            //Adds events for others
            Load += new EventHandler(FormLoaded);

            Data.LoadAllData();

            Data.LoadRotMGData(true);
        }

        /// <summary>
        /// Triggers when the form is finished loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLoaded(object sender, EventArgs e) {
            //Start the timer once the form is loaded
            InitTimer();

            MainTabControl.SelectedTab = RushingTab;

            TabPage firstRushing = CreateTab(RushingTabControl, new RushingUserControl(0), 0);
            Button button = FindControl<Button>("AddScript", firstRushing);
            button.Enabled = false;
            button.BackColor = Color.Gray;

            int lastIndex = 1;

            //If there are more rushing tabs that should be created, create them
            for (int i = 1; i < Data.rushConfigs.Length; i++) {
                if (Data.rushConfigs[i] != null) {
                    TabPage tp = CreateTab(RushingTabControl, new RushingUserControl(i), i);
                    Button b = FindControl<Button>("AddScript", tp);
                    b.Enabled = false;
                    b.BackColor = Color.Gray;
                    lastIndex++;
                }
            }

            button = FindControl<Button>("AddScript", FindControl<TabPage>("Script" + lastIndex));
            button.Enabled = true;
            button.BackColor = Color.White;

            //Create a new blank RUC in order to copy the controls over to the game info tab
            RushingUserControl ruc = new RushingUserControl(-1);

            GameInfoPanel.Controls.Add(ruc.SettingsPanel);

            foreach (CustomCheckBox box in FindControls<CustomCheckBox>("", GameInfoPanel)) {
                box.AutoCheck = false;
                box.Cursor = Cursors.Default;
                box.Loaded();
            }

            //Set the current tab as the first one
            RushingTabControl.SelectedTab = firstRushing;
            MainTabControl.SelectedTab = MainTab;

            //Apply the link to the LinkLabels
            GitHubLink.Links.Add(0, 0, "https://github.com/Lilypad-666/RotMGScripts");
            GitHubLink.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkClicked);

            //Update the version label to include the current version number
            VersionNumberLabel.Text = Info.version;

            //Add event handlers for when you click hotkey buttons
            HotkeyButton0.Click += new EventHandler(HotkeyButtonClick);

            //Set the paint handler for adding images to the background
            DebuggingInfoPanel.Paint += new PaintEventHandler(InfoTabPaint);

            //Set the paint handler for adding images to the title bar
            TitleBarPanel.Paint += new PaintEventHandler(TitleBarPaint);

            //Call event when the text is changed in the process name field
            ProcessName.TextChanged += new EventHandler(ProcessTextChanged);

            //Call event when a key is pressed in the console input to check for an Enter or Arrow key
            ConsoleInput.KeyDown += new KeyEventHandler(ConsoleInputKeyDown);
            ConsoleSendButton.Click += new EventHandler(ConsoleSendClick);

            //Update the two delays
            SearchDelayInput.ValueChanged += new EventHandler(DelayInputValueChanged);
            UpdateDelayInput.ValueChanged += new EventHandler(DelayInputValueChanged);

            //Add event handlers for checking the auto resize box
            foreach (CheckBox box in FindControls<CheckBox>("", AspectRatioGroup)) {
                box.MouseClick += new MouseEventHandler(AspectBoxChanged);
            }

            //Lets you drag around the window without a windows title bar
            TitleBarPanel.MouseDown += new MouseEventHandler(TitleBar);
            TitleLabel.MouseDown += new MouseEventHandler(TitleBar);

            ExitButton.InitializeButton();
            MinimizeButton.InitializeButton();

            KeyboardHook.StartHook();
        }

        /// <summary>
        /// Handles dragging around the window without a windows title bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleBar(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /// <summary>
        /// Triggers when an aspect ratio checbox is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AspectBoxChanged(object sender, EventArgs e) {
            CheckBox thisBox = sender as CheckBox;

            foreach (CheckBox box in FindControls<CheckBox>("", AspectRatioGroup)) {
                box.Checked = false;
            }

            thisBox.Checked = true;

            switch (thisBox.Name) {
                case "AspectFourThree":
                    Data.settings[3] = 0;
                    break;

                case "AspectSixteenNine":
                    Data.settings[3] = 1;
                    break;

                case "AspectOneOne":
                    Data.settings[3] = 2;
                    break;

                case "AspectNone":
                    Data.settings[3] = 3;
                    break;
            }

            Data.Save("settings.dat", Data.settings);
        }

        /// <summary>
        /// Triggers when the vaule of either delay inputs are changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelayInputValueChanged(object sender, EventArgs e) {
            NumericUpDown input = sender as NumericUpDown;

            if (input.Name.Contains("Search")) {
                Info.searchDelay = decimal.ToInt32(input.Value);

                Data.settings[1] = Info.searchDelay;
            }

            if (input.Name.Contains("Update")) {
                Info.updateDelay = decimal.ToInt32(input.Value);
                Data.settings[2] = Info.updateDelay;
            }

            Data.Save("settings.dat", Data.settings);
            UpdateTimerDelay();
        }

        /// <summary>
        /// Triggers when a link is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            LinkLabel link = sender as LinkLabel;

            Process.Start(link.Links[0].LinkData.ToString());
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
            Info.foundGame = false;
            Info.isFocusedWindow = false;

            UpdateTimerDelay();

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

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("RotMG_Scripts.Resources.lilypad1.png");
            Bitmap bmp = new Bitmap(myStream);

            e.Graphics.DrawImage(bmp, 250, 250, bmp.Width, bmp.Height);
        }

        /// <summary>
        /// Triggers when the Title Bar tab needs to get repained. Allows me to draw images.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitleBarPaint(object sender, PaintEventArgs e) {
            //Draws the images on the program info tab
            Graphics g = e.Graphics;
            g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("RotMG_Scripts.Resources.Cloak.png");
            Bitmap bmp = new Bitmap(myStream);

            e.Graphics.DrawImage(bmp, 5f, 2.5f, 25, 25);
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
            if (Info.toggleTabs) {
                ToggleTabs();
                Info.toggleTabs = false;
            }

            Data.LoadRotMGData();

            Info.isFocusedWindow = Data.window.IsFocusedWindow();
        }

        /// <summary>
        /// Triggers when the change hotkey button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HotkeyButtonClick(object sender, EventArgs e) {
            Button button = sender as Button;
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
        /// Updates the timer to the correct delay
        /// </summary>
        public void UpdateTimerDelay() {
            if (updateTimer != null) {
                //If we are in the game
                if (Info.foundGame) {
                    //Verify that the current delay is the update delay
                    if (Info.currentDelay != Info.updateDelay) {
                        //If it isn't set the interval to be the update delay
                        Info.currentDelay = Info.updateDelay;
                        updateTimer.Stop();
                        updateTimer.Interval = Info.updateDelay;
                        updateTimer.Start();

                        //Print out that we changed the delay
                        Console.WriteLine("Changed current delay to " + Info.currentDelay + "ms.");
                    }
                }
                else {
                    //Verify that the current delay is the search delay
                    if (Info.currentDelay != Info.searchDelay) {
                        //If it isn't, set the interval to be the search delay
                        Info.currentDelay = Info.searchDelay;
                        updateTimer.Stop();
                        updateTimer.Interval = Info.searchDelay;
                        updateTimer.Start();

                        //Print out that we changed the delay
                        Console.WriteLine("Changed current delay to " + Info.currentDelay + "ms.");
                    }
                }
            }
        }

        /// <summary>
        /// Gets triggered when a hotkey is pressed from the hook
        /// </summary>
        /// <param name="key"></param>
        public static void HotkeyPressed(Keys key) {
            //We're checking for hotkeys pressed here
            int index = Array.IndexOf(Data.hotkeys, key);

            //If it's a valid index
            if (index >= 0) {
                //Rush hotkey
                if (index >= 1 && index <= 7) {
                    if (!Data.hotkeyDelay.IsRunning || Data.hotkeyDelay.ElapsedMilliseconds > 1000) {
                        Data.hotkeyDelay.Restart();
                        RushingUserControl control = Data.form.RushingTabControl.TabPages[index - 1].Controls[0] as RushingUserControl;
                        Console.WriteLine("Toggling Settings!");
                        FlipSettings(control.config);
                    }
                }
            }
        }

        /// <summary>
        /// Attempts to change the given settings, attempts 3 times
        /// </summary>
        /// <param name="config">The config to try to change to</param>
        /// <param name="depth">Attempt count</param>
        private static void FlipSettings(RushConfig config, int depth = 0) {
            //After 3 attempts, throw an error
            if (depth >= 3) {
                Console.WriteLine("Unable to flip settings properly, check your options key.", Console.logTypes.ERROR);
                return;
            }

            bool settingsOpen = false;
            int currentTab = -1;

            //Runs through each debuff setting
            for (int i = 0; i < Data.debuffSettings.Length; i++) {
                //If the settings are different
                if (Data.debuffSettings[i] != config.debuffs[i]) {
                    //If you haven't already opened the settings menu, do so
                    if (!settingsOpen) {
                        settingsOpen = true;
                        Data.window.OpenSettings();
                    }

                    //If you're not already on the proper tab, switch
                    if (currentTab != 0) {
                        currentTab = 0;
                        Data.window.SettingsTab(Info.headerNames.Debuffs);
                    }

                    //Toggle the debuff
                    Data.window.ClickDebuff(i);
                }
            }

            //Run through each other setting
            for (int i = 0; i < Data.otherSettings.Length; i++) {
                if (Data.otherSettings[i] != config.others[i]) {
                    //If you haven't already opened the settings menu, do so
                    if (!settingsOpen) {
                        settingsOpen = true;
                        Data.window.OpenSettings();
                    }
                    
                    //Done this way to allow for settings to jump around
                    //Checks which tab the setting should be and changes to it
                    if (Array.IndexOf(new int[1] { 0 }, i) != -1) {
                        if (currentTab != 1) {
                            currentTab = 1;
                            Data.window.SettingsTab(Info.headerNames.Visual);
                        }
                    }
                    else if (Array.IndexOf(new int[4] { 1, 2, 3, 4 }, i) != -1) {
                        if (currentTab != 2) {
                            currentTab = 2;
                            Data.window.SettingsTab(Info.headerNames.World);
                        }
                    }

                    //Clicks the setting
                    Data.window.ClickOther(i);
                }
            }

            //Closes the settings
            Data.window.CloseSettings();

            //Sleep to let the settings save to file
            Thread.Sleep(400);

            //Count how many missed
            int missedCount = VerifyFlipped(config);

            //Retry if missed any
            if (missedCount > 0) {
                Console.WriteLine("Missed " + missedCount + " flips, retrying!", Console.logTypes.WARN);
                FlipSettings(config, depth + 1);
                return;
            }
        }

        /// <summary>
        /// Verifies that the in-game settings are correct
        /// </summary>
        /// <param name="config">Config to compare against</param>
        /// <returns>How many settings were missed</returns>
        public static int VerifyFlipped(RushConfig config) {
            //Loads the data from file
            Data.LoadRotMGData();
            
            int missedCount = 0;

            for (int i = 0; i < Data.debuffSettings.Length; i++) {
                if (Data.debuffSettings[i] != config.debuffs[i]) {
                    missedCount++;
                }
            }

            for (int i = 0; i < Data.otherSettings.Length; i++) {
                if (Data.otherSettings[i] != config.others[i]) {
                    missedCount++;
                }
            }

            return missedCount;
        }

        /// <summary>
        /// Starts the timer for the update
        /// </summary>
        private void InitTimer() {
            //Creates a timer on a x ms interval
            updateTimer = new System.Windows.Forms.Timer();
            updateTimer.Tick += new EventHandler(UpdateTimerTick);
            updateTimer.Interval = Info.searchDelay;
            updateTimer.Start();
        }

        /// <summary>
        /// Toggles whether the tabs are enabled, given foundGame
        /// </summary>
        private void ToggleTabs() {
            //If the active tab isn't the Debugging tab or the Main tab, set the active tab to the Main tab
            if (MainTabControl.SelectedTab != MainTab && MainTabControl.SelectedTab != DebuggingTab) {
                MainTabControl.ForceTabSwitch(MainTab);
            }

            //Run through each tab and set it to Data.foundGame unless it's the Main or Debugging tab,
            //As those are always active
            foreach (TabPage tab in MainTabControl.TabPages) {
                if (tab != MainTab && tab != DebuggingTab) {
                    tab.Enabled = Info.foundGame;
                }
            }

            MainTabControl.Refresh();
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
            using (var form = new PressAnyKeyBox(index)) {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
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
                        Info.foundGame = false;
                        Info.isFocusedWindow = false;
                        return;
                    }

                    //If found, set the text and enable the panels and tabs
                    RotMGProcess.Text = Data.window.GetWindowName();

                    Info.foundGame = true;
                    Info.toggleTabs = true;

                    Console.WriteLine("Found window: " + Data.window.GetWindowName());

                    //Verify that the delay is at the updateDelay speed
                    UpdateTimerDelay();
                }
                else {
                    RestoreWindowInfoDefault();

                    Info.foundGame = false;
                    Info.toggleTabs = true;
                    Info.isFocusedWindow = false;

                    //Verify that the delay is at the searchDelay speed
                    UpdateTimerDelay();
                }
            }
            else {
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
        public static TabPage CreateTab(CustomTabControl tc, CustomUserControl template, int index) {
            //Creates an "adjusted index" based on the index (0-7) and the offset
            int adjustedIndex = index + template.offset;

            TabPage tp = new TabPage();

            template.Name += (index + 1);

            //Copy all the data from the template to the new tab
            tp.Controls.Add(template);

            //Sets the text and name
            tp.Text = "Script " + (index + 1);
            tp.Name = "Script" + adjustedIndex;

            //Allows 7 tabs (0-6) of any given type
            if (index >= 6) {
                if (template is UserControl) {
                    Button button = FindControl<Button>("AddScript", tp);
                    button.Enabled = false;
                    button.BackColor = Color.Gray;
                }
            }

            //Adds the tab to the tab control
            tc.TabPages.Add(tp);

            //Sets the tab as the currently active tab
            tc.ForceTabSwitch(tp);

            Console.WriteLine("Successfully created tab index " + adjustedIndex);

            return tp;
        }

        /// <summary>
        /// Converts the data from Data.debuffSettings and Data.otherSettings to check boxes on the screen
        /// </summary>
        public static void RotMGDataToScreen(bool firstRun) {
            //Run through each checkbox on the game info tab
            foreach (CustomCheckBox box in FindControls<CustomCheckBox>("", Data.form.GameInfoPanel)) {
                //Snag the number from the end of the String
                int number = int.Parse(Regex.Match(box.Name, @"\d+").Value);

                //Sort by the type of category it's in and put it onto the page
                if (number < Data.debuffSettings.Length) {
                    if (Data.debuffSettings[number] == 1) {
                        if (firstRun) {
                            box.SetChecked(true, true);
                        }

                        if (!box.Checked) {
                            box.SetChecked(true, false);
                        }
                    }
                    else {
                        if (firstRun) {
                            box.SetChecked(false, true);
                        }

                        if (box.Checked) {
                            box.SetChecked(false, false);
                        }
                    }
                }
                else if (number < Data.debuffSettings.Length + Data.otherSettings.Length) {
                    if (Data.otherSettings[number - Data.debuffSettings.Length] == 1) {
                        if (firstRun) {
                            box.SetChecked(true, true);
                        }

                        if (!box.Checked) {
                            box.SetChecked(true, false);
                        }
                    }
                    else {
                        if (firstRun) {
                            box.SetChecked(false, true);
                        }

                        if (box.Checked) {
                            box.SetChecked(false, false);
                        }
                    }
                }

                box.Refresh();
            }
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
                }
                else {
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
        public static List<T> FindControls<T>(string name = "", Control root = null, bool childrenOfChildren = true) where T : Control {
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
                }
                else {
                    //If the name matches, return it
                    if (c is T && c.Name.Contains(name)) {
                        list.Add(c as T);
                    }
                }
            }

            return list;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
    }
}