using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    public partial class RemoveGroupForm : Form {
        private GroupBase group;
        GroupType groupType;

        public RemoveGroupForm() {
            InitializeComponent();
        }

        private void RemoveGroupForm_Load(object sender, EventArgs e) {
            if (group != null) {
                cmbGroup.Items.AddRange(group.Items.ToArray());
            }
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

        private void btnDelete_Click(object sender, EventArgs e) {
            if (cmbGroup.SelectedItem != null) {
                string selectedGroup = (string)cmbGroup.SelectedItem;
                string message = String.Format("Are you sure you want to delete this {0} ? All shops assigned to this {0} is not shown in the shop listing.", groupType);
                if (MessageBox.Show(message, String.Format("Delete {0}", groupType), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    if (group.Items.Contains(selectedGroup)) {
                        group.Items.Remove(selectedGroup);
                        group.Save();

                        foreach (Shop shop in ShopManager.Shops) {
                            if (shop.Category == selectedGroup) {
                                shop.Category = "";
                            }
                        }

                        ShopManager.Save();
                    }

                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}