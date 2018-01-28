using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    public partial class HotspotViewCtrl : UserControl {
        public event EventHandler<HotspotClickedEventArgs> HotpotClicked;

        public HotspotViewCtrl() {
            InitializeComponent();
        }

        public void LoadControl() {
            HotspotManager.Load();

            foreach (Hotspot hotspot in HotspotManager.Hotspots) {
                Button btn = CreateControl(hotspot);
                pnlHotspots.Controls.Add(btn);
            }
        }

        private Button CreateControl(Hotspot hotspot) {
            Button hotspotButton = new Button();
            hotspotButton.Click += new EventHandler(hotspotButton_Click);
            hotspotButton.Image = null;
            hotspotButton.Text = hotspot.ImageName;

            return hotspotButton;
        }

        void hotspotButton_Click(object sender, EventArgs e) {
            if (HotpotClicked != null) {
                HotpotClicked(sender, new HotspotClickedEventArgs(null));
            }
        }
    }
}