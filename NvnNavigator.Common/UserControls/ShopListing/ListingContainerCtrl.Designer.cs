namespace NvnNavigator.Common {
    partial class ListingContainerCtrl {
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listingConfigCtrl1 = new NvnNavigator.Common.ListingConfigCtrl();
            this.btnChangeFloorSettings = new DotNetSkin.SkinControls.SkinButton();
            this.btnChangeCategorySettings = new DotNetSkin.SkinControls.SkinButton();
            this.listingViewContainerCtrl1 = new NvnNavigator.Common.ListingViewContainerCtrl();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listingConfigCtrl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnChangeFloorSettings);
            this.splitContainer1.Panel2.Controls.Add(this.btnChangeCategorySettings);
            this.splitContainer1.Panel2.Controls.Add(this.listingViewContainerCtrl1);
            this.splitContainer1.Size = new System.Drawing.Size(952, 548);
            this.splitContainer1.SplitterDistance = 477;
            this.splitContainer1.TabIndex = 0;
            // 
            // listingConfigCtrl1
            // 
            this.listingConfigCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listingConfigCtrl1.Location = new System.Drawing.Point(0, 0);
            this.listingConfigCtrl1.Name = "listingConfigCtrl1";
            this.listingConfigCtrl1.Size = new System.Drawing.Size(473, 544);
            this.listingConfigCtrl1.TabIndex = 0;
            // 
            // btnChangeFloorSettings
            // 
            this.btnChangeFloorSettings.Location = new System.Drawing.Point(196, 10);
            this.btnChangeFloorSettings.Name = "btnChangeFloorSettings";
            this.btnChangeFloorSettings.Size = new System.Drawing.Size(162, 23);
            this.btnChangeFloorSettings.TabIndex = 4;
            this.btnChangeFloorSettings.Text = "Change floor settings";
            this.btnChangeFloorSettings.UseVisualStyleBackColor = true;
            this.btnChangeFloorSettings.Click += new System.EventHandler(this.btnChangeFloorSettings_Click);
            // 
            // btnChangeCategorySettings
            // 
            this.btnChangeCategorySettings.Location = new System.Drawing.Point(28, 10);
            this.btnChangeCategorySettings.Name = "btnChangeCategorySettings";
            this.btnChangeCategorySettings.Size = new System.Drawing.Size(162, 23);
            this.btnChangeCategorySettings.TabIndex = 3;
            this.btnChangeCategorySettings.Text = "Change category settings";
            this.btnChangeCategorySettings.UseVisualStyleBackColor = true;
            this.btnChangeCategorySettings.Click += new System.EventHandler(this.btnChangeCategorySettings_Click);
            // 
            // listingViewContainerCtrl1
            // 
            this.listingViewContainerCtrl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listingViewContainerCtrl1.Location = new System.Drawing.Point(3, 49);
            this.listingViewContainerCtrl1.Name = "listingViewContainerCtrl1";
            this.listingViewContainerCtrl1.Size = new System.Drawing.Size(461, 377);
            this.listingViewContainerCtrl1.TabIndex = 0;
            // 
            // ListingContainerCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ListingContainerCtrl";
            this.Size = new System.Drawing.Size(952, 548);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private ListingConfigCtrl listingConfigCtrl1;
        private ListingViewContainerCtrl listingViewContainerCtrl1;
        private DotNetSkin.SkinControls.SkinButton btnChangeCategorySettings;
        private DotNetSkin.SkinControls.SkinButton btnChangeFloorSettings;
    }
}