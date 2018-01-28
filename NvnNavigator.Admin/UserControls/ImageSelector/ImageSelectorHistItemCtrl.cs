using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NvnNavigator.Common;

namespace NvnNavigator.Admin {
    internal partial class ImageSelectorHistItemCtrl : UserControl {

        public event EventHandler HistImageSelected;
        public event EventHandler DeleteHistImageSelected;

        private string imagePath;

        public ImageSelectorHistItemCtrl() {
            InitializeComponent();
        }

        public string ImagePath {
            get { return imagePath; }
            set { imagePath = value; }
        }

        public void LoadControl() {
            // Set deleted date
            string[] pathInfo = imagePath.Split("#".ToCharArray());
            if (pathInfo.Length > 1) {
                lblUpdateDate.Text += pathInfo[1].Split(" ".ToCharArray())[0].Replace("@","/");
            }
            // Load image
            pbCurrentImage.Image = ImageLoader.GetImageFromFile(imagePath, pbCurrentImage.Width, pbCurrentImage.Height);
        }

        private void pbCurrentImage_DoubleClick(object sender, EventArgs e) {
            ImageForm imageForm = new ImageForm();
            imageForm.LoadImage(imagePath);
            imageForm.ShowDialog();
        }

        private void lnkUseItAgain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (HistImageSelected != null) {
                HistImageSelected(this, null);
            }
        }

        private void lnkDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (DeleteHistImageSelected != null) {
                DeleteHistImageSelected(this, null);
            }
        }
    }
}
