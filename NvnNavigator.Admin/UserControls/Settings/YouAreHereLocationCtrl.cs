using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NvnNavigator.Common;

namespace NvnNavigator.Admin {
    public partial class YouAreHereLocationCtrl : UserControl {
        public YouAreHereLocationCtrl() {
            InitializeComponent();
        }

        public void LoadControl() {
            YouAreHereLocation.Instance.Load();

            ShowPreview();
        }

        private void btnDefineYouAreHere_Click(object sender, EventArgs e) {
            RealNavigationForm navigationForm = new RealNavigationForm();
            navigationForm.CurrentPlace = Globals.NavigatorPlace;
            navigationForm.CurrentPath = Globals.NavigatorPlace.Paths[0];
            navigationForm.CurrentPoint = Globals.NavigatorPlace.Paths[0].Points[0];
            navigationForm.CurrentAngle = 0;
            navigationForm.StartRealView();
            if (navigationForm.ShowDialog() == DialogResult.OK) {
                YouAreHereLocation.Instance.PathId = navigationForm.CurrentPath.Id;
                YouAreHereLocation.Instance.Point = navigationForm.CurrentPoint;
                YouAreHereLocation.Instance.Angle = navigationForm.CurrentAngle;

                YouAreHereLocation.Instance.Save();

                ShowPreview();
            }
        }

        private void ShowPreview() {
            if (String.IsNullOrEmpty(YouAreHereLocation.Instance.PathId) == false && YouAreHereLocation.Instance.Point != null) {
                // TODO: get image for the given angle
            }
        }
    }
}
