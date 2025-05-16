namespace KnowledgeManagement
{
    partial class PictureForm
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
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.PhotoLoadingError = new System.Windows.Forms.Label();
            this.PhotoBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Browse = new System.Windows.Forms.Button();
            this.PhotoPath = new System.Windows.Forms.TextBox();
            this.TitleText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenPictureDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(12, 113);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 0;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(329, 113);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // PhotoLoadingError
            // 
            this.PhotoLoadingError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotoLoadingError.Location = new System.Drawing.Point(410, 25);
            this.PhotoLoadingError.Name = "PhotoLoadingError";
            this.PhotoLoadingError.Size = new System.Drawing.Size(100, 23);
            this.PhotoLoadingError.TabIndex = 24;
            this.PhotoLoadingError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PhotoLoadingError.UseCompatibleTextRendering = true;
            this.PhotoLoadingError.Visible = false;
            // 
            // PhotoBox
            // 
            this.PhotoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotoBox.Location = new System.Drawing.Point(410, 25);
            this.PhotoBox.Name = "PhotoBox";
            this.PhotoBox.Size = new System.Drawing.Size(100, 111);
            this.PhotoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoBox.TabIndex = 23;
            this.PhotoBox.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Путь к фотографии";
            // 
            // Browse
            // 
            this.Browse.Location = new System.Drawing.Point(334, 59);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(70, 23);
            this.Browse.TabIndex = 21;
            this.Browse.Text = "Обзор";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // PhotoPath
            // 
            this.PhotoPath.Location = new System.Drawing.Point(123, 62);
            this.PhotoPath.Name = "PhotoPath";
            this.PhotoPath.Size = new System.Drawing.Size(205, 20);
            this.PhotoPath.TabIndex = 20;
            this.PhotoPath.Leave += new System.EventHandler(this.PhotoPath_Leave);
            // 
            // TitleText
            // 
            this.TitleText.Location = new System.Drawing.Point(12, 25);
            this.TitleText.Name = "TitleText";
            this.TitleText.Size = new System.Drawing.Size(392, 20);
            this.TitleText.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Заголовок:";
            // 
            // OpenPictureDialog
            // 
            this.OpenPictureDialog.Filter = "BMP|*.bmp|JPG|*.jpg|Все файлы|*.*";
            this.OpenPictureDialog.Title = "Открыть фотографию";
            // 
            // PictureForm
            // 
            this.AcceptButton = this.OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(523, 150);
            this.Controls.Add(this.TitleText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PhotoLoadingError);
            this.Controls.Add(this.PhotoBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.PhotoPath);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Name = "PictureForm";
            this.Text = "PictureForm";
            ((System.ComponentModel.ISupportInitialize)(this.PhotoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label PhotoLoadingError;
        private System.Windows.Forms.PictureBox PhotoBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.TextBox PhotoPath;
        private System.Windows.Forms.TextBox TitleText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog OpenPictureDialog;
    }
}