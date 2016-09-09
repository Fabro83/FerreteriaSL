using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FerreteriaSL.AutoUpdate
{
    public delegate void NewUpdateHandler();
    public delegate void UpdateProgressChanged(int percentage);
    public delegate void NewUpdateDownloadFinished(Exception downloadError);

    class AutoUpdate
    {
        readonly string _jsonInfoFilePath = AppDomain.CurrentDomain.BaseDirectory + @"\Version.json";
        private BackgroundWorker _updateWorker;
        private VersionInfo _updateInfo, _currentInfo;
        private string _downloadedUpdateFilePath;
        private string _downloadedUpdateFileName;
        public event NewUpdateHandler NewUpdate;
        public event UpdateProgressChanged ProgressChanged;
        public event NewUpdateDownloadFinished DownloadFinished;

        public void Check()
        {
            GetCurrentVersionInfo();
            GetUpdateInfo();
        }

        public void GetCurrentVersionInfo()
        {
            var currentInfoJson = File.ReadAllText(_jsonInfoFilePath);
            _currentInfo = JsonConvert.DeserializeObject<VersionInfo>(currentInfoJson);
        }

        private void GetUpdateInfo()
        {
            _updateWorker = new BackgroundWorker();
            _updateWorker.DoWork += UpdateGetInfoWork;
            _updateWorker.RunWorkerCompleted += UpdateGetInfoDone;
            _updateWorker.RunWorkerAsync();
        }

        private void UpdateGetInfoWork(object sender, DoWorkEventArgs args)
        {
            try
            {
                var updateInfoJson = new WebClient().DownloadString(_currentInfo.CheckUrl);
                _updateInfo = JsonConvert.DeserializeObject<VersionInfo>(updateInfoJson);
                args.Result = true;
            }
            catch (Exception)
            {
                args.Result = false;
            }
        }

        private void UpdateGetInfoDone(object sender, RunWorkerCompletedEventArgs args)
        {
            if (!(bool) args.Result) return;

            if (_updateInfo.CheckUrl != _currentInfo.CheckUrl)
            {
                _currentInfo.CheckUrl = _updateInfo.CheckUrl;
                var newCurrentInfo = JsonConvert.SerializeObject(_currentInfo);
                File.WriteAllText(_jsonInfoFilePath, newCurrentInfo);
                Check();
            }
            else if (_updateInfo.Version != _currentInfo.Version)
                NewUpdate();          
        }

        public void DownloadNewVersion()
        {
            WebClient newVersionDownloader = new WebClient();
            string newFilePath = AppDomain.CurrentDomain.BaseDirectory + @"\Update\";
            string newFileName = _updateInfo.Date.Ticks + "-" + _updateInfo.Version + ".exe";
            _downloadedUpdateFileName = newFileName;
            _downloadedUpdateFilePath = newFilePath + newFileName;

            if (File.Exists(_downloadedUpdateFilePath))
                File.Delete(_downloadedUpdateFilePath);
            else if (!Directory.Exists(newFilePath))
                Directory.CreateDirectory(newFilePath);

            newVersionDownloader.DownloadFileCompleted += DownloadNewVersionCompleted;
            newVersionDownloader.DownloadProgressChanged += DownloadNewVersionProgressChanged;
            newVersionDownloader.DownloadFileAsync(_updateInfo.Url, _downloadedUpdateFilePath);          
        }

        void DownloadNewVersionProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            ProgressChanged(e.ProgressPercentage);
        }

        private void DownloadNewVersionCompleted(object sender, AsyncCompletedEventArgs e)
        {
            DownloadFinished(e.Error);
        }

        public void DoUpdate()
        {
            ProcessStartInfo updateProcessStartInfo = new ProcessStartInfo
            {
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Normal,
                FileName = "Updater.exe",
                Arguments = _downloadedUpdateFileName,
                WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory
            };
            Process.Start(updateProcessStartInfo);
            Application.Exit();
        }
    }

    class VersionInfo
    {
        public string Version { get; set; }
        public DateTime Date { get; set; }
        public Uri Url { get; set; }
        public Uri CheckUrl { get; set; }
    }
}
