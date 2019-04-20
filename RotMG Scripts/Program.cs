using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace RotMG_Scripts {
    static class Program {
        
        [STAThread]
        static void Main() {
            //If not debugging
            if (Path.GetDirectoryName(Application.ExecutablePath).EndsWith(@"\RotMG Scripts\bin\Debug")) {
                Info.debug = true;
            } else {
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
