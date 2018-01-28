using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NvnNavigator.Common {
    internal partial class AdConfigItemCtrl : UserControl {
        public event EventHandler ConfigItemSelected;
        public event EventHandler UpClicked;
        public event EventHandler DownClicked;
        public event EventHandler DeleteClicked;
        public event EventHandler ValueUpdated;

        private AdSettings adSettings;

        public AdConfigItemCtrl() {
            InitializeComponent();

            List<KeyValuePair<string, FadeType>> fadeTypes = new List<KeyValuePair<string, FadeType>>() { 
                new KeyValuePair<string, FadeType>("Bottom to Top", FadeType.BottomToTop),
                new KeyValuePair<string, FadeType>("Top to Bottom", FadeType.TopToBottom),
                new KeyValuePair<string, FadeType>("Left to Right", FadeType.LeftToRight),
                new KeyValuePair<string, FadeType>("Right to Left", FadeType.RightToLeft),
                new KeyValuePair<string, FadeType>("Brighten Image", FadeType.BrightenImage),
                new KeyValuePair<string, FadeType>("Darken Image", FadeType.DarkenImage),
                new KeyValuePair<string, FadeType>("Split from Right to Left", FadeType.SplitRightToLeft)
            };

            cmbFadeType.DataSource = fadeTypes;
            cmbFadeType.DisplayMember = "Key";
            cmbFadeType.ValueMember = "Value";
        }

        public bool IsSelected {
            set {
                this.BackColor = value ? SystemColors.ControlDark : SystemColors.Control;
            }
        }

        public AdSettings AdSettings {
            get { return adSettings; }
            set { adSettings = value; }
        }

        public void LoadValues() {
            if (adSettings != null) {
                lblFileName.Text = adSettings.FileName;
                nudDisplayInterval.Value = adSettings.DisplayInterval;
                chkEnabled.Checked = adSettings.Enabled;
                cmbFadeType.SelectedValue = adSettings.FadeType;
            }
        }

        public void SelectControl() {
            if (ConfigItemSelected != null) {
                ConfigItemSelected(this, null);
            }
        }

        private void UpdateAndNotify() {
            if (adSettings != null) {
                adSettings.FileName = lblFileName.Text;
                adSettings.DisplayInterval = Convert.ToInt32(nudDisplayInterval.Value);
                adSettings.Enabled = chkEnabled.Checked;
                adSettings.FadeType = (FadeType)cmbFadeType.SelectedValue;

                if (ValueUpdated != null) {
                    ValueUpdated(this, null);
                }
            }
        }

        private void AdConfigItemCtrl_Click(object sender, EventArgs e) {
            if (ConfigItemSelected != null) {
                ConfigItemSelected(this, null);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image files (.jpg, .jpeg, .bmp, .gif, .png)|*.jpg;*.jpeg;*.bmp;*.gif;*.png";
            dlg.Multiselect = false;
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dlg.ShowDialog() == DialogResult.OK) {
                lblFileName.Text = Path.GetFileName(dlg.FileName);
                IOSupport.CopyFile(dlg.FileName, Globals.SettingsResourceDir + lblFileName.Text);

                UpdateAndNotify();
            }
        }

        private void btnUp_Click(object sender, EventArgs e) {
            if (UpClicked != null) {
                UpClicked(this, null);
            }
        }

        private void btnDown_Click(object sender, EventArgs e) {
            if (DownClicked != null) {
                DownClicked(this, null);
            }
        }

        private void lnkDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (MessageBox.Show("Are you sure you want to delete this advertisement ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                if (DeleteClicked != null) {
                    DeleteClicked(this, null);
                }
            }
        }

        private void cmbFadeType_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateAndNotify();
        }

        private void chkEnabled_CheckedChanged(object sender, EventArgs e) {
            UpdateAndNotify();
        }

        private void nudDisplayInterval_ValueChanged(object sender, EventArgs e) {
            UpdateAndNotify();
        }
    }
}