using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace FerreteriaSL
{

    public static class Afldbg
    {
        static Afldbg()
        {
#if DEBUG
            const string filename = @"C:\Wamp\www\csTrace\afliw.log";
            File.WriteAllText(filename, String.Empty);
            Trace.Listeners.Add(new TextWriterTraceListener(filename));
            Trace.AutoFlush = true;
            Trace.Indent();
            //asd
            Application.ApplicationExit += Application_ApplicationExit;
#endif
        }

        public static void Log(object sender, string msg, string color = "black")
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
