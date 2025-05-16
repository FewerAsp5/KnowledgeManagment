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
    public partial class InputTextForm : Form
    {
        public static bool TryInputText(ref string input, string caption, string label)
        {
            var form = new InputTextForm();
            form.Caption = caption;
            form.Label = label;
            form.Input = input;
            if (form.ShowDialog() == DialogResult.OK)
            {
                input = form.Input;
                return true;
            }
            return false;
        }

        public InputTextForm()
        {
            InitializeComponent();
        }

        public string Input 
        {
            get { return InputText.Text; }
            set { InputText.Text = value; }
        }

        public string Caption
        {
            set { Text = value; }
        }

        public string Label
        { 
            set { InputLabel.Text = value; } 
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (InputText.Text.Length == 0)
            {
                MessageBox.Show("Введите название новой категории.", "Добавление категории", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
