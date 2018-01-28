using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    public partial class LayoutViewCtrl : UserControl {
        public LayoutViewCtrl() {
            InitializeComponent();

            //navigationViewerCtrl.PositionChanged +=new EventHandler<NavigatorPositionChangedEventArgs>(navigationViewerCtrl_PositionChanged);
            //hotspotViewCtrl1.HotpotClicked += new EventHandler<HotspotClickedEventArgs>(hotspotViewCtrl1_HotpotClicked);
        }

        public void LoadControl(string selectedPath) {
            //// Navigator control
            //Globals.ProjectDir = selectedPath;
            //Globals.NavigatorPlace = LoadSave.Load(Globals.ProjectFile);
            //navigationViewerCtrl.ProjectImagePath = Globals.ImagesDir;
            //navigationViewerCtrl.CurrentPlace = Globals.NavigatorPlace;
            //navigationViewerCtrl.CurrentPath = navigationViewerCtrl.CurrentPlace.Paths[0];
            //navigationViewerCtrl.CurrentPoint = navigationViewerCtrl.CurrentPlace.Paths[0].Points[0];
            //navigationViewerCtrl.CurrentAngle = 0;

            //navigationViewerCtrl.StartViewer();

            ////Maps control
            //navigatorMapCtrl.LoadMaps();

            //// Hotspot view control
            //hotspotViewCtrl1.LoadControl();
        }

        //void navigationViewerCtrl_PositionChanged(object sender, NavigatorPositionChangedEventArgs e) {
        //    navigatorMapCtrl.UpdateLocation(e.Point, MapLocationImageType.CurrentLocation);
        //}

        //void hotspotViewCtrl1_HotpotClicked(object sender, HotspotClickedEventArgs e) {
        //    if (MessageBox.Show("Click yes to go to selected location from the place \"You Are Here\"", "Go", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK) {
        //        navigationViewerCtrl.SearchAndNavigate(e.Location);
        //    }
        //}

        private void CreateLayout() {
            panelLayout.Controls.Clear();

            Control viewMapCtrl = CreateViewAndMapControls();
            if (LayoutSettings.Instance.Enabled)
            {
                Control adCtrl = CreatePreviewControl("ad");

                SplitContainer container = new SplitContainer();
                container.SplitterDistance = 100;// TODO:
                container.Dock = DockStyle.Fill;

                switch (LayoutSettings.Instance.AdLayout) {
                    case AdLayout.Bottom:
                        container.Orientation = Orientation.Horizontal;
                        container.Panel1.Controls.Add(viewMapCtrl);
                        container.Panel2.Controls.Add(adCtrl);
                        break;
                    case AdLayout.Left:
                        container.Orientation = Orientation.Vertical;
                        container.Panel1.Controls.Add(adCtrl);
                        container.Panel2.Controls.Add(viewMapCtrl);
                        break;
                    case AdLayout.Right:
                        container.Orientation = Orientation.Vertical;
                        container.Panel1.Controls.Add(viewMapCtrl);
                        container.Panel2.Controls.Add(adCtrl);
                        break;
                    case AdLayout.Top:
                        container.Orientation = Orientation.Horizontal;
                        container.Panel1.Controls.Add(adCtrl);
                        container.Panel2.Controls.Add(viewMapCtrl);
                        break;
                }

                panelLayout.Controls.Add(container);
            } else {
                panelLayout.Controls.Add(viewMapCtrl);
            }
        }

        private Control CreateViewAndMapControls() {
            Control ctrl = null;
            if (LayoutSettings.Instance.ViewMapLayout == ViewMapLayout.ViewOnly ||
                LayoutSettings.Instance.ViewMapLayout == ViewMapLayout.MapOnly) {
                if (LayoutSettings.Instance.ViewMapLayout == ViewMapLayout.ViewOnly) {
                    ctrl = CreatePreviewControl("view");
                } else if (LayoutSettings.Instance.ViewMapLayout == ViewMapLayout.MapOnly) {
                    ctrl = CreatePreviewControl("map");
                }
            } else {
                SplitContainer container = new SplitContainer();
                container.SplitterDistance = container.Width / 2;
                container.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;

                Control viewCtrl = CreatePreviewControl("view");
                Control mapCtrl = CreatePreviewControl("map");

                switch (LayoutSettings.Instance.ViewMapLayout) {
                    case ViewMapLayout.ViewLeftMapRight:
                        container.Panel1.Controls.Add(viewCtrl);
                        container.Panel2.Controls.Add(mapCtrl);
                        break;
                    case ViewMapLayout.ViewRightMapLeft:
                        container.Panel1.Controls.Add(mapCtrl);
                        container.Panel2.Controls.Add(viewCtrl);
                        break;
                    case ViewMapLayout.ViewTopMapBottom:
                        container.Orientation = Orientation.Horizontal;
                        container.Panel1.Controls.Add(viewCtrl);
                        container.Panel2.Controls.Add(mapCtrl);
                        break;
                    case ViewMapLayout.ViewBottomMapTop:
                        container.Orientation = Orientation.Horizontal;
                        container.Panel1.Controls.Add(mapCtrl);
                        container.Panel2.Controls.Add(viewCtrl);
                        break;
                }

                ctrl = container;
            }

            ctrl.Dock = DockStyle.Fill;

            return ctrl;
        }

        private Control CreatePreviewControl(string type) {
            PictureBox pb = new PictureBox();
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Dock = DockStyle.Fill;
            pb.Width = pb.Width; // TODO:
            pb.Height = pb.Height;// TODO:

            switch (type) {
                case "map":
                    pb.Image = Properties.Resources.mapLayoutSettings;
                    break;
                case "view":
                    pb.Image = Properties.Resources.viewLayoutSettings;
                    break;
                case "ad":
                    pb.Image = Properties.Resources.adsLayoutSettings;
                    break;
            }

            return pb;
        }

    }
}
