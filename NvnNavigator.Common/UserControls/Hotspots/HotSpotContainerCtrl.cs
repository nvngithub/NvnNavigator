using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    public partial class HotSpotContainerCtrl : UserControl {
        public HotSpotContainerCtrl() {
            InitializeComponent();
        }

        public void LoadControl() {
            HotspotManager.Load();

            pnlHotspots.Controls.Clear();
            foreach (Hotspot hotSpot in HotspotManager.Hotspots) {
                HotSpotCtrl ctrl = CreateControl(hotSpot);
                pnlHotspots.Controls.Add(ctrl);
            }

            if (pnlHotspots.Controls.Count > 0) {
                ((HotSpotCtrl)pnlHotspots.Controls[0]).IsSelected = true;
            }
        }

        private HotSpotCtrl CreateControl(Hotspot hotSpot) {
            HotSpotCtrl ctrl = new HotSpotCtrl();
            ctrl.ControlClicked += new EventHandler(ctrl_ControlClicked);
            ctrl.HotSpot = hotSpot;
            ctrl.IsSelected = false;
            ctrl.LoadControl();
            ctrl.Collapse();
            return ctrl;
        }

        void ctrl_ControlClicked(object sender, EventArgs e) {
            HotSpotCtrl selectedCtrl = (HotSpotCtrl)sender;
            foreach (Control ctrl in pnlHotspots.Controls) {
                HotSpotCtrl hotSpotCtrl = (HotSpotCtrl)ctrl;
                hotSpotCtrl.IsSelected = hotSpotCtrl == selectedCtrl;
            }
        }

        private void btnAddNewHotspot_Click(object sender, EventArgs e) {
            Hotspot newHotSpot = new Hotspot();

            HotSpotCtrl ctrl = CreateControl(newHotSpot);
            pnlHotspots.Controls.Add(ctrl);

            HotspotManager.Hotspots.Add(newHotSpot);
            HotspotManager.Save();
        }

        private void btnDeleteSelectedHotspot_Click(object sender, EventArgs e) {
            HotSpotCtrl hotSpotCtrl = null;
            foreach (Control ctrl in pnlHotspots.Controls) {
                hotSpotCtrl = (HotSpotCtrl)ctrl;
                if (hotSpotCtrl.IsSelected) break;
            }

            if (hotSpotCtrl != null) {
                if (MessageBox.Show("Are you sure you want to delete this hot spot ?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                    HotspotManager.Hotspots.Remove(hotSpotCtrl.HotSpot);
                    HotspotManager.Save();

                    pnlHotspots.Controls.Remove(hotSpotCtrl);
                }
            }
        }
    }
}