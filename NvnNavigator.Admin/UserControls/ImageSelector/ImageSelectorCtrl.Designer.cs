namespace NvnNavigator.Admin {
    partial class ImageSelectorCtrl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.pbCurrentImage = new System.Windows.Forms.PictureBox();
            this.pnlImageHistory = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkSelectNewImage = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.navigationViewerCtrl1 = new NvnNavigator.Common.NavigationViewerCtrl();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(780, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Image";
            // 
            // pbCurrentImage
            // 
            this.pbCurrentImage.Location = new System.Drawing.Point(783, 57);
            this.pbCurrentImage.Name = "pbCurrentImage";
            this.pbCurrentImage.Size = new System.Drawing.Size(130, 74);
            this.pbCurrentImage.TabIndex = 2;
            this.pbCurrentImage.TabStop = false;
            // 
            // pnlImageHistory
            // 
            this.pnlImageHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlImageHistory.AutoScroll = true;
            this.pnlImageHistory.Location = new System.Drawing.Point(770, 176);
            this.pnlImageHistory.Name = "pnlImageHistory";
            this.pnlImageHistory.Size = new System.Drawing.Size(176, 310);
            this.pnlImageHistory.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(767, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Past images";
            // 
            // lnkSelectNewImage
            // 
            this.lnkSelectNewImage.AutoSize = true;
            this.lnkSelectNewImage.Location = new System.Drawing.Point(780, 134);
            this.lnkSelectNewImage.Name = "lnkSelectNewImage";
            this.lnkSelectNewImage.Size = new System.Drawing.Size(91, 13);
            this.lnkSelectNewImage.TabIndex = 5;
            this.lnkSelectNewImage.TabStop = true;
            this.lnkSelectNewImage.Text = "Select new image";
            this.lnkSelectNewImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSelectNewImage_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(767, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Double click image to view larger image";
            // 
            // navigationViewerCtrl1
            // 
            this.navigationViewerCtrl1.CurrentAngle = 0;
            this.navigationViewerCtrl1.CurrentPath = null;
            this.navigationViewerCtrl1.CurrentPlace = null;
            this.navigationViewerCtrl1.CurrentPoint = null;
            this.navigationViewerCtrl1.Location = new System.Drawing.Point(3, 3);
            this.navigationViewerCtrl1.Name = "navigationViewerCtrl1";
            this.navigationViewerCtrl1.Size = new System.Drawing.Size(758, 538);
            this.navigationViewerCtrl1.TabIndex = 0;
            // 
            // ImageSelectorCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnkSelectNewImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlImageHistory);
            this.Controls.Add(this.pbCurrentImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navigationViewerCtrl1);
            this.Name = "ImageSelectorCtrl";
            this.Size = new System.Drawing.Size(953, 548);
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NvnNavigator.Common.NavigationViewerCtrl navigationViewerCtrl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCurrentImage;
        private System.Windows.Forms.FlowLayoutPanel pnlImageHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkSelectNewImage;
        private System.Windows.Forms.Label label3;

    }
}
