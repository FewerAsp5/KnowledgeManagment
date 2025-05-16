using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnowledgeManagement
{
    public partial class KnowledgeForm : Form
    {
        private readonly KnowledgeDataSet knowledgeDataSet;

        public KnowledgeForm(string categoryName, KnowledgeDataSet knowledgeDataSet)
        {
            this.knowledgeDataSet = knowledgeDataSet;
            InitializeComponent();

            Text = "Новое знание для категории " + categoryName;

            tagTableAdapter.Fill(knowledgeDataSet.Tag);
            foreach (var tag in knowledgeDataSet.Tag)
            {
                TagList.Items.Add(tag);
            }
        }

        public string KnowledgeName
        {
            get { return KnowledgeNameText.Text; }
            set { KnowledgeNameText.Text = value; }
        }

        public IEnumerable<int> Tags
        {
            get
            {
                foreach (var item in TagList.CheckedItems)
                {
                    yield return ((KnowledgeDataSet.TagRow)item).TagID;
                }
            }
            set
            {
                var list = value.ToList();
                for(int i = 0; i < TagList.Items.Count; i ++)
                {
                    var item = TagList.Items[i];
                    var check = list.Contains(((KnowledgeDataSet.TagRow)item).TagID);
                    TagList.SetItemChecked(i, check);
                }
            }
        }

        public IEnumerable<KnowledgeDataSet.ArticleRow> Article
        {
            get
            {
                foreach(var item in ArticleList.Items)
                {
                    yield return (KnowledgeDataSet.ArticleRow)item;
                }
            }
            set
            {
                ArticleList.Items.Clear();
                ArticleList.Items.AddRange(value.ToArray());
            }
        }

        public IEnumerable<KnowledgeDataSet.PictureRow> Picture
        {
            get
            {
                foreach (var item in PictureList.Items)
                {
                    yield return (KnowledgeDataSet.PictureRow)item;
                }
            }
            set
            {
                PictureList.Items.Clear();
                PictureList.Items.AddRange(value.ToArray());
            }
        }

        public IEnumerable<KnowledgeDataSet.VideoRow> Video
        {
            get
            {
                foreach (var item in VideoList.Items)
                {
                    yield return (KnowledgeDataSet.VideoRow)item;
                }
            }
            set
            {
                VideoList.Items.Clear();
                VideoList.Items.AddRange(value.ToArray());
            }
        }

        public IEnumerable<KnowledgeDataSet.LinkRow> Link
        {
            get
            {
                foreach (var item in LinkList.Items)
                {
                    yield return (KnowledgeDataSet.LinkRow)item;
                }
            }
            set
            {
                LinkList.Items.Clear();
                LinkList.Items.AddRange(value.ToArray());
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(KnowledgeNameText.Text))
            {
                MessageBox.Show("Введите наименование знания.", "Ошибка добавления знания", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void AddTag_Click(object sender, EventArgs e)
        {
            var newTag = string.Empty;
            if (InputTextForm.TryInputText(ref newTag, "Добавить тэг", "Введите наименование нового тэга:"))
            {
                var tag = knowledgeDataSet.Tag.NewTagRow();
                tag.Text = newTag;
                knowledgeDataSet.Tag.AddTagRow(tag);

                tagTableAdapter.Update(knowledgeDataSet.Tag);

                TagList.Items.Add(tag);
            }
        }

        private void EditTag_Click(object sender, EventArgs e)
        {
            var selectedItem = (KnowledgeDataSet.TagRow)TagList.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать тэг для редактирования.", "Изменить тег", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var tag = selectedItem.Text;
            if(InputTextForm.TryInputText(ref tag, "Измиенить тэг", "введите новое наименование тэга:"))
            {
                selectedItem.Text = tag;
                TagList.Refresh();
                tagTableAdapter.Update(selectedItem);
            }
        }

        private void DeleteTag_Click(object sender, EventArgs e)
        {
            var selectedItem = (KnowledgeDataSet.TagRow)TagList.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать тэг для удаления.", "Удалить тег", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Вы действительно хотите удалить тэг \"{selectedItem}\"?", "Удалить тег", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            TagList.Items.Remove(selectedItem);
            selectedItem.Delete();
            tagTableAdapter.Update(knowledgeDataSet.Tag);
        }

        private void AddArticle_Click(object sender, EventArgs e)
        {
            var form = new ArticleForm();
            form.Text = "Новая статья";
            if (form.ShowDialog() == DialogResult.OK)
            {
                var article = knowledgeDataSet.Article.NewArticleRow();
                article.Title = form.Caption;
                article.Text = form.Content;
                ArticleList.Items.Add(article);
            }
        }

        private void EditArticle_Click(object sender, EventArgs e)
        {
            var selectedItem = (KnowledgeDataSet.ArticleRow)ArticleList.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать статью для изменения.", "Изменить статью", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new ArticleForm();
            form.Text = "Изменить статью";
            form.Caption = selectedItem.Title;
            form.Content = selectedItem.Text;
            if (form.ShowDialog() == DialogResult.OK)
            {
                selectedItem.Title = form.Caption;
                selectedItem.Text = form.Content;

                ArticleList.Items[ArticleList.SelectedIndex] = selectedItem;
            }
        }

        private void DeleteArticle_Click(object sender, EventArgs e)
        {
            var selectedItem = (KnowledgeDataSet.ArticleRow)ArticleList.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать статью для удаления.", "Удалить статью", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Вы действительно хотите удалить статью \"{selectedItem}\"?", "Удалить статью", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            ArticleList.Items.Remove(selectedItem);
        }

        private void AddPicture_Click(object sender, EventArgs e)
        {
            var form = new PictureForm();
            form.Text = "Новая картинка";
            if (form.ShowDialog() == DialogResult.OK)
            {
                var picture = knowledgeDataSet.Picture.NewPictureRow();
                picture.Title = form.Title;
                picture.FilePath = form.Path;
                PictureList.Items.Add(picture);
            }
        }

        private void EditPicture_Click(object sender, EventArgs e)
        {
            var selectedItem = (KnowledgeDataSet.PictureRow)PictureList.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать картинку для изменения.", "Изменить картинку", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new PictureForm();
            form.Text = "Изменить картинку";
            form.Title = selectedItem.Title;
            form.Path = selectedItem.FilePath;
            if (form.ShowDialog() == DialogResult.OK)
            {
                selectedItem.Title = form.Title;
                selectedItem.FilePath = form.Path;

                PictureList.Items[PictureList.SelectedIndex] = selectedItem;
            }
        }

        private void DeletePicture_Click(object sender, EventArgs e)
        {
            var selectedItem = (KnowledgeDataSet.PictureRow)PictureList.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать картинку для удаления.", "Удалить картинку", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Вы действительно хотите удалить картинку \"{selectedItem}\"?", "Удалить картинку", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            PictureList.Items.Remove(selectedItem);
        }

        private void AddVideo_Click(object sender, EventArgs e)
        {
            var form = new VideoForm();
            form.Text = "Новое видео";
            if (form.ShowDialog() == DialogResult.OK)
            {
                var video = knowledgeDataSet.Video.NewVideoRow();
                video.Title = form.Title;
                video.FilePath = form.Path;
                VideoList.Items.Add(video);
            }
        }

        private void EditVideo_Click(object sender, EventArgs e)
        {
            var selectedItem = (KnowledgeDataSet.VideoRow)VideoList.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать видео для изменения.", "Изменить видео", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new VideoForm();
            form.Text = "Изменить видео";
            form.Title = selectedItem.Title;
            form.Path = selectedItem.FilePath;
            if (form.ShowDialog() == DialogResult.OK)
            {
                selectedItem.Title = form.Title;
                selectedItem.FilePath = form.Path;

                VideoList.Items[VideoList.SelectedIndex] = selectedItem;
            }
        }

        private void DeleteVideo_Click(object sender, EventArgs e)
        {
            var selectedItem = (KnowledgeDataSet.VideoRow)VideoList.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать видео для удаления.", "Удалить видео", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Вы действительно хотите удалить видео \"{selectedItem}\"?", "Удалить видео", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            VideoList.Items.Remove(selectedItem);
        }

        private void AddLink_Click(object sender, EventArgs e)
        {
            var form = new LinkForm();
            form.Text = "Новая ссылка";
            if (form.ShowDialog() == DialogResult.OK)
            {
                var link = knowledgeDataSet.Link.NewLinkRow();
                link.Title = form.Title;
                link.LinkAddress = form.Link;
                LinkList.Items.Add(link);
            }
        }

        private void EditLink_Click(object sender, EventArgs e)
        {
            var selectedItem = (KnowledgeDataSet.LinkRow)LinkList.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать ссылку для изменения.", "Изменить ссылку", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new LinkForm();
            form.Text = "Изменить ссылку";
            form.Title = selectedItem.Title;
            form.Link = selectedItem.LinkAddress;
            if (form.ShowDialog() == DialogResult.OK)
            {
                selectedItem.Title = form.Title;
                selectedItem.LinkAddress = form.Link;

                LinkList.Items[LinkList.SelectedIndex] = selectedItem;
            }
        }

        private void DeleteLink_Click(object sender, EventArgs e)
        {
            var selectedItem = (KnowledgeDataSet.LinkRow)LinkList.SelectedItem;
            if (selectedItem == null)
            {
                MessageBox.Show("Необходимо выбрать ссылку для удаления.", "Удалить ссылку", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show($"Вы действительно хотите удалить ссылку \"{selectedItem}\"?", "Удалить ссылку", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            LinkList.Items.Remove(selectedItem);
        }
    }
}
