using System;
using System.Windows.Forms;

namespace Thursday_Gen_Quiz
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Catch ANY unhandled exception globally
            AppDomain.CurrentDomain.UnhandledException +=
                (sender, args) =>
                {
                    Exception ex = (Exception)args.ExceptionObject;
                    MessageBox.Show("GLOBAL ERROR: " + ex.Message +
                                    "\n\nStack: " + ex.StackTrace,
                                    "Critical Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                };

            Application.ThreadException +=
                (sender, args) =>
                {
                    MessageBox.Show("THREAD ERROR: " + args.Exception.Message +
                                    "\n\nStack: " + args.Exception.StackTrace,
                                    "Thread Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainDashboard());
        }
    }
}