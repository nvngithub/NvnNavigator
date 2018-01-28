namespace NvnNavigator.Common {
    partial class HotSpotImageForm {
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
            this.rbChoseResourceImage = new System.Windows.Forms.RadioButton();
            this.rbChooseNewFile = new System.Windows.Forms.RadioButton();
            this.pbHotSpotImage = new System.Windows.Forms.PictureBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.cmbResourceImages = new NvnNavigator.Common.ComboBoxEx();
            this.btnBrowse = new DotNetSkin.SkinControls.SkinButton();
            this.btnCancel = new DotNetSkin.SkinControls.SkinButton();
            this.btnSelect = new DotNetSkin.SkinControls.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbHotSpotImage)).BeginInit();
            this.SuspendLayout();
            // 
            // rbChoseResourceImage
            // 
            this.rbChoseResourceImage.AutoSize = true;
            this.rbChoseResourceImage.Checked = true;
            this.rbChoseResourceImage.Location = new System.Drawing.Point(93, 12);
            this.rbChoseResourceImage.Name = "rbChoseResourceImage";
            this.rbChoseResourceImage.Size = new System.Drawing.Size(144, 17);
            this.rbChoseResourceImage.TabIndex = 9;
            this.rbChoseResourceImage.TabStop = true;
            this.rbChoseResourceImage.Text = "Choose from resource file";
            this.rbChoseResourceImage.UseVisualStyleBackColor = true;
            this.rbChoseResourceImage.CheckedChanged += new System.EventHandler(this.rbChoseResourceImage_CheckedChanged);
            // 
            // rbChooseNewFile
            // 
            this.rbChooseNewFile.AutoSize = true;
            this.rbChooseNewFile.Location = new System.Drawing.Point(93, 72);
            this.rbChooseNewFile.Name = "rbChooseNewFile";
            this.rbChooseNewFile.Size = new System.Drawing.Size(109, 17);
            this.rbChooseNewFile.TabIndex = 10;
            this.rbChooseNewFile.Text = "Choose a new file";
            this.rbChooseNewFile.UseVisualStyleBackColor = true;
            this.rbChooseNewFile.CheckedChanged += new System.EventHandler(this.rbChooseNewFile_CheckedChanged);
            // 
            // pbHotSpotImage
            // 
            this.pbHotSpotImage.Location = new System.Drawing.Point(12, 35);
            this.pbHotSpotImage.Name = "pbHotSpotImage";
            this.pbHotSpotImage.Size = new System.Drawing.Size(74, 50);
            this.pbHotSpotImage.TabIndex = 12;
            this.pbHotSpotImage.TabStop = false;
            // 
            // lblFilename
            // 
            this.lblFilename.Enabled = false;
            this.lblFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilename.Location = new System.Drawing.Point(90, 92);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(214, 32);
            this.lblFilename.TabIndex = 15;
            this.lblFilename.Text = "<No file selected>";
            // 
            // cmbResourceImages
            // 
            this.cmbResourceImages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbResourceImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbResourceImages.FormattingEnabled = true;
            this.cmbResourceImages.ImageList = null;
            this.cmbResourceImages.ItemHeight = 25;
            this.cmbResourceImages.Location = new System.Drawing.Point(93, 35);
            this.cmbResourceImages.Name = "cmbResourceImages";
            this.cmbResourceImages.Size = new System.Drawing.Size(302, 31);
            this.cmbResourceImages.TabIndex = 6;
            this.cmbResourceImages.SelectedIndexChanged += new System.EventHandler(this.cmbResourceImages_SelectedIndexChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Enabled = false;
            this.btnBrowse.Location = new System.Drawing.Point(310, 87);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(85, 23);
            this.btnBrowse.TabIndex = 16;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(310, 127);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(219, 127);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(85, 23);
            this.btnSelect.TabIndex = 18;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // HotSpotImageForm
            // 
            this.AcceptButton = this.btnSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(407, 162);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.pbHotSpotImage);
            this.Controls.Add(this.rbChooseNewFile);
            this.Controls.Add(this.rbChoseResourceImage);
            this.Controls.Add(this.cmbResourceImages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HotSpotImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select an image...";
            ((System.ComponentModel.ISupportInitialize)(this.pbHotSpotImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBoxEx cmbResourceImages;
        private System.Windows.Forms.RadioButton rbChoseResourceImage;
        private System.Windows.Forms.RadioButton rbChooseNewFile;
        private System.Windows.Forms.PictureBox pbHotSpotImage;
        private System.Windows.Forms.Label lblFilename;
        private DotNetSkin.SkinControls.SkinButton btnBrowse;
        private DotNetSkin.SkinControls.SkinButton btnCancel;
        private DotNetSkin.SkinControls.SkinButton btnSelect;
    }
}