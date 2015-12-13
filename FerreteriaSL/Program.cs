using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Diagnostics;




=======
//github test
>>>>>>> origin/master
namespace FerreteriaSL
{
    static class Program
    {
        public static string workingServer = "";
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());          
        }
        
    }
}
