namespace NvnNavigator.Common {
    partial class ListingViewContainerCtrl {
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
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.listingCtrl1 = new NvnNavigator.Common.ListingViewCtrl();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackgroundImage = global::NvnNavigator.Common.Properties.Resources.Close;
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbClose.Location = new System.Drawing.Point(508, 25);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(33, 28);
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // listingCtrl1
            // 
            this.listingCtrl1.BackColor = System.Drawing.Color.Transparent;
            this.listingCtrl1.Location = new System.Drawing.Point(4, 36);
            this.listingCtrl1.Name = "listingCtrl1";
            this.listingCtrl1.Size = new System.Drawing.Size(537, 378);
            this.listingCtrl1.TabIndex = 2;
            // 
            // ListingViewContainerCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.listingCtrl1);
            this.Name = "ListingViewContainerCtrl";
            this.Size = new System.Drawing.Size(554, 437);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClose;
        private ListingViewCtrl listingCtrl1;
    }
}