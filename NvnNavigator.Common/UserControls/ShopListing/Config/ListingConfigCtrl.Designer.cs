namespace NvnNavigator.Common {
    partial class ListingConfigCtrl {
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
            this.pnlShopListing = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDeleteAll = new DotNetSkin.SkinControls.SkinButton();
            this.btnAdd = new DotNetSkin.SkinControls.SkinButton();
            this.SuspendLayout();
            // 
            // pnlShopListing
            // 
            this.pnlShopListing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlShopListing.Location = new System.Drawing.Point(3, 32);
            this.pnlShopListing.Name = "pnlShopListing";
            this.pnlShopListing.Size = new System.Drawing.Size(626, 467);
            this.pnlShopListing.TabIndex = 0;
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(99, 3);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(90, 23);
            this.btnDeleteAll.TabIndex = 2;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ListingConfigCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.pnlShopListing);
            this.Name = "ListingConfigCtrl";
            this.Size = new System.Drawing.Size(632, 502);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlShopListing;
        private DotNetSkin.SkinControls.SkinButton btnDeleteAll;
        private DotNetSkin.SkinControls.SkinButton btnAdd;
    }
}
