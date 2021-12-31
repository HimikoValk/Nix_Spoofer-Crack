using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyAuth; 

namespace Nix_Spoofer_Crack
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if(!Spoofer.Utils.IsAdministrator())
            {
                MessageBox.Show("Please run the Program as Administrator!", "Crack Me if you can HAHAHAH", MessageBoxButtons.OK); 
                Environment.Exit(0);
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new main());
            }

        }
    }
}
