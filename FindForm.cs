using KnowledgeManagement.KnowledgeDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KnowledgeManagement
{
    public partial class FindForm : Form
    {
        private QueriesTableAdapter procAdapter;

        private readonly string pictureStorage;

        private readonly string videoStorage;

        private class ListItemID : IComparable<ListItemID>
        {
            public string Text;
            public int ID;

            public int CompareTo(ListItemID other)
            {
                return ID - other.ID;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        public FindForm(string pictureStorage, string videoStorage, bool v)
        {
            InitializeComponent();

            tagTableAdapter.Fill(knowledgeDataSetSearch.Tag);
            foreach (var tag in knowledgeDataSetSearch.Tag)
            {
                var tagItem = new ListItemID
                {
                    Text = tag.ToString(),
                    ID = tag.TagID,
                };
                TagListSearch.Items.Add(tagItem);
            }

        }

        private IEnumerable<TreeNode> GetCheckedCategories(IEnumerable<TreeNode> root)
        {

            foreach (var node in root)
            {

                if (node.Checked)
                {
                    yield return node;
                }

                foreach (var r in GetCheckedCategories(node.Nodes.OfType<TreeNode>()))
                {
                    yield return r;
                }
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SearchResultView.Items.Clear();

            var tags = TagListSearch.CheckedItems.Cast<ListItemID>().Select(i => i.ID);
            var categories = GetCheckedCategories(treeViewCategoriesSearch.Nodes.OfType<TreeNode>()).Select(i => i.Tag);
            var knowledges = new SortedSet<ListItemID>();
            foreach (var t in tags)
            {
                var tagKnowledges = knowledgeTableAdapterSearch.GetSearch(t)
                    .ToList()
                    .Where((k) =>
                    {
                        var res = categories.Contains(k.CategoryID);
                        return res;
                    })
                    .Select(k => new ListItemID() 
                    {
                        ID = k.KnowledgeID,
                        Text = k.Title
                    });
                knowledges.UnionWith(tagKnowledges);
            }
            foreach(var k in knowledges)
            {
                SearchResultView.Items.Add(k);
            }
        }

        private void FindForm_Load(object sender, EventArgs e)
        {
            knowledgeTagLinkTableAdapterSearch.Fill(knowledgeDataSetSearch.KnowledgeTagLink);
            procAdapter = new QueriesTableAdapter();
            LoadCategories();
        }

        private void LoadCategories()
        {
            treeViewCategoriesSearch.Nodes.Clear();

            // Построим дерево. Начнём с корневых узлов (Parent IS NULL).
            // В нашей таблице Parent может быть NULL (или 0, если так задумано).
            // Предположим, что корневые элементы – те, у кого Parent IS NULL.
            var rootRows = categoryTableAdapterSearch.GetRootCategories();
            //DataRow[] rootRows = knowledgeDataSet.Category.Select("Parent IS NULL");

            foreach (var root in rootRows)
            {
                TreeNode rootNode = new TreeNode(root.Name);
                rootNode.Tag = root.CategoryID;
                treeViewCategoriesSearch.Nodes.Add(rootNode);

                // Рекурсивно добавим дочерние узлы
                BuildTree(rootNode);
            }

            treeViewCategoriesSearch.ExpandAll();
        }

        /// <summary>
        /// Рекурсивное построение дерева.
        /// </summary>
        /// <param name="parentNode">Родительский узел в TreeView.</param>
        private void BuildTree(TreeNode parentNode)
        {
            // Ищем строки, у которых Parent = parentNode.Tag (текущий CategoryID).
            int parentId = Convert.ToInt32(parentNode.Tag);
            var childRows = categoryTableAdapterSearch.GetChildrenCategories(parentId);

            foreach (var childRow in childRows)
            {
                TreeNode childNode = new TreeNode(childRow.Name);
                childNode.Tag = childRow.CategoryID;
                parentNode.Nodes.Add(childNode);

                // Рекурсия: у этого узла тоже могут быть дети
                BuildTree(childNode);
            }
        }

        private void SearchResultView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchResultView_DoubleClick(object sender, EventArgs e)
        {
            if (SearchResultView.SelectedItem == null)
            {
                MessageBox.Show("Для просмотра знания его необходимо выбрать.", "Ошибка просмотра знания", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var knowledgeID = ((ListItemID)SearchResultView.SelectedItem).ID;
            
            var form = new KnowledgeView(knowledgeID);
            form.ShowDialog();
        }
    }
}
