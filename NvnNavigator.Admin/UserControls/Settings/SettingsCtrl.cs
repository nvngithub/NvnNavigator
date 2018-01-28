using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NvnNavigator.Common;

namespace NvnNavigator.Admin {
    public partial class SettingsCtrl : UserControl {
        public SettingsCtrl() {
            InitializeComponent();
        }

        public void LoadControl() {
            User.Load();
            txtAdminPassword.Text = User.AdminPassword;
            txtClientPassword.Text = User.ClientPassword;

            // Logo configuration control
            logoConfigCtrl1.LoadControl();

            // You are here location control
            youAreHereLocationCtrl1.LoadControl();

            // Layout control
            layoutSettingsCtrl1.LoadControl();
        }

        private void btnSaveUserSettings_Click(object sender, EventArgs e) {
            User.AdminPassword = txtAdminPassword.Text;
            User.ClientPassword = txtClientPassword.Text;

            User.Save();
        }
    }
}
