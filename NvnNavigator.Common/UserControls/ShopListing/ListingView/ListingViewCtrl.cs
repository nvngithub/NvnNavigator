using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    internal partial class ListingViewCtrl : UserControl {
        Dictionary<string, GroupSettings> groupSettings = new Dictionary<string, GroupSettings>();
        private GroupType selectedType = GroupType.Category;

        public ListingViewCtrl() {
            InitializeComponent();
        }

        #region Event handlers
        private void btnNone_Click(object sender, EventArgs e) {
            selectedType = GroupType.None;
            LoadShopsAndSettings();
        }

        private void btnSortByCategory_Click(object sender, EventArgs e) {
            selectedType = GroupType.Category;
            LoadShopsAndSettings();
        }

        private void btnSortByFloor_Click(object sender, EventArgs e) {
            selectedType = GroupType.Floor;
            LoadShopsAndSettings();
        }

        #endregion

        #region Methods
        public void LoadShopsAndSettings() {
            LoadSettings();

            LoadShops();
        }

        private void LoadSettings() {
            GroupSettingsManager.Load();
            groupSettings.Clear();
            foreach (GroupSettings settings in GroupSettingsManager.Groups) {
                groupSettings.Add(settings.GroupName, settings);
            }
        }

        private void LoadShops() {
            // get list of shops assigned to each group
            Dictionary<string, List<Shop>> groupNshops = new Dictionary<string, List<Shop>>();
            foreach (Shop shop in ShopManager.Shops) {
                string group = string.Empty;
                if (selectedType == GroupType.Category) {
                    group = shop.Category;
                } else if (selectedType == GroupType.Floor) {
                    group = shop.Floor;
                }

                if (groupNshops.ContainsKey(group) == false) {
                    groupNshops.Add(group, new List<Shop>());
                }

                groupNshops[group].Add(shop);
            }

            // create control for each group
            pnlContainer.Controls.Clear();
            foreach (string group in groupNshops.Keys) {
                pnlContainer.Controls.Add(CreateGroupControl(group, groupNshops[group]));
            }
        }

        private Control CreateGroupControl(string group, List<Shop> shops) {
            ListingViewGroupCtrl groupCtrl = new ListingViewGroupCtrl();
            if (groupSettings.ContainsKey(group)) {
                groupCtrl.GroupSettings = groupSettings[group];
            }
            groupCtrl.Shops = shops;
            groupCtrl.LoadShopsAndSettings();
            return groupCtrl;
        }
        #endregion
    }
}