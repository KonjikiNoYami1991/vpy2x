using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace vpy2x
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        
        private static Mutex mutex = null;
        [STAThread]
        static void Main()
        {
            const string appName = "vpy2x";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                MessageBox.Show("vpy2x is already running!\nExiting the application.", appName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new vpy2x());
        }
    }
}
