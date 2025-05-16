namespace KnowledgeManagement
{
    partial class MainForm
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
            this.Manage = new System.Windows.Forms.Button();
            this.Find = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Manage
            // 
            this.Manage.Location = new System.Drawing.Point(25, 29);
            this.Manage.Name = "Manage";
            this.Manage.Size = new System.Drawing.Size(191, 164);
            this.Manage.TabIndex = 0;
            this.Manage.Text = "Управление знаниями";
            this.Manage.UseVisualStyleBackColor = true;
            this.Manage.Click += new System.EventHandler(this.Manage_Click);
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(222, 29);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(191, 164);
            this.Find.TabIndex = 1;
            this.Find.Text = "Поиск знаний";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 212);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.Manage);
            this.Name = "MainForm";
            this.Text = "Система управления базой знаний";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Manage;
        private System.Windows.Forms.Button Find;
    }
}

