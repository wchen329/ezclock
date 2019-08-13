using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ezClock
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form_ezClock application = new Form_ezClock();
            Application.Run(application);
        }
    }
}
