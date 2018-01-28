using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    internal partial class ListingConfigItemCtrl : UserControl {
        private Shop shop;
        public event EventHandler DeleteClicked;
        public event EventHandler ListItemUpdated;

        public ListingConfigItemCtrl() {
            InitializeComponent();
        }

        public Shop Shop {
            get { return shop; }
            set {
                shop = value;
                LoadValues();
            }
        }

        private void LoadValues() {
            if (shop != null) {
                lblName.Text = shop.Name;
                lblTagline.Text = shop.Tagline;
                pbShopIcon.Image = ImageLoader.GetImageFromFile(Globals.SettingsResourceDir + shop.IconName, pbShopIcon.Width, pbShopIcon.Height);
            }
        }

        private void lnkEdit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            AddEditListingForm addEditListingForm = new AddEditListingForm();
            addEditListingForm.Title = "Edit - " + this.shop.Name;
            addEditListingForm.Shop = this.shop;
            if (addEditListingForm.ShowDialog() == DialogResult.OK) {
                shop = addEditListingForm.Shop;
                ShopManager.Save();
                LoadValues();

                if (ListItemUpdated != null) {
                    ListItemUpdated(null, null);
                }
            }
        }

        private void lnkDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (MessageBox.Show("Are you sure you want to delete this Shop ?", "Delete...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                ShopManager.Shops.Remove(shop);
                ShopManager.Save();

                if (DeleteClicked != null) {
                    DeleteClicked(this, null);
                }
            }
        }
    }
}