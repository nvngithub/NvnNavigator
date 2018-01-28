namespace NvnNavigator.Common {
    partial class ListingConfigItemCtrl {
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
            this.pbShopIcon = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lnkEdit = new System.Windows.Forms.LinkLabel();
            this.lnkDelete = new System.Windows.Forms.LinkLabel();
            this.lblTagline = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbShopIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pbShopIcon
            // 
            this.pbShopIcon.Location = new System.Drawing.Point(3, 4);
            this.pbShopIcon.Name = "pbShopIcon";
            this.pbShopIcon.Size = new System.Drawing.Size(50, 28);
            this.pbShopIcon.TabIndex = 0;
            this.pbShopIcon.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(59, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lnkEdit
            // 
            this.lnkEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkEdit.AutoSize = true;
            this.lnkEdit.Location = new System.Drawing.Point(255, 11);
            this.lnkEdit.Name = "lnkEdit";
            this.lnkEdit.Size = new System.Drawing.Size(25, 13);
            this.lnkEdit.TabIndex = 3;
            this.lnkEdit.TabStop = true;
            this.lnkEdit.Text = "Edit";
            this.lnkEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEdit_LinkClicked);
            // 
            // lnkDelete
            // 
            this.lnkDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkDelete.AutoSize = true;
            this.lnkDelete.Location = new System.Drawing.Point(298, 11);
            this.lnkDelete.Name = "lnkDelete";
            this.lnkDelete.Size = new System.Drawing.Size(38, 13);
            this.lnkDelete.TabIndex = 4;
            this.lnkDelete.TabStop = true;
            this.lnkDelete.Text = "Delete";
            this.lnkDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDelete_LinkClicked);
            // 
            // lblTagline
            // 
            this.lblTagline.AutoSize = true;
            this.lblTagline.Location = new System.Drawing.Point(59, 19);
            this.lblTagline.Name = "lblTagline";
            this.lblTagline.Size = new System.Drawing.Size(42, 13);
            this.lblTagline.TabIndex = 5;
            this.lblTagline.Text = "Tagline";
            // 
            // ListingConfigItemCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTagline);
            this.Controls.Add(this.lnkDelete);
            this.Controls.Add(this.lnkEdit);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbShopIcon);
            this.Name = "ListingConfigItemCtrl";
            this.Size = new System.Drawing.Size(350, 35);
            ((System.ComponentModel.ISupportInitialize)(this.pbShopIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbShopIcon;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.LinkLabel lnkEdit;
        private System.Windows.Forms.LinkLabel lnkDelete;
        private System.Windows.Forms.Label lblTagline;
    }
}
