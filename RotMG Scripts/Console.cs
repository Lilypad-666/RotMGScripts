using System;
using System.Diagnostics;
using System.IO;
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
            WriteLine(text, logTypes.CMD);

            if (text.ToUpper().Equals("PING")) {
                WriteLine("PONG", logTypes.INFO);
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
                Data.form.ConsoleText.AppendText(output);
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
            } else {
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
    }
}
