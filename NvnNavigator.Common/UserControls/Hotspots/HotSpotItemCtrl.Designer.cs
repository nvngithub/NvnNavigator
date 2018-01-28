namespace NvnNavigator.Common {
    partial class HotSpotItemCtrl {
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
            this.lnkAssign = new System.Windows.Forms.LinkLabel();
            this.lnkDelete = new System.Windows.Forms.LinkLabel();
            this.pbPreviewImage = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkAssign
            // 
            this.lnkAssign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkAssign.AutoSize = true;
            this.lnkAssign.Location = new System.Drawing.Point(231, 22);
            this.lnkAssign.Name = "lnkAssign";
            this.lnkAssign.Size = new System.Drawing.Size(38, 13);
            this.lnkAssign.TabIndex = 0;
            this.lnkAssign.TabStop = true;
            this.lnkAssign.Text = "Assign";
            this.lnkAssign.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAssign_LinkClicked);
            // 
            // lnkDelete
            // 
            this.lnkDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkDelete.AutoSize = true;
            this.lnkDelete.ForeColor = System.Drawing.Color.Red;
            this.lnkDelete.LinkColor = System.Drawing.Color.Red;
            this.lnkDelete.Location = new System.Drawing.Point(289, 22);
            this.lnkDelete.Name = "lnkDelete";
            this.lnkDelete.Size = new System.Drawing.Size(38, 13);
            this.lnkDelete.TabIndex = 1;
            this.lnkDelete.TabStop = true;
            this.lnkDelete.Text = "Delete";
            this.lnkDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDelete_LinkClicked);
            // 
            // pbPreviewImage
            // 
            this.pbPreviewImage.Location = new System.Drawing.Point(3, 3);
            this.pbPreviewImage.Name = "pbPreviewImage";
            this.pbPreviewImage.Size = new System.Drawing.Size(88, 50);
            this.pbPreviewImage.TabIndex = 2;
            this.pbPreviewImage.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(98, 21);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(109, 13);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "No location assigned.";
            // 
            // HotSpotItemCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pbPreviewImage);
            this.Controls.Add(this.lnkDelete);
            this.Controls.Add(this.lnkAssign);
            this.Name = "HotSpotItemCtrl";
            this.Size = new System.Drawing.Size(353, 61);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkAssign;
        private System.Windows.Forms.LinkLabel lnkDelete;
        private System.Windows.Forms.PictureBox pbPreviewImage;
        private System.Windows.Forms.Label lblMessage;
    }
}