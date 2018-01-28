using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    internal partial class AdConfigCtrl : UserControl {
        public event EventHandler AdSettingsChanged;

        public AdConfigCtrl() {
            InitializeComponent();
        }

        public void LoadControl() {
            AdSettingsContainer.Load();

            pnlConfigItems.Controls.Clear();
            foreach (AdSettings adSettings in AdSettingsContainer.Ads) {
                AdConfigItemCtrl ctrl = CreateAdConfigItemControl(adSettings);
                pnlConfigItems.Controls.Add(ctrl);
            }

            if (pnlConfigItems.Controls.Count > 0) {
                ((AdConfigItemCtrl)pnlConfigItems.Controls[0]).SelectControl();
            } else {
                pbSelectedImage.Image = null;
            }
        }

        private AdConfigItemCtrl CreateAdConfigItemControl(AdSettings adSettings) {
            AdConfigItemCtrl itemCtrl = new AdConfigItemCtrl();
            itemCtrl.AdSettings = adSettings;
            itemCtrl.LoadValues();
            itemCtrl.ConfigItemSelected += new EventHandler(itemCtrl_ConfigItemSelected);
            itemCtrl.UpClicked += new EventHandler(itemCtrl_UpClicked);
            itemCtrl.DownClicked += new EventHandler(itemCtrl_DownClicked);
            itemCtrl.DeleteClicked += new EventHandler(itemCtrl_DeleteClicked);
            itemCtrl.ValueUpdated += new EventHandler(itemCtrl_ValueUpdated);
            return itemCtrl;
        }

        void itemCtrl_ValueUpdated(object sender, EventArgs e) {
            AdSettingsContainer.Save();

            NotifyAdSettingsChanged();
        }

        void itemCtrl_DeleteClicked(object sender, EventArgs e) {
            // delete file
            AdSettings settings = ((AdConfigItemCtrl)sender).AdSettings;
            IOSupport.DeleteFile(Globals.SettingsResourceDir + settings.FileName);

            // remove from the list and save
            AdSettingsContainer.Ads.Remove(settings);
            AdSettingsContainer.Save();

            // Load all settings control again and notify
            LoadControl();

            NotifyAdSettingsChanged();
        }

        void itemCtrl_DownClicked(object sender, EventArgs e) {
            ChangeOrder((AdConfigItemCtrl)sender, 1);

            LoadControl();

            NotifyAdSettingsChanged();
        }

        void itemCtrl_UpClicked(object sender, EventArgs e) {
            ChangeOrder((AdConfigItemCtrl)sender, -1);

            LoadControl();

            NotifyAdSettingsChanged();
        }

        void itemCtrl_ConfigItemSelected(object sender, EventArgs e) {
            AdConfigItemCtrl itemCtrl = (AdConfigItemCtrl)sender;
            foreach (Control ctrl in pnlConfigItems.Controls) {
                if (ctrl is AdConfigItemCtrl) {
                    ((AdConfigItemCtrl)ctrl).IsSelected = (ctrl == itemCtrl);
                }
            }
            string filename = Globals.SettingsResourceDir + itemCtrl.AdSettings.FileName;
            pbSelectedImage.Image = ImageLoader.GetImageFromFile(filename, pbSelectedImage.Width, pbSelectedImage.Height);
        }

        private void ChangeOrder(AdConfigItemCtrl ctrl, int moveIndex) {
            AdSettings adSettings = ctrl.AdSettings;
            if (AdSettingsContainer.Ads.Contains(adSettings)) {
                int index = AdSettingsContainer.Ads.IndexOf(adSettings);
                int newIndex = index + moveIndex;
                AdSettingsContainer.Ads.Remove(adSettings);
                AdSettingsContainer.Ads.Insert(newIndex, adSettings);

                AdSettingsContainer.Save();
            }
        }

        private void NotifyAdSettingsChanged() {
            if (AdSettingsChanged != null) {
                AdSettingsChanged(this, null);
            }
        }

        private void btnAddAdvertisement_Click(object sender, EventArgs e) {
            AdSettings adSettings = new AdSettings();
            AdSettingsContainer.Ads.Add(adSettings);
            AdSettingsContainer.Save();

            AdConfigItemCtrl itemCtrl = CreateAdConfigItemControl(adSettings);
            pnlConfigItems.Controls.Add(itemCtrl);
        }
    }
}