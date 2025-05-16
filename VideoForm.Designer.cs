namespace KnowledgeManagement
{
    partial class VideoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoForm));
            this.Cancel = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.TitleText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.VideoPath = new System.Windows.Forms.TextBox();
            this.OpenVideoDialog = new System.Windows.Forms.OpenFileDialog();
            this.VideoLoadingError = new System.Windows.Forms.Label();
            this.VideoBox = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.VideoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(329, 104);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(15, 104);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // TitleText
            // 
            this.TitleText.Location = new System.Drawing.Point(12, 24);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(392, 20);
            this.TitleText.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Заголовок:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Путь к идео";
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(334, 58);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(70, 23);
            this.Browse.TabIndex = 28;
            this.Browse.Text = "Обзор";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // VideoPath
            // 
            this.VideoPath.Location = new System.Drawing.Point(85, 61);
            this.VideoPath.Name = "VideoPath";
            this.VideoPath.Size = new System.Drawing.Size(243, 20);
            this.VideoPath.TabIndex = 27;
            this.VideoPath.Leave += new System.EventHandler(this.PhotoPath_Leave);
            // 
            // OpenVideoDialog
            // 
            this.OpenVideoDialog.Filter = "mp4|*.mp4|avi|*.avi|Все файлы|*.*";
            this.OpenVideoDialog.Title = "Открыть вдео";
            // 
            // VideoLoadingError
            // 
            this.VideoLoadingError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VideoLoadingError.Location = new System.Drawing.Point(428, 24);
            this.VideoLoadingError.Name = "VideoLoadingError";
            this.VideoLoadingError.Size = new System.Drawing.Size(100, 23);
            this.VideoLoadingError.TabIndex = 33;
            this.VideoLoadingError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.VideoLoadingError.UseCompatibleTextRendering = true;
            this.VideoLoadingError.Visible = false;
            // 
            // VideoBox
            // 
            this.VideoBox.Enabled = true;
            this.VideoBox.Location = new System.Drawing.Point(429, 24);
            this.VideoBox.Name = "VideoBox";
            this.VideoBox.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoBox.OcxState")));
            this.VideoBox.Size = new System.Drawing.Size(99, 103);
            this.VideoBox.TabIndex = 32;
            this.VideoBox.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.VideoBox_PlayStateChange);
            // 
            // VideoForm
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(548, 151);
            this.Controls.Add(this.VideoLoadingError);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.VideoPath);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.VideoBox);
            this.Name = "VideoForm";
            this.Text = "VideoForm";
            ((System.ComponentModel.ISupportInitialize)(this.VideoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox VideoPath;
        private AxWMPLib.AxWindowsMediaPlayer VideoBox;
        private System.Windows.Forms.OpenFileDialog OpenVideoDialog;
        private System.Windows.Forms.Label VideoLoadingError;
    }
}