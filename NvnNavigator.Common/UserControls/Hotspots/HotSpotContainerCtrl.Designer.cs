namespace NvnNavigator.Common {
    partial class HotSpotContainerCtrl {
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
            this.pnlHotspots = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddNewHotspot = new DotNetSkin.SkinControls.SkinButton();
            this.btnDeleteSelectedHotspot = new DotNetSkin.SkinControls.SkinButton();
            this.SuspendLayout();
            // 
            // pnlHotspots
            // 
            this.pnlHotspots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHotspots.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlHotspots.Location = new System.Drawing.Point(3, 63);
            this.pnlHotspots.Name = "pnlHotspots";
            this.pnlHotspots.Size = new System.Drawing.Size(693, 466);
            this.pnlHotspots.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotspots";
            // 
            // btnAddNewHotspot
            // 
            this.btnAddNewHotspot.Location = new System.Drawing.Point(3, 34);
            this.btnAddNewHotspot.Name = "btnAddNewHotspot";
            this.btnAddNewHotspot.Size = new System.Drawing.Size(135, 23);
            this.btnAddNewHotspot.TabIndex = 4;
            this.btnAddNewHotspot.Text = "Add new hotspot";
            this.btnAddNewHotspot.UseVisualStyleBackColor = true;
            this.btnAddNewHotspot.Click += new System.EventHandler(this.btnAddNewHotspot_Click);
            // 
            // btnDeleteSelectedHotspot
            // 
            this.btnDeleteSelectedHotspot.Location = new System.Drawing.Point(144, 34);
            this.btnDeleteSelectedHotspot.Name = "btnDeleteSelectedHotspot";
            this.btnDeleteSelectedHotspot.Size = new System.Drawing.Size(153, 23);
            this.btnDeleteSelectedHotspot.TabIndex = 5;
            this.btnDeleteSelectedHotspot.Text = "Delete selected hotspot";
            this.btnDeleteSelectedHotspot.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedHotspot.Click += new System.EventHandler(this.btnDeleteSelectedHotspot_Click);
            // 
            // HotSpotContainerCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteSelectedHotspot);
            this.Controls.Add(this.btnAddNewHotspot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlHotspots);
            this.Name = "HotSpotContainerCtrl";
            this.Size = new System.Drawing.Size(699, 532);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlHotspots;
        private System.Windows.Forms.Label label1;
        private DotNetSkin.SkinControls.SkinButton btnAddNewHotspot;
        private DotNetSkin.SkinControls.SkinButton btnDeleteSelectedHotspot;
    }
}