namespace NvnNavigator.Common {
    partial class RenameGroupForm {
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
            this.lblCurrentGroup = new System.Windows.Forms.Label();
            this.lblNewGroup = new System.Windows.Forms.Label();
            this.txtNewGroup = new System.Windows.Forms.TextBox();
            this.cmbCurrentGroup = new System.Windows.Forms.ComboBox();
            this.btnRename = new DotNetSkin.SkinControls.SkinButton();
            this.btnCancel = new DotNetSkin.SkinControls.SkinButton();
            this.SuspendLayout();
            // 
            // lblCurrentGroup
            // 
            this.lblCurrentGroup.AutoSize = true;
            this.lblCurrentGroup.Location = new System.Drawing.Point(12, 15);
            this.lblCurrentGroup.Name = "lblCurrentGroup";
            this.lblCurrentGroup.Size = new System.Drawing.Size(51, 13);
            this.lblCurrentGroup.TabIndex = 9;
            this.lblCurrentGroup.Text = "Current #";
            // 
            // lblNewGroup
            // 
            this.lblNewGroup.AutoSize = true;
            this.lblNewGroup.Location = new System.Drawing.Point(24, 41);
            this.lblNewGroup.Name = "lblNewGroup";
            this.lblNewGroup.Size = new System.Drawing.Size(39, 13);
            this.lblNewGroup.TabIndex = 11;
            this.lblNewGroup.Text = "New #";
            // 
            // txtNewGroup
            // 
            this.txtNewGroup.Location = new System.Drawing.Point(104, 38);
            this.txtNewGroup.Name = "txtNewGroup";
            this.txtNewGroup.Size = new System.Drawing.Size(237, 20);
            this.txtNewGroup.TabIndex = 10;
            // 
            // cmbCurrentGroup
            // 
            this.cmbCurrentGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCurrentGroup.FormattingEnabled = true;
            this.cmbCurrentGroup.Location = new System.Drawing.Point(104, 11);
            this.cmbCurrentGroup.Name = "cmbCurrentGroup";
            this.cmbCurrentGroup.Size = new System.Drawing.Size(237, 21);
            this.cmbCurrentGroup.TabIndex = 14;
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(155, 64);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(90, 23);
            this.btnRename.TabIndex = 15;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(251, 64);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RenameGroupForm
            // 
            this.AcceptButton = this.btnRename;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(350, 97);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.cmbCurrentGroup);
            this.Controls.Add(this.lblCurrentGroup);
            this.Controls.Add(this.lblNewGroup);
            this.Controls.Add(this.txtNewGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RenameGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rename #";
            this.Load += new System.EventHandler(this.RenameGroupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentGroup;
        private System.Windows.Forms.Label lblNewGroup;
        private System.Windows.Forms.TextBox txtNewGroup;
        private System.Windows.Forms.ComboBox cmbCurrentGroup;
        private DotNetSkin.SkinControls.SkinButton btnRename;
        private DotNetSkin.SkinControls.SkinButton btnCancel;
    }
}