namespace NvnNavigator.Common {
    partial class LogoConfigCtrl {
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.lnkChooseNewLogo = new System.Windows.Forms.LinkLabel();
            this.logoViewCtrl = new NvnNavigator.Common.LogoViewCtrl();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(59, 29);
            this.nudWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(67, 20);
            this.nudWidth.TabIndex = 1;
            this.nudWidth.ValueChanged += new System.EventHandler(this.nudWidth_ValueChanged);
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(174, 29);
            this.nudHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(67, 20);
            this.nudHeight.TabIndex = 3;
            this.nudHeight.ValueChanged += new System.EventHandler(this.nudHeight_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height";
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.Location = new System.Drawing.Point(21, 3);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(65, 17);
            this.chkEnabled.TabIndex = 4;
            this.chkEnabled.Text = "Enabled";
            this.chkEnabled.UseVisualStyleBackColor = true;
            this.chkEnabled.CheckedChanged += new System.EventHandler(this.chkEnabled_CheckedChanged);
            // 
            // lnkChooseNewLogo
            // 
            this.lnkChooseNewLogo.AutoSize = true;
            this.lnkChooseNewLogo.Location = new System.Drawing.Point(186, 67);
            this.lnkChooseNewLogo.Name = "lnkChooseNewLogo";
            this.lnkChooseNewLogo.Size = new System.Drawing.Size(43, 13);
            this.lnkChooseNewLogo.TabIndex = 6;
            this.lnkChooseNewLogo.TabStop = true;
            this.lnkChooseNewLogo.Text = "Choose";
            this.lnkChooseNewLogo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkChooseNewLogo_LinkClicked);
            // 
            // logoViewCtrl
            // 
            this.logoViewCtrl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoViewCtrl.Location = new System.Drawing.Point(21, 95);
            this.logoViewCtrl.Name = "logoViewCtrl";
            this.logoViewCtrl.Size = new System.Drawing.Size(249, 70);
            this.logoViewCtrl.TabIndex = 5;
            // 
            // LogoConfigCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lnkChooseNewLogo);
            this.Controls.Add(this.logoViewCtrl);
            this.Controls.Add(this.chkEnabled);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.label1);
            this.Name = "LogoConfigCtrl";
            this.Size = new System.Drawing.Size(316, 168);
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkEnabled;
        private LogoViewCtrl logoViewCtrl;
        private System.Windows.Forms.LinkLabel lnkChooseNewLogo;
    }
}