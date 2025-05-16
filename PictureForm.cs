using PracticeTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace KnowledgeManagement
{
    public partial class PictureForm : Form
    {
        private readonly ImageLoader photo;

        public PictureForm()
        {
            InitializeComponent();

            photo = new ImageLoader(PhotoBox, PhotoLoadingError);
            RedrawPhoto();
        }

        public string Title
        {
            get { return TitleText.Text; }
            set { TitleText.Text = value; }
        }

        public string Path
        {
            get { return PhotoPath.Text; }
            set
            {
                PhotoPath.Text = value;
                RedrawPhoto();
            }
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Title) || string.IsNullOrEmpty(Path))
            {
                MessageBox.Show("Введите заголовок и путь к файлу.", "Ошибка ввода данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(Path))
            {
                MessageBox.Show("Введите путь к существующему файлу", "Ошибочеая ссылка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            if (OpenPictureDialog.ShowDialog() == DialogResult.OK)
            {
                Path = OpenPictureDialog.FileName;
            }
        }

        private void PhotoPath_Leave(object sender, EventArgs e)
        {
            RedrawPhoto();
        }

        private void RedrawPhoto()
        {
            if (string.IsNullOrWhiteSpace(PhotoPath.Text))
                photo.ResetImage();
            else
                photo.LoadImage(PhotoPath.Text);
        }
    }
}
