using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NvnNavigator.Common {
    public partial class AddEditListingForm : Form {
        private Shop shop;

        public AddEditListingForm() {
            InitializeComponent();
        }

        public string Title {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public Shop Shop {
            get { return shop; }
            set { shop = value; }
        }

        private void AddEditListingForm_Load(object sender, EventArgs e) {
            cmbCategory.Items.AddRange(GroupManager.Categories.Items.ToArray());
            cmbFloors.Items.AddRange(GroupManager.Floors.Items.ToArray());
            if (shop != null) { LoadValues(); }
        }

        private void btnSave_Click(object sender, EventArgs e) {
            bool status = SetValues();
            if (status) {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }

        private void lnkAddCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            CreateGroup(cmbCategory, GroupType.Category, GroupManager.Categories);
        }

        private void lnkAddFloor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            CreateGroup(cmbFloors, GroupType.Floor, GroupManager.Floors);
        }

        private void CreateGroup(ComboBox cmb, GroupType groupType, GroupBase group) {
            CreateGroupForm defineGroupForm = new CreateGroupForm();
            defineGroupForm.GroupType = groupType;
            defineGroupForm.Group = group;
            if (defineGroupForm.ShowDialog() == DialogResult.OK) {
                cmb.Items.Clear();
                cmb.Items.AddRange(group.Items.ToArray());
                if (shop != null) {
                    cmb.Text = "";
                    cmb.SelectedIndex = -1;
                }
            }
        }

        private void lnkEditFloor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            EditGroup(cmbFloors, GroupType.Floor, GroupManager.Floors);
        }

        private void lnkEditCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            EditGroup(cmbCategory, GroupType.Category, GroupManager.Categories);
        }

        private void EditGroup(ComboBox cmb, GroupType groupType, GroupBase group) {
            RenameGroupForm renameGroupForm = new RenameGroupForm();
            renameGroupForm.GroupType = groupType;
            renameGroupForm.Group = group;
            if (renameGroupForm.ShowDialog() == DialogResult.OK) {
                cmb.Items.Clear();
                cmb.Items.AddRange(group.Items.ToArray());
                if (shop != null) {
                    cmb.Text = "";
                    cmb.SelectedIndex = -1;
                }
            }
        }

        private void lnkDeleteFloor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            DeleteGroup(cmbFloors, GroupType.Floor, GroupManager.Floors);
        }

        private void lnkDeleteCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            DeleteGroup(cmbCategory, GroupType.Category, GroupManager.Categories);
        }

        private void DeleteGroup(ComboBox cmb, GroupType groupType, GroupBase group) {
            RemoveGroupForm removeGroupForm = new RemoveGroupForm();
            removeGroupForm.GroupType = groupType;
            removeGroupForm.Group = group;
            if (removeGroupForm.ShowDialog() == DialogResult.OK) {
                cmb.Items.Clear();
                cmb.Items.AddRange(group.Items.ToArray());
                if (shop != null) {
                    cmb.Text = "";
                    cmb.SelectedIndex = -1;
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = false;
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            dlg.Filter = "Icons (*.ico)|*.ico|PNG Portable Network Graphics Format (*.png)|*.png|GIF Graphics Interchange Format (*.gif)|*.gif|JPEG file interchange format (*.jpg)|*.jpg|Device Independent Bitmap (*.bmp)|*.bmp";
            if (dlg.ShowDialog() == DialogResult.OK) {
                string destFile = Globals.SettingsResourceDir + Path.GetFileName(dlg.FileName);
                if (String.IsNullOrEmpty(txtIconFile.Text)) {
                    // Copy new file to resource folder
                    txtIconFile.Text = Path.GetFileName(dlg.FileName);
                    bool assigned = false;
                    if (File.Exists(destFile)) {
                        // get the name of shop to which this icon is assigned
                        foreach (Shop shop in ShopManager.Shops) {
                            if (shop.IconName == txtIconFile.Text) {
                                MessageBox.Show(String.Format("Icon with name {0} already assigned to shop {1}.", txtIconFile.Text, shop.Name), "Icon...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                assigned = true;
                                break;
                            }
                        }
                    }

                    if (assigned == false) {
                        IOSupport.CopyFile(dlg.FileName, destFile, true);
                    }
                } else {
                    //1. Delete old file
                    string oldFile = Globals.SettingsResourceDir + txtIconFile.Text;
                    IOSupport.DeleteFile(oldFile);
                    //2. copy new file
                    IOSupport.CopyFile(dlg.FileName, destFile);
                }
            }
        }

        private bool SetValues() {
            bool validated = ValidateUserInput();
            if (validated) {
                if (shop == null) {
                    shop = new Shop();
                }

                shop.Name = txtName.Text;
                shop.Number = txtNumber.Text;
                shop.Floor = (string)cmbFloors.SelectedItem;
                shop.Category = (string)cmbCategory.SelectedItem;
                shop.IconName = txtIconFile.Text;
                shop.Tagline = txtTagline.Text;
                shop.Description = txtDescription.Text;
            }

            return validated;
        }

        private void LoadValues() {
            if (shop != null) {
                txtName.Text = shop.Name;
                txtNumber.Text = shop.Number;
                cmbFloors.SelectedItem = shop.Floor;
                cmbCategory.SelectedItem = shop.Category;
                txtIconFile.Text = shop.IconName;
                txtTagline.Text = shop.Tagline;
                txtDescription.Text = shop.Description;
            }
        }

        private bool ValidateUserInput() {
            if (String.IsNullOrEmpty(txtName.Text.Trim())) {
                MessageBox.Show("Shop name cannot be empty. Please enter the shop name.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (String.IsNullOrEmpty(txtNumber.Text.Trim())) {
                MessageBox.Show("Shop number cannot be empty. Please enter the shop number.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (String.IsNullOrEmpty(txtNumber.Text.Trim())) {
                MessageBox.Show("Shop floor number cannot be empty. Please enter the shop floor number.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbCategory.Items.Count < 1) {
                MessageBox.Show("No category defined. Please define a new category.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbCategory.Items.Count > 0 && cmbCategory.SelectedIndex < 0) {
                MessageBox.Show("No category selected. Please define a new category if needed.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtTagline.Text.Length > 200) {
                MessageBox.Show("Please limit short message (tagline or slogan) text to 200 characters.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}