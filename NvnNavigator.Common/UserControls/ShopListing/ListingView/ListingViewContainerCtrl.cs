using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    internal partial class ListingViewContainerCtrl : UserControl {
        public event EventHandler FormCloseRequested;

        public ListingViewContainerCtrl() {
            InitializeComponent();
        }

        public void LoadControl() {
            listingCtrl1.LoadShopsAndSettings();
        }

        private void pbClose_Click(object sender, EventArgs e) {
            if (FormCloseRequested != null) {
                FormCloseRequested(null, null);
            }
        }
    }
}