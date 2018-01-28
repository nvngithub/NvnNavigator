using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using System.IO;

namespace NvnNavigator.Common {
    public partial class LogoConfigCtrl : UserControl {
        public event EventHandler LogoSettingsChanged;
        private bool loading = false;

        public LogoConfigCtrl() {
            InitializeComponent();
        }

        public void LoadControl() {
            loading = true;

            LogoSettings.Load();

            if (LogoSettings.Instance != null) {
                chkEnabled.Checked = LogoSettings.Instance.Enabled;
                nudWidth.Value = LogoSettings.Instance.Size.Width;
                nudHeight.Value = LogoSettings.Instance.Size.Height;
            }

            logoViewCtrl.UpdateControl();

            loading = false;
        }

        private void lnkChooseNewLogo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image files (.jpg, .jpeg, .bmp, .gif, .png)|*.jpg;*.jpeg;*.bmp;*.gif;*.png";
            dlg.Multiselect = false;
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dlg.ShowDialog() == DialogResult.OK) {
                LogoSettings.Instance.FileName = Path.GetFileName(dlg.FileName);
                IOSupport.CopyFile(dlg.FileName, Globals.SettingsResourceDir + LogoSettings.Instance.FileName);

                SaveAndUpdate();
            }
        }

        private void nudWidth_ValueChanged(object sender, EventArgs e) {
            if (loading) return;
            SaveAndUpdate();
        }

        private void nudHeight_ValueChanged(object sender, EventArgs e) {
            if (loading) return;
            SaveAndUpdate();
        }

        private void chkEnabled_CheckedChanged(object sender, EventArgs e) {
            if (loading) return;
            SaveAndUpdate();
        }

        private void SaveAndUpdate() {
            LogoSettings.Instance.Enabled = chkEnabled.Checked;
            LogoSettings.Instance.Size = new Size(Convert.ToInt32(nudWidth.Value), Convert.ToInt32(nudHeight.Value));

            LogoSettings.Save();

            if (chkEnabled.Checked) {
                logoViewCtrl.UpdateControl();
            } else {
                logoViewCtrl.ShowNone();
            }

            if (LogoSettingsChanged != null) {
                LogoSettingsChanged(this, null);
            }
        }
    }
}