using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetracker
{
    /// <summary>
    /// Program main entry point
    /// </summary>
    static class Program
    {
        /// <summary>
        /// MUTEX TO MAKE SURE THE APPLICATION HAS ONLY ONE INSTANCE
        /// </summary>
        static Mutex mutex = new Mutex(true, "{AB8DC92D-39FC-95C1-BC2C-BD9ABC7EF9AB}");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(TrayApplicationContext.Instance);
            } else
            {
                MessageBox.Show("Timestracker is already running. Cannot start a second instance.");
            }
        }
    }
}
