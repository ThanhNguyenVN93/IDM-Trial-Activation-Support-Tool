using System;
using System.Net;
using System.ComponentModel;

namespace frmidmactive
{
    /// <summary>
    /// Handles file downloads with progress reporting
    /// </summary>
    public class DownloadManager : IDisposable
    {
        private WebClient _webClient;
        private bool _disposed = false;

        public event DownloadProgressChangedEventHandler ProgressChanged;
        public event AsyncCompletedEventHandler DownloadCompleted;

        public void DownloadFileAsync(string downloadUrl, string destinationPath)
        {
            if (_disposed)
                throw new ObjectDisposedException("DownloadManager");

            try
            {
                _webClient = new WebClient();
                _webClient.DownloadProgressChanged += OnWebClientProgressChanged;
                _webClient.DownloadFileCompleted += OnWebClientDownloadCompleted;

                _webClient.DownloadFileAsync(new Uri(downloadUrl), destinationPath);
            }
            catch (Exception ex)
            {
                Cleanup();
                throw new InvalidOperationException("Failed to start download.", ex);
            }
        }

        private void OnWebClientProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            if (ProgressChanged != null)
            {
                ProgressChanged(sender, e);
            }
        }

        private void OnWebClientDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (DownloadCompleted != null)
            {
                DownloadCompleted(sender, e);
            }
            Cleanup();
        }

        public void CancelAsync()
        {
            if (_webClient != null)
            {
                _webClient.CancelAsync();
            }
        }

        private void Cleanup()
        {
            if (_webClient != null)
            {
                _webClient.Dispose();
            }
            _webClient = null;
        }

        public void Dispose()
        {
            if (_disposed)
                return;

            Cleanup();
            _disposed = true;
        }
    }
}
