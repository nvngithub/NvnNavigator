using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using NvnNavigator.Common;

namespace NvnNavigator.Editor {
    public partial class ImageCaptureControl : UserControl {

        private WebCamCapture webCam;
        private NavigatorPoint navigatorPoint;
        private NavigatorPath navigatorPath;

        public event EventHandler PointImagesUpdated;

        public ImageCaptureControl() {
            InitializeComponent();
        }

        public NavigatorPoint NavigatorPoint {
            get { return navigatorPoint; }
            set { navigatorPoint = value; }
        }

        public NavigatorPath NavigatorPath {
            get { return navigatorPath; }
            set { navigatorPath = value; }
        }

        public void LoadPointImages() {
            if (navigatorPoint != null) {
                string selectedPathLocation = Globals.ImagesDir + "\\" + navigatorPath.Id;
                pbStraight.Image = ImageLoader.GetImageFromFile(selectedPathLocation + "\\" + navigatorPoint.Img1, pbStraight.Width, pbStraight.Height);
                pbLeft.Image = ImageLoader.GetImageFromFile(selectedPathLocation + "\\" + navigatorPoint.Img2, pbLeft.Width, pbLeft.Height);
                pbBehind.Image = ImageLoader.GetImageFromFile(selectedPathLocation + "\\" + navigatorPoint.Img3, pbBehind.Width, pbBehind.Height);
                pbRight.Image = ImageLoader.GetImageFromFile(selectedPathLocation + "\\" + navigatorPoint.Img4, pbRight.Width, pbRight.Height);

                if (pbStraight.Image == null) navigatorPoint.Img1 = string.Empty;
                if (pbLeft.Image == null) navigatorPoint.Img2 = string.Empty;
                if (pbBehind.Image == null) navigatorPoint.Img3 = string.Empty;
                if (pbRight.Image == null) navigatorPoint.Img4 = string.Empty;
            }
        }

        private void AssignCapturedImage_Click(object sender, EventArgs e) {
            Button button = (Button)sender;
            if (button.Name == btnSetStraight.Name) {
                CaptureAndAssignImage(1);
            } else if (button.Name == btnSetLeft.Name) {
                CaptureAndAssignImage(2);
            } else if (button.Name == btnSetBehind.Name) {
                CaptureAndAssignImage(3);
            } else if (button.Name == btnSetRight.Name) {
                CaptureAndAssignImage(4);
            }
        }

        private void CaptureAndAssignImage(int index) {
            if (navigatorPoint != null && navigatorPath != null && webCam != null) {
                string newImageFileName = Globals.ImagesDir + navigatorPath.Id + "\\" + navigatorPoint.Id + "-" + Globals.GetUniqueId() + ".png";
                Image image = webCam.GetSnapShot();
                image.Save(newImageFileName, ImageFormat.Png);

                switch (index) {
                    case 1:
                        pbStraight.Image = ImageLoader.GetImageFromFile(newImageFileName, pbStraight.Width, pbStraight.Height);
                        navigatorPoint.Img1 = Path.GetFileName(newImageFileName);
                        break;
                    case 2:
                        pbLeft.Image = ImageLoader.GetImageFromFile(newImageFileName, pbLeft.Width, pbLeft.Height);
                        navigatorPoint.Img2 = Path.GetFileName(newImageFileName);
                        break;
                    case 3:
                        pbBehind.Image = ImageLoader.GetImageFromFile(newImageFileName, pbBehind.Width, pbBehind.Height);
                        navigatorPoint.Img3 = Path.GetFileName(newImageFileName);
                        break;
                    case 4:
                        pbRight.Image = ImageLoader.GetImageFromFile(newImageFileName, pbRight.Width, pbRight.Height);
                        navigatorPoint.Img4 = Path.GetFileName(newImageFileName);
                        break;
                }

                if (PointImagesUpdated != null) {
                    PointImagesUpdated(this, null);
                }
            }
        }

        private void lnkStart_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            webCam = new WebCamCapture();
            webCam.Container = pbLiveImage;
            webCam.OpenConnection();
        }

        private void lnkStop_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (webCam != null) {
                webCam.CloseConnection();
            }
        }

        public void ProcessKeyDownEvent(Keys keyData) {
            switch (keyData) {
                case Keys.D1:
                    CaptureAndAssignImage(1);
                    break;
                case Keys.D2:
                    CaptureAndAssignImage(2);
                    break;
                case Keys.D3:
                    CaptureAndAssignImage(3);
                    break;
                case Keys.D4:
                    CaptureAndAssignImage(4);
                    break;
            }
        }
    }
}
