using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    public partial class GroupSettingsForm : Form {
        private GroupSettings settings = DefaultGroupSettings.Instance;
        private GroupType currentGroupType;
        private bool loading = false;
        private bool settingsChanged = false;

        public GroupSettingsForm() {
            InitializeComponent();

            listingViewGroupCtrl1.Visible = false;
        }

        public void LoadControl(GroupType type) {
            currentGroupType = type;
            if (type == GroupType.Category) {
                cmbGroup.Items.AddRange(GroupManager.Categories.Items.ToArray());
            } else if (type == GroupType.Floor) {
                cmbGroup.Items.AddRange(GroupManager.Floors.Items.ToArray());
            }
        }

        public bool SettingsChanged {
            get { return settingsChanged; }
        }

        #region Event Handlers
        private void GroupSettingsForm_Load(object sender, EventArgs e) {
            if (cmbGroup.Items.Count > 0) { cmbGroup.SelectedIndex = 0; }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e) {
            listingViewGroupCtrl1.Visible = true;
            if (cmbGroup.SelectedItem != null) {
                this.settings = GroupSettingsManager.GetGroupSettings((string)cmbGroup.SelectedItem);
            }

            LoadSettings();
        }

        private void lnkApplyToAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (MessageBox.Show("Are you sure you want to apply this to all ? This will overwrite all settings", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                foreach (GroupSettings groupSettings in GroupSettingsManager.Groups) {
                    groupSettings.Copy(this.settings);
                }

                GroupSettingsManager.Save();
            }
        }

        private void lnkMakeDefaultSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (MessageBox.Show("Are you sure you want to make this as default settings ? All new groups get this default value.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                DefaultGroupSettings.Instance = this.settings;
                DefaultGroupSettings.Save();
            }
        }

        private void lnkConfigGroupNameColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ConfigColor(new PropertyInvoker("GroupNameColor", settings), pnlGroupNameColor);
        }

        private void lnkConfigGroupNameBackColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ConfigColor(new PropertyInvoker("GroupNameBackgroundColor", settings), pnlGroupNameBackColor);
        }

        private void lnkConfigGroupNameFont_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ConfigFont(new PropertyInvoker("GroupNameFont", settings), lblGroupNameFontPreview);
        }

        private void lnkConfigShopNameColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ConfigColor(new PropertyInvoker("ShopNameColor", settings), pnlShopNameColor);
        }

        private void lnkConfigShopNameFont_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ConfigFont(new PropertyInvoker("ShopNameFont", settings), lblShopNameFontPreview);
        }

        private void lnkConfigShopDescColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ConfigColor(new PropertyInvoker("ShopDescriptionColor", settings), pnlShopDescColor);
        }

        private void lnkConfigShopDescFont_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ConfigFont(new PropertyInvoker("ShopDescriptionFont", settings), lblShopDescriptionFontPreview);
        }

        private void lnkConfigShopBackColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            ConfigColor(new PropertyInvoker("ShopBackgroundColor", settings), pnlShopBackColor);
        }

        private void numericLogoWidth_ValueChanged(object sender, EventArgs e) {
            settings.LogoSize = new Size(Convert.ToInt32(nudLogoWidth.Value), settings.LogoSize.Height);
            UpdateGroupCtrlSettings();
        }

        private void numericLogoHeight_ValueChanged(object sender, EventArgs e) {
            settings.LogoSize = new Size(settings.LogoSize.Width, Convert.ToInt32(nudLogoHeight.Value));
            UpdateGroupCtrlSettings();
        }

        private void numericShopWidth_ValueChanged(object sender, EventArgs e) {
            settings.ShopControlSize = new Size(Convert.ToInt32(nudShopWidth.Value), settings.ShopControlSize.Height);
            UpdateGroupCtrlSettings();
        }

        private void numericShopHeight_ValueChanged(object sender, EventArgs e) {
            settings.ShopControlSize = new Size(settings.ShopControlSize.Width, Convert.ToInt32(nudShopHeight.Value));
            UpdateGroupCtrlSettings();
        }
        #endregion

        private void ConfigColor(PropertyInvoker property, Panel pnl) {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            cd.FullOpen = true;
            cd.Color = (Color)property.Property;

            if (cd.ShowDialog() == DialogResult.OK) {
                property.Property = cd.Color;
                pnl.BackColor = cd.Color;
                UpdateGroupCtrlSettings();
            }
        }

        private void ConfigFont(PropertyInvoker property, Label lbl) {
            FontDialog fd = new FontDialog();
            //fd.ShowColor = true; // TODO
            //fd.ShowApply = true;
            if (fd.ShowDialog() == DialogResult.OK) {
                property.Property = fd.Font;
                lbl.Font = fd.Font;
                UpdateGroupCtrlSettings();
            }
        }

        private void UpdateGroupCtrlSettings() {
            if (loading == false) {
                GroupSettingsManager.Save();
                settingsChanged = true;
                ShowSampleShops();
            }
        }

        private void LoadSettings() {
            if (settings != null) {
                loading = true;

                // set all control values
                pnlGroupNameColor.BackColor = settings.GroupNameColor;
                pnlGroupNameBackColor.BackColor = settings.GroupNameBackgroundColor;
                lblGroupNameFontPreview.Font = settings.GroupNameFont;
                pnlShopNameColor.BackColor = settings.ShopNameColor;
                lblShopNameFontPreview.Font = settings.ShopNameFont;
                pnlShopDescColor.BackColor = settings.ShopDescriptionColor;
                lblShopDescriptionFontPreview.Font = settings.ShopDescriptionFont;
                pnlShopBackColor.BackColor = settings.ShopBackgroundColor;
                nudLogoWidth.Value = settings.LogoSize.Width;
                nudLogoHeight.Value = settings.LogoSize.Height;
                nudShopWidth.Value = settings.ShopControlSize.Width;
                nudShopHeight.Value = settings.ShopControlSize.Height;

                // Show sample items
                ShowSampleShops();

                loading = false;
            }
        }

        private void ShowSampleShops() {
            listingViewGroupCtrl1.GroupSettings = this.settings;
            listingViewGroupCtrl1.Shops = CreateSampleShops();
            listingViewGroupCtrl1.LoadShopsAndSettings();
        }

        private List<Shop> CreateSampleShops() {
            List<Shop> shops = new List<Shop>();
            // shop1
            Shop shop1 = new Shop();
            shop1.Description = "test description";
            shop1.Name = "shop1";
            //shop1.IconName = "";// TODO
            shop1.Tagline = "test tagline";
            shops.Add(shop1);

            // shop2 
            Shop shop2 = new Shop();
            shop2.Description = "test description";
            shop2.Name = "shop2";
            //shop2.IconName = "";// TODO
            shop2.Tagline = "test tagline";
            shops.Add(shop2);

            return shops;
        }
    }
}