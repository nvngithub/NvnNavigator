using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    public partial class AdConfigContainerCtrl : UserControl {
        public AdConfigContainerCtrl() {
            InitializeComponent();
            adConfigCtrl.AdSettingsChanged += new EventHandler(adConfigCtrl_AdSettingsChanged);
        }

        public void LoadControl() {
            adConfigCtrl.LoadControl();
            adViewCtrl1.LoadControl();
            adViewCtrl1.Visible = AdSettingsContainer.Ads.Count != 0;
        }

        void adConfigCtrl_AdSettingsChanged(object sender, EventArgs e) {
            if (AdSettingsContainer.Ads.Count > 0) {
                adViewCtrl1.Visible = true;
                adViewCtrl1.RefreshControl();
            } else {
                adViewCtrl1.Visible = false;
            }
        }
    }
}