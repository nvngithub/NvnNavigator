using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NvnNavigator.Common {
    internal partial class HotSpotItemCtrl : UserControl {
        public event EventHandler ItemDeleted;
        private HotspotLocation location;

        public HotSpotItemCtrl() {
            InitializeComponent();
        }

        public HotspotLocation HotspotLocation {
            get { return location; }
            set { location = value; }
        }

        public void LoadControl() {
            LoadPreviewImage();

            lblMessage.Visible = pbPreviewImage.Image == null;
        }

        private void lnkAssign_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // get the location using real map
            RealNavigationForm navigationForm = new RealNavigationForm();
            navigationForm.ProjectImagePath = Globals.ImagesDir;
            navigationForm.CurrentPlace = Globals.NavigatorPlace;
            if (Globals.NavigatorPlace.Paths.Count > 0) {
                navigationForm.CurrentPath = Globals.NavigatorPlace.Paths[0];
            }
            if (Globals.NavigatorPlace.Paths.Count > 0 && Globals.NavigatorPlace.Paths[0].Points.Count > 0) {
                navigationForm.CurrentPoint = Globals.NavigatorPlace.Paths[0].Points[0];
            }
            navigationForm.CurrentAngle = 0;
            navigationForm.StartRealView();
            if (navigationForm.ShowDialog() == DialogResult.OK) {
                location.NavigatorPathId = (new FileInfo(navigationForm.CurrentImagePath)).Directory.Name;
                location.ImageName = Path.GetFileName(navigationForm.CurrentImagePath);
            }

            LoadPreviewImage();

            HotspotManager.Save();
        }

        private void lnkDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (ItemDeleted != null) {
                ItemDeleted(this, null);
            }
        }

        private void LoadPreviewImage() {
            if (location != null) {
                pbPreviewImage.Image = ImageLoader.GetImageFromFile(Globals.ImagesDir + location.NavigatorPathId + "\\" + location.ImageName, pbPreviewImage.Width, pbPreviewImage.Height);
            }
        }
    }
}