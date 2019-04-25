using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RotMG_Scripts {

    /// <summary>
    /// Template tab for a rushing layout
    /// </summary>
    public partial class RushingUserControl : CustomUserControl {

        //Global index, including all controls
        private int globalIndex;

        //Local index of just this control
        private int localIndex;

        //Config for this control
        public RushConfig config;

        /// <summary>
        /// Contstructor, sets the offset and generates the local and global index based on those
        /// </summary>
        /// <param name="index"></param>
        public RushingUserControl(int index) {
            InitializeComponent();

            this.GameInfoOther.ResumeLayout();
            this.OffsetGroupBox.ResumeLayout();
            this.GameInfoClient.ResumeLayout();
            this.GameInfoServer.ResumeLayout();
            this.SettingsPanel.ResumeLayout();
            this.ResumeLayout();

            offset = Info.controlOffsets[0];

            localIndex = index;
            globalIndex = index + offset;

            Load += new EventHandler(Loaded);
        }

        /// <summary>
        /// Triggers when the form is finished loading
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Loaded(object sender, EventArgs e) {
            //Adds the index to the hotkeyboxes name and sets the text properly
            HotkeyBox.Name += globalIndex;
            if (Data.hotkeys[globalIndex] != Keys.None) {
                KeysConverter kc = new KeysConverter();
                HotkeyBox.Text = kc.ConvertToString(Data.hotkeys[globalIndex]);
            }

            //Adds the index to the button
            HotkeyButton.Name += globalIndex;

            //Adds the event handler to the hotkey button
            HotkeyButton.Click += new EventHandler(HotkeyButtonClick);

            //Adds the event handler to the add script button
            AddScript.Click += new EventHandler(AddScriptClick);

            //Adds Click handlers to the checkboxes to save the configs as they're being edited
            List<CheckBox> boxes = MainForm.FindControls<CheckBox>("", this);
            foreach (CheckBox box in boxes) {
                box.Click += CheckboxToggle;
            }

            //Load the config from the file to the checkboxes
            LoadConfig();
        }

        /// <summary>
        /// Triggers when a checkbox is toggled
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckboxToggle(object sender, EventArgs e) {
            //On checkbox toggle, save to the config
            CheckBox box = (sender as CheckBox);
            ScreenToConfig(box);
        }

        /// <summary>
        /// Adds a new script tab with the same UserControl as this class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddScriptClick(object sender, EventArgs e) {
            //When you click to add a new tab, create it and add it to the correct tabControl
            MainForm.CreateTab(Data.form.RushingTabControl, new RushingUserControl(localIndex + 1), localIndex + 1);

            //Disable the add tab button on this page
            Button button = (Button)sender;
            button.Enabled = false;
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
            Data.form.SetHotkey(globalIndex);
        }

        /// <summary>
        /// Loads the config from the rushConfigs if it exists
        /// </summary>
        private void LoadConfig() {
            //If the config exists
            if (Data.rushConfigs[globalIndex - offset] != null) {
                //Set the config and refresh the screen
                config = Data.rushConfigs[globalIndex - offset];
                ConfigToScreen();
            }
            else {
                //Create a new config
                config = new RushConfig();
                Data.rushConfigs[globalIndex - offset] = config;
                //Store the default values to the new config
                ScreenToConfig();
            }
        }

        /// <summary>
        /// Checks the boxes relative to the config
        /// </summary>
        private void ConfigToScreen() {
            //Run through each checkbox on the page
            List<CheckBox> boxes = MainForm.FindControls<CheckBox>("", this);
            foreach (CheckBox box in boxes) {
                //Snag the number from the end of the String
                int number = int.Parse(Regex.Match(box.Name, @"\d+").Value);

                //Sort by the type of category it's in and put it onto the page
                if (number < config.debuffs.Length) {
                    if (config.debuffs[number] == 1) {
                        box.Checked = true;
                    }
                    else {
                        box.Checked = false;
                    }
                }
                else if (number < config.debuffs.Length + config.others.Length) {
                    if (config.others[number - config.debuffs.Length] == 1) {
                        box.Checked = true;
                    }
                    else {
                        box.Checked = false;
                    }
                }
            }
        }

        /// <summary>
        /// Save the screen to the config and then write to the file
        /// </summary>
        /// <param name="box">The checkbox that was updated</param>
        private void ScreenToConfig(CheckBox box = null) {
            if (box == null) {
                //Run through each checkbox on the page
                List<CheckBox> boxes = MainForm.FindControls<CheckBox>("", this);
                foreach (CheckBox c in boxes) {
                    int number = int.Parse(Regex.Match(c.Name, @"\d+").Value);

                    //Sort by the type of category it's in and store it into the config
                    if (number < config.debuffs.Length) {
                        config.debuffs[number] = c.Checked ? 1 : -1;
                    }
                    else if (number < config.debuffs.Length + config.others.Length) {
                        config.others[number - config.debuffs.Length] = c.Checked ? 1 : -1;
                    }
                }
            }
            else {
                int number = int.Parse(Regex.Match(box.Name, @"\d+").Value);

                //Sort by the type of category it's in and store it into the config
                if (number < config.debuffs.Length) {
                    config.debuffs[number] = box.Checked ? 1 : -1;
                }
                else if (number < config.debuffs.Length + config.others.Length) {
                    config.others[number - config.debuffs.Length] = box.Checked ? 1 : -1;
                }
            }

            //Just in case it's not there yet, put it into the rushConfigs
            Data.rushConfigs[globalIndex - offset] = config;

            //Re-write RushConfigs to the file
            Data.Save("rushconfigs.dat", Data.rushConfigs);
        }

        private void Weak9_CheckedChanged(object sender, EventArgs e) {

        }

        private void Sick10_CheckedChanged(object sender, EventArgs e) {

        }

        private void Stunned11_CheckedChanged(object sender, EventArgs e) {

        }

        private void Bleeding12_CheckedChanged(object sender, EventArgs e) {

        }

        private void PetStasis13_CheckedChanged(object sender, EventArgs e) {

        }

        private void Silence14_CheckedChanged(object sender, EventArgs e) {

        }

        private void Petrified5_CheckedChanged(object sender, EventArgs e) {

        }

        private void ArmorBroken4_CheckedChanged(object sender, EventArgs e) {

        }

        private void Paralyzed3_CheckedChanged(object sender, EventArgs e) {

        }

        private void Dazed2_CheckedChanged(object sender, EventArgs e) {

        }

        private void Slowed1_CheckedChanged(object sender, EventArgs e) {

        }

        private void Quiet0_CheckedChanged(object sender, EventArgs e) {

        }

        private void GameInfoClient_Enter(object sender, EventArgs e) {

        }

        private void Blind6_CheckedChanged(object sender, EventArgs e) {

        }

        private void Drunk7_CheckedChanged(object sender, EventArgs e) {

        }

        private void Unstable8_CheckedChanged(object sender, EventArgs e) {

        }

        private void Darkness17_CheckedChanged(object sender, EventArgs e) {

        }

        private void Confused16_CheckedChanged(object sender, EventArgs e) {

        }

        private void Hallucinating15_CheckedChanged(object sender, EventArgs e) {

        }

        private void OffsetEtherite19_CheckedChanged(object sender, EventArgs e) {

        }

        private void OffsetColo20_CheckedChanged(object sender, EventArgs e) {

        }

        private void OffsetVoidBow22_CheckedChanged(object sender, EventArgs e) {

        }

        private void OffsetCultistStaff21_CheckedChanged(object sender, EventArgs e) {

        }

        private void MobInfo18_CheckedChanged(object sender, EventArgs e) {

        }

        private void GameInfoOther_Enter(object sender, EventArgs e) {

        }

        private void OffsetGroupBox_Enter(object sender, EventArgs e) {

        }

        private void CheckedDescription_Click(object sender, EventArgs e) {

        }

        private void OptionsLabel_Click(object sender, EventArgs e) {

        }

        private void HotkeyButton_Click(object sender, EventArgs e) {

        }

        private void AddScript_Click(object sender, EventArgs e) {

        }
    }
}