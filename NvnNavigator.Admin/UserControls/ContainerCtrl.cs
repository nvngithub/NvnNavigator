using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NvnNavigator.Common;
using System.IO;
using System.Reflection;

namespace NvnNavigator.Admin {
    public partial class ContainerCtrl : UserControl {

        public ContainerCtrl() {
            InitializeComponent();

            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            applicationNameCtrl1.Version = version.Major + "." + version.Minor;
        }

        public void LoadControl(string projectPath) {
            LoadProject(projectPath);
        }

        private void LoadProject(string selectedPath) {
            Globals.ProjectDir = selectedPath;
            Globals.NavigatorPlace = LoadSave.Load(Globals.ProjectFile);

            // Settings control
            settingsCtrl1.LoadControl();

            // Shops control
            listingContainerCtrl1.LoadControl();

            // Ads configuration control
            adConfigContainerCtrl1.LoadControl();

            // Image editor control
            imageEditorCtrl1.ProjectImagePath = Globals.ImagesDir;
            imageEditorCtrl1.CurrentPlace = Globals.NavigatorPlace;
            imageEditorCtrl1.CurrentPath = imageEditorCtrl1.CurrentPlace.Paths[0];
            imageEditorCtrl1.CurrentPoint = imageEditorCtrl1.CurrentPlace.Paths[0].Points[0];
            imageEditorCtrl1.CurrentAngle = 0;
            imageEditorCtrl1.StartRealView();

            // Hotspots control
            hotSpotContainerCtrl1.LoadControl();
        }
    }
}
