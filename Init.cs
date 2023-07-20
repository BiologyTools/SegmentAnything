using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegmentAnything
{
    public partial class Init : Form
    {
        public Init()
        {
            InitializeComponent();
        }
        private void setPremodelBut_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog()!=DialogResult.OK) return;
            Settings.AddSettings("PreModel", openFileDialog.FileName);
            preModelBox.Text = openFileDialog.FileName;
        }

        private void setModelBut_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            Settings.AddSettings("Model", openFileDialog.FileName);
            modelBox.Text = openFileDialog.FileName;
        }
        private void okBut_Click_1(object sender, EventArgs e)
        {
            if (!File.Exists(preModelBox.Text) || !File.Exists(modelBox.Text))
                return;
            Settings.Save();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBut_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
