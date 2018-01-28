using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NvnNavigator.Common {
    public partial class RecentFilesForm : Form {
        public RecentFilesForm() {
            InitializeComponent();

            this.Text = Globals.ApplicationDisplayName + " - Loading";

            lstRecentFiles.DrawItem += new DrawItemEventHandler(lstRecentFiles_DrawItem);
            lstRecentFiles.MeasureItem += new MeasureItemEventHandler(lstRecentFiles_MeasureItem);

            RecentFiles.Load();
            foreach (string recentFile in RecentFiles.Files) {
                lstRecentFiles.Items.Add(recentFile);
            }
        }

        public string SelectedPath {
            get { return txtSelectedFile.Text; }
        }

        void lstRecentFiles_MeasureItem(object sender, MeasureItemEventArgs e) {
            e.ItemHeight = lstRecentFiles.ItemHeight;
        }

        void lstRecentFiles_DrawItem(object sender, DrawItemEventArgs e) {
            if (lstRecentFiles.Items.Count > 0) {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString((string)lstRecentFiles.Items[e.Index], e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }

        private void lstRecentFiles_SelectedIndexChanged(object sender, EventArgs e) {
            if (lstRecentFiles.SelectedItem != null) {
                txtSelectedFile.Text = (string)lstRecentFiles.SelectedItem;
            }
        }

        private void lnkClearHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            RecentFiles.Files.Clear();
            RecentFiles.Save();
            lstRecentFiles.Items.Clear();
        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.RootFolder = Environment.SpecialFolder.Desktop;
            dlg.ShowNewFolderButton = false;
            if (dlg.ShowDialog() == DialogResult.OK) {
                txtSelectedFile.Text = dlg.SelectedPath;
                lstRecentFiles.Items.Add(dlg.SelectedPath);

                if (RecentFiles.Files.Contains(dlg.SelectedPath) == false) {
                    RecentFiles.Files.Add(dlg.SelectedPath);
                    RecentFiles.Save();
                }
            }
            this.DialogResult = DialogResult.None;
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            LoadSelectedFile();
        }

        private void lstRecentFiles_DoubleClick(object sender, EventArgs e) {
            LoadSelectedFile();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.No;
        }

        private void LoadSelectedFile() {
            if (String.IsNullOrEmpty(txtSelectedFile.Text) == false) {
                // Check whether folder contains Navigator.prj... application project file
                string[] files = Directory.GetFiles(txtSelectedFile.Text);
                bool projectFileExists = false;
                foreach (string file in files) {
                    if (Path.GetFileName(file).Trim() == Path.GetFileName(Globals.ProjectFile)) {
                        projectFileExists = true;
                        break;
                    }
                }

                if (projectFileExists) {
                    this.DialogResult = DialogResult.OK;
                } else {
                    MessageBox.Show("Selected folder does not contain essential files. Please select try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
