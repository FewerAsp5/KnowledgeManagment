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
    public partial class LinkForm : Form
    {
        public LinkForm()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return TitleText.Text; }
            set { TitleText.Text = value; }
        }

        public string Link 
        { 
            get { return LinkText.Text; }
            set { LinkText.Text = value; }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Title) || string.IsNullOrEmpty(Link))
            {
                MessageBox.Show("Введите заголовок и ссылку.", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(!IsValidUrl())
            {
                MessageBox.Show("Введите корректную ссылку", "Ошибочеая ссылка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private bool IsValidUrl()
        {
            if (Uri.TryCreate(Link, UriKind.Absolute, out var url))
            {
                return url.Scheme == Uri.UriSchemeHttp || url.Scheme == Uri.UriSchemeHttps;
            }
            return false;
        }
    }
}
