using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NvnNavigator.Common;
using System.IO;

namespace NvnNavigator.Admin {
    internal partial class ImageSelectorCtrl : UserControl {
        public ImageSelectorCtrl() {
            InitializeComponent();

            navigationViewerCtrl1.ImageChanged += new EventHandler(navigationViewerCtrl1_ImageChanged);
        }

        public NavigatorPlace CurrentPlace {
            get { return navigationViewerCtrl1.CurrentPlace; }
            set { navigationViewerCtrl1.CurrentPlace = value; }
        }

        public NavigatorPath CurrentPath {
            get { return navigationViewerCtrl1.CurrentPath; }
            set { navigationViewerCtrl1.CurrentPath = value; }
        }

        public NavigatorPoint CurrentPoint {
            get { return navigationViewerCtrl1.CurrentPoint; }
            set { navigationViewerCtrl1.CurrentPoint = value; }
        }

        public int CurrentAngle {
            get { return navigationViewerCtrl1.CurrentAngle; }
            set { navigationViewerCtrl1.CurrentAngle = value; }
        }

        public string ProjectImagePath {
            set { navigationViewerCtrl1.ProjectImagePath = value; }
        }

        public void StartRealView() {
            navigationViewerCtrl1.StartViewer();
        }

        void navigationViewerCtrl1_ImageChanged(object sender, EventArgs e) {
            ShowCurrentImage();
            ShowPastImages();
        }

        private void lnkSelectNewImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image files (.jpg, .jpeg, .bmp, .gif, .png)|*.jpg;*.jpeg;*.bmp;*.gif;*.png";
            dlg.Multiselect = false;
            if (dlg.ShowDialog() == DialogResult.OK) {
                // rename current image (name#dd-MMM-yyyy seconds.extension)
                string curFile = navigationViewerCtrl1.CurrentImagePath;
                IOSupport.RenameFile(curFile, GetHistFilename(curFile));
                // rename selected image to be used for Navigator point
                IOSupport.CopyFile(dlg.FileName, curFile);
                
                ShowCurrentImage();
                ShowPastImages();

                navigationViewerCtrl1.RefreshCurrentImage();
            }
        }

        private void ShowCurrentImage() {
            pbCurrentImage.Image = ImageLoader.GetImageFromFile(navigationViewerCtrl1.CurrentImagePath, pbCurrentImage.Width, pbCurrentImage.Height);
        }

        private void ShowPastImages() {
            string dir = Path.GetDirectoryName(navigationViewerCtrl1.CurrentImagePath);
            string imageName = Path.GetFileNameWithoutExtension(navigationViewerCtrl1.CurrentImagePath);
            pnlImageHistory.Controls.Clear();

            string[] files = Directory.GetFiles(dir, imageName + "#*.*");
            files = SortFiles(files);
            for (int i = files.Length - 1; i >= 0; i--) {
                string file = files[i];
                pnlImageHistory.Controls.Add(CreateHistCtrl(file));
            }
        }

        // sort files based on date deleted
        private string[] SortFiles(string[] files) { 
            Dictionary<DateTime, string> dateFileMapping = new Dictionary<DateTime, string>();
            foreach (string file in files) {
                dateFileMapping.Add(Convert.ToDateTime((Path.GetFileNameWithoutExtension(file).Split("#".ToCharArray())[1]).Replace("@", "/").Replace("$",":")), file);
            }

            List<DateTime> times = new List<DateTime>(dateFileMapping.Keys);
            times.Sort();

            List<string> sortedFiles = new List<string>();
            foreach (DateTime datetime in times) {
                sortedFiles.Add(dateFileMapping[datetime]);
            }

            return sortedFiles.ToArray();
        }

        private string GetHistFilename(string filename) {
            return Path.GetDirectoryName(filename) + "\\" + Path.GetFileNameWithoutExtension(filename) + "#" + DateTime.Now.ToString().Replace("/", "@").Replace(":", "$") + Path.GetExtension(filename);
        }

        private ImageSelectorHistItemCtrl CreateHistCtrl(string imagePath) {
            ImageSelectorHistItemCtrl histItemCtrl = new ImageSelectorHistItemCtrl();
            histItemCtrl.ImagePath = imagePath;
            histItemCtrl.LoadControl();
            histItemCtrl.HistImageSelected += new EventHandler(histItemCtrl_HistImageSelected);
            histItemCtrl.DeleteHistImageSelected += new EventHandler(histItemCtrl_DeleteHistImageSelected);

            return histItemCtrl;
        }

        void histItemCtrl_HistImageSelected(object sender, EventArgs e) {
            ImageSelectorHistItemCtrl ctrl = (ImageSelectorHistItemCtrl)sender;

            // rename current to history file
            string curFile = navigationViewerCtrl1.CurrentImagePath;
            IOSupport.RenameFile(curFile, GetHistFilename(curFile));

            // use selected image
            IOSupport.RenameFile(ctrl.ImagePath, curFile);

            ShowCurrentImage();
            ShowPastImages();

            navigationViewerCtrl1.RefreshCurrentImage();
        }

        void histItemCtrl_DeleteHistImageSelected(object sender, EventArgs e) {
            ImageSelectorHistItemCtrl ctrl = (ImageSelectorHistItemCtrl)sender;
            if (pnlImageHistory.Controls.Contains(ctrl)) {
                pnlImageHistory.Controls.Remove(ctrl);
            }

            IOSupport.DeleteFile(ctrl.ImagePath);
        }
    }
}