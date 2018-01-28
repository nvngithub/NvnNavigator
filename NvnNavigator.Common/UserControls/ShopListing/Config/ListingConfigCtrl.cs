using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    internal partial class ListingConfigCtrl : UserControl {
        public event EventHandler ListingChanged;

        public ListingConfigCtrl() {
            InitializeComponent();
        }

        public void LoadShopItems() {
            ShopManager.Load();

            pnlShopListing.Controls.Clear();
            foreach (Shop shop in ShopManager.Shops) {
                pnlShopListing.Controls.Add(CreateShopControl(shop));
            }
        }

        private ListingConfigItemCtrl CreateShopControl(Shop shop) {
            ListingConfigItemCtrl listingConfigItemCtrl = new ListingConfigItemCtrl();
            listingConfigItemCtrl.ListItemUpdated += new EventHandler(listingConfigItemCtrl_ListItemUpdated);
            listingConfigItemCtrl.DeleteClicked += new EventHandler(listingConfigItemCtrl_DeleteClicked);
            listingConfigItemCtrl.Shop = shop;

            return listingConfigItemCtrl;
        }

        void listingConfigItemCtrl_ListItemUpdated(object sender, EventArgs e) {
            NotifyListingChanged();
        }

        void listingConfigItemCtrl_DeleteClicked(object sender, EventArgs e) {
            pnlShopListing.Controls.Remove((Control)sender);
            NotifyListingChanged();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddEditListingForm addEditListingForm = new AddEditListingForm();
            addEditListingForm.Title = "Add new shop";
            if (addEditListingForm.ShowDialog() == DialogResult.OK) {
                ShopManager.Shops.Add(addEditListingForm.Shop);
                ShopManager.Save();

                pnlShopListing.Controls.Add(CreateShopControl(addEditListingForm.Shop));
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to delete all shops ?", "Delete all", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                ShopManager.Shops.Clear();
                ShopManager.Save();

                pnlShopListing.Controls.Clear();
            }
        }

        private void NotifyListingChanged() {
            if (ListingChanged != null) {
                ListingChanged(null, null);
            }
        }
    }
}