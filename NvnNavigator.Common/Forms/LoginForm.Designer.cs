namespace NvnNavigator.Common {
    partial class LoginForm {
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
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCancel = new DotNetSkin.SkinControls.SkinButton();
            this.btnLogin = new DotNetSkin.SkinControls.SkinButton();
            this.applicationNameCtrl1 = new NvnNavigator.Common.ApplicationNameCtrl();
            this.keyboardControl = new NvnNavigator.Common.KeyboardControl();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(9, 17);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(106, 13);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Enter # password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 33);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(209, 20);
            this.txtPassword.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(112, 59);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 59);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 23);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // applicationNameCtrl1
            // 
            this.applicationNameCtrl1.ApplicationModule = "Administrator";
            this.applicationNameCtrl1.Location = new System.Drawing.Point(12, 102);
            this.applicationNameCtrl1.Name = "applicationNameCtrl1";
            this.applicationNameCtrl1.Size = new System.Drawing.Size(242, 48);
            this.applicationNameCtrl1.TabIndex = 11;
            this.applicationNameCtrl1.Version = "Version";
            // 
            // keyboardControl
            // 
            this.keyboardControl.KeyboardType = NvnNavigator.Common.BoW.Standard;
            this.keyboardControl.Location = new System.Drawing.Point(276, 12);
            this.keyboardControl.Name = "keyboardControl";
            this.keyboardControl.Size = new System.Drawing.Size(575, 152);
            this.keyboardControl.TabIndex = 10;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(863, 175);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.applicationNameCtrl1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.keyboardControl);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblDesc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtPassword;
        private KeyboardControl keyboardControl;
        private DotNetSkin.SkinControls.SkinButton btnLogin;
        private DotNetSkin.SkinControls.SkinButton btnCancel;
        private ApplicationNameCtrl applicationNameCtrl1;
    }
}