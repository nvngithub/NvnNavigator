namespace NvnNavigator.Editor
{
    partial class MarkControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.btnMaps = new System.Windows.Forms.Button();
            this.cmbMaps = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbkClear = new System.Windows.Forms.LinkLabel();
            this.lnkClearAll = new System.Windows.Forms.LinkLabel();
            this.lblDeleteUnused = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMap
            // 
            this.pbMap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMap.Location = new System.Drawing.Point(3, 30);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(890, 696);
            this.pbMap.TabIndex = 11;
            this.pbMap.TabStop = false;
            this.pbMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbMap_MouseMove);
            this.pbMap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbMap_MouseClick);
            this.pbMap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbMap_MouseUp);
            // 
            // btnMaps
            // 
            this.btnMaps.Location = new System.Drawing.Point(284, 1);
            this.btnMaps.Name = "btnMaps";
            this.btnMaps.Size = new System.Drawing.Size(75, 23);
            this.btnMaps.TabIndex = 17;
            this.btnMaps.Text = "Maps";
            this.btnMaps.UseVisualStyleBackColor = true;
            this.btnMaps.Click += new System.EventHandler(this.btnMaps_Click);
            // 
            // cmbMaps
            // 
            this.cmbMaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaps.FormattingEnabled = true;
            this.cmbMaps.Location = new System.Drawing.Point(73, 3);
            this.cmbMaps.Name = "cmbMaps";
            this.cmbMaps.Size = new System.Drawing.Size(205, 21);
            this.cmbMaps.TabIndex = 16;
            this.cmbMaps.SelectedIndexChanged += new System.EventHandler(this.cmbMaps_SelectedIndexChanged);
            // 
            // lblLocation
            // 
            this.lblLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(818, 3);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(0, 13);
            this.lblLocation.TabIndex = 19;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(550, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbkClear
            // 
            this.lbkClear.AutoSize = true;
            this.lbkClear.Location = new System.Drawing.Point(378, 11);
            this.lbkClear.Name = "lbkClear";
            this.lbkClear.Size = new System.Drawing.Size(31, 13);
            this.lbkClear.TabIndex = 21;
            this.lbkClear.TabStop = true;
            this.lbkClear.Text = "Clear";
            this.lbkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbkClear_LinkClicked);
            // 
            // lnkClearAll
            // 
            this.lnkClearAll.AutoSize = true;
            this.lnkClearAll.Location = new System.Drawing.Point(415, 11);
            this.lnkClearAll.Name = "lnkClearAll";
            this.lnkClearAll.Size = new System.Drawing.Size(45, 13);
            this.lnkClearAll.TabIndex = 23;
            this.lnkClearAll.TabStop = true;
            this.lnkClearAll.Text = "Clear All";
            this.lnkClearAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearAll_LinkClicked);
            // 
            // lblDeleteUnused
            // 
            this.lblDeleteUnused.AutoSize = true;
            this.lblDeleteUnused.Location = new System.Drawing.Point(466, 11);
            this.lblDeleteUnused.Name = "lblDeleteUnused";
            this.lblDeleteUnused.Size = new System.Drawing.Size(78, 13);
            this.lblDeleteUnused.TabIndex = 24;
            this.lblDeleteUnused.TabStop = true;
            this.lblDeleteUnused.Text = "Delete Unused";
            this.lblDeleteUnused.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDeleteUnused_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Maps";
            // 
            // MarkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDeleteUnused);
            this.Controls.Add(this.lnkClearAll);
            this.Controls.Add(this.lbkClear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnMaps);
            this.Controls.Add(this.cmbMaps);
            this.Controls.Add(this.pbMap);
            this.Name = "MarkControl";
            this.Size = new System.Drawing.Size(896, 729);
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.Button btnMaps;
        private System.Windows.Forms.ComboBox cmbMaps;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.LinkLabel lbkClear;
        private System.Windows.Forms.LinkLabel lnkClearAll;
        private System.Windows.Forms.LinkLabel lblDeleteUnused;
        private System.Windows.Forms.Label label1;
    }
}
