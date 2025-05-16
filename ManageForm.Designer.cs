namespace KnowledgeManagement
{
    partial class ManageForm
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
            this.treeViewCategories = new System.Windows.Forms.TreeView();
            this.AddCategory = new System.Windows.Forms.Button();
            this.DelCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryKnowledgeLabel = new System.Windows.Forms.Label();
            this.KnowledgeList = new System.Windows.Forms.DataGridView();
            this.knowledgeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knowledgeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knowledgeDataSet = new KnowledgeManagement.KnowledgeDataSet();
            this.AddKnowledge = new System.Windows.Forms.Button();
            this.DeleteKnowledge = new System.Windows.Forms.Button();
            this.EditKnowledge = new System.Windows.Forms.Button();
            this.CategorySource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new KnowledgeManagement.KnowledgeDataSetTableAdapters.CategoryTableAdapter();
            this.knowledgeTableAdapter = new KnowledgeManagement.KnowledgeDataSetTableAdapters.KnowledgeTableAdapter();
            this.knowledgeTagLinkTableAdapter = new KnowledgeManagement.KnowledgeDataSetTableAdapters.KnowledgeTagLinkTableAdapter();
            this.articleTableAdapter = new KnowledgeManagement.KnowledgeDataSetTableAdapters.ArticleTableAdapter();
            this.pictureTableAdapter = new KnowledgeManagement.KnowledgeDataSetTableAdapters.PictureTableAdapter();
            this.videoTableAdapter = new KnowledgeManagement.KnowledgeDataSetTableAdapters.VideoTableAdapter();
            this.linkTableAdapter = new KnowledgeManagement.KnowledgeDataSetTableAdapters.LinkTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KnowledgeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowledgeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowledgeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategorySource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewCategories
            // 
            this.treeViewCategories.FullRowSelect = true;
            this.treeViewCategories.HideSelection = false;
            this.treeViewCategories.Location = new System.Drawing.Point(12, 25);
            this.treeViewCategories.Name = "treeViewCategories";
            this.treeViewCategories.ShowRootLines = false;
            this.treeViewCategories.Size = new System.Drawing.Size(217, 396);
            this.treeViewCategories.TabIndex = 0;
            this.treeViewCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCategories_AfterSelect);
            // 
            // AddCategory
            // 
            this.AddCategory.Location = new System.Drawing.Point(12, 427);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(75, 41);
            this.AddCategory.TabIndex = 1;
            this.AddCategory.Text = "Добавить категорию";
            this.AddCategory.UseVisualStyleBackColor = true;
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // DelCategory
            // 
            this.DelCategory.Location = new System.Drawing.Point(154, 427);
            this.DelCategory.Name = "DelCategory";
            this.DelCategory.Size = new System.Drawing.Size(75, 41);
            this.DelCategory.TabIndex = 2;
            this.DelCategory.Text = "Удалить категорию";
            this.DelCategory.UseVisualStyleBackColor = true;
            this.DelCategory.Click += new System.EventHandler(this.DelCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Категории знаний";
            // 
            // CategoryKnowledgeLabel
            // 
            this.CategoryKnowledgeLabel.AutoSize = true;
            this.CategoryKnowledgeLabel.Location = new System.Drawing.Point(252, 9);
            this.CategoryKnowledgeLabel.Name = "CategoryKnowledgeLabel";
            this.CategoryKnowledgeLabel.Size = new System.Drawing.Size(128, 13);
            this.CategoryKnowledgeLabel.TabIndex = 4;
            this.CategoryKnowledgeLabel.Text = "CategoryKnowledgeLabel";
            // 
            // KnowledgeList
            // 
            this.KnowledgeList.AllowUserToAddRows = false;
            this.KnowledgeList.AllowUserToDeleteRows = false;
            this.KnowledgeList.AllowUserToOrderColumns = true;
            this.KnowledgeList.AutoGenerateColumns = false;
            this.KnowledgeList.CausesValidation = false;
            this.KnowledgeList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.KnowledgeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.knowledgeIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn});
            this.KnowledgeList.DataSource = this.knowledgeBindingSource;
            this.KnowledgeList.Location = new System.Drawing.Point(255, 25);
            this.KnowledgeList.Name = "KnowledgeList";
            this.KnowledgeList.ReadOnly = true;
            this.KnowledgeList.RowHeadersVisible = false;
            this.KnowledgeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.KnowledgeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.KnowledgeList.ShowCellErrors = false;
            this.KnowledgeList.ShowCellToolTips = false;
            this.KnowledgeList.ShowEditingIcon = false;
            this.KnowledgeList.ShowRowErrors = false;
            this.KnowledgeList.Size = new System.Drawing.Size(304, 396);
            this.KnowledgeList.TabIndex = 5;
            // 
            // knowledgeIDDataGridViewTextBoxColumn
            // 
            this.knowledgeIDDataGridViewTextBoxColumn.DataPropertyName = "KnowledgeID";
            this.knowledgeIDDataGridViewTextBoxColumn.HeaderText = "KnowledgeID";
            this.knowledgeIDDataGridViewTextBoxColumn.Name = "knowledgeIDDataGridViewTextBoxColumn";
            this.knowledgeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.knowledgeIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 265;
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // knowledgeBindingSource
            // 
            this.knowledgeBindingSource.DataMember = "Knowledge";
            this.knowledgeBindingSource.DataSource = this.knowledgeDataSet;
            // 
            // knowledgeDataSet
            // 
            this.knowledgeDataSet.DataSetName = "KnowledgeDataSet";
            this.knowledgeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddKnowledge
            // 
            this.AddKnowledge.Location = new System.Drawing.Point(255, 427);
            this.AddKnowledge.Name = "AddKnowledge";
            this.AddKnowledge.Size = new System.Drawing.Size(75, 41);
            this.AddKnowledge.TabIndex = 6;
            this.AddKnowledge.Text = "Добавить знание";
            this.AddKnowledge.UseVisualStyleBackColor = true;
            this.AddKnowledge.Click += new System.EventHandler(this.AddKnowledge_Click);
            // 
            // DeleteKnowledge
            // 
            this.DeleteKnowledge.Location = new System.Drawing.Point(484, 427);
            this.DeleteKnowledge.Name = "DeleteKnowledge";
            this.DeleteKnowledge.Size = new System.Drawing.Size(75, 41);
            this.DeleteKnowledge.TabIndex = 7;
            this.DeleteKnowledge.Text = "Удалить знание";
            this.DeleteKnowledge.UseVisualStyleBackColor = true;
            this.DeleteKnowledge.Click += new System.EventHandler(this.DeleteKnowledge_Click);
            // 
            // EditKnowledge
            // 
            this.EditKnowledge.Location = new System.Drawing.Point(370, 427);
            this.EditKnowledge.Name = "EditKnowledge";
            this.EditKnowledge.Size = new System.Drawing.Size(75, 41);
            this.EditKnowledge.TabIndex = 8;
            this.EditKnowledge.Text = "Изменить знание";
            this.EditKnowledge.UseVisualStyleBackColor = true;
            this.EditKnowledge.Click += new System.EventHandler(this.EditKnowledge_Click);
            // 
            // CategorySource
            // 
            this.CategorySource.DataMember = "Category";
            this.CategorySource.DataSource = this.knowledgeDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // knowledgeTableAdapter
            // 
            this.knowledgeTableAdapter.ClearBeforeFill = true;
            // 
            // knowledgeTagLinkTableAdapter
            // 
            this.knowledgeTagLinkTableAdapter.ClearBeforeFill = true;
            // 
            // articleTableAdapter
            // 
            this.articleTableAdapter.ClearBeforeFill = true;
            // 
            // pictureTableAdapter
            // 
            this.pictureTableAdapter.ClearBeforeFill = true;
            // 
            // videoTableAdapter
            // 
            this.videoTableAdapter.ClearBeforeFill = true;
            // 
            // linkTableAdapter
            // 
            this.linkTableAdapter.ClearBeforeFill = true;
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 547);
            this.Controls.Add(this.EditKnowledge);
            this.Controls.Add(this.DeleteKnowledge);
            this.Controls.Add(this.AddKnowledge);
            this.Controls.Add(this.KnowledgeList);
            this.Controls.Add(this.CategoryKnowledgeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DelCategory);
            this.Controls.Add(this.AddCategory);
            this.Controls.Add(this.treeViewCategories);
            this.Name = "ManageForm";
            this.Text = "Управление знаниями";
            this.Load += new System.EventHandler(this.ManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KnowledgeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowledgeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowledgeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategorySource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewCategories;
        private System.Windows.Forms.BindingSource CategorySource;
        private KnowledgeDataSet knowledgeDataSet;
        private KnowledgeDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Button AddCategory;
        private System.Windows.Forms.Button DelCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CategoryKnowledgeLabel;
        private System.Windows.Forms.DataGridView KnowledgeList;
        private System.Windows.Forms.BindingSource knowledgeBindingSource;
        private KnowledgeDataSetTableAdapters.KnowledgeTableAdapter knowledgeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn knowledgeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button AddKnowledge;
        private System.Windows.Forms.Button DeleteKnowledge;
        private System.Windows.Forms.Button EditKnowledge;
        private KnowledgeDataSetTableAdapters.KnowledgeTagLinkTableAdapter knowledgeTagLinkTableAdapter;
        private KnowledgeDataSetTableAdapters.ArticleTableAdapter articleTableAdapter;
        private KnowledgeDataSetTableAdapters.PictureTableAdapter pictureTableAdapter;
        private KnowledgeDataSetTableAdapters.VideoTableAdapter videoTableAdapter;
        private KnowledgeDataSetTableAdapters.LinkTableAdapter linkTableAdapter;
    }
}