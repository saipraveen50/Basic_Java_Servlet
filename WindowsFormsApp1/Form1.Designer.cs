
namespace WindowsFormsApp1
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabDownload = new System.Windows.Forms.TabPage();
            this.grbVideoInfo = new System.Windows.Forms.GroupBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.flpDownloadClip = new System.Windows.Forms.FlowLayoutPanel();
            this.chbDownloadClipFrom = new System.Windows.Forms.CheckBox();
            this.chbDownloadClipTo = new System.Windows.Forms.CheckBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lFileSize = new System.Windows.Forms.Label();
            this.videoThumbnail = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.cmbQuality = new System.Windows.Forms.ComboBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbLink = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.tabHelp = new System.Windows.Forms.TabPage();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Dataprogress = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl.SuspendLayout();
            this.tabDownload.SuspendLayout();
            this.grbVideoInfo.SuspendLayout();
            this.flpDownloadClip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoThumbnail)).BeginInit();
            this.grbLink.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabDownload);
            this.tabControl.Controls.Add(this.tabHelp);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(760, 437);
            this.tabControl.TabIndex = 0;
            // 
            // tabDownload
            // 
            this.tabDownload.BackColor = System.Drawing.Color.PowderBlue;
            this.tabDownload.Controls.Add(this.statusStrip1);
            this.tabDownload.Controls.Add(this.grbVideoInfo);
            this.tabDownload.Controls.Add(this.grbLink);
            this.tabDownload.Location = new System.Drawing.Point(4, 22);
            this.tabDownload.Name = "tabDownload";
            this.tabDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tabDownload.Size = new System.Drawing.Size(752, 411);
            this.tabDownload.TabIndex = 0;
            this.tabDownload.Text = "Download";
            // 
            // grbVideoInfo
            // 
            this.grbVideoInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbVideoInfo.Controls.Add(this.txtFilePath);
            this.grbVideoInfo.Controls.Add(this.flpDownloadClip);
            this.grbVideoInfo.Controls.Add(this.txtTitle);
            this.grbVideoInfo.Controls.Add(this.lFileSize);
            this.grbVideoInfo.Controls.Add(this.videoThumbnail);
            this.grbVideoInfo.Controls.Add(this.label3);
            this.grbVideoInfo.Controls.Add(this.label4);
            this.grbVideoInfo.Controls.Add(this.btnBrowse);
            this.grbVideoInfo.Controls.Add(this.cmbQuality);
            this.grbVideoInfo.Controls.Add(this.btnDownload);
            this.grbVideoInfo.Controls.Add(this.label1);
            this.grbVideoInfo.Location = new System.Drawing.Point(6, 112);
            this.grbVideoInfo.Name = "grbVideoInfo";
            this.grbVideoInfo.Size = new System.Drawing.Size(740, 169);
            this.grbVideoInfo.TabIndex = 10;
            this.grbVideoInfo.TabStop = false;
            this.grbVideoInfo.Text = "Video Details";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilePath.Location = new System.Drawing.Point(304, 74);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(393, 20);
            this.txtFilePath.TabIndex = 12;
            // 
            // flpDownloadClip
            // 
            this.flpDownloadClip.Controls.Add(this.chbDownloadClipFrom);
            this.flpDownloadClip.Controls.Add(this.chbDownloadClipTo);
            this.flpDownloadClip.Location = new System.Drawing.Point(4, 130);
            this.flpDownloadClip.Name = "flpDownloadClip";
            this.flpDownloadClip.Size = new System.Drawing.Size(281, 20);
            this.flpDownloadClip.TabIndex = 10;
            this.flpDownloadClip.Visible = false;
            // 
            // chbDownloadClipFrom
            // 
            this.chbDownloadClipFrom.AutoSize = true;
            this.chbDownloadClipFrom.Location = new System.Drawing.Point(3, 3);
            this.chbDownloadClipFrom.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.chbDownloadClipFrom.Name = "chbDownloadClipFrom";
            this.chbDownloadClipFrom.Size = new System.Drawing.Size(66, 17);
            this.chbDownloadClipFrom.TabIndex = 16;
            this.chbDownloadClipFrom.Text = "Clip from";
            this.chbDownloadClipFrom.UseVisualStyleBackColor = true;
            // 
            // chbDownloadClipTo
            // 
            this.chbDownloadClipTo.AutoSize = true;
            this.chbDownloadClipTo.Enabled = false;
            this.chbDownloadClipTo.Location = new System.Drawing.Point(72, 3);
            this.chbDownloadClipTo.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.chbDownloadClipTo.Name = "chbDownloadClipTo";
            this.chbDownloadClipTo.Size = new System.Drawing.Size(35, 17);
            this.chbDownloadClipTo.TabIndex = 17;
            this.chbDownloadClipTo.Text = "to";
            this.chbDownloadClipTo.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitle.Location = new System.Drawing.Point(304, 20);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(393, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // lFileSize
            // 
            this.lFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lFileSize.AutoSize = true;
            this.lFileSize.Location = new System.Drawing.Point(622, 49);
            this.lFileSize.Name = "lFileSize";
            this.lFileSize.Size = new System.Drawing.Size(44, 13);
            this.lFileSize.TabIndex = 11;
            this.lFileSize.Text = "File size";
            // 
            // videoThumbnail
            // 
            this.videoThumbnail.BackColor = System.Drawing.Color.Gainsboro;
            this.videoThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.videoThumbnail.Location = new System.Drawing.Point(6, 22);
            this.videoThumbnail.Name = "videoThumbnail";
            this.videoThumbnail.Size = new System.Drawing.Size(196, 102);
            this.videoThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.videoThumbnail.TabIndex = 4;
            this.videoThumbnail.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Title";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(703, 73);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(31, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // cmbQuality
            // 
            this.cmbQuality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbQuality.FormattingEnabled = true;
            this.cmbQuality.Location = new System.Drawing.Point(304, 46);
            this.cmbQuality.Name = "cmbQuality";
            this.cmbQuality.Size = new System.Drawing.Size(312, 21);
            this.cmbQuality.TabIndex = 1;
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDownload.Enabled = false;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(625, 102);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(109, 38);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Save to";
            // 
            // grbLink
            // 
            this.grbLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbLink.Controls.Add(this.label2);
            this.grbLink.Controls.Add(this.btnStart);
            this.grbLink.Controls.Add(this.txtUrl);
            this.grbLink.Location = new System.Drawing.Point(6, 6);
            this.grbLink.Name = "grbLink";
            this.grbLink.Size = new System.Drawing.Size(740, 89);
            this.grbLink.TabIndex = 9;
            this.grbLink.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Link";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.SystemColors.Info;
            this.btnStart.Location = new System.Drawing.Point(644, 45);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 38);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(39, 19);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(695, 20);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.TextChanged += new System.EventHandler(this.txtYoutubeLink_TextChanged);
            // 
            // tabHelp
            // 
            this.tabHelp.Location = new System.Drawing.Point(4, 22);
            this.tabHelp.Name = "tabHelp";
            this.tabHelp.Padding = new System.Windows.Forms.Padding(3);
            this.tabHelp.Size = new System.Drawing.Size(752, 411);
            this.tabHelp.TabIndex = 1;
            this.tabHelp.Text = "Help";
            this.tabHelp.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.Status,
            this.Dataprogress});
            this.statusStrip1.Location = new System.Drawing.Point(3, 386);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(746, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel1.Text = "Status : ";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(0, 17);
            // 
            // Dataprogress
            // 
            this.Dataprogress.Name = "Dataprogress";
            this.Dataprogress.Size = new System.Drawing.Size(0, 17);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(644, 425);
            this.Name = "MainWindow";
            this.Text = "Youtube Video Downloader";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl.ResumeLayout(false);
            this.tabDownload.ResumeLayout(false);
            this.tabDownload.PerformLayout();
            this.grbVideoInfo.ResumeLayout(false);
            this.grbVideoInfo.PerformLayout();
            this.flpDownloadClip.ResumeLayout(false);
            this.flpDownloadClip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoThumbnail)).EndInit();
            this.grbLink.ResumeLayout(false);
            this.grbLink.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDownload;
        private System.Windows.Forms.TabPage tabHelp;
        private System.Windows.Forms.GroupBox grbVideoInfo;
        private System.Windows.Forms.FlowLayoutPanel flpDownloadClip;
        private System.Windows.Forms.CheckBox chbDownloadClipFrom;
        private System.Windows.Forms.CheckBox chbDownloadClipTo;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lFileSize;
        private System.Windows.Forms.PictureBox videoThumbnail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox cmbQuality;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.ToolStripStatusLabel Dataprogress;
    }
}

