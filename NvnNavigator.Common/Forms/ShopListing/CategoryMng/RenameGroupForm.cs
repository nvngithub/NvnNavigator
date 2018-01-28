using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    public partial class RenameGroupForm : Form {
        private GroupBase group;
        private GroupType groupType;

        public RenameGroupForm() {
            InitializeComponent();
        }

        private void RenameGroupForm_Load(object sender, EventArgs e) {
            if (group != null) {
                cmbCurrentGroup.Items.AddRange(group.Items.ToArray());
            }
        }

        public GroupType GroupType {
            set {
                this.Text = this.Text.Replace("#", value.ToString().ToLower());
                lblCurrentGroup.Text = lblCurrentGroup.Text.Replace("#", value.ToString().ToLower());
                lblNewGroup.Text = lblNewGroup.Text.Replace("#", value.ToString().ToLower());
            }
        }

        public GroupBase Group {
            set { group = value; }
        }

        private void btnRename_Click(object sender, EventArgs e) {
            // check whether value is given
            if (cmbCurrentGroup.SelectedItem == null) {
                MessageBox.Show("Current category name is not selected.", "Rename", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if (String.IsNullOrEmpty(txtNewGroup.Text)) {
                MessageBox.Show("New category name is not provided.", "Rename", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            // check whether it already exists
            if (group.Items.Contains(txtNewGroup.Text)) {
                MessageBox.Show("New category name " + txtNewGroup.Text + " is already defined.", "Rename", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            // rename all shops assigned to this category
            string selectedCurrentCategory = (string)cmbCurrentGroup.SelectedItem;
            foreach (Shop shop in ShopManager.Shops) {
                if (shop.Category == selectedCurrentCategory) {
                    shop.Category = txtNewGroup.Text;
                }
            }

            ShopManager.Save();

            group.Items.Remove(selectedCurrentCategory);
            group.Items.Add(txtNewGroup.Text);
            group.Save();

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}