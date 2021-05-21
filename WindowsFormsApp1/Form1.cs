using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        private YouTube youtube = YouTube.Default;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            grbVideoInfo.Visible = false;
            //cmbQuality.Items.Clear();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            grbVideoInfo.Visible = true;
            //GetVideoData(txtUrl.Text);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                    txtFilePath.Text = folderDialog.SelectedPath;
                else
                    txtFilePath.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            } 
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {

        }

        private void txtYoutubeLink_TextChanged(object sender, EventArgs e)
        {
            // To start the asynchronous operation
            if (!backgroundWorker.IsBusy)
                backgroundWorker.RunWorkerAsync();
        }

        /// <summary>
        /// Method to get all data of the video
        /// </summary>
        /// <param name="link"></param>
        private void GetVideoData(string link)
        {
            var videoData = youtube.GetAllVideos(link);
            var resolution = videoData.Where(r => r.AdaptiveKind == AdaptiveKind.Video && r.Format == VideoFormat.Mp4)
                .Select(r => r.Resolution);
            var bitRate = videoData.Where(r => r.AdaptiveKind == AdaptiveKind.Audio ).Select(r => r.AudioBitrate);
            foreach (var item in resolution)
            {
                cmbQuality.Invoke((MethodInvoker)(() => cmbQuality.Items.Add(item.ToString() + "p")));
            }

            foreach (var item in bitRate)
            {
                cmbQuality.Invoke((MethodInvoker)(() => cmbQuality.Items.Add(item.ToString() + "Kbps")));
            }

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            GetVideoData(txtUrl.Text);
        }
    }
}
