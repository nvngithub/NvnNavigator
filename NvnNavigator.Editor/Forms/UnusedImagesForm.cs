using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using NvnNavigator.Common;

namespace NvnNavigator.Editor {
    public partial class UnusedImagesForm : Form {

        public UnusedImagesForm() {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            lblStatus.Text = "Searching ...";
            List<string> usedFiles = new List<string>();
            // Get all used file list
            foreach (NavigatorPath path in Globals.NavigatorPlace.Paths) {
                string pathDir = Globals.ImagesDir + "\\" + path.Id;
                foreach (NavigatorPoint point in path.Points) {
                    usedFiles.Add(pathDir + "\\" + point.Img1);
                    usedFiles.Add(pathDir + "\\" + point.Img2);
                    usedFiles.Add(pathDir + "\\" + point.Img3);
                    usedFiles.Add(pathDir + "\\" + point.Img4);
                }
            }

            // Get all files in Images folder
            string[] files = Directory.GetFiles(Globals.ImagesDir, "*.*", SearchOption.AllDirectories);
            foreach (string file in files) {
                if (usedFiles.Contains(file) == false && Path.GetFileName(file).StartsWith("_") == false) {
                    lstFiles.Items.Add(file);
                }
            }
            lblStatus.Text = "Search Complete ...";
        }

        private void btnRenameUnused_Click(object sender, EventArgs e) {
            lblStatus.Text = "Renaming ...";
            foreach (string filename in lstFiles.Items) {
                if (File.Exists(filename)) {
                    string newFileName = Path.GetDirectoryName(filename) + "\\_" + Path.GetFileName(filename);
                    File.Move(filename, newFileName);
                }
            }

            lstFiles.Items.Clear();
            lblStatus.Text = "Rename complete ...";
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}