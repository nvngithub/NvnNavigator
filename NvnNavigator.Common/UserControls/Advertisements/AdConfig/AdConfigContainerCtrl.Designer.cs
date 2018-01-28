namespace NvnNavigator.Common {
    partial class AdConfigContainerCtrl {
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
            this.adConfigCtrl = new NvnNavigator.Common.AdConfigCtrl();
            this.adViewCtrl1 = new NvnNavigator.Common.AdViewCtrl();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.adConfigCtrl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.adViewCtrl1);
            this.splitContainer1.Size = new System.Drawing.Size(795, 604);
            this.splitContainer1.SplitterDistance = 528;
            this.splitContainer1.TabIndex = 0;
            // 
            // adConfigCtrl
            // 
            this.adConfigCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adConfigCtrl.Location = new System.Drawing.Point(0, 0);
            this.adConfigCtrl.Name = "adConfigCtrl";
            this.adConfigCtrl.Size = new System.Drawing.Size(528, 604);
            this.adConfigCtrl.TabIndex = 0;
            // 
            // adViewCtrl1
            // 
            this.adViewCtrl1.Location = new System.Drawing.Point(14, 14);
            this.adViewCtrl1.Name = "adViewCtrl1";
            this.adViewCtrl1.Size = new System.Drawing.Size(236, 492);
            this.adViewCtrl1.TabIndex = 0;
            // 
            // AdConfigContainerCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "AdConfigContainerCtrl";
            this.Size = new System.Drawing.Size(795, 604);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private AdViewCtrl adViewCtrl1;
        private AdConfigCtrl adConfigCtrl;
    }
}