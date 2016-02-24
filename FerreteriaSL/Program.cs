using System;
using System.Windows.Forms;

namespace FerreteriaSL
{
    static class Program
    {
        public static string WorkingServer = "";
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
        // Fork test Test
    }
}
