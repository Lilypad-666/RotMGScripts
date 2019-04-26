using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RotMG_Scripts {

    public partial class PressAnyKeyBox : Form {

        //The current hotkey that we're updating, see the hotkeys array above for meanings
        private int updatingHotkey;

        public PressAnyKeyBox() {
            InitializeComponent();
        }

        public PressAnyKeyBox(int updatingHotkey) {
            InitializeComponent();

            //Lets the program see keys even when it's not focused (for hotkeys)
            KeyPreview = true;

            this.updatingHotkey = updatingHotkey;

            HotkeyTitleBar.MouseDown += new MouseEventHandler(TitleBar);
            HotkeyLabel.MouseDown += new MouseEventHandler(TitleBar);

            Load += Loaded;
        }

        private void Loaded(object sender, EventArgs e) {
            HotkeyExitButton.InitializeButton();

            string labelText = "";
            if (updatingHotkey == 0) {
                labelText = "Options";
                OptionsWarningLabel.Text = "Must be A-Z, 0-9, or F1-F24";
                OptionsWarningLabel.ForeColor = Color.Red;
            }

            if (updatingHotkey >= 1 && updatingHotkey <= 7) {
                labelText = "Script " + updatingHotkey;
            }

            labelText += " Hotkey";

            EditingHotkeyLabel.Text = labelText;

            //Set the paint handler for adding images to the title bar
            HotkeyTitleBar.Paint += new PaintEventHandler(TitleBarPaint);

            KeyDown += new KeyEventHandler(KeyPressed);
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
            Stream myStream = myAssembly.GetManifestResourceStream("RotMG_Scripts.Resources.Keyboard.png");
            Bitmap bmp = new Bitmap(myStream);

            e.Graphics.DrawImage(bmp, 5f, 2.5f, 25, 25);
        }

        private void TitleBar(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /// <summary>
        /// Handles updating hotkeys
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyPressed(object sender, KeyEventArgs e) {
            //If we're updating a hotkey
            if (updatingHotkey >= 0) {
                KeysConverter kc = new KeysConverter();
                string key = kc.ConvertToString(e.KeyCode);
                //If we're changing the Options key
                if (updatingHotkey == 0) {
                    //Verify that the key can only be set to A-Z, 0-9, and F1-F24
                    Regex regex = new Regex(@"^[0-9]+$");
                    if (key.Length > 1) {
                        if (key.Length > 3 || !key.Substring(0, 1).Equals("F") || !regex.IsMatch(key.Substring(1, key.Length - 1))) {
                            Console.WriteLine("Invalid Options key selected: " + key + ".", Console.logTypes.WARN);

                            return;
                        }
                    }
                }

                //Store the index of the key code
                int oldIndex = Array.IndexOf(Data.hotkeys, e.KeyCode);

                //If it's set to another hotkey
                if (oldIndex != -1) {
                    //Try to find the old hotkey box
                    TextBox oldBox = MainForm.FindControl<TextBox>("HotkeyBox" + oldIndex);

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
                MainForm.FindControl<TextBox>("HotkeyBox" + updatingHotkey).Text = key;

                Console.WriteLine("Successfully set hotkey number " + updatingHotkey + " as " + key + ".");

                //Reset updating hotkey
                updatingHotkey = -1;

                //Save the hotkeys to file
                Data.Save("hotkeys.dat", Data.hotkeys);

                Close();
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
    }
}