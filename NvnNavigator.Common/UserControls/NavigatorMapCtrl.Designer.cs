namespace NvnNavigator.Common {
    partial class NavigatorMapCtrl {
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
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.floorsCtrl = new NvnNavigator.Common.FloorsCtrl();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMap
            // 
            this.pbMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMap.Location = new System.Drawing.Point(3, 3);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(274, 186);
            this.pbMap.TabIndex = 0;
            this.pbMap.TabStop = false;
            this.pbMap.MouseLeave += new System.EventHandler(this.pbMap_MouseLeave);
            this.pbMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMap_MouseMove);
            this.pbMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbMap_MouseClick);
            this.pbMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbMap_MouseDown);
            this.pbMap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMap_MouseUp);
            this.pbMap.MouseEnter += new System.EventHandler(this.pbMap_MouseEnter);
            // 
            // floorsCtrl
            // 
            this.floorsCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.floorsCtrl.Location = new System.Drawing.Point(3, 191);
            this.floorsCtrl.Name = "floorsCtrl";
            this.floorsCtrl.SelectedMap = null;
            this.floorsCtrl.Size = new System.Drawing.Size(274, 33);
            this.floorsCtrl.TabIndex = 1;
            // 
            // NavigatorMapCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.floorsCtrl);
            this.Controls.Add(this.pbMap);
            this.Name = "NavigatorMapCtrl";
            this.Size = new System.Drawing.Size(280, 227);
            this.Resize += new System.EventHandler(this.NavigatorMapCtrl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMap;
        private FloorsCtrl floorsCtrl;
    }
}
