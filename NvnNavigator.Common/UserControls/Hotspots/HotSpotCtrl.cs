using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NvnNavigator.Common {
    internal partial class HotSpotCtrl : UserControl {
        public event EventHandler ControlClicked;

        private Hotspot hotSpot;
        private Size expandedSize;
        private Size collapsedSize;
        private bool isSelected = false;

        public HotSpotCtrl() {
            InitializeComponent();

            expandedSize = this.Size;
            collapsedSize = new Size(this.Width, pnlHotSpotItems.Location.Y - 10);
        }

        public bool IsSelected {
            get { return isSelected; }
            set {
                isSelected = value;
                this.BackColor = isSelected ? SystemColors.ControlDark : SystemColors.Control;
            }
        }

        public Hotspot HotSpot {
            get { return hotSpot; }
            set { hotSpot = value; }
        }

        public void LoadControl() {
            lblImageName.Text = hotSpot.ImageName;
            pbImagePreview.Image = ImageLoader.GetImageFromFile(Globals.SettingsResourceDir + hotSpot.ImageName, pbImagePreview.Width, pbImagePreview.Height);

            // Load locations
            pnlHotSpotItems.Controls.Clear();
            foreach (HotspotLocation location in hotSpot.Locations) {
                HotSpotItemCtrl ctrl = CreateHotSpotItemCtrl(location);
                pnlHotSpotItems.Controls.Add(ctrl);
            }
        }

        private HotSpotItemCtrl CreateHotSpotItemCtrl(HotspotLocation location) {
            HotSpotItemCtrl itemCtrl = new HotSpotItemCtrl();
            itemCtrl.ItemDeleted += new EventHandler(itemCtrl_ItemDeleted);
            itemCtrl.HotspotLocation = location;
            itemCtrl.LoadControl();
            return itemCtrl;
        }

        void itemCtrl_ItemDeleted(object sender, EventArgs e) {
            HotSpotItemCtrl ctrl = (HotSpotItemCtrl)sender;

            // remove from the collection
            hotSpot.Locations.Remove(ctrl.HotspotLocation);
            HotspotManager.Save();

            // remove from the panel containing it
            pnlHotSpotItems.Controls.Remove(ctrl);
        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            HotSpotImageForm imageForm = new HotSpotImageForm();
            string resFile = string.Empty;
            if (imageForm.ShowDialog() == DialogResult.OK) {
                if (imageForm.ResourceImageSelected && imageForm.SelectedImage != null) {
                    resFile = Globals.SettingsResourceDir + imageForm.SelectedResourceImageFileName + ".png";
                    imageForm.SelectedImage.Save(resFile);
                } else if (imageForm.ResourceImageSelected == false && String.IsNullOrEmpty(imageForm.SelectedFile) == false) {
                    resFile = Globals.SettingsResourceDir + Path.GetFileName(imageForm.SelectedFile);
                    IOSupport.CopyFile(imageForm.SelectedFile, resFile);
                }

                pbImagePreview.Image = ImageLoader.GetImageFromFile(resFile, pbImagePreview.Width, pbImagePreview.Height);

                hotSpot.ImageName = Path.GetFileName(resFile);
                HotspotManager.Save();
            }
        }

        private void btnExpandCollapse_Click(object sender, EventArgs e) {
            if (btnExpandCollapse.Text == "+") {
                Expand();
                btnExpandCollapse.Text = "-";
            } else if (btnExpandCollapse.Text == "-") {
                Collapse();
                btnExpandCollapse.Text = "+";
            }
        }

        public void Collapse() {
            this.Size = collapsedSize;
            btnExpandCollapse.Text = "+";
        }

        public void Expand() {
            this.Size = expandedSize;
            btnExpandCollapse.Text = "-";
        }

        private void lnkAddNewLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (hotSpot != null) {
                HotspotLocation newLocation = new HotspotLocation();

                HotSpotItemCtrl ctrl = CreateHotSpotItemCtrl(newLocation);
                pnlHotSpotItems.Controls.Add(ctrl);

                hotSpot.Locations.Add(newLocation);
                HotspotManager.Save();
            }
        }

        private void HotSpotCtrl_Click(object sender, EventArgs e) {
            if (ControlClicked != null) {
                ControlClicked(this, null);
            }
        }
    }

    class ComboBoxEx : ComboBox {
        private ImageList imageList;
        public ImageList ImageList {
            get { return imageList; }
            set { imageList = value; }
        }

        public ComboBoxEx() {
            DrawMode = DrawMode.OwnerDrawFixed;
        }

        protected override void OnDrawItem(DrawItemEventArgs ea) {
            ea.DrawBackground();
            ea.DrawFocusRectangle();

            ComboBoxExItem item;
            Size imageSize = imageList.ImageSize;
            Rectangle bounds = ea.Bounds;

            try {
                item = (ComboBoxExItem)Items[ea.Index];

                if (item.ImageIndex != -1) {
                    imageList.Draw(ea.Graphics, bounds.Left, bounds.Top,
                    item.ImageIndex);
                    ea.Graphics.DrawString(item.Text, ea.Font, new
                    SolidBrush(ea.ForeColor), bounds.Left + imageSize.Width, bounds.Top);
                } else {
                    ea.Graphics.DrawString(item.Text, ea.Font, new
                    SolidBrush(ea.ForeColor), bounds.Left, bounds.Top);
                }
            } catch {
                if (ea.Index != -1) {
                    ea.Graphics.DrawString(Items[ea.Index].ToString(), ea.Font, new
                    SolidBrush(ea.ForeColor), bounds.Left, bounds.Top);
                } else {
                    ea.Graphics.DrawString(Text, ea.Font, new
                    SolidBrush(ea.ForeColor), bounds.Left, bounds.Top);
                }
            }

            base.OnDrawItem(ea);
        }
    }

    class ComboBoxExItem {
        private string _text;
        public string Text {
            get { return _text; }
            set { _text = value; }
        }

        private int _imageIndex;
        public int ImageIndex {
            get { return _imageIndex; }
            set { _imageIndex = value; }
        }

        public ComboBoxExItem()
            : this("") {
        }

        public ComboBoxExItem(string text)
            : this(text, -1) {
        }

        public ComboBoxExItem(string text, int imageIndex) {
            _text = text;
            _imageIndex = imageIndex;
        }

        public override string ToString() {
            return _text;
        }
    }

}