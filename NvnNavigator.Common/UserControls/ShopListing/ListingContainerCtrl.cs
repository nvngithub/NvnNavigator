using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    public partial class ListingContainerCtrl : UserControl {
        public ListingContainerCtrl() {
            InitializeComponent();

            listingConfigCtrl1.ListingChanged += new EventHandler(listingConfigCtrl1_ListingChanged);
        }

        void listingConfigCtrl1_ListingChanged(object sender, EventArgs e) {
            listingViewContainerCtrl1.LoadControl();
        }

        public void LoadControl() {
            listingConfigCtrl1.LoadShopItems();
            listingViewContainerCtrl1.LoadControl();
        }

        private void btnChangeCategorySettings_Click(object sender, EventArgs e) {
            GroupSettingsForm settingsForm = new GroupSettingsForm();
            settingsForm.LoadControl(GroupType.Category);
            settingsForm.ShowDialog();

            if (settingsForm.SettingsChanged) listingViewContainerCtrl1.LoadControl();
        }

        private void btnChangeFloorSettings_Click(object sender, EventArgs e) {
            GroupSettingsForm settingsForm = new GroupSettingsForm();
            settingsForm.LoadControl(GroupType.Floor);
            settingsForm.ShowDialog();

            if (settingsForm.SettingsChanged) listingViewContainerCtrl1.LoadControl();
        }
    }
}