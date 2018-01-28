using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    public partial class CreateGroupForm : Form {
        private GroupBase group;
        private GroupType groupType;

        public CreateGroupForm() {
            InitializeComponent();
        }

        public GroupType GroupType {
            set {
                this.Text = this.Text.Replace("#", value.ToString().ToLower());
                lblGroupName.Text = lblGroupName.Text.Replace("#", value.ToString());
                this.groupType = value;
            }
        }

        public GroupBase Group {
            set { group = value; }
        }

        private void btnCreateGroup_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(txtNewGroup.Text)) {
                string message = String.Format("{0} name cannot be empty. Please enter the new {0} name", groupType);
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (group.Items.Contains(txtNewGroup.Text)) {
                MessageBox.Show(String.Format("{0} with the name {1} already exists. Please enter a new {0} name", groupType, txtNewGroup.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            group.Items.Add(txtNewGroup.Text);
            group.Save();

            this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}