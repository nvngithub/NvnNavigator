namespace NvnNavigator.Common {
    partial class RealNavigationForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.navigationViewerCtrl1 = new NvnNavigator.Common.NavigationViewerCtrl();
            this.btnOK = new DotNetSkin.SkinControls.SkinButton();
            this.btnCancel = new DotNetSkin.SkinControls.SkinButton();
            this.SuspendLayout();
            // 
            // navigationViewerCtrl1
            // 
            this.navigationViewerCtrl1.CurrentAngle = 0;
            this.navigationViewerCtrl1.CurrentPath = null;
            this.navigationViewerCtrl1.CurrentPlace = null;
            this.navigationViewerCtrl1.CurrentPoint = null;
            this.navigationViewerCtrl1.Location = new System.Drawing.Point(12, 12);
            this.navigationViewerCtrl1.Name = "navigationViewerCtrl1";
            this.navigationViewerCtrl1.Size = new System.Drawing.Size(834, 536);
            this.navigationViewerCtrl1.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(690, 569);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(786, 569);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RealNavigationForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(902, 604);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.navigationViewerCtrl1);
            this.Name = "RealNavigationForm";
            this.Text = "RealNavigationForm";
            this.ResumeLayout(false);

        }

        #endregion

        private NvnNavigator.Common.NavigationViewerCtrl navigationViewerCtrl1;
        private DotNetSkin.SkinControls.SkinButton btnOK;
        private DotNetSkin.SkinControls.SkinButton btnCancel;
    }
}