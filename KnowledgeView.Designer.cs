namespace KnowledgeManagement
{
    partial class KnowledgeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnowledgeView));
            this.ArticleGrid = new System.Windows.Forms.DataGridView();
            this.articleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knowledgeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.knowledgeDataSet = new KnowledgeManagement.KnowledgeDataSet();
            this.articleTableAdapter = new KnowledgeManagement.KnowledgeDataSetTableAdapters.ArticleTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.VideoGrid = new System.Windows.Forms.DataGridView();
            this.videoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filePathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knowledgeIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videoTableAdapter = new KnowledgeManagement.KnowledgeDataSetTableAdapters.VideoTableAdapter();
            this.ArticleView = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.VideoView = new AxWMPLib.AxWindowsMediaPlayer();
            this.PictureGrid = new System.Windows.Forms.DataGridView();
            this.pictureIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filePathDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knowledgeIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureTableAdapter = new KnowledgeManagement.KnowledgeDataSetTableAdapters.PictureTableAdapter();
            this.PictureView = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LinkGrid = new System.Windows.Forms.DataGridView();
            this.linkIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knowledgeIDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linkTableAdapter = new KnowledgeManagement.KnowledgeDataSetTableAdapters.LinkTableAdapter();
            this.LinkView = new System.Windows.Forms.WebBrowser();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ArticleGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowledgeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinkGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ArticleGrid
            // 
            this.ArticleGrid.AllowUserToAddRows = false;
            this.ArticleGrid.AllowUserToDeleteRows = false;
            this.ArticleGrid.AllowUserToResizeRows = false;
            this.ArticleGrid.AutoGenerateColumns = false;
            this.ArticleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ArticleGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articleIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.knowledgeIDDataGridViewTextBoxColumn});
            this.ArticleGrid.DataSource = this.articleBindingSource;
            this.ArticleGrid.Location = new System.Drawing.Point(20, 31);
            this.ArticleGrid.Margin = new System.Windows.Forms.Padding(4);
            this.ArticleGrid.MultiSelect = false;
            this.ArticleGrid.Name = "ArticleGrid";
            this.ArticleGrid.ReadOnly = true;
            this.ArticleGrid.RowHeadersVisible = false;
            this.ArticleGrid.RowHeadersWidth = 51;
            this.ArticleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ArticleGrid.Size = new System.Drawing.Size(320, 185);
            this.ArticleGrid.TabIndex = 0;
            this.ArticleGrid.SelectionChanged += new System.EventHandler(this.ArticleGrid_SelectionChanged);
            // 
            // articleIDDataGridViewTextBoxColumn
            // 
            this.articleIDDataGridViewTextBoxColumn.DataPropertyName = "ArticleID";
            this.articleIDDataGridViewTextBoxColumn.HeaderText = "ArticleID";
            this.articleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.articleIDDataGridViewTextBoxColumn.Name = "articleIDDataGridViewTextBoxColumn";
            this.articleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.articleIDDataGridViewTextBoxColumn.Visible = false;
            this.articleIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn.Width = 125;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            this.textDataGridViewTextBoxColumn.Visible = false;
            this.textDataGridViewTextBoxColumn.Width = 125;
            // 
            // knowledgeIDDataGridViewTextBoxColumn
            // 
            this.knowledgeIDDataGridViewTextBoxColumn.DataPropertyName = "KnowledgeID";
            this.knowledgeIDDataGridViewTextBoxColumn.HeaderText = "KnowledgeID";
            this.knowledgeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.knowledgeIDDataGridViewTextBoxColumn.Name = "knowledgeIDDataGridViewTextBoxColumn";
            this.knowledgeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.knowledgeIDDataGridViewTextBoxColumn.Visible = false;
            this.knowledgeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // articleBindingSource
            // 
            this.articleBindingSource.DataMember = "Article";
            this.articleBindingSource.DataSource = this.knowledgeDataSet;
            // 
            // knowledgeDataSet
            // 
            this.knowledgeDataSet.DataSetName = "KnowledgeDataSet";
            this.knowledgeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articleTableAdapter
            // 
            this.articleTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Статьи:";
            // 
            // VideoGrid
            // 
            this.VideoGrid.AllowUserToAddRows = false;
            this.VideoGrid.AllowUserToDeleteRows = false;
            this.VideoGrid.AllowUserToResizeRows = false;
            this.VideoGrid.AutoGenerateColumns = false;
            this.VideoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VideoGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.videoIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn1,
            this.filePathDataGridViewTextBoxColumn,
            this.knowledgeIDDataGridViewTextBoxColumn1});
            this.VideoGrid.DataSource = this.videoBindingSource;
            this.VideoGrid.Location = new System.Drawing.Point(348, 31);
            this.VideoGrid.Margin = new System.Windows.Forms.Padding(4);
            this.VideoGrid.MultiSelect = false;
            this.VideoGrid.Name = "VideoGrid";
            this.VideoGrid.ReadOnly = true;
            this.VideoGrid.RowHeadersVisible = false;
            this.VideoGrid.RowHeadersWidth = 51;
            this.VideoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.VideoGrid.Size = new System.Drawing.Size(320, 185);
            this.VideoGrid.TabIndex = 2;
            this.VideoGrid.SelectionChanged += new System.EventHandler(this.VideoGrid_SelectionChanged);
            // 
            // videoIDDataGridViewTextBoxColumn
            // 
            this.videoIDDataGridViewTextBoxColumn.DataPropertyName = "VideoID";
            this.videoIDDataGridViewTextBoxColumn.HeaderText = "VideoID";
            this.videoIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.videoIDDataGridViewTextBoxColumn.Name = "videoIDDataGridViewTextBoxColumn";
            this.videoIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.videoIDDataGridViewTextBoxColumn.Visible = false;
            this.videoIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn1.Width = 125;
            // 
            // filePathDataGridViewTextBoxColumn
            // 
            this.filePathDataGridViewTextBoxColumn.DataPropertyName = "FilePath";
            this.filePathDataGridViewTextBoxColumn.HeaderText = "FilePath";
            this.filePathDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.filePathDataGridViewTextBoxColumn.Name = "filePathDataGridViewTextBoxColumn";
            this.filePathDataGridViewTextBoxColumn.ReadOnly = true;
            this.filePathDataGridViewTextBoxColumn.Visible = false;
            this.filePathDataGridViewTextBoxColumn.Width = 125;
            // 
            // knowledgeIDDataGridViewTextBoxColumn1
            // 
            this.knowledgeIDDataGridViewTextBoxColumn1.DataPropertyName = "KnowledgeID";
            this.knowledgeIDDataGridViewTextBoxColumn1.HeaderText = "KnowledgeID";
            this.knowledgeIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.knowledgeIDDataGridViewTextBoxColumn1.Name = "knowledgeIDDataGridViewTextBoxColumn1";
            this.knowledgeIDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.knowledgeIDDataGridViewTextBoxColumn1.Visible = false;
            this.knowledgeIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // videoBindingSource
            // 
            this.videoBindingSource.DataMember = "Video";
            this.videoBindingSource.DataSource = this.knowledgeDataSet;
            // 
            // videoTableAdapter
            // 
            this.videoTableAdapter.ClearBeforeFill = true;
            // 
            // ArticleView
            // 
            this.ArticleView.Location = new System.Drawing.Point(20, 235);
            this.ArticleView.Margin = new System.Windows.Forms.Padding(4);
            this.ArticleView.Name = "ArticleView";
            this.ArticleView.Size = new System.Drawing.Size(319, 303);
            this.ArticleView.TabIndex = 3;
            this.ArticleView.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(348, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Видео:";
            // 
            // VideoView
            // 
            this.VideoView.Enabled = true;
            this.VideoView.Location = new System.Drawing.Point(347, 235);
            this.VideoView.Margin = new System.Windows.Forms.Padding(4);
            this.VideoView.Name = "VideoView";
            this.VideoView.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("VideoView.OcxState")));
            this.VideoView.Size = new System.Drawing.Size(321, 303);
            this.VideoView.TabIndex = 5;
            this.VideoView.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.VideoView_PlayStateChangeAsync);
            // 
            // PictureGrid
            // 
            this.PictureGrid.AllowUserToAddRows = false;
            this.PictureGrid.AllowUserToDeleteRows = false;
            this.PictureGrid.AllowUserToResizeRows = false;
            this.PictureGrid.AutoGenerateColumns = false;
            this.PictureGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PictureGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pictureIDDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn2,
            this.filePathDataGridViewTextBoxColumn1,
            this.knowledgeIDDataGridViewTextBoxColumn2});
            this.PictureGrid.DataSource = this.pictureBindingSource;
            this.PictureGrid.Location = new System.Drawing.Point(677, 31);
            this.PictureGrid.Margin = new System.Windows.Forms.Padding(4);
            this.PictureGrid.MultiSelect = false;
            this.PictureGrid.Name = "PictureGrid";
            this.PictureGrid.ReadOnly = true;
            this.PictureGrid.RowHeadersVisible = false;
            this.PictureGrid.RowHeadersWidth = 51;
            this.PictureGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PictureGrid.Size = new System.Drawing.Size(320, 185);
            this.PictureGrid.TabIndex = 6;
            this.PictureGrid.SelectionChanged += new System.EventHandler(this.PictureGrid_SelectionChanged);
            // 
            // pictureIDDataGridViewTextBoxColumn
            // 
            this.pictureIDDataGridViewTextBoxColumn.DataPropertyName = "PictureID";
            this.pictureIDDataGridViewTextBoxColumn.HeaderText = "PictureID";
            this.pictureIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pictureIDDataGridViewTextBoxColumn.Name = "pictureIDDataGridViewTextBoxColumn";
            this.pictureIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pictureIDDataGridViewTextBoxColumn.Visible = false;
            this.pictureIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn2
            // 
            this.titleDataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn2.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn2.Name = "titleDataGridViewTextBoxColumn2";
            this.titleDataGridViewTextBoxColumn2.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn2.Width = 125;
            // 
            // filePathDataGridViewTextBoxColumn1
            // 
            this.filePathDataGridViewTextBoxColumn1.DataPropertyName = "FilePath";
            this.filePathDataGridViewTextBoxColumn1.HeaderText = "FilePath";
            this.filePathDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.filePathDataGridViewTextBoxColumn1.Name = "filePathDataGridViewTextBoxColumn1";
            this.filePathDataGridViewTextBoxColumn1.ReadOnly = true;
            this.filePathDataGridViewTextBoxColumn1.Visible = false;
            this.filePathDataGridViewTextBoxColumn1.Width = 125;
            // 
            // knowledgeIDDataGridViewTextBoxColumn2
            // 
            this.knowledgeIDDataGridViewTextBoxColumn2.DataPropertyName = "KnowledgeID";
            this.knowledgeIDDataGridViewTextBoxColumn2.HeaderText = "KnowledgeID";
            this.knowledgeIDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.knowledgeIDDataGridViewTextBoxColumn2.Name = "knowledgeIDDataGridViewTextBoxColumn2";
            this.knowledgeIDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.knowledgeIDDataGridViewTextBoxColumn2.Visible = false;
            this.knowledgeIDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // pictureBindingSource
            // 
            this.pictureBindingSource.DataMember = "Picture";
            this.pictureBindingSource.DataSource = this.knowledgeDataSet;
            // 
            // pictureTableAdapter
            // 
            this.pictureTableAdapter.ClearBeforeFill = true;
            // 
            // PictureView
            // 
            this.PictureView.Location = new System.Drawing.Point(677, 235);
            this.PictureView.Margin = new System.Windows.Forms.Padding(4);
            this.PictureView.Name = "PictureView";
            this.PictureView.Size = new System.Drawing.Size(320, 304);
            this.PictureView.TabIndex = 7;
            this.PictureView.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(677, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Картинки:";
            // 
            // LinkGrid
            // 
            this.LinkGrid.AllowUserToAddRows = false;
            this.LinkGrid.AllowUserToDeleteRows = false;
            this.LinkGrid.AllowUserToResizeRows = false;
            this.LinkGrid.AutoGenerateColumns = false;
            this.LinkGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LinkGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linkIDDataGridViewTextBoxColumn,
            this.linkAddressDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn3,
            this.knowledgeIDDataGridViewTextBoxColumn3});
            this.LinkGrid.DataSource = this.linkBindingSource;
            this.LinkGrid.Location = new System.Drawing.Point(1007, 31);
            this.LinkGrid.Margin = new System.Windows.Forms.Padding(4);
            this.LinkGrid.MultiSelect = false;
            this.LinkGrid.Name = "LinkGrid";
            this.LinkGrid.ReadOnly = true;
            this.LinkGrid.RowHeadersVisible = false;
            this.LinkGrid.RowHeadersWidth = 51;
            this.LinkGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LinkGrid.Size = new System.Drawing.Size(320, 185);
            this.LinkGrid.TabIndex = 9;
            this.LinkGrid.SelectionChanged += new System.EventHandler(this.LinkGrid_SelectionChanged);
            // 
            // linkIDDataGridViewTextBoxColumn
            // 
            this.linkIDDataGridViewTextBoxColumn.DataPropertyName = "LinkID";
            this.linkIDDataGridViewTextBoxColumn.HeaderText = "LinkID";
            this.linkIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.linkIDDataGridViewTextBoxColumn.Name = "linkIDDataGridViewTextBoxColumn";
            this.linkIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.linkIDDataGridViewTextBoxColumn.Visible = false;
            this.linkIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // linkAddressDataGridViewTextBoxColumn
            // 
            this.linkAddressDataGridViewTextBoxColumn.DataPropertyName = "LinkAddress";
            this.linkAddressDataGridViewTextBoxColumn.HeaderText = "LinkAddress";
            this.linkAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.linkAddressDataGridViewTextBoxColumn.Name = "linkAddressDataGridViewTextBoxColumn";
            this.linkAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.linkAddressDataGridViewTextBoxColumn.Visible = false;
            this.linkAddressDataGridViewTextBoxColumn.Width = 125;
            // 
            // titleDataGridViewTextBoxColumn3
            // 
            this.titleDataGridViewTextBoxColumn3.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn3.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.titleDataGridViewTextBoxColumn3.Name = "titleDataGridViewTextBoxColumn3";
            this.titleDataGridViewTextBoxColumn3.ReadOnly = true;
            this.titleDataGridViewTextBoxColumn3.Width = 125;
            // 
            // knowledgeIDDataGridViewTextBoxColumn3
            // 
            this.knowledgeIDDataGridViewTextBoxColumn3.DataPropertyName = "KnowledgeID";
            this.knowledgeIDDataGridViewTextBoxColumn3.HeaderText = "KnowledgeID";
            this.knowledgeIDDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.knowledgeIDDataGridViewTextBoxColumn3.Name = "knowledgeIDDataGridViewTextBoxColumn3";
            this.knowledgeIDDataGridViewTextBoxColumn3.ReadOnly = true;
            this.knowledgeIDDataGridViewTextBoxColumn3.Visible = false;
            this.knowledgeIDDataGridViewTextBoxColumn3.Width = 125;
            // 
            // linkBindingSource
            // 
            this.linkBindingSource.DataMember = "Link";
            this.linkBindingSource.DataSource = this.knowledgeDataSet;
            // 
            // linkTableAdapter
            // 
            this.linkTableAdapter.ClearBeforeFill = true;
            // 
            // LinkView
            // 
            this.LinkView.Location = new System.Drawing.Point(1007, 235);
            this.LinkView.Margin = new System.Windows.Forms.Padding(4);
            this.LinkView.MinimumSize = new System.Drawing.Size(27, 25);
            this.LinkView.Name = "LinkView";
            this.LinkView.Size = new System.Drawing.Size(320, 304);
            this.LinkView.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1007, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ссылки:";
            // 
            // KnowledgeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LinkView);
            this.Controls.Add(this.LinkGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PictureView);
            this.Controls.Add(this.PictureGrid);
            this.Controls.Add(this.VideoView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ArticleView);
            this.Controls.Add(this.VideoGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArticleGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KnowledgeView";
            this.Text = "KnowledgeView";
            this.Load += new System.EventHandler(this.KnowledgeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArticleGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowledgeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VideoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinkGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ArticleGrid;
        private KnowledgeDataSet knowledgeDataSet;
        private System.Windows.Forms.BindingSource articleBindingSource;
        private KnowledgeDataSetTableAdapters.ArticleTableAdapter articleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn knowledgeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView VideoGrid;
        private System.Windows.Forms.BindingSource videoBindingSource;
        private KnowledgeDataSetTableAdapters.VideoTableAdapter videoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn videoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn knowledgeIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.RichTextBox ArticleView;
        private System.Windows.Forms.Label label2;
        private AxWMPLib.AxWindowsMediaPlayer VideoView;
        private System.Windows.Forms.DataGridView PictureGrid;
        private System.Windows.Forms.BindingSource pictureBindingSource;
        private KnowledgeDataSetTableAdapters.PictureTableAdapter pictureTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pictureIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePathDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn knowledgeIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.PictureBox PictureView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView LinkGrid;
        private System.Windows.Forms.BindingSource linkBindingSource;
        private KnowledgeDataSetTableAdapters.LinkTableAdapter linkTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn knowledgeIDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.WebBrowser LinkView;
        private System.Windows.Forms.Label label4;
    }
}