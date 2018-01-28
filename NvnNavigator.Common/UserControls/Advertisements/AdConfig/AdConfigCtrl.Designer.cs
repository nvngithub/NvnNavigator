namespace NvnNavigator.Common {
    partial class AdConfigCtrl {
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
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.pnlConfigItems = new System.Windows.Forms.FlowLayoutPanel();
            this.pbSelectedImage = new System.Windows.Forms.PictureBox();
            this.btnAddAdvertisement = new DotNetSkin.SkinControls.SkinButton();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btnAddAdvertisement);
            this.splitContainer3.Panel1.Controls.Add(this.pnlConfigItems);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.pbSelectedImage);
            this.splitContainer3.Size = new System.Drawing.Size(584, 474);
            this.splitContainer3.SplitterDistance = 355;
            this.splitContainer3.TabIndex = 2;
            // 
            // pnlConfigItems
            // 
            this.pnlConfigItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConfigItems.AutoScroll = true;
            this.pnlConfigItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlConfigItems.Location = new System.Drawing.Point(3, 32);
            this.pnlConfigItems.Name = "pnlConfigItems";
            this.pnlConfigItems.Size = new System.Drawing.Size(349, 439);
            this.pnlConfigItems.TabIndex = 0;
            // 
            // pbSelectedImage
            // 
            this.pbSelectedImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSelectedImage.Location = new System.Drawing.Point(9, 19);
            this.pbSelectedImage.Name = "pbSelectedImage";
            this.pbSelectedImage.Size = new System.Drawing.Size(206, 452);
            this.pbSelectedImage.TabIndex = 0;
            this.pbSelectedImage.TabStop = false;
            // 
            // btnAddAdvertisement
            // 
            this.btnAddAdvertisement.Location = new System.Drawing.Point(3, 3);
            this.btnAddAdvertisement.Name = "btnAddAdvertisement";
            this.btnAddAdvertisement.Size = new System.Drawing.Size(166, 23);
            this.btnAddAdvertisement.TabIndex = 1;
            this.btnAddAdvertisement.Text = "Add new advertisement";
            this.btnAddAdvertisement.UseVisualStyleBackColor = true;
            this.btnAddAdvertisement.Click += new System.EventHandler(this.btnAddAdvertisement_Click);
            // 
            // AdConfigCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer3);
            this.Name = "AdConfigCtrl";
            this.Size = new System.Drawing.Size(584, 474);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.FlowLayoutPanel pnlConfigItems;
        private System.Windows.Forms.PictureBox pbSelectedImage;
        private DotNetSkin.SkinControls.SkinButton btnAddAdvertisement;
    }
}