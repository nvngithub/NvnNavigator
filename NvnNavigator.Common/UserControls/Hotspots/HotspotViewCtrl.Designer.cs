namespace NvnNavigator.Common {
    partial class HotspotViewCtrl {
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
            this.btnShps = new System.Windows.Forms.Button();
            this.pnlHotspots = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnShps
            // 
            this.btnShps.Location = new System.Drawing.Point(3, 17);
            this.btnShps.Name = "btnShps";
            this.btnShps.Size = new System.Drawing.Size(75, 23);
            this.btnShps.TabIndex = 0;
            this.btnShps.Text = "Shps";
            this.btnShps.UseVisualStyleBackColor = true;
            // 
            // pnlHotspots
            // 
            this.pnlHotspots.Location = new System.Drawing.Point(84, 3);
            this.pnlHotspots.Name = "pnlHotspots";
            this.pnlHotspots.Size = new System.Drawing.Size(603, 55);
            this.pnlHotspots.TabIndex = 1;
            // 
            // FooterCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlHotspots);
            this.Controls.Add(this.btnShps);
            this.Name = "FooterCtrl";
            this.Size = new System.Drawing.Size(690, 61);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShps;
        private System.Windows.Forms.FlowLayoutPanel pnlHotspots;
    }
}