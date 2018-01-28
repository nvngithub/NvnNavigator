using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    public partial class LayoutSettingsCtrl : UserControl {
        public event EventHandler AdsEnabledChanged;
        public event EventHandler ConfigureAdsClicked;
        private bool updating = false;

        public LayoutSettingsCtrl() {
            InitializeComponent();
        }

        public void LoadControl() {
            updating = true;
            LayoutSettings.Instance.Load();

            switch (LayoutSettings.Instance.ViewMapLayout) {
                case ViewMapLayout.MapOnly: rbMapOnly.Checked = true; break;
                case ViewMapLayout.ViewBottomMapTop: rbViewBottom.Checked = true; break;
                case ViewMapLayout.ViewLeftMapRight: rbViewLeft.Checked = true; break;
                case ViewMapLayout.ViewOnly: rbViewOnly.Checked = true; break;
                case ViewMapLayout.ViewRightMapLeft: rbViewRight.Checked = true; break;
                case ViewMapLayout.ViewTopMapBottom: rbViewTop.Checked = true; break;
            }

            chkAdsEnabled.Checked = LayoutSettings.Instance.Enabled;

            switch (LayoutSettings.Instance.AdLayout) {
                case AdLayout.Bottom: rbAdsBottom.Checked = true; break;
                case AdLayout.Left: rbAdsLeft.Checked = true; break;
                case AdLayout.Right: rbAdsRight.Checked = true; break;
                case AdLayout.Top: rbAdsTop.Checked = true; break;
            }

            CreateLayout();

            updating = false;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e) {
            if (updating) return;
            
            // Set and save values
            SetAndSaveLayoutSettings();
            // Create layout
            CreateLayout();
        }

        private void chkAdsEnabled_CheckedChanged(object sender, EventArgs e) {
            if (updating) return;

            if (MessageBox.Show("Are you sure you want to Enable / Disable ALL ads ?", "Enable/Disable", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                // enable, disable ad settings
                rbAdsRight.Enabled = chkAdsEnabled.Checked;
                rbAdsBottom.Enabled = chkAdsEnabled.Checked;
                rbAdsLeft.Enabled = chkAdsEnabled.Checked;
                rbAdsTop.Enabled = chkAdsEnabled.Checked;

                // Set and save values
                SetAndSaveLayoutSettings();
                // Create layout
                CreateLayout();

                // fire event so that ad config control is updated
                if (AdsEnabledChanged != null) {
                    AdsEnabledChanged(this, null);
                }
            } else {
                updating = true;
                chkAdsEnabled.Checked = ! chkAdsEnabled.Checked;
                updating = false;
            }
        }

        private void lnkConfigureAds_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (ConfigureAdsClicked != null) {
                ConfigureAdsClicked(this, null);
            }
        }

        private void SetAndSaveLayoutSettings() {
            // Layout
            if (rbViewOnly.Checked) LayoutSettings.Instance.ViewMapLayout = ViewMapLayout.ViewOnly;
            else if (rbMapOnly.Checked) LayoutSettings.Instance.ViewMapLayout = ViewMapLayout.MapOnly;
            else if (rbViewLeft.Checked) LayoutSettings.Instance.ViewMapLayout = ViewMapLayout.ViewLeftMapRight;
            else if (rbViewRight.Checked) LayoutSettings.Instance.ViewMapLayout = ViewMapLayout.ViewRightMapLeft;
            else if (rbViewTop.Checked) LayoutSettings.Instance.ViewMapLayout = ViewMapLayout.ViewTopMapBottom;
            else if (rbViewBottom.Checked) LayoutSettings.Instance.ViewMapLayout = ViewMapLayout.ViewBottomMapTop;

            // Ad layout
            if (rbAdsTop.Checked) LayoutSettings.Instance.AdLayout = AdLayout.Top;
            else if (rbAdsRight.Checked) LayoutSettings.Instance.AdLayout = AdLayout.Right;
            else if (rbAdsBottom.Checked) LayoutSettings.Instance.AdLayout = AdLayout.Bottom;
            else if (rbAdsLeft.Checked) LayoutSettings.Instance.AdLayout = AdLayout.Left;

            // Enabled
            LayoutSettings.Instance.Enabled = chkAdsEnabled.Checked;

            // Save
            LayoutSettings.Instance.Save();
        }

        private void CreateLayout() {
            panel1.Controls.Clear();

            Control viewMapCtrl = CreateViewAndMapControls();
            if (chkAdsEnabled.Checked) // TODO: use object value.. not control state
            {
                Control adCtrl = CreatePreviewControl("ad");

                SplitContainer container = new SplitContainer();
                container.SplitterDistance = 100;// TODO:
                container.Dock = DockStyle.Fill;

                switch (LayoutSettings.Instance.AdLayout) {
                    case AdLayout.Bottom:
                        container.Orientation = Orientation.Horizontal;
                        container.Panel1.Controls.Add(viewMapCtrl);
                        container.Panel2.Controls.Add(adCtrl);
                        break;
                    case AdLayout.Left:
                        container.Orientation = Orientation.Vertical;
                        container.Panel1.Controls.Add(adCtrl);
                        container.Panel2.Controls.Add(viewMapCtrl);
                        break;
                    case AdLayout.Right:
                        container.Orientation = Orientation.Vertical;
                        container.Panel1.Controls.Add(viewMapCtrl);
                        container.Panel2.Controls.Add(adCtrl);
                        break;
                    case AdLayout.Top:
                        container.Orientation = Orientation.Horizontal;
                        container.Panel1.Controls.Add(adCtrl);
                        container.Panel2.Controls.Add(viewMapCtrl);
                        break;
                }

                panel1.Controls.Add(container);
            } else {
                panel1.Controls.Add(viewMapCtrl);
            }
        }

        private Control CreateViewAndMapControls() {
            Control ctrl = null;
            if (LayoutSettings.Instance.ViewMapLayout == ViewMapLayout.ViewOnly ||
                LayoutSettings.Instance.ViewMapLayout == ViewMapLayout.MapOnly) {
                if (LayoutSettings.Instance.ViewMapLayout == ViewMapLayout.ViewOnly) {
                    ctrl = CreatePreviewControl("view");
                } else if (LayoutSettings.Instance.ViewMapLayout == ViewMapLayout.MapOnly) {
                    ctrl = CreatePreviewControl("map");
                }
            } else {
                SplitContainer container = new SplitContainer();
                container.SplitterDistance = container.Width / 2;
                container.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;

                Control viewCtrl = CreatePreviewControl("view");
                Control mapCtrl = CreatePreviewControl("map");

                switch (LayoutSettings.Instance.ViewMapLayout) {
                    case ViewMapLayout.ViewLeftMapRight:
                        container.Panel1.Controls.Add(viewCtrl);
                        container.Panel2.Controls.Add(mapCtrl);
                        break;
                    case ViewMapLayout.ViewRightMapLeft:
                        container.Panel1.Controls.Add(mapCtrl);
                        container.Panel2.Controls.Add(viewCtrl);
                        break;
                    case ViewMapLayout.ViewTopMapBottom:
                        container.Orientation = Orientation.Horizontal;
                        container.Panel1.Controls.Add(viewCtrl);
                        container.Panel2.Controls.Add(mapCtrl);
                        break;
                    case ViewMapLayout.ViewBottomMapTop:
                        container.Orientation = Orientation.Horizontal;
                        container.Panel1.Controls.Add(mapCtrl);
                        container.Panel2.Controls.Add(viewCtrl);
                        break;
                }

                ctrl = container;
            }

            ctrl.Dock = DockStyle.Fill;

            return ctrl;
        }

        private Control CreatePreviewControl(string type) {
            PictureBox pb = new PictureBox();
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Dock = DockStyle.Fill;
            pb.Width = pb.Width; // TODO:
            pb.Height = pb.Height;// TODO:

            switch (type) {
                case "map":
                    pb.Image = Properties.Resources.mapLayoutSettings;
                    break;
                case "view":
                    pb.Image = Properties.Resources.viewLayoutSettings;
                    break;
                case "ad":
                    pb.Image = Properties.Resources.adsLayoutSettings;
                    break;
            }

            return pb;
        }
    }
}