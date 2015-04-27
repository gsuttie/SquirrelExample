using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Squirrel;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SquirrelAwareApp.HandleEvents(onAppUpdate: Form1.OnAppUpdate, onAppUninstall: Form1.OnAppUninstall, onInitialInstall: Form1.OnInitialInstall); 
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
