using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    public partial class LogoViewCtrl : UserControl {
        private Image defaultLogo;

        public LogoViewCtrl() {
            InitializeComponent();

            if (this.DesignMode == false) {
                defaultLogo = NvnNavigator.Common.Properties.Resources.defaultlogo;                
            }
        }

        public void UpdateControl() {
            LogoSettings.Load();
            if (LogoSettings.Instance == null || String.IsNullOrEmpty(LogoSettings.Instance.FileName)) {
                pbLogo.Image = defaultLogo;
            } else {
                pbLogo.Image = ImageLoader.GetImageFromFile(Globals.SettingsResourceDir + LogoSettings.Instance.FileName, LogoSettings.Instance.Size.Width, LogoSettings.Instance.Size.Height);
            }

            this.Size = pbLogo.Image.Size;
        }

        public void ShowNone() {
            pbLogo.Image = null;
            pbLogo.Refresh();
        }
    }
}