using AxWMPLib;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnowledgeManagement
{
    public partial class VideoForm : Form
    {
        public VideoForm()
        {
            InitializeComponent();

            VideoBox.uiMode = "none";
            VideoBox.settings.mute = true;
            VideoLoadingError.Size = VideoBox.Size;
            RedrawVideo();
        }

        public string Title
        {
            get { return TitleText.Text; }
            set { TitleText.Text = value; }
        }

        public string Path
        {
            get { return VideoPath.Text; }
            set
            {
                VideoPath.Text = value;
                RedrawVideo();
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            VideoBox.Ctlcontrols.stop();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if (OpenVideoDialog.ShowDialog() == DialogResult.OK)
            {
                Path = OpenVideoDialog.FileName;
            }
        }

        private void PhotoPath_Leave(object sender, EventArgs e)
        {
            RedrawVideo();
        }

        private void RedrawVideo()
        {
            if(System.IO.File.Exists(Path))
            { 
                VideoLoadingError.Visible = false;
                VideoBox.Ctlcontrols.stop();
                VideoBox.URL = Path;
                VideoBox.Visible = true;
                VideoBox.settings.mute = true;
                VideoBox.Ctlcontrols.play();
            }
            else
            {
                VideoBox.Visible = false;
                VideoLoadingError.Text = string.IsNullOrWhiteSpace(Path)
                    ? "Файл не указан"
                    : $"Не удалось загрузить изображение из файла '{System.IO.Path.GetFileName(Path)}'";
                VideoLoadingError.Visible = true;
            }
        }

        private async void VideoBox_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                await Task.Delay(100);
                VideoBox.Ctlcontrols.currentPosition = 0;
                VideoBox.Ctlcontrols.play();
            }
        }
    }
}
