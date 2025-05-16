namespace KnowledgeManagement
{
    partial class KnowledgeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.KnowledgeNameText = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.CategoryKnowledgeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ArticleList = new System.Windows.Forms.ListBox();
            this.PictureList = new System.Windows.Forms.ListBox();
            this.LinkList = new System.Windows.Forms.ListBox();
            this.VideoList = new System.Windows.Forms.ListBox();
            this.TagList = new System.Windows.Forms.CheckedListBox();
            this.tagTableAdapter = new KnowledgeManagement.KnowledgeDataSetTableAdapters.TagTableAdapter();
            this.AddTag = new System.Windows.Forms.Button();
            this.EditTag = new System.Windows.Forms.Button();
            this.DeleteTag = new System.Windows.Forms.Button();
            this.AddArticle = new System.Windows.Forms.Button();
            this.EditArticle = new System.Windows.Forms.Button();
            this.DeleteArticle = new System.Windows.Forms.Button();
            this.DeletePicture = new System.Windows.Forms.Button();
            this.EditPicture = new System.Windows.Forms.Button();
            this.AddPicture = new System.Windows.Forms.Button();
            this.DeleteVideo = new System.Windows.Forms.Button();
            this.EditVideo = new System.Windows.Forms.Button();
            this.AddVideo = new System.Windows.Forms.Button();
            this.DeleteLink = new System.Windows.Forms.Button();
            this.EditLink = new System.Windows.Forms.Button();
            this.AddLink = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование знания:";
            // 
            // KnowledgeNameText
            // 
            this.KnowledgeNameText.Location = new System.Drawing.Point(12, 25);
            this.KnowledgeNameText.Name = "KnowledgeNameText";
            this.KnowledgeNameText.Size = new System.Drawing.Size(451, 20);
            this.KnowledgeNameText.TabIndex = 1;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(12, 485);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(517, 485);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // CategoryKnowledgeLabel
            // 
            this.CategoryKnowledgeLabel.AutoSize = true;
            this.CategoryKnowledgeLabel.Location = new System.Drawing.Point(9, 48);
            this.CategoryKnowledgeLabel.Name = "CategoryKnowledgeLabel";
            this.CategoryKnowledgeLabel.Size = new System.Drawing.Size(45, 13);
            this.CategoryKnowledgeLabel.TabIndex = 6;
            this.CategoryKnowledgeLabel.Text = "Статьи:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Видео:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ссылки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Картинки";
            // 
            // ArticleList
            // 
            this.ArticleList.FormattingEnabled = true;
            this.ArticleList.Location = new System.Drawing.Point(12, 64);
            this.ArticleList.Name = "ArticleList";
            this.ArticleList.Size = new System.Drawing.Size(221, 95);
            this.ArticleList.TabIndex = 13;
            // 
            // PictureList
            // 
            this.PictureList.FormattingEnabled = true;
            this.PictureList.Location = new System.Drawing.Point(245, 64);
            this.PictureList.Name = "PictureList";
            this.PictureList.Size = new System.Drawing.Size(221, 95);
            this.PictureList.TabIndex = 14;
            // 
            // LinkList
            // 
            this.LinkList.FormattingEnabled = true;
            this.LinkList.Location = new System.Drawing.Point(245, 265);
            this.LinkList.Name = "LinkList";
            this.LinkList.Size = new System.Drawing.Size(221, 95);
            this.LinkList.TabIndex = 16;
            // 
            // VideoList
            // 
            this.VideoList.FormattingEnabled = true;
            this.VideoList.Location = new System.Drawing.Point(12, 265);
            this.VideoList.Name = "VideoList";
            this.VideoList.Size = new System.Drawing.Size(221, 95);
            this.VideoList.TabIndex = 15;
            // 
            // TagList
            // 
            this.TagList.FormattingEnabled = true;
            this.TagList.Location = new System.Drawing.Point(472, 25);
            this.TagList.Name = "TagList";
            this.TagList.Size = new System.Drawing.Size(120, 334);
            this.TagList.TabIndex = 17;
            // 
            // tagTableAdapter
            // 
            this.tagTableAdapter.ClearBeforeFill = true;
            // 
            // AddTag
            // 
            this.AddTag.Location = new System.Drawing.Point(472, 366);
            this.AddTag.Name = "AddTag";
            this.AddTag.Size = new System.Drawing.Size(120, 23);
            this.AddTag.TabIndex = 18;
            this.AddTag.Text = "Добавить тэг";
            this.AddTag.UseVisualStyleBackColor = true;
            this.AddTag.Click += new System.EventHandler(this.AddTag_Click);
            // 
            // EditTag
            // 
            this.EditTag.Location = new System.Drawing.Point(472, 395);
            this.EditTag.Name = "EditTag";
            this.EditTag.Size = new System.Drawing.Size(120, 23);
            this.EditTag.TabIndex = 19;
            this.EditTag.Text = "Изменить тэг";
            this.EditTag.UseVisualStyleBackColor = true;
            this.EditTag.Click += new System.EventHandler(this.EditTag_Click);
            // 
            // DeleteTag
            // 
            this.DeleteTag.Location = new System.Drawing.Point(472, 424);
            this.DeleteTag.Name = "DeleteTag";
            this.DeleteTag.Size = new System.Drawing.Size(120, 23);
            this.DeleteTag.TabIndex = 20;
            this.DeleteTag.Text = "Удалить тэг";
            this.DeleteTag.UseVisualStyleBackColor = true;
            this.DeleteTag.Click += new System.EventHandler(this.DeleteTag_Click);
            // 
            // AddArticle
            // 
            this.AddArticle.Location = new System.Drawing.Point(12, 165);
            this.AddArticle.Name = "AddArticle";
            this.AddArticle.Size = new System.Drawing.Size(221, 23);
            this.AddArticle.TabIndex = 21;
            this.AddArticle.Text = "Добавить статью";
            this.AddArticle.UseVisualStyleBackColor = true;
            this.AddArticle.Click += new System.EventHandler(this.AddArticle_Click);
            // 
            // EditArticle
            // 
            this.EditArticle.Location = new System.Drawing.Point(12, 194);
            this.EditArticle.Name = "EditArticle";
            this.EditArticle.Size = new System.Drawing.Size(221, 23);
            this.EditArticle.TabIndex = 22;
            this.EditArticle.Text = "Изменить статью";
            this.EditArticle.UseVisualStyleBackColor = true;
            this.EditArticle.Click += new System.EventHandler(this.EditArticle_Click);
            // 
            // DeleteArticle
            // 
            this.DeleteArticle.Location = new System.Drawing.Point(12, 223);
            this.DeleteArticle.Name = "DeleteArticle";
            this.DeleteArticle.Size = new System.Drawing.Size(221, 23);
            this.DeleteArticle.TabIndex = 23;
            this.DeleteArticle.Text = "Удалить статью";
            this.DeleteArticle.UseVisualStyleBackColor = true;
            this.DeleteArticle.Click += new System.EventHandler(this.DeleteArticle_Click);
            // 
            // DeletePicture
            // 
            this.DeletePicture.Location = new System.Drawing.Point(245, 223);
            this.DeletePicture.Name = "DeletePicture";
            this.DeletePicture.Size = new System.Drawing.Size(221, 23);
            this.DeletePicture.TabIndex = 26;
            this.DeletePicture.Text = "Удалить картинку";
            this.DeletePicture.UseVisualStyleBackColor = true;
            this.DeletePicture.Click += new System.EventHandler(this.DeletePicture_Click);
            // 
            // EditPicture
            // 
            this.EditPicture.Location = new System.Drawing.Point(245, 194);
            this.EditPicture.Name = "EditPicture";
            this.EditPicture.Size = new System.Drawing.Size(221, 23);
            this.EditPicture.TabIndex = 25;
            this.EditPicture.Text = "Изменить картинку";
            this.EditPicture.UseVisualStyleBackColor = true;
            this.EditPicture.Click += new System.EventHandler(this.EditPicture_Click);
            // 
            // AddPicture
            // 
            this.AddPicture.Location = new System.Drawing.Point(245, 165);
            this.AddPicture.Name = "AddPicture";
            this.AddPicture.Size = new System.Drawing.Size(221, 23);
            this.AddPicture.TabIndex = 24;
            this.AddPicture.Text = "Добавить картинку";
            this.AddPicture.UseVisualStyleBackColor = true;
            this.AddPicture.Click += new System.EventHandler(this.AddPicture_Click);
            // 
            // DeleteVideo
            // 
            this.DeleteVideo.Location = new System.Drawing.Point(12, 424);
            this.DeleteVideo.Name = "DeleteVideo";
            this.DeleteVideo.Size = new System.Drawing.Size(221, 23);
            this.DeleteVideo.TabIndex = 29;
            this.DeleteVideo.Text = "Удалить видео";
            this.DeleteVideo.UseVisualStyleBackColor = true;
            this.DeleteVideo.Click += new System.EventHandler(this.DeleteVideo_Click);
            // 
            // EditVideo
            // 
            this.EditVideo.Location = new System.Drawing.Point(12, 395);
            this.EditVideo.Name = "EditVideo";
            this.EditVideo.Size = new System.Drawing.Size(221, 23);
            this.EditVideo.TabIndex = 28;
            this.EditVideo.Text = "Изменить видео";
            this.EditVideo.UseVisualStyleBackColor = true;
            this.EditVideo.Click += new System.EventHandler(this.EditVideo_Click);
            // 
            // AddVideo
            // 
            this.AddVideo.Location = new System.Drawing.Point(12, 366);
            this.AddVideo.Name = "AddVideo";
            this.AddVideo.Size = new System.Drawing.Size(221, 23);
            this.AddVideo.TabIndex = 27;
            this.AddVideo.Text = "Добавить видео";
            this.AddVideo.UseVisualStyleBackColor = true;
            this.AddVideo.Click += new System.EventHandler(this.AddVideo_Click);
            // 
            // DeleteLink
            // 
            this.DeleteLink.Location = new System.Drawing.Point(245, 424);
            this.DeleteLink.Name = "DeleteLink";
            this.DeleteLink.Size = new System.Drawing.Size(221, 23);
            this.DeleteLink.TabIndex = 32;
            this.DeleteLink.Text = "Удалить ссылку";
            this.DeleteLink.UseVisualStyleBackColor = true;
            this.DeleteLink.Click += new System.EventHandler(this.DeleteLink_Click);
            // 
            // EditLink
            // 
            this.EditLink.Location = new System.Drawing.Point(245, 395);
            this.EditLink.Name = "EditLink";
            this.EditLink.Size = new System.Drawing.Size(221, 23);
            this.EditLink.TabIndex = 31;
            this.EditLink.Text = "Изменить ссылку";
            this.EditLink.UseVisualStyleBackColor = true;
            this.EditLink.Click += new System.EventHandler(this.EditLink_Click);
            // 
            // AddLink
            // 
            this.AddLink.Location = new System.Drawing.Point(245, 366);
            this.AddLink.Name = "AddLink";
            this.AddLink.Size = new System.Drawing.Size(221, 23);
            this.AddLink.TabIndex = 30;
            this.AddLink.Text = "Добавить ссылку";
            this.AddLink.UseVisualStyleBackColor = true;
            this.AddLink.Click += new System.EventHandler(this.AddLink_Click);
            // 
            // KnowledgeForm
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(604, 520);
            this.Controls.Add(this.DeleteLink);
            this.Controls.Add(this.EditLink);
            this.Controls.Add(this.AddLink);
            this.Controls.Add(this.DeleteVideo);
            this.Controls.Add(this.EditVideo);
            this.Controls.Add(this.AddVideo);
            this.Controls.Add(this.DeletePicture);
            this.Controls.Add(this.EditPicture);
            this.Controls.Add(this.AddPicture);
            this.Controls.Add(this.DeleteArticle);
            this.Controls.Add(this.EditArticle);
            this.Controls.Add(this.AddArticle);
            this.Controls.Add(this.DeleteTag);
            this.Controls.Add(this.EditTag);
            this.Controls.Add(this.AddTag);
            this.Controls.Add(this.TagList);
            this.Controls.Add(this.LinkList);
            this.Controls.Add(this.VideoList);
            this.Controls.Add(this.PictureList);
            this.Controls.Add(this.ArticleList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CategoryKnowledgeLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.KnowledgeNameText);
            this.Controls.Add(this.label1);
            this.Name = "KnowledgeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KnowledgeNameText;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label CategoryKnowledgeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ArticleList;
        private System.Windows.Forms.ListBox PictureList;
        private System.Windows.Forms.ListBox LinkList;
        private System.Windows.Forms.ListBox VideoList;
        private System.Windows.Forms.CheckedListBox TagList;
        private KnowledgeDataSetTableAdapters.TagTableAdapter tagTableAdapter;
        private System.Windows.Forms.Button AddTag;
        private System.Windows.Forms.Button EditTag;
        private System.Windows.Forms.Button DeleteTag;
        private System.Windows.Forms.Button AddArticle;
        private System.Windows.Forms.Button EditArticle;
        private System.Windows.Forms.Button DeleteArticle;
        private System.Windows.Forms.Button DeletePicture;
        private System.Windows.Forms.Button EditPicture;
        private System.Windows.Forms.Button AddPicture;
        private System.Windows.Forms.Button DeleteVideo;
        private System.Windows.Forms.Button EditVideo;
        private System.Windows.Forms.Button AddVideo;
        private System.Windows.Forms.Button DeleteLink;
        private System.Windows.Forms.Button EditLink;
        private System.Windows.Forms.Button AddLink;
    }
}