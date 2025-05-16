using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static KnowledgeManagement.KnowledgeDataSet;

namespace KnowledgeManagement
{
    public partial class KnowledgeView : Form
    {
        private readonly int knowledgeID;
        public KnowledgeView(int knowledgeID)
        {
            this.knowledgeID = knowledgeID;
            InitializeComponent();
            VideoView.Left = VideoGrid.Left;
            VideoView.Top = ArticleView.Top;
            VideoView.Width = VideoGrid.Width;
            VideoView.Height = ArticleView.Height;
            VideoView.settings.mute = true;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            VideoView.Ctlcontrols.stop();
        }

        private void KnowledgeView_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "knowledgeDataSet.Link". При необходимости она может быть перемещена или удалена.
            this.linkTableAdapter.FillByKnowledge(this.knowledgeDataSet.Link, knowledgeID);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "knowledgeDataSet.Picture". При необходимости она может быть перемещена или удалена.
            this.pictureTableAdapter.FillByKnowledge(this.knowledgeDataSet.Picture, knowledgeID);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "knowledgeDataSet.Video". При необходимости она может быть перемещена или удалена.
            this.videoTableAdapter.FillByKnowledge(this.knowledgeDataSet.Video, knowledgeID);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "knowledgeDataSet.Article". При необходимости она может быть перемещена или удалена.
            this.articleTableAdapter.FillByKnowledge(this.knowledgeDataSet.Article, knowledgeID);

        }

        private void ArticleGrid_SelectionChanged(object sender, EventArgs e)
        {
            var i = ArticleGrid.CurrentRow.Index;
            var article = knowledgeDataSet.Article[i];
            ArticleView.Text = article.Text;
        }

        private void VideoGrid_SelectionChanged(object sender, EventArgs e)
        {
            var i = VideoGrid.CurrentRow.Index;
            var video = knowledgeDataSet.Video[i];
            var videoPath = video.FilePath;
            if (File.Exists(videoPath))
            {
                VideoView.URL = videoPath;
                VideoView.Visible = true;
                VideoView.settings.mute = true;
            }
        }

        private async void VideoView_PlayStateChangeAsync(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                await Task.Delay(100);
                VideoView.Ctlcontrols.currentPosition = 0;
                VideoView.Ctlcontrols.play();
            }
        }

        private void PictureGrid_SelectionChanged(object sender, EventArgs e)
        {
            var i = PictureGrid.CurrentRow.Index;
            var picture = knowledgeDataSet.Picture[i];
            var picturePath = picture.FilePath;
            if (File.Exists(picturePath))
            {
                PictureView.Image = Image.FromFile(picturePath);
                PictureView.Visible = true;
            }
        }

        private void LinkGrid_SelectionChanged(object sender, EventArgs e)
        {
            var i = LinkGrid.CurrentRow.Index;
            var link = knowledgeDataSet.Link[i];
            var linkPath = new Uri(link.LinkAddress);
            LinkView.Navigate(linkPath);
        }
    }
}
