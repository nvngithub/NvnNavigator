namespace NvnNavigator.Common {
    partial class HotSpotCtrl {
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
            this.pbImagePreview = new System.Windows.Forms.PictureBox();
            this.pnlHotSpotItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lblImageName = new System.Windows.Forms.Label();
            this.btnExpandCollapse = new System.Windows.Forms.Button();
            this.lnkAddNewLocation = new System.Windows.Forms.LinkLabel();
            this.btnBrowse = new DotNetSkin.SkinControls.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagePreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagePreview
            // 
            this.pbImagePreview.Location = new System.Drawing.Point(35, 3);
            this.pbImagePreview.Name = "pbImagePreview";
            this.pbImagePreview.Size = new System.Drawing.Size(79, 51);
            this.pbImagePreview.TabIndex = 1;
            this.pbImagePreview.TabStop = false;
            // 
            // pnlHotSpotItems
            // 
            this.pnlHotSpotItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHotSpotItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHotSpotItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlHotSpotItems.Location = new System.Drawing.Point(35, 60);
            this.pnlHotSpotItems.Name = "pnlHotSpotItems";
            this.pnlHotSpotItems.Size = new System.Drawing.Size(496, 252);
            this.pnlHotSpotItems.TabIndex = 2;
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageName.Location = new System.Drawing.Point(144, 16);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(110, 13);
            this.lblImageName.TabIndex = 3;
            this.lblImageName.Text = "<No file selected>";
            // 
            // btnExpandCollapse
            // 
            this.btnExpandCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandCollapse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpandCollapse.Location = new System.Drawing.Point(4, 16);
            this.btnExpandCollapse.Name = "btnExpandCollapse";
            this.btnExpandCollapse.Size = new System.Drawing.Size(25, 23);
            this.btnExpandCollapse.TabIndex = 5;
            this.btnExpandCollapse.Text = "-";
            this.btnExpandCollapse.UseVisualStyleBackColor = true;
            this.btnExpandCollapse.Click += new System.EventHandler(this.btnExpandCollapse_Click);
            // 
            // lnkAddNewLocation
            // 
            this.lnkAddNewLocation.AutoSize = true;
            this.lnkAddNewLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddNewLocation.Location = new System.Drawing.Point(32, 315);
            this.lnkAddNewLocation.Name = "lnkAddNewLocation";
            this.lnkAddNewLocation.Size = new System.Drawing.Size(105, 13);
            this.lnkAddNewLocation.TabIndex = 6;
            this.lnkAddNewLocation.TabStop = true;
            this.lnkAddNewLocation.Text = "Add new location";
            this.lnkAddNewLocation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddNewLocation_LinkClicked);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Location = new System.Drawing.Point(441, 11);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(90, 23);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // HotSpotCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lnkAddNewLocation);
            this.Controls.Add(this.btnExpandCollapse);
            this.Controls.Add(this.lblImageName);
            this.Controls.Add(this.pnlHotSpotItems);
            this.Controls.Add(this.pbImagePreview);
            this.Name = "HotSpotCtrl";
            this.Size = new System.Drawing.Size(534, 341);
            this.Click += new System.EventHandler(this.HotSpotCtrl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagePreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagePreview;
        private System.Windows.Forms.FlowLayoutPanel pnlHotSpotItems;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Button btnExpandCollapse;
        private System.Windows.Forms.LinkLabel lnkAddNewLocation;
        private DotNetSkin.SkinControls.SkinButton btnBrowse;
    }
}