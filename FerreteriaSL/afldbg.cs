using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace FerreteriaSL
{

    public static class afldbg
    {
        static afldbg()
        {
#if DEBUG
            const string filename = @"C:\Wamp\www\csTrace\afliw.log";
            File.WriteAllText(filename, String.Empty);
            Trace.Listeners.Add(new TextWriterTraceListener(filename));
            Trace.AutoFlush = true;
            Trace.Indent();
            //asd
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
#endif
        }

        public static void log(object sender, string msg, string color = "black")
        {
#if DEBUG
            //string Class = sender.GetType().Name;
            //string timeStamp = DateTime.Now.ToString("HH:mm:ss.fff");
            //Trace.WriteLine("|" + color + "?" + timeStamp + " (" + Class + ") " + msg);
#endif
        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {
#if DEBUG
            Trace.Unindent();
            Trace.Flush();
#endif
        }
    }
}
