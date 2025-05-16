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
    public partial class ArticleForm : Form
    {
        public ArticleForm()
        {
            InitializeComponent();
        }

        public string Caption
        {
            get { return CaptionText.Text; }
            set { CaptionText.Text = value; }
        }

        public string Content
        {
            get { return ContenText.Text; }
            set { ContenText.Text = value; }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Content) || string.IsNullOrEmpty(Caption))
            {
                MessageBox.Show("Введите заголовок и содержимое статьи.", "Неверные данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
