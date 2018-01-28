namespace NvnNavigator.Common {
    partial class AdViewCtrl {
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
            this.pbAd = new System.Windows.Forms.PictureBox();
            this.logoViewCtrl1 = new NvnNavigator.Common.LogoViewCtrl();
            ((System.ComponentModel.ISupportInitialize)(this.pbAd)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAd
            // 
            this.pbAd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAd.Location = new System.Drawing.Point(3, 3);
            this.pbAd.Name = "pbAd";
            this.pbAd.Size = new System.Drawing.Size(230, 417);
            this.pbAd.TabIndex = 1;
            this.pbAd.TabStop = false;
            // 
            // logoViewCtrl1
            // 
            this.logoViewCtrl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.logoViewCtrl1.Location = new System.Drawing.Point(0, 426);
            this.logoViewCtrl1.Name = "logoViewCtrl1";
            this.logoViewCtrl1.Size = new System.Drawing.Size(236, 70);
            this.logoViewCtrl1.TabIndex = 0;
            // 
            // AdViewCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbAd);
            this.Controls.Add(this.logoViewCtrl1);
            this.Name = "AdViewCtrl";
            this.Size = new System.Drawing.Size(236, 496);
            ((System.ComponentModel.ISupportInitialize)(this.pbAd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LogoViewCtrl logoViewCtrl1;
        private System.Windows.Forms.PictureBox pbAd;
    }
}