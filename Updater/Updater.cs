using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Updater
{
    public partial class Updater : Form
    {
        private readonly string _fileName,_filePath;
        private BackgroundWorker _updateWorker;
        public Updater(string[] args)
        {
            InitializeComponent();
            if (!args.Any())
            {
                MessageBox.Show("Filename not provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(-1);
            }
            else
            {
                _fileName = args.First();
                _filePath = AppDomain.CurrentDomain.BaseDirectory + @"Update\" + _fileName;
            }            
        }

        private void Updater_Shown(object sender, EventArgs e)
        {
            if (_fileName == null || !File.Exists(_filePath)) Environment.Exit(-1);
            _updateWorker = new BackgroundWorker();
            _updateWorker.DoWork += updateWorker_DoWork;
            _updateWorker.RunWorkerCompleted += updateWorker_RunWorkerCompleted;
            _updateWorker.RunWorkerAsync();
        }

        private static void updateWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ProcessStartInfo ferreteriaProcessStartInfo = new ProcessStartInfo
            {
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Maximized,
                FileName = AppDomain.CurrentDomain.BaseDirectory + @"\Ferreteria.exe"
            };
            Process.Start(ferreteriaProcessStartInfo);
            Application.Exit();
        }

        private static void DeleteAllUpdateFiles()
        {
            while(Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Update"))
            {
                Thread.Sleep(5000);
                foreach (var file in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "Update"))
                {
                    File.SetAttributes(file, FileAttributes.Normal);
                    File.Delete(file);
                }
                Directory.Delete(AppDomain.CurrentDomain.BaseDirectory + "Update");
            }
        }

        void updateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            WaitFerreteriaProcessToExit();
            ProcessStartInfo extractProcessStartInfo = new ProcessStartInfo
            {
                CreateNoWindow = false,
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = AppDomain.CurrentDomain.BaseDirectory + @"Update\" + _fileName,
                Arguments = "-o\"" + AppDomain.CurrentDomain.BaseDirectory + "\" -y"
            };
            Process updateProcess = Process.Start(extractProcessStartInfo);
            updateProcess.WaitForExit();
            DeleteAllUpdateFiles();
        }

        private static void WaitFerreteriaProcessToExit()
        {
            Process[] processes = Process.GetProcessesByName("Ferreteria");
            foreach (var process in processes.Where(process => process.MainModule.FileName == AppDomain.CurrentDomain.BaseDirectory + "Ferreteria.exe"))
            {
                process.WaitForExit();
            }
        }
    }
}
