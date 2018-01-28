namespace NvnNavigator.Admin {
    partial class ImageSelectorHistItemCtrl {
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
            this.pbCurrentImage = new System.Windows.Forms.PictureBox();
            this.lnkUseItAgain = new System.Windows.Forms.LinkLabel();
            this.lnkDelete = new System.Windows.Forms.LinkLabel();
            this.lblUpdateDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCurrentImage
            // 
            this.pbCurrentImage.Location = new System.Drawing.Point(3, 22);
            this.pbCurrentImage.Name = "pbCurrentImage";
            this.pbCurrentImage.Size = new System.Drawing.Size(130, 74);
            this.pbCurrentImage.TabIndex = 3;
            this.pbCurrentImage.TabStop = false;
            this.pbCurrentImage.DoubleClick += new System.EventHandler(this.pbCurrentImage_DoubleClick);
            // 
            // lnkUseItAgain
            // 
            this.lnkUseItAgain.AutoSize = true;
            this.lnkUseItAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkUseItAgain.Location = new System.Drawing.Point(3, 99);
            this.lnkUseItAgain.Name = "lnkUseItAgain";
            this.lnkUseItAgain.Size = new System.Drawing.Size(125, 13);
            this.lnkUseItAgain.TabIndex = 4;
            this.lnkUseItAgain.TabStop = true;
            this.lnkUseItAgain.Text = "Use this image again";
            this.lnkUseItAgain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUseItAgain_LinkClicked);
            // 
            // lnkDelete
            // 
            this.lnkDelete.AutoSize = true;
            this.lnkDelete.Location = new System.Drawing.Point(3, 115);
            this.lnkDelete.Name = "lnkDelete";
            this.lnkDelete.Size = new System.Drawing.Size(85, 13);
            this.lnkDelete.TabIndex = 5;
            this.lnkDelete.TabStop = true;
            this.lnkDelete.Text = "Delete it for ever";
            this.lnkDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDelete_LinkClicked);
            // 
            // lblUpdateDate
            // 
            this.lblUpdateDate.AutoSize = true;
            this.lblUpdateDate.Location = new System.Drawing.Point(3, 6);
            this.lblUpdateDate.Name = "lblUpdateDate";
            this.lblUpdateDate.Size = new System.Drawing.Size(65, 13);
            this.lblUpdateDate.TabIndex = 7;
            this.lblUpdateDate.Text = "Deleted on: ";
            // 
            // ImageSelectorHistItemCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblUpdateDate);
            this.Controls.Add(this.lnkDelete);
            this.Controls.Add(this.lnkUseItAgain);
            this.Controls.Add(this.pbCurrentImage);
            this.Name = "ImageSelectorHistItemCtrl";
            this.Size = new System.Drawing.Size(141, 134);
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCurrentImage;
        private System.Windows.Forms.LinkLabel lnkUseItAgain;
        private System.Windows.Forms.LinkLabel lnkDelete;
        private System.Windows.Forms.Label lblUpdateDate;
    }
}
