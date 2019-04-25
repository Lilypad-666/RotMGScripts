using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace RotMG_Scripts {

    /// <summary>
    /// Console class to take care of debugging and logging
    /// </summary>
    public class Console {

        //Different log types
        public enum logTypes {
            INFO,
            CMD,
            WARN,
            ERROR,
            FATAL
        }

        /// <summary>
        /// Catches all non-ui errors and writes them to the log as a fatal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void UnhandledException(object sender, UnhandledExceptionEventArgs e) {
            Exception exception = e.ExceptionObject as Exception;
            WriteLine(exception.Message + Environment.NewLine + exception.StackTrace, logTypes.FATAL);
        }

        /// <summary>
        /// Catches all ui errors and writes them to the log as a fatal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void ThreadException(object sender, ThreadExceptionEventArgs e) {
            Exception exception = e.Exception;
            WriteLine(exception.Message + Environment.NewLine + exception.StackTrace, logTypes.FATAL);
        }

        /// <summary>
        /// Sends a command to the console
        /// </summary>
        /// <param name="text"></param>
        public static void SendCommand(string text) {
            //Write the command to the log
            WriteLine(text, logTypes.CMD);

            string[] tokens = text.Split(' ');

            if (tokens.Length == 1) {
                if (text.ToUpper().Equals("HOOK") || text.ToUpper().Equals("REHOOK")) {
                    KeyboardHook.StartHook();
                }

                if (text.ToUpper().Equals("UNHOOK")) {
                    KeyboardHook.StopHook();
                }
            }

            if (tokens.Length == 5) {
                if (tokens[0].ToUpper().Equals("WINDOW")) {
                    //Data.window.SetWindowLocAndSize(int.Parse(tokens[1]), int.Parse(tokens[2]), int.Parse(tokens[3]), int.Parse(tokens[4]));
                }
            }

            if (tokens[0].ToUpper().Equals("MOUSE")) {
                Data.window.MoveMouse(float.Parse(tokens[1]), float.Parse(tokens[2]));
            }

            for (int i = 0; i < Info.debuffNames.Length; i++) {
                if (text.ToUpper().Contains(Info.debuffNames[i].ToUpper())) {
                    if (text.Substring(0, 8).ToUpper().Equals("GAMEINFO")) {
                        string info = settingToString(Data.debuffSettings[i]);

                        WriteLine(Info.debuffNames[i] + ": " + info, logTypes.INFO);
                    }

                    if (text.Substring(0, 8).ToUpper().Equals("RUSHINFO")) {
                        //1-9
                        int index = 0;

                        if (int.TryParse(text.Substring(9, 1), out index)) {
                            string info = settingToString(Data.rushConfigs[index].debuffs[i]);

                            WriteLine(Info.debuffNames[i] + ": " + info, logTypes.INFO);
                        }
                        else {
                            Console.WriteLine("Invalid format");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Simple int to string converter
        /// </summary>
        /// <param name="setting"></param>
        /// <returns></returns>
        private static string settingToString(int setting) {
            switch (setting) {
                case 1:
                    return "On";

                case -1:
                    return "Off";

                default:
                    return "Unknown";
            }
        }

        /// <summary>
        /// Simple int to string converter
        /// </summary>
        /// <param name="setting"></param>
        /// <returns></returns>
        private static string settingToString(bool setting) {
            switch (setting) {
                case true:
                    return "On";

                case false:
                    return "Off";

                default:
                    return "Unknown";
            }
        }

        /// <summary>
        /// Writes a line to the console and the log from an object's ToString()
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="type"></param>
        public static void WriteLine(object obj, logTypes type = logTypes.INFO) {
            WriteLine(obj.ToString(), type);
        }

        /// <summary>
        /// Writes a line to the console and the log from a string
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type"></param>
        public static void WriteLine(string text, logTypes type = logTypes.INFO) {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) {
                return;
            }

            //Get the date and time
            DateTime now = DateTime.Now;
            string date = now.ToString("yyyy-MM-dd");
            string time = now.ToString("HH:mm:ss");

            //Get the type of log this is
            string typeText = type.ToString();

            //Create the output with formatting
            string output = "[" + time + "] " + "[" + typeText + "] " + text + Environment.NewLine;

            //If the form's loaded yet, append the text to the console
            if (Data.form != null) {
                Data.form.RichConsoleText.SelectionColor = LogTypeToColor(type);

                Data.form.RichConsoleText.AppendText(output);

                SendMessage(Data.form.RichConsoleText.Handle, WM_VSCROLL, (IntPtr)SB_BOTTOM, IntPtr.Zero);
            }

            //If we're in debug, write to the actual console
            if (Info.debug) {
                System.Console.Write(output);
            }

            //If a log file for today doesn't exist
            if (!File.Exists("Logs/" + date + ".log")) {
                //Make one and write the output to it
                StreamWriter sw = File.CreateText("Logs/" + date + ".log");
                sw.Write(output);
                sw.Close();
            }
            else {
                //Otherwise append the output to the end
                File.AppendAllText("Logs/" + date + ".log", output);
            }

            //If we're not in debug mode
            if (!Info.debug) {
                //If the log is an error
                if (type == logTypes.ERROR) {
                    string caption = "Error!";

                    string message = text + Environment.NewLine + "The program may not function as intended." + Environment.NewLine + "Do you wish to exit?";

                    //Show a message box asking the user if they want to exit the program
                    DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

                    //If they don't click no, exit the program
                    if (result != DialogResult.No) {
                        WriteLine("User has exited after error.");
                        Environment.Exit(1);
                    }
                }

                //If the log is a fatal
                if (type == logTypes.FATAL) {
                    string error = text.Substring(0, text.IndexOf("\n"));
                    string caption = "Fatal Error!";

                    string message = error + Environment.NewLine + "Check the Logs folder for more info, please report this." + Environment.NewLine + "The program will now exit.";

                    //Show a message box telling the user that the program is closing
                    MessageBox.Show(message, caption, MessageBoxButtons.OK);
                    Environment.Exit(2);
                }
            }
        }

        private static Color LogTypeToColor(logTypes type) {
            switch (type) {
                case logTypes.CMD:
                    return Color.Aqua;

                case logTypes.WARN:
                    return Color.Yellow;

                case logTypes.ERROR:
                    return Color.Orange;

                case logTypes.FATAL:
                    return Color.Red;

                default:
                    return Color.Lime;
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        private const int WM_VSCROLL = 0x115;
        private const int SB_BOTTOM = 7;
    }
}