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
    public partial class JunctionPointItemControl : UserControl {

        public event EventHandler JunctionPointDeleted;
        public event EventHandler JunctionPointSaved;
        private JunctionPoint junctionPoint;

        public JunctionPointItemControl() {
            InitializeComponent();
        }

        public JunctionPoint JunctionPoint {
            get { return junctionPoint; }
            set { junctionPoint = value; }
        }

        public string PathId {
            get { return txtPathId.Text; }
        }

        public void LoadProperties() {
            txtPathAngle.Text = junctionPoint.PathAngle.ToString();
            txtPathId.Text = junctionPoint.Path.Id;
            chkStartOrEnd.Checked = junctionPoint.StartOrEnd == StartOrEnd.Start ? true : false;
            // Load Images
            NavigatorPoint point = null;
            if (junctionPoint.StartOrEnd == StartOrEnd.Start) point = junctionPoint.Path.Points[0];
            else point = junctionPoint.Path.Points[junctionPoint.Path.Points.Count - 1];

            if (point != null) {
                string pathDir = Globals.ImagesDir + "\\"+junctionPoint.Path.Id+"\\";
                pbStraight.Image = ImageLoader.GetImageFromFile(pathDir + point.Img1, pbStraight.Width, pbStraight.Height);
                pbLeft.Image = ImageLoader.GetImageFromFile(pathDir + point.Img2, pbLeft.Width, pbLeft.Height);
                pbBehind.Image = ImageLoader.GetImageFromFile(pathDir + point.Img3, pbBehind.Width, pbBehind.Height);
                pbRight.Image = ImageLoader.GetImageFromFile(pathDir + point.Img4, pbRight.Width, pbRight.Height);
                lbl1.Text = point.Img1; lbl2.Text = point.Img2; lbl3.Text = point.Img3; lbl4.Text = point.Img4;
            }
        }

        private void lnkSave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            junctionPoint.PathAngle = Int32.Parse(txtPathAngle.Text.Trim());
            junctionPoint.StartOrEnd = chkStartOrEnd.Checked ? StartOrEnd.Start : StartOrEnd.End;
            junctionPoint.Path = Globals.NavigatorPlace.GetPath(txtPathId.Text);

            if (JunctionPointSaved != null) {
                JunctionPointSaved(this, null);
            }
        }

        private void lnkDelete_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            if (JunctionPointDeleted != null) {
                JunctionPointDeleted(this, null);
            }
        }

        private void PointImage_DoubleClick(object sender, EventArgs e) {
            ImageForm imageForm = new NvnNavigator.Common.ImageForm();
            string pathDir = Globals.ImagesDir + "\\" + junctionPoint.Path.Id + "\\";
            if (((PictureBox)sender).Name == pbStraight.Name) {
                imageForm.LoadImage(pathDir + lbl1.Text);
            } else if (((PictureBox)sender).Name == pbLeft.Name) {
                imageForm.LoadImage(pathDir + lbl2.Text);
            } else if (((PictureBox)sender).Name == pbBehind.Name) {
                imageForm.LoadImage(pathDir + lbl3.Text);
            } else if (((PictureBox)sender).Name == pbRight.Name) {
                imageForm.LoadImage(pathDir + lbl4.Text);
            }

            imageForm.ShowDialog();
        }
    }
}
