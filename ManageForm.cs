using KnowledgeManagement.KnowledgeDataSetTableAdapters;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnowledgeManagement
{
    public partial class ManageForm : Form
    {
        private QueriesTableAdapter procAdapter;

        private readonly string pictureStorage;

        private readonly string videoStorage;

        public ManageForm(string pictureStorage, string videoStorage, bool editMode)
        {
            this.pictureStorage = pictureStorage;
            this.videoStorage = videoStorage;

            InitializeComponent();

            AddCategory.Visible = 
                DelCategory.Visible =
                AddKnowledge.Visible = 
                EditKnowledge.Visible = 
                DeleteKnowledge.Visible = editMode;
        }

        private void ManageForm_Load(object sender, EventArgs e)
        {
            knowledgeTagLinkTableAdapter.Fill(knowledgeDataSet.KnowledgeTagLink);
            procAdapter = new QueriesTableAdapter();
            LoadCategories();
        }

        private void LoadCategories()
        {
            treeViewCategories.Nodes.Clear();
            CategoryKnowledgeLabel.Text = string.Empty;

            // Построим дерево. Начнём с корневых узлов (Parent IS NULL).
            // В нашей таблице Parent может быть NULL (или 0, если так задумано).
            // Предположим, что корневые элементы – те, у кого Parent IS NULL.
            var rootRows = categoryTableAdapter.GetRootCategories();
            //DataRow[] rootRows = knowledgeDataSet.Category.Select("Parent IS NULL");

            foreach (var root in rootRows)
            {
                TreeNode rootNode = new TreeNode(root.Name);
                rootNode.Tag = root.CategoryID;
                treeViewCategories.Nodes.Add(rootNode);

                // Рекурсивно добавим дочерние узлы
                BuildTree(rootNode);
            }

            treeViewCategories.ExpandAll();
        }

        /// <summary>
        /// Рекурсивное построение дерева.
        /// </summary>
        /// <param name="parentNode">Родительский узел в TreeView.</param>
        private void BuildTree(TreeNode parentNode)
        {
            // Ищем строки, у которых Parent = parentNode.Tag (текущий CategoryID).
            int parentId = Convert.ToInt32(parentNode.Tag);
            var childRows = categoryTableAdapter.GetChildrenCategories(parentId);

            foreach (var childRow in childRows)
            {
                TreeNode childNode = new TreeNode(childRow.Name);
                childNode.Tag = childRow.CategoryID;
                parentNode.Nodes.Add(childNode);

                // Рекурсия: у этого узла тоже могут быть дети
                BuildTree(childNode);
            }
        }

        private void treeViewCategories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var categoryId = (int)e.Node.Tag;
            CategoryKnowledgeLabel.Text = $"Знания из категории \"{e.Node.Text}\":";
            knowledgeTableAdapter.FillByCategory(knowledgeDataSet.Knowledge, categoryId);
            KnowledgeList.Refresh();
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            var selectedNode = treeViewCategories.SelectedNode;
            if (selectedNode == null && treeViewCategories.GetNodeCount(false) > 0)
            {
                MessageBox.Show("Необходимо выбрать родительскую категорию.", "Добавить категорию", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newCategory = string.Empty;
            if (InputTextForm.TryInputText(ref newCategory, "Добавить категорию", "Введите наименование новой категории:"))
            {
                var parent = (int?)selectedNode?.Tag;
                categoryTableAdapter.Insert(newCategory, parent);

                LoadCategories();
            }
        }

        private void DelCategory_Click(object sender, EventArgs e)
        {
            var selectedNode = treeViewCategories.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("Необходимо выбрать категорию для удаления.", "Удалить категорию", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var res = MessageBox.Show($"Вы действительно хотите удалить категорию {selectedNode.Text} со всеми подкатегориями и входящими в них знаниями?", "Удалить категорию", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
            {
                return;
            }

            procAdapter.DeleteCategoryCascade((int)selectedNode.Tag);
            LoadCategories();
        }

        private void AddKnowledge_Click(object sender, EventArgs e)
        {
            var selectedNode = treeViewCategories.SelectedNode;
            if (selectedNode == null)
            {
                MessageBox.Show("Необходимо выбрать категорию для нового знания.", "Добавить знание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var form = new KnowledgeForm(selectedNode.Text, knowledgeDataSet);
            if (form.ShowDialog() == DialogResult.OK)
            {
                var category = (int)selectedNode.Tag;

                var newKnowledge = knowledgeDataSet.Knowledge.NewKnowledgeRow();
                newKnowledge.Title = form.KnowledgeName;
                newKnowledge.CategoryID = category;
                knowledgeDataSet.Knowledge.AddKnowledgeRow(newKnowledge);
                knowledgeTableAdapter.Update(knowledgeDataSet.Knowledge);

                foreach(var tag in form.Tags)
                {
                    var link = knowledgeDataSet.KnowledgeTagLink.NewKnowledgeTagLinkRow();
                    link.KnowledgeID = newKnowledge.KnowledgeID;
                    link.TagID = tag;
                    knowledgeDataSet.KnowledgeTagLink.AddKnowledgeTagLinkRow(link);
                }
                knowledgeTagLinkTableAdapter.Update(knowledgeDataSet.KnowledgeTagLink);

                foreach(var article in form.Article)
                {
                    article.KnowledgeID = newKnowledge.KnowledgeID;
                    knowledgeDataSet.Article.AddArticleRow(article);
                }
                articleTableAdapter.Update(knowledgeDataSet.Article);

                foreach(var picture in form.Picture)
                {
                    picture.KnowledgeID = newKnowledge.KnowledgeID;
                    var storageName = Path.Combine(pictureStorage, Guid.NewGuid().ToString());
                    storageName = Path.ChangeExtension(storageName, Path.GetExtension(picture.FilePath));
                    File.Copy(picture.FilePath, storageName, true);
                    picture.FilePath = storageName;
                    knowledgeDataSet.Picture.AddPictureRow(picture);
                }
                pictureTableAdapter.Update(knowledgeDataSet.Picture);

                foreach(var video in form.Video)
                {
                    video.KnowledgeID = newKnowledge.KnowledgeID;
                    var storageName = Path.Combine(videoStorage, Guid.NewGuid().ToString());
                    storageName = Path.ChangeExtension(storageName, Path.GetExtension(video.FilePath));
                    File.Copy(video.FilePath, storageName, true);
                    video.FilePath = storageName;
                    knowledgeDataSet.Video.AddVideoRow(video);
                }
                videoTableAdapter.Update(knowledgeDataSet.Video);

                foreach(var link in form.Link)
                {
                    link.KnowledgeID = newKnowledge.KnowledgeID;
                    knowledgeDataSet.Link.AddLinkRow(link);
                }
                linkTableAdapter.Update(knowledgeDataSet.Link);

                treeViewCategories_AfterSelect(treeViewCategories, new TreeViewEventArgs(selectedNode));
            }
        }

        private void EditKnowledge_Click(object sender, EventArgs e)
        {
            var selectedRowView = (DataRowView)knowledgeBindingSource.Current;
            if (selectedRowView == null)
            {
                MessageBox.Show("Необходимо выбрать знание для изменения.", "Изменить знание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var editKnowledge = (KnowledgeDataSet.KnowledgeRow)selectedRowView.Row;
            var form = new KnowledgeForm(treeViewCategories.SelectedNode.Text, knowledgeDataSet);
            form.KnowledgeName = editKnowledge.Title;

            var tags = knowledgeTagLinkTableAdapter.GetDataByKnowledge(editKnowledge.KnowledgeID).Select(t => t.TagID);
            form.Tags = tags;

            var articles = articleTableAdapter.GetDataByKnowledge(editKnowledge.KnowledgeID);
            form.Article = articles;

            var pictures = pictureTableAdapter.GetDataByKnowledge(editKnowledge.KnowledgeID);
            form.Picture = pictures;

            var videos = videoTableAdapter.GetDataByKnowledge(editKnowledge.KnowledgeID);
            form.Video = videos;

            var links = linkTableAdapter.GetDataByKnowledge(editKnowledge.KnowledgeID);
            form.Link = links;

            if (form.ShowDialog() == DialogResult.OK)
            {
                var delTags = tags.Except(form.Tags);
                foreach(var t in delTags)
                {
                    knowledgeTagLinkTableAdapter.Delete(editKnowledge.KnowledgeID, t);
                }
                var newTags = form.Tags.Except(tags);
                foreach (var t in newTags)
                {
                    var link = knowledgeDataSet.KnowledgeTagLink.NewKnowledgeTagLinkRow();
                    link.KnowledgeID = editKnowledge.KnowledgeID;
                    link.TagID = t;
                    knowledgeDataSet.KnowledgeTagLink.AddKnowledgeTagLinkRow(link);
                }
                knowledgeTagLinkTableAdapter.Update(knowledgeDataSet.KnowledgeTagLink);

                var delArticles = articles.Except(form.Article);
                foreach (var a in delArticles)
                {
                    a.Delete();
                }
                articleTableAdapter.Update(articles);
                var newArticles = form.Article.Except(articles);
                foreach (var a in newArticles)
                {
                    a.KnowledgeID = editKnowledge.KnowledgeID;
                    knowledgeDataSet.Article.AddArticleRow(a);
                }
                articleTableAdapter.Update(knowledgeDataSet);

                var delPictures = pictures.Except(form.Picture);
                foreach (var p in delPictures)
                {
                    p.Delete();
                }
                pictureTableAdapter.Update(pictures);
                var newPictures = form.Picture.Except(pictures);
                foreach (var p in newPictures)
                {
                    p.KnowledgeID = editKnowledge.KnowledgeID;
                    knowledgeDataSet.Picture.AddPictureRow(p);
                }
                pictureTableAdapter.Update(knowledgeDataSet);

                var delVideos = videos.Except(form.Video);
                foreach (var v in delVideos)
                {
                    v.Delete();
                }
                videoTableAdapter.Update(videos);
                var newVideos = form.Video.Except(videos);
                foreach (var v in newVideos)
                {
                    v.KnowledgeID = editKnowledge.KnowledgeID;
                    knowledgeDataSet.Video.AddVideoRow(v);
                }
                pictureTableAdapter.Update(knowledgeDataSet);

                var delLinks = links.Except(form.Link);
                foreach (var l in delLinks)
                {
                    l.Delete();
                }
                linkTableAdapter.Update(links);
                var newLinks = form.Link.Except(links);
                foreach (var l in newLinks)
                {
                    l.KnowledgeID = editKnowledge.KnowledgeID;
                    knowledgeDataSet.Link.AddLinkRow(l);
                }
                pictureTableAdapter.Update(knowledgeDataSet);
            }
        }

        private void DeleteKnowledge_Click(object sender, EventArgs e)
        {
            var selectedRowView = (DataRowView)knowledgeBindingSource.Current;
            if (selectedRowView == null)
            {
                MessageBox.Show("Необходимо выбрать категорию для удаления знания.", "Удалить знание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var res = MessageBox.Show($"Вы действительно хотите удалить выбранное знание?", "Удалить знание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes)
            {
                return;
            }

            var deleteKnowledge = (KnowledgeDataSet.KnowledgeRow)selectedRowView.Row;
            knowledgeDataSet.Knowledge.RemoveKnowledgeRow(deleteKnowledge);
            knowledgeTableAdapter.Update(deleteKnowledge);
        }
    }
}
