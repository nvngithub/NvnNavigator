namespace NvnNavigator.Common {
    partial class LayoutSettingsCtrl {
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
            this.rbViewOnly = new System.Windows.Forms.RadioButton();
            this.rbMapOnly = new System.Windows.Forms.RadioButton();
            this.rbViewBottom = new System.Windows.Forms.RadioButton();
            this.rbViewTop = new System.Windows.Forms.RadioButton();
            this.rbViewRight = new System.Windows.Forms.RadioButton();
            this.rbViewLeft = new System.Windows.Forms.RadioButton();
            this.chkAdsEnabled = new System.Windows.Forms.CheckBox();
            this.rbAdsRight = new System.Windows.Forms.RadioButton();
            this.rbAdsBottom = new System.Windows.Forms.RadioButton();
            this.rbAdsLeft = new System.Windows.Forms.RadioButton();
            this.rbAdsTop = new System.Windows.Forms.RadioButton();
            this.lnkConfigureAds = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbViewOnly
            // 
            this.rbViewOnly.AutoSize = true;
            this.rbViewOnly.Location = new System.Drawing.Point(3, 3);
            this.rbViewOnly.Name = "rbViewOnly";
            this.rbViewOnly.Size = new System.Drawing.Size(119, 17);
            this.rbViewOnly.TabIndex = 1;
            this.rbViewOnly.Text = "Navigator View only";
            this.rbViewOnly.UseVisualStyleBackColor = true;
            this.rbViewOnly.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbMapOnly
            // 
            this.rbMapOnly.AutoSize = true;
            this.rbMapOnly.Location = new System.Drawing.Point(3, 26);
            this.rbMapOnly.Name = "rbMapOnly";
            this.rbMapOnly.Size = new System.Drawing.Size(68, 17);
            this.rbMapOnly.TabIndex = 2;
            this.rbMapOnly.Text = "Map only";
            this.rbMapOnly.UseVisualStyleBackColor = true;
            this.rbMapOnly.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbViewBottom
            // 
            this.rbViewBottom.AutoSize = true;
            this.rbViewBottom.Location = new System.Drawing.Point(3, 118);
            this.rbViewBottom.Name = "rbViewBottom";
            this.rbViewBottom.Size = new System.Drawing.Size(176, 17);
            this.rbViewBottom.TabIndex = 3;
            this.rbViewBottom.Text = "Navigator view bottom, Map top";
            this.rbViewBottom.UseVisualStyleBackColor = true;
            this.rbViewBottom.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbViewTop
            // 
            this.rbViewTop.AutoSize = true;
            this.rbViewTop.Location = new System.Drawing.Point(3, 95);
            this.rbViewTop.Name = "rbViewTop";
            this.rbViewTop.Size = new System.Drawing.Size(176, 17);
            this.rbViewTop.TabIndex = 4;
            this.rbViewTop.Text = "Navigatpr view top, Map bottom";
            this.rbViewTop.UseVisualStyleBackColor = true;
            this.rbViewTop.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbViewRight
            // 
            this.rbViewRight.AutoSize = true;
            this.rbViewRight.Location = new System.Drawing.Point(3, 72);
            this.rbViewRight.Name = "rbViewRight";
            this.rbViewRight.Size = new System.Drawing.Size(163, 17);
            this.rbViewRight.TabIndex = 5;
            this.rbViewRight.Text = "Navigator view right, Map left";
            this.rbViewRight.UseVisualStyleBackColor = true;
            this.rbViewRight.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbViewLeft
            // 
            this.rbViewLeft.AutoSize = true;
            this.rbViewLeft.Location = new System.Drawing.Point(3, 49);
            this.rbViewLeft.Name = "rbViewLeft";
            this.rbViewLeft.Size = new System.Drawing.Size(163, 17);
            this.rbViewLeft.TabIndex = 6;
            this.rbViewLeft.Text = "Navigator view left, Map right";
            this.rbViewLeft.UseVisualStyleBackColor = true;
            this.rbViewLeft.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // chkAdsEnabled
            // 
            this.chkAdsEnabled.AutoSize = true;
            this.chkAdsEnabled.Location = new System.Drawing.Point(3, 198);
            this.chkAdsEnabled.Name = "chkAdsEnabled";
            this.chkAdsEnabled.Size = new System.Drawing.Size(65, 17);
            this.chkAdsEnabled.TabIndex = 7;
            this.chkAdsEnabled.Text = "Enabled";
            this.chkAdsEnabled.UseVisualStyleBackColor = true;
            this.chkAdsEnabled.CheckedChanged += new System.EventHandler(this.chkAdsEnabled_CheckedChanged);
            // 
            // rbAdsRight
            // 
            this.rbAdsRight.AutoSize = true;
            this.rbAdsRight.Location = new System.Drawing.Point(3, 3);
            this.rbAdsRight.Name = "rbAdsRight";
            this.rbAdsRight.Size = new System.Drawing.Size(50, 17);
            this.rbAdsRight.TabIndex = 8;
            this.rbAdsRight.Text = "Right";
            this.rbAdsRight.UseVisualStyleBackColor = true;
            this.rbAdsRight.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbAdsBottom
            // 
            this.rbAdsBottom.AutoSize = true;
            this.rbAdsBottom.Checked = true;
            this.rbAdsBottom.Location = new System.Drawing.Point(3, 26);
            this.rbAdsBottom.Name = "rbAdsBottom";
            this.rbAdsBottom.Size = new System.Drawing.Size(58, 17);
            this.rbAdsBottom.TabIndex = 9;
            this.rbAdsBottom.TabStop = true;
            this.rbAdsBottom.Text = "Bottom";
            this.rbAdsBottom.UseVisualStyleBackColor = true;
            this.rbAdsBottom.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbAdsLeft
            // 
            this.rbAdsLeft.AutoSize = true;
            this.rbAdsLeft.Location = new System.Drawing.Point(3, 49);
            this.rbAdsLeft.Name = "rbAdsLeft";
            this.rbAdsLeft.Size = new System.Drawing.Size(43, 17);
            this.rbAdsLeft.TabIndex = 10;
            this.rbAdsLeft.Text = "Left";
            this.rbAdsLeft.UseVisualStyleBackColor = true;
            this.rbAdsLeft.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbAdsTop
            // 
            this.rbAdsTop.AutoSize = true;
            this.rbAdsTop.Location = new System.Drawing.Point(3, 72);
            this.rbAdsTop.Name = "rbAdsTop";
            this.rbAdsTop.Size = new System.Drawing.Size(44, 17);
            this.rbAdsTop.TabIndex = 11;
            this.rbAdsTop.Text = "Top";
            this.rbAdsTop.UseVisualStyleBackColor = true;
            this.rbAdsTop.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // lnkConfigureAds
            // 
            this.lnkConfigureAds.AutoSize = true;
            this.lnkConfigureAds.Location = new System.Drawing.Point(3, 324);
            this.lnkConfigureAds.Name = "lnkConfigureAds";
            this.lnkConfigureAds.Size = new System.Drawing.Size(106, 13);
            this.lnkConfigureAds.TabIndex = 12;
            this.lnkConfigureAds.TabStop = true;
            this.lnkConfigureAds.Text = "Configure ad settings";
            this.lnkConfigureAds.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConfigureAds_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(212, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 198);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbViewLeft);
            this.panel2.Controls.Add(this.rbViewOnly);
            this.panel2.Controls.Add(this.rbMapOnly);
            this.panel2.Controls.Add(this.rbViewBottom);
            this.panel2.Controls.Add(this.rbViewTop);
            this.panel2.Controls.Add(this.rbViewRight);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 146);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbAdsRight);
            this.panel3.Controls.Add(this.rbAdsBottom);
            this.panel3.Controls.Add(this.rbAdsLeft);
            this.panel3.Controls.Add(this.rbAdsTop);
            this.panel3.Location = new System.Drawing.Point(3, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(122, 100);
            this.panel3.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Preview";
            // 
            // LayoutSettingsCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lnkConfigureAds);
            this.Controls.Add(this.chkAdsEnabled);
            this.Name = "LayoutSettingsCtrl";
            this.Size = new System.Drawing.Size(469, 353);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbViewOnly;
        private System.Windows.Forms.RadioButton rbMapOnly;
        private System.Windows.Forms.RadioButton rbViewBottom;
        private System.Windows.Forms.RadioButton rbViewTop;
        private System.Windows.Forms.RadioButton rbViewRight;
        private System.Windows.Forms.RadioButton rbViewLeft;
        private System.Windows.Forms.CheckBox chkAdsEnabled;
        private System.Windows.Forms.RadioButton rbAdsRight;
        private System.Windows.Forms.RadioButton rbAdsBottom;
        private System.Windows.Forms.RadioButton rbAdsLeft;
        private System.Windows.Forms.RadioButton rbAdsTop;
        private System.Windows.Forms.LinkLabel lnkConfigureAds;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}