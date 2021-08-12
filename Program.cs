using System;
using System.Threading;
using System.Windows.Forms;

namespace ClickerGame
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Global catch
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(GlobalCatcher);
            Application.Run(new LogForm());
        }

        // Catching every exception in application (global exception catcher)
        private static void GlobalCatcher(object sender, ThreadExceptionEventArgs e)
        {
            // Only exception text:
            // MessageBox.Show(e.Exception.Message);

            // More Details:
            MessageBox.Show(e.Exception.ToString());
        }
    }
}
