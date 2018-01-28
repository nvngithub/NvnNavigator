namespace NvnNavigator.Admin {
    partial class YouAreHereLocationCtrl {
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
            this.pbYouAreHereImage = new System.Windows.Forms.PictureBox();
            this.btnDefineYouAreHere = new DotNetSkin.SkinControls.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbYouAreHereImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbYouAreHereImage
            // 
            this.pbYouAreHereImage.Location = new System.Drawing.Point(9, 8);
            this.pbYouAreHereImage.Name = "pbYouAreHereImage";
            this.pbYouAreHereImage.Size = new System.Drawing.Size(100, 50);
            this.pbYouAreHereImage.TabIndex = 1;
            this.pbYouAreHereImage.TabStop = false;
            // 
            // btnDefineYouAreHere
            // 
            this.btnDefineYouAreHere.Location = new System.Drawing.Point(154, 24);
            this.btnDefineYouAreHere.Name = "btnDefineYouAreHere";
            this.btnDefineYouAreHere.Size = new System.Drawing.Size(155, 23);
            this.btnDefineYouAreHere.TabIndex = 2;
            this.btnDefineYouAreHere.Text = "You are here !!!";
            this.btnDefineYouAreHere.UseVisualStyleBackColor = true;
            this.btnDefineYouAreHere.Click += new System.EventHandler(this.btnDefineYouAreHere_Click);
            // 
            // YouAreHereLocationCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDefineYouAreHere);
            this.Controls.Add(this.pbYouAreHereImage);
            this.Name = "YouAreHereLocationCtrl";
            this.Size = new System.Drawing.Size(514, 70);
            ((System.ComponentModel.ISupportInitialize)(this.pbYouAreHereImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbYouAreHereImage;
        private DotNetSkin.SkinControls.SkinButton btnDefineYouAreHere;
    }
}
