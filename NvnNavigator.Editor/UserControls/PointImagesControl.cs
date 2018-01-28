using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using NvnNavigator.Common;

namespace NvnNavigator.Editor {
    public partial class PointImages : UserControl {

        private NavigatorPoint navigatorPoint;
        private NavigatorPath navigatorPath;

        public PointImages() {
            InitializeComponent();
        }

        public NavigatorPoint Point {
            get { return navigatorPoint; }
            set { navigatorPoint = value; }
        }

        public NavigatorPath NavigatorPath {
            get { return navigatorPath; }
            set { navigatorPath = value; }
        }

        public void LoadPointImages() {
            if (navigatorPoint != null) {
                string selectedPathLocation = Globals.ImagesDir + navigatorPath.Id + "\\";
                pbStraight.Image = ImageLoader.GetImageFromFile(selectedPathLocation + navigatorPoint.Img1, pbStraight.Width, pbStraight.Height);
                pbLeft.Image = ImageLoader.GetImageFromFile(selectedPathLocation + navigatorPoint.Img2, pbLeft.Width, pbLeft.Height);
                pbBehind.Image = ImageLoader.GetImageFromFile(selectedPathLocation + navigatorPoint.Img3, pbBehind.Width, pbBehind.Height);
                pbRight.Image = ImageLoader.GetImageFromFile(selectedPathLocation + navigatorPoint.Img4, pbRight.Width, pbRight.Height);

                if (pbStraight.Image == null) navigatorPoint.Img1 = string.Empty;
                if (pbLeft.Image == null) navigatorPoint.Img2 = string.Empty;
                if (pbBehind.Image == null) navigatorPoint.Img3 = string.Empty;
                if (pbRight.Image == null) navigatorPoint.Img4 = string.Empty;
            }
        }

        private void PictureBox_DoubleClick(object sender, EventArgs e) {
            PictureBox pictureBox = (PictureBox)sender;
            string selectedImageLocation = Globals.ImagesDir + navigatorPath.Id + "\\";
            if (pictureBox == pbStraight) selectedImageLocation += navigatorPoint.Img1;
            else if (pictureBox == pbLeft) selectedImageLocation += navigatorPoint.Img2;
            else if (pictureBox == pbBehind) selectedImageLocation += navigatorPoint.Img3;
            else if (pictureBox == pbRight) selectedImageLocation += navigatorPoint.Img4;

            ImageForm imageForm = new ImageForm();
            imageForm.LoadImage(selectedImageLocation);
            imageForm.ShowDialog();
        }

        private void SetLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            LinkLabel label = (LinkLabel)sender;

            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK) {
                if (label.Name == lnkSet1.Name) SetImage(0, dlg.FileName);
                else if (label.Name == lnkSet2.Name) SetImage(1, dlg.FileName);
                else if (label.Name == lnkSet3.Name) SetImage(2, dlg.FileName);
                else if (label.Name == lnkSet4.Name) SetImage(3, dlg.FileName);
            }
        }

        private void SetImage(int index, string filepath) {
            string fileName = navigatorPoint.Id + "-" + Path.GetFileName(filepath);
            string curFileName = string.Empty;

            // Set point image and picture box image
            switch (index) {
                case 0:
                    pbStraight.Image = ImageLoader.GetImageFromFile(filepath, pbStraight.Width, pbStraight.Height);
                    curFileName = navigatorPoint.Img1;
                    navigatorPoint.Img1 = fileName;
                    break;
                case 1:
                    pbLeft.Image = ImageLoader.GetImageFromFile(filepath, pbLeft.Width, pbLeft.Height); ;
                    curFileName = navigatorPoint.Img2;
                    navigatorPoint.Img2 = fileName;
                    break;
                case 2:
                    pbBehind.Image = ImageLoader.GetImageFromFile(filepath, pbBehind.Width, pbBehind.Height); ;
                    curFileName = navigatorPoint.Img3;
                    navigatorPoint.Img3 = fileName;
                    break;
                case 3:
                    pbRight.Image = ImageLoader.GetImageFromFile(filepath, pbRight.Width, pbRight.Height); ;
                    curFileName = navigatorPoint.Img4;
                    navigatorPoint.Img4 = fileName;
                    break;
            }

            
            string destinationDir = Globals.ImagesDir + navigatorPath.Id + "\\";

            IOSupport.CopyFile(filepath, destinationDir + fileName);

            // Rename old file name (filename to _filename)
            if (String.IsNullOrEmpty(curFileName) == false && File.Exists(destinationDir + curFileName)) {
                IOSupport.RenameFile(destinationDir + curFileName, destinationDir + "_" + curFileName);
            }
        }
    }
}
