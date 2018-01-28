using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace NvnNavigator.Common {
    public partial class LoginForm : Form {
        private bool adminUser = true;

        public LoginForm() {
            InitializeComponent();

            this.Text = Globals.ApplicationDisplayName + " - Login";
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            applicationNameCtrl1.Version = version.Major + "." + version.Minor;
            keyboardControl.UserKeyPressed += new KeyboardDelegate(keyboardControl_UserKeyPressed);
        }

        public bool AdminUser {
            get { return adminUser; }
            set {
                adminUser = value;
                lblDesc.Text = lblDesc.Text.Replace("#", value ? "administrator" : "client");
                applicationNameCtrl1.ApplicationModule = value ? "Administrator" : "Navigator Client";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if (txtPassword.Text.Trim() == (adminUser ? User.AdminPassword : User.ClientPassword)) {
                this.DialogResult = DialogResult.OK;
            } else {
                MessageBox.Show(String.Format("Invalid {0} password. Please enter the valid {0} password.", adminUser ? "administrator" : "client application"),
                    "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }

        void keyboardControl_UserKeyPressed(object sender, KeyboardEventArgs e) {
            txtPassword.Focus();
            SendKeys.Send(e.KeyboardKeyPressed);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}