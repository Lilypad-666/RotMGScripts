using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RotMG_Scripts {
    public partial class RushingUserControl : CustomUserControl {
        RotMGHotkeys form;
        int globalIndex;
        int localIndex;
        RushConfig config;

        public RushingUserControl(RotMGHotkeys form, int index) {
            offset = 2;

            this.form = form;

            localIndex = index;
            globalIndex = index + offset;

            InitializeComponent();

            Load += new EventHandler(Loaded);
        }

        public void CheckboxToggle(object sender, EventArgs e) {
            //On checkbox toggle, save to the config
            ScreenToConfig();
        }

        public void Loaded(object sender, EventArgs e) {
            TextBox box = Controls.Find("HotkeyBox", true)[0] as TextBox;

            //Adds the index to the hotkeyboxes name and sets the text properly
            box.Name += globalIndex;
            if (Data.hotkeys[globalIndex] != Keys.None) {
                KeysConverter kc = new KeysConverter();
                box.Text = kc.ConvertToString(Data.hotkeys[globalIndex]);
            }

            Button hotkeyButton = Controls.Find("HotkeyButton", true)[0] as Button;

            //Adds the index to the button
            hotkeyButton.Name += globalIndex;
            hotkeyButton.Click += new System.EventHandler(HotkeyButtonClick);

            Button addScriptButton = Controls.Find("AddScript", true)[0] as Button;

            addScriptButton.Click += new EventHandler(AddScriptClick);

            //Adds Click handlers to the checkboxes to save the configs as they're being edited
            foreach (Control c in Controls) {
                if (c is GroupBox) {
                    foreach (Control x in c.Controls) {
                        if (x is CheckBox) {
                            (x as CheckBox).Click += CheckboxToggle;
                        }
                    }
                }
            }

            //Load the config from the file to the checkboxes
            LoadConfig();
        }

        public void LoadConfig() {
            //If there's a config, load it. Otherwise generate a new one and save it.
            if (form.rushConfigs[globalIndex - offset] != null) {
                config = form.rushConfigs[globalIndex - offset];
                ConfigToScreen();
            } else {
                config = new RushConfig();
                form.rushConfigs[globalIndex - offset] = config;
                ScreenToConfig();
            }
        }

        public void ConfigToScreen() {
            //Run through each checkbox on the page
            foreach (Control c in Controls) {
                if (c is GroupBox) {
                    foreach (Control x in c.Controls) {
                        if (x is CheckBox) {
                            CheckBox box = x as CheckBox;

                            //Snag the number from the end of the String
                            int number = int.Parse(Regex.Match(box.Name, @"\d+").Value);

                            //Sort by the type of category it's in and put it onto the page
                            if (number < config.debuffs.Length) {
                                box.Checked = config.debuffs[number];
                            } else if (number < config.debuffs.Length + config.others.Length) {
                                box.Checked = config.others[number - config.debuffs.Length];
                            }
                        }
                    }
                }
            }
        }

        public void ScreenToConfig() {
            //Run through each checkbox on the page
            foreach (Control c in Controls) {
                if (c is GroupBox) {
                    foreach (Control x in c.Controls) {
                        if (x is CheckBox) {
                            CheckBox box = x as CheckBox;

                            //Get the number from the end of the string
                            int number = int.Parse(Regex.Match(box.Name, @"\d+").Value);

                            //Sort by the type of category it's in and store it into the config
                            if (number < config.debuffs.Length) {
                                config.debuffs[number] = box.Checked;
                            } else if (number < config.debuffs.Length + config.others.Length) {
                                config.others[number - config.debuffs.Length] = box.Checked;
                            }
                        }
                    }
                }
            }

            //Just in case it's not there yet, put it into the rushConfigs
            form.rushConfigs[globalIndex - offset] = config;

            //Re-write RushConfigs to the file
            RotMGHotkeys.WriteToBinaryFile("rushconfigs.dat", form.rushConfigs);
        }

        private void AddScriptClick(object sender, EventArgs e) {
            //When you click to add a new tab, create it and add it to the correct tabControl
            form.CreateTab("rushingTabControl", new RushingUserControl(form, localIndex + 1), localIndex + 1);

            //Disable the add tab button on this page
            Button button = (Button)sender;
            button.Enabled = false;
        }

        private void HotkeyButtonClick(object sender, EventArgs e) {
            Button button = (Button)sender;
            button.Text = "Press Any Key...";
            form.SetHotkey(globalIndex);
        }
    }
}
