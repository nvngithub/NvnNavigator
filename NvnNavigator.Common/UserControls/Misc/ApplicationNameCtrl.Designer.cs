namespace NvnNavigator.Common {
    partial class ApplicationNameCtrl {
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
            this.lblApplicationModuleName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblAppName = new System.Windows.Forms.Label();
            this.pbAppLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApplicationModuleName
            // 
            this.lblApplicationModuleName.AutoSize = true;
            this.lblApplicationModuleName.Location = new System.Drawing.Point(70, 27);
            this.lblApplicationModuleName.Name = "lblApplicationModuleName";
            this.lblApplicationModuleName.Size = new System.Drawing.Size(67, 13);
            this.lblApplicationModuleName.TabIndex = 11;
            this.lblApplicationModuleName.Text = "Administrator";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(154, 27);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(42, 13);
            this.lblVersion.TabIndex = 10;
            this.lblVersion.Text = "Version";
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(69, 7);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(92, 20);
            this.lblAppName.TabIndex = 9;
            this.lblAppName.Text = "App Name";
            // 
            // pbAppLogo
            // 
            this.pbAppLogo.Location = new System.Drawing.Point(3, 7);
            this.pbAppLogo.Name = "pbAppLogo";
            this.pbAppLogo.Size = new System.Drawing.Size(60, 43);
            this.pbAppLogo.TabIndex = 8;
            this.pbAppLogo.TabStop = false;
            // 
            // ApplicationNameCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblApplicationModuleName);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.pbAppLogo);
            this.Name = "ApplicationNameCtrl";
            this.Size = new System.Drawing.Size(275, 57);
            ((System.ComponentModel.ISupportInitialize)(this.pbAppLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApplicationModuleName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.PictureBox pbAppLogo;
    }
}
