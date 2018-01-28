using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NvnNavigator.Common;

namespace NvnNavigator.Common {
    public partial class RealNavigationForm : Form {
        public RealNavigationForm() {
            InitializeComponent();
        }

        public NavigatorPlace CurrentPlace {
            get { return navigationViewerCtrl1.CurrentPlace; }
            set { navigationViewerCtrl1.CurrentPlace = value; }
        }

        public NavigatorPath CurrentPath {
            get { return navigationViewerCtrl1.CurrentPath; }
            set { navigationViewerCtrl1.CurrentPath = value; }
        }

        public NavigatorPoint CurrentPoint {
            get { return navigationViewerCtrl1.CurrentPoint; }
            set { navigationViewerCtrl1.CurrentPoint = value; }
        }

        public int CurrentAngle {
            get { return navigationViewerCtrl1.CurrentAngle; }
            set { navigationViewerCtrl1.CurrentAngle = value; }
        }

        public string CurrentImagePath {
            get { return navigationViewerCtrl1.CurrentImagePath; }
        }

        public string ProjectImagePath {
            set { navigationViewerCtrl1.ProjectImagePath = value; }
        }

        public void StartRealView() {
            navigationViewerCtrl1.StartViewer();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
