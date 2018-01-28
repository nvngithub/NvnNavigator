using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace NvnNavigator.Common {
    public partial class ApplicationNameCtrl : UserControl {
        public ApplicationNameCtrl() {
            InitializeComponent();

            lblAppName.Text = Globals.ApplicationDisplayName;
        }

        public string ApplicationModule {
            get { return lblApplicationModuleName.Text; }
            set { lblApplicationModuleName.Text = value; }
        }

        public string Version {
            get { return lblVersion.Text; }
            set { lblVersion.Text = value; }
        }
    }
}
