namespace NvnNavigator.Admin {
    partial class SettingsCtrl {
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
            this.btnSaveUserSettings = new DotNetSkin.SkinControls.SkinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.txtClientPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.logoConfigCtrl1 = new NvnNavigator.Common.LogoConfigCtrl();
            this.youAreHereLocationCtrl1 = new NvnNavigator.Admin.YouAreHereLocationCtrl();
            this.layoutSettingsCtrl1 = new NvnNavigator.Common.LayoutSettingsCtrl();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveUserSettings
            // 
            this.btnSaveUserSettings.Location = new System.Drawing.Point(269, 84);
            this.btnSaveUserSettings.Name = "btnSaveUserSettings";
            this.btnSaveUserSettings.Size = new System.Drawing.Size(90, 23);
            this.btnSaveUserSettings.TabIndex = 0;
            this.btnSaveUserSettings.Text = "Save";
            this.btnSaveUserSettings.UseVisualStyleBackColor = true;
            this.btnSaveUserSettings.Click += new System.EventHandler(this.btnSaveUserSettings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrator password";
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Location = new System.Drawing.Point(152, 32);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.PasswordChar = '*';
            this.txtAdminPassword.Size = new System.Drawing.Size(207, 20);
            this.txtAdminPassword.TabIndex = 2;
            // 
            // txtClientPassword
            // 
            this.txtClientPassword.Location = new System.Drawing.Point(152, 58);
            this.txtClientPassword.Name = "txtClientPassword";
            this.txtClientPassword.PasswordChar = '*';
            this.txtClientPassword.Size = new System.Drawing.Size(207, 20);
            this.txtClientPassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Client password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "User settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Logo settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "\"You are here\" location";
            // 
            // logoConfigCtrl1
            // 
            this.logoConfigCtrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logoConfigCtrl1.Location = new System.Drawing.Point(34, 138);
            this.logoConfigCtrl1.Name = "logoConfigCtrl1";
            this.logoConfigCtrl1.Size = new System.Drawing.Size(316, 168);
            this.logoConfigCtrl1.TabIndex = 7;
            // 
            // youAreHereLocationCtrl1
            // 
            this.youAreHereLocationCtrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.youAreHereLocationCtrl1.Location = new System.Drawing.Point(34, 334);
            this.youAreHereLocationCtrl1.Name = "youAreHereLocationCtrl1";
            this.youAreHereLocationCtrl1.Size = new System.Drawing.Size(316, 70);
            this.youAreHereLocationCtrl1.TabIndex = 9;
            // 
            // layoutSettingsCtrl1
            // 
            this.layoutSettingsCtrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layoutSettingsCtrl1.Location = new System.Drawing.Point(365, 32);
            this.layoutSettingsCtrl1.Name = "layoutSettingsCtrl1";
            this.layoutSettingsCtrl1.Size = new System.Drawing.Size(513, 372);
            this.layoutSettingsCtrl1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(362, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Layout settings";
            // 
            // SettingsCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.layoutSettingsCtrl1);
            this.Controls.Add(this.youAreHereLocationCtrl1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.logoConfigCtrl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtClientPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveUserSettings);
            this.Name = "SettingsCtrl";
            this.Size = new System.Drawing.Size(903, 471);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DotNetSkin.SkinControls.SkinButton btnSaveUserSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.TextBox txtClientPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private NvnNavigator.Common.LogoConfigCtrl logoConfigCtrl1;
        private System.Windows.Forms.Label label5;
        private YouAreHereLocationCtrl youAreHereLocationCtrl1;
        private NvnNavigator.Common.LayoutSettingsCtrl layoutSettingsCtrl1;
        private System.Windows.Forms.Label label6;
    }
}
