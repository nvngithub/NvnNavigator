using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    internal partial class ListingViewGroupCtrl : UserControl {
        private GroupSettings groupSettings = DefaultGroupSettings.Instance;
        private List<Shop> shops;

        public ListingViewGroupCtrl() {
            InitializeComponent();
        }

        public GroupSettings GroupSettings {
            get { return groupSettings; }
            set { groupSettings = value; }
        }

        public List<Shop> Shops {
            get { return shops; }
            set { shops = value; }
        }

        public void LoadShopsAndSettings() {
            LoadShops();

            ApplySettings();
        }

        private void LoadShops() {
            if (shops != null) {
                pnlShopItems.Controls.Clear();
                foreach (Shop shop in shops) {
                    ListingViewItemCtrl listingViewItemCtrl = CreateItemCtrl(shop);
                    pnlShopItems.Controls.Add(listingViewItemCtrl);
                }
            }
        }

        private ListingViewItemCtrl CreateItemCtrl(Shop shop) {
            ListingViewItemCtrl ctrl = new ListingViewItemCtrl();
            ctrl.ShopName = shop.Name;
            ctrl.Description = ctrl.Description;
            ctrl.IconName = shop.IconName;
            return ctrl;
        }

        private void ApplySettings() {
            if (groupSettings == null) return;

            // Apply settings to header
            lblGroupName.Text = groupSettings.GroupName;
            lblGroupName.ForeColor = groupSettings.GroupNameColor;
            lblGroupName.Font = groupSettings.GroupNameFont;
            pnlHeader.BackColor = groupSettings.GroupNameBackgroundColor;

            // Apply settings to all shop controls
            foreach (Control ctrl in pnlShopItems.Controls) {
                if (ctrl is ListingViewItemCtrl) {
                    ListingViewItemCtrl listingViewItemCtrl = (ListingViewItemCtrl)ctrl;
                    listingViewItemCtrl.ShopNameColor = groupSettings.ShopNameColor;
                    listingViewItemCtrl.ShopNameFont = groupSettings.ShopNameFont;
                    listingViewItemCtrl.BackgroundColor = groupSettings.ShopBackgroundColor;
                    listingViewItemCtrl.ShopDescriptionColor = groupSettings.ShopDescriptionColor;
                    listingViewItemCtrl.ShopDescriptionFont = groupSettings.ShopDescriptionFont;
                    listingViewItemCtrl.ShopControlSize = groupSettings.ShopControlSize;
                }
            }

            this.Size = groupSettings.ShopControlSize;
        }
    }
}