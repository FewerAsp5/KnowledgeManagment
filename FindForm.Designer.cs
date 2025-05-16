namespace KnowledgeManagement
{
    partial class FindForm
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
            this.components = new System.ComponentModel.Container();
            this.treeViewCategoriesSearch = new System.Windows.Forms.TreeView();
            this.Search = new System.Windows.Forms.Button();
            this.knowledgeTagLinkTableAdapterSearch = new KnowledgeManagement.KnowledgeDataSetTableAdapters.KnowledgeTagLinkTableAdapter();
            this.knowledgeDataSetSearch = new KnowledgeManagement.KnowledgeDataSet();
            this.categoryTableAdapterSearch = new KnowledgeManagement.KnowledgeDataSetTableAdapters.CategoryTableAdapter();
            this.knowledgeTableAdapterSearch = new KnowledgeManagement.KnowledgeDataSetTableAdapters.KnowledgeTableAdapter();
            this.knowledgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TagListSearch = new System.Windows.Forms.CheckedListBox();
            this.tagTableAdapter = new KnowledgeManagement.KnowledgeDataSetTableAdapters.TagTableAdapter();
            this.SearchResultView = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.knowledgeDataSetSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowledgeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewCategoriesSearch
            // 
            this.treeViewCategoriesSearch.CheckBoxes = true;
            this.treeViewCategoriesSearch.FullRowSelect = true;
            this.treeViewCategoriesSearch.HideSelection = false;
            this.treeViewCategoriesSearch.Location = new System.Drawing.Point(15, 33);
            this.treeViewCategoriesSearch.Margin = new System.Windows.Forms.Padding(4);
            this.treeViewCategoriesSearch.Name = "treeViewCategoriesSearch";
            this.treeViewCategoriesSearch.ShowRootLines = false;
            this.treeViewCategoriesSearch.Size = new System.Drawing.Size(230, 210);
            this.treeViewCategoriesSearch.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(13, 251);
            this.Search.Margin = new System.Windows.Forms.Padding(4);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(470, 35);
            this.Search.TabIndex = 7;
            this.Search.Text = "Найти знания";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // knowledgeTagLinkTableAdapterSearch
            // 
            this.knowledgeTagLinkTableAdapterSearch.ClearBeforeFill = true;
            // 
            // knowledgeDataSetSearch
            // 
            this.knowledgeDataSetSearch.DataSetName = "KnowledgeDataSet";
            this.knowledgeDataSetSearch.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapterSearch
            // 
            this.categoryTableAdapterSearch.ClearBeforeFill = true;
            // 
            // knowledgeTableAdapterSearch
            // 
            this.knowledgeTableAdapterSearch.ClearBeforeFill = true;
            // 
            // knowledgeBindingSource
            // 
            this.knowledgeBindingSource.DataMember = "Knowledge";
            this.knowledgeBindingSource.DataSource = this.knowledgeDataSetSearch;
            // 
            // TagListSearch
            // 
            this.TagListSearch.CheckOnClick = true;
            this.TagListSearch.FormattingEnabled = true;
            this.TagListSearch.Location = new System.Drawing.Point(253, 33);
            this.TagListSearch.Margin = new System.Windows.Forms.Padding(4);
            this.TagListSearch.MultiColumn = true;
            this.TagListSearch.Name = "TagListSearch";
            this.TagListSearch.Size = new System.Drawing.Size(230, 208);
            this.TagListSearch.Sorted = true;
            this.TagListSearch.TabIndex = 10;
            // 
            // tagTableAdapter
            // 
            this.tagTableAdapter.ClearBeforeFill = true;
            // 
            // SearchResultView
            // 
            this.SearchResultView.FormattingEnabled = true;
            this.SearchResultView.ItemHeight = 16;
            this.SearchResultView.Location = new System.Drawing.Point(16, 319);
            this.SearchResultView.Margin = new System.Windows.Forms.Padding(4);
            this.SearchResultView.Name = "SearchResultView";
            this.SearchResultView.Size = new System.Drawing.Size(467, 148);
            this.SearchResultView.TabIndex = 11;
            this.SearchResultView.DoubleClick += new System.EventHandler(this.SearchResultView_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Категории для поиска:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Теги для поиска:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Найденные знания:";
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 483);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchResultView);
            this.Controls.Add(this.TagListSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.treeViewCategoriesSearch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FindForm";
            this.Text = "FindForm";
            this.Load += new System.EventHandler(this.FindForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.knowledgeDataSetSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowledgeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewCategoriesSearch;
        private System.Windows.Forms.Button Search;
        private KnowledgeDataSetTableAdapters.KnowledgeTagLinkTableAdapter knowledgeTagLinkTableAdapterSearch;
        private KnowledgeDataSet knowledgeDataSetSearch;
        private KnowledgeDataSetTableAdapters.CategoryTableAdapter categoryTableAdapterSearch;
        private KnowledgeDataSetTableAdapters.KnowledgeTableAdapter knowledgeTableAdapterSearch;
        private System.Windows.Forms.CheckedListBox TagListSearch;
        private KnowledgeDataSetTableAdapters.TagTableAdapter tagTableAdapter;
        private System.Windows.Forms.BindingSource knowledgeBindingSource;
        private System.Windows.Forms.ListBox SearchResultView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}