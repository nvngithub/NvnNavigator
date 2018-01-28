using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NvnNavigator.Common {
    public partial class HotSpotImageForm : Form {
        private Image selectedImage;
        private string selectedFile;
        private string selectedResourceImageFileName;
        private ImageList imageList = new ImageList();

        public HotSpotImageForm() {
            InitializeComponent();

            //// Load resource images into combo
            //imageList.Images.Add(Properties.Resources._1);
            //imageList.Images.Add(Properties.Resources._2);

            //cmbResourceImages.ImageList = imageList;
            //cmbResourceImages.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmbResourceImages.Items.Add(new ComboBoxExItem("Text0", 0));
            //cmbResourceImages.Items.Add(new ComboBoxExItem("Text1", 1));
        }

        public bool ResourceImageSelected {
            get { return rbChoseResourceImage.Checked; }
        }

        public Image SelectedImage {
            get { return selectedImage; }
            set { selectedImage = value; }
        }

        public string SelectedResourceImageFileName {
            get { return selectedResourceImageFileName; }
            set { selectedResourceImageFileName = value; }
        }

        public string SelectedFile {
            get { return selectedFile; }
            set { selectedFile = value; }
        }

        public void LoadForm(Image img) {
            pbHotSpotImage.Image = img;
        }

        private void rbChoseResourceImage_CheckedChanged(object sender, EventArgs e) {
            btnBrowse.Enabled = lblFilename.Enabled = false;
            cmbResourceImages.Enabled = true;

            if (rbChoseResourceImage.Checked && cmbResourceImages.SelectedItem != null) {
                pbHotSpotImage.Image = imageList.Images[cmbResourceImages.SelectedIndex];
            }
        }

        private void rbChooseNewFile_CheckedChanged(object sender, EventArgs e) {
            btnBrowse.Enabled = lblFilename.Enabled = true;
            cmbResourceImages.Enabled = false;

            if (rbChooseNewFile.Checked && String.IsNullOrEmpty(selectedFile) == false) {
                pbHotSpotImage.Image = ImageLoader.GetImageFromFile(selectedFile, pbHotSpotImage.Width, pbHotSpotImage.Height);
            }
        }

        private void cmbResourceImages_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbResourceImages.SelectedItem != null) {
                selectedImage = imageList.Images[cmbResourceImages.SelectedIndex];
                selectedResourceImageFileName = cmbResourceImages.Text;
                pbHotSpotImage.Image = selectedImage;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image files (.jpg, .jpeg, .bmp, .gif, .png)|*.jpg;*.jpeg;*.bmp;*.gif;*.png";
            dlg.Multiselect = false;
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (dlg.ShowDialog() == DialogResult.OK) {
                selectedFile = dlg.FileName;
                lblFilename.Text = selectedFile;

                pbHotSpotImage.Image = ImageLoader.GetImageFromFile(selectedFile, pbHotSpotImage.Width, pbHotSpotImage.Height);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}