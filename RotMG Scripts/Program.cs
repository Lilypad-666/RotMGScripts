using System;
using System.Threading;
using System.Windows.Forms;

namespace RotMG_Scripts {

    internal static class Program {

        [STAThread]
        private static void Main(string[] args) {
            //If in VS
            if (args.Length > 0 && args[0].Equals("1")) {
                Info.debug = true;
            }
            else {
                Info.debug = false;
                //UI Excepitons
                Application.ThreadException += new ThreadExceptionEventHandler(Console.ThreadException);

                //Force exceptions to go through our handler
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

                //Non-UI Exceptions
                AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(Console.UnhandledException);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new MainForm());
        }
    }
}