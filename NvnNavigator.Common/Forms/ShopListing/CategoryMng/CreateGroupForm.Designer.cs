namespace NvnNavigator.Common {
    partial class CreateGroupForm {
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
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtNewGroup = new System.Windows.Forms.TextBox();
            this.btnCreateGroup = new DotNetSkin.SkinControls.SkinButton();
            this.btnClose = new DotNetSkin.SkinControls.SkinButton();
            this.SuspendLayout();
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(12, 15);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(43, 13);
            this.lblGroupName.TabIndex = 2;
            this.lblGroupName.Text = "# name";
            // 
            // txtNewGroup
            // 
            this.txtNewGroup.Location = new System.Drawing.Point(73, 12);
            this.txtNewGroup.Name = "txtNewGroup";
            this.txtNewGroup.Size = new System.Drawing.Size(214, 20);
            this.txtNewGroup.TabIndex = 0;
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Location = new System.Drawing.Point(101, 38);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(90, 23);
            this.btnCreateGroup.TabIndex = 3;
            this.btnCreateGroup.Text = "Create";
            this.btnCreateGroup.UseVisualStyleBackColor = true;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(197, 38);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CreateGroupForm
            // 
            this.AcceptButton = this.btnCreateGroup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(309, 68);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreateGroup);
            this.Controls.Add(this.txtNewGroup);
            this.Controls.Add(this.lblGroupName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Define a new #";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.TextBox txtNewGroup;
        private DotNetSkin.SkinControls.SkinButton btnCreateGroup;
        private DotNetSkin.SkinControls.SkinButton btnClose;
    }
}