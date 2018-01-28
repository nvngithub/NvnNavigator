using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    public partial class ImageForm : Form {
        private string imagePath = string.Empty;

        public ImageForm() {
            InitializeComponent();
        }

        public Image Image {
            set { pbImage.Image = value; }
        }

        public void LoadImage(string imagePath) {
            this.imagePath = imagePath;
            pbImage.Image = ImageLoader.GetImageFromFile(imagePath, pbImage.Width, pbImage.Height);
            pbImage.Refresh();
        }

        private void ImageForm_Resize(object sender, EventArgs e) {
            LoadImage(this.imagePath);
        }
    }
}