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

namespace KnowledgeManagement
{
    public partial class MainForm : Form
    {
        private readonly string pictureStorage;

        private readonly string videoStorage;

        private const string Storage = "Storage";

        public MainForm()
        {
            InitializeComponent();
            var exeDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            pictureStorage = Path.Combine(exeDirectory, Storage, "Picture");
            if (!Directory.Exists(pictureStorage))
            {
                Directory.CreateDirectory(pictureStorage);
            }
            videoStorage = Path.Combine(exeDirectory, Storage, "Video");
            if (!Directory.Exists(videoStorage))
            {
                Directory.CreateDirectory(videoStorage);
            }
        }

        private void Manage_Click(object sender, EventArgs e)
        {
            var form = new ManageForm(pictureStorage, videoStorage, true);
            form.ShowDialog(this);
        }

        private void Find_Click(object sender, EventArgs e)
        {
            var form = new FindForm(pictureStorage, videoStorage, false);
            form.ShowDialog(this);
        }
    }
}
