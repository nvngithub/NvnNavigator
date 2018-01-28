namespace NvnNavigator.Common {
    partial class RecentFilesForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectedFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstRecentFiles = new System.Windows.Forms.ListBox();
            this.lnkClearHistory = new System.Windows.Forms.LinkLabel();
            this.btnBrowse = new DotNetSkin.SkinControls.SkinButton();
            this.btnLoad = new DotNetSkin.SkinControls.SkinButton();
            this.btnCancel = new DotNetSkin.SkinControls.SkinButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a project file";
            // 
            // txtSelectedFile
            // 
            this.txtSelectedFile.Location = new System.Drawing.Point(33, 25);
            this.txtSelectedFile.Name = "txtSelectedFile";
            this.txtSelectedFile.Size = new System.Drawing.Size(349, 20);
            this.txtSelectedFile.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Recent files";
            // 
            // lstRecentFiles
            // 
            this.lstRecentFiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lstRecentFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecentFiles.FormattingEnabled = true;
            this.lstRecentFiles.IntegralHeight = false;
            this.lstRecentFiles.ItemHeight = 20;
            this.lstRecentFiles.Location = new System.Drawing.Point(33, 64);
            this.lstRecentFiles.Name = "lstRecentFiles";
            this.lstRecentFiles.Size = new System.Drawing.Size(451, 108);
            this.lstRecentFiles.TabIndex = 5;
            this.lstRecentFiles.SelectedIndexChanged += new System.EventHandler(this.lstRecentFiles_SelectedIndexChanged);
            this.lstRecentFiles.DoubleClick += new System.EventHandler(this.lstRecentFiles_DoubleClick);
            // 
            // lnkClearHistory
            // 
            this.lnkClearHistory.AutoSize = true;
            this.lnkClearHistory.Location = new System.Drawing.Point(30, 175);
            this.lnkClearHistory.Name = "lnkClearHistory";
            this.lnkClearHistory.Size = new System.Drawing.Size(64, 13);
            this.lnkClearHistory.TabIndex = 7;
            this.lnkClearHistory.TabStop = true;
            this.lnkClearHistory.Text = "Clear history";
            this.lnkClearHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkClearHistory_LinkClicked);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(388, 25);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(96, 23);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(286, 178);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(96, 23);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(388, 178);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // RecentFilesForm
            // 
            this.AcceptButton = this.btnLoad;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(496, 215);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lnkClearHistory);
            this.Controls.Add(this.lstRecentFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSelectedFile);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecentFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecentFilesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelectedFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstRecentFiles;
        private System.Windows.Forms.LinkLabel lnkClearHistory;
        private DotNetSkin.SkinControls.SkinButton btnBrowse;
        private DotNetSkin.SkinControls.SkinButton btnLoad;
        private DotNetSkin.SkinControls.SkinButton btnCancel;
    }
}