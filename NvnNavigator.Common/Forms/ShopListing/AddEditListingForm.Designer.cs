namespace NvnNavigator.Common {
    partial class AddEditListingForm {
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lnkAddCategory = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTagline = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIconFile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lnkAddFloor = new System.Windows.Forms.LinkLabel();
            this.cmbFloors = new System.Windows.Forms.ComboBox();
            this.lnkEditFloor = new System.Windows.Forms.LinkLabel();
            this.lnkDeleteFloor = new System.Windows.Forms.LinkLabel();
            this.lnkDeleteCategory = new System.Windows.Forms.LinkLabel();
            this.lnkEditCategory = new System.Windows.Forms.LinkLabel();
            this.btnClose = new DotNetSkin.SkinControls.SkinButton();
            this.btnSave = new DotNetSkin.SkinControls.SkinButton();
            this.btnBrowse = new DotNetSkin.SkinControls.SkinButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(63, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(176, 20);
            this.txtName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(63, 38);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(119, 20);
            this.txtNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Floor";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(8, 96);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(63, 91);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(119, 21);
            this.cmbCategory.TabIndex = 9;
            // 
            // lnkAddCategory
            // 
            this.lnkAddCategory.AutoSize = true;
            this.lnkAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddCategory.Location = new System.Drawing.Point(188, 96);
            this.lnkAddCategory.Name = "lnkAddCategory";
            this.lnkAddCategory.Size = new System.Drawing.Size(29, 13);
            this.lnkAddCategory.TabIndex = 10;
            this.lnkAddCategory.TabStop = true;
            this.lnkAddCategory.Text = "Add";
            this.lnkAddCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddCategory_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tagline or Slogan";
            // 
            // txtTagline
            // 
            this.txtTagline.Location = new System.Drawing.Point(11, 159);
            this.txtTagline.Name = "txtTagline";
            this.txtTagline.Size = new System.Drawing.Size(342, 20);
            this.txtTagline.TabIndex = 12;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(11, 198);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(342, 106);
            this.txtDescription.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Description";
            // 
            // txtIconFile
            // 
            this.txtIconFile.Enabled = false;
            this.txtIconFile.Location = new System.Drawing.Point(63, 120);
            this.txtIconFile.Name = "txtIconFile";
            this.txtIconFile.Size = new System.Drawing.Size(176, 20);
            this.txtIconFile.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Icon";
            // 
            // lnkAddFloor
            // 
            this.lnkAddFloor.AutoSize = true;
            this.lnkAddFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddFloor.Location = new System.Drawing.Point(188, 67);
            this.lnkAddFloor.Name = "lnkAddFloor";
            this.lnkAddFloor.Size = new System.Drawing.Size(29, 13);
            this.lnkAddFloor.TabIndex = 18;
            this.lnkAddFloor.TabStop = true;
            this.lnkAddFloor.Text = "Add";
            this.lnkAddFloor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddFloor_LinkClicked);
            // 
            // cmbFloors
            // 
            this.cmbFloors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFloors.FormattingEnabled = true;
            this.cmbFloors.Location = new System.Drawing.Point(63, 64);
            this.cmbFloors.Name = "cmbFloors";
            this.cmbFloors.Size = new System.Drawing.Size(119, 21);
            this.cmbFloors.TabIndex = 19;
            // 
            // lnkEditFloor
            // 
            this.lnkEditFloor.AutoSize = true;
            this.lnkEditFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkEditFloor.Location = new System.Drawing.Point(223, 67);
            this.lnkEditFloor.Name = "lnkEditFloor";
            this.lnkEditFloor.Size = new System.Drawing.Size(29, 13);
            this.lnkEditFloor.TabIndex = 20;
            this.lnkEditFloor.TabStop = true;
            this.lnkEditFloor.Text = "Edit";
            this.lnkEditFloor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditFloor_LinkClicked);
            // 
            // lnkDeleteFloor
            // 
            this.lnkDeleteFloor.AutoSize = true;
            this.lnkDeleteFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDeleteFloor.Location = new System.Drawing.Point(258, 67);
            this.lnkDeleteFloor.Name = "lnkDeleteFloor";
            this.lnkDeleteFloor.Size = new System.Drawing.Size(44, 13);
            this.lnkDeleteFloor.TabIndex = 21;
            this.lnkDeleteFloor.TabStop = true;
            this.lnkDeleteFloor.Text = "Delete";
            this.lnkDeleteFloor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDeleteFloor_LinkClicked);
            // 
            // lnkDeleteCategory
            // 
            this.lnkDeleteCategory.AutoSize = true;
            this.lnkDeleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDeleteCategory.Location = new System.Drawing.Point(258, 96);
            this.lnkDeleteCategory.Name = "lnkDeleteCategory";
            this.lnkDeleteCategory.Size = new System.Drawing.Size(44, 13);
            this.lnkDeleteCategory.TabIndex = 23;
            this.lnkDeleteCategory.TabStop = true;
            this.lnkDeleteCategory.Text = "Delete";
            this.lnkDeleteCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDeleteCategory_LinkClicked);
            // 
            // lnkEditCategory
            // 
            this.lnkEditCategory.AutoSize = true;
            this.lnkEditCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkEditCategory.Location = new System.Drawing.Point(223, 96);
            this.lnkEditCategory.Name = "lnkEditCategory";
            this.lnkEditCategory.Size = new System.Drawing.Size(29, 13);
            this.lnkEditCategory.TabIndex = 22;
            this.lnkEditCategory.TabStop = true;
            this.lnkEditCategory.Text = "Edit";
            this.lnkEditCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEditCategory_LinkClicked);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(253, 310);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 23);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(147, 310);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(245, 118);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 23);
            this.btnBrowse.TabIndex = 26;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // AddEditListingForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(369, 340);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lnkDeleteCategory);
            this.Controls.Add(this.lnkEditCategory);
            this.Controls.Add(this.lnkDeleteFloor);
            this.Controls.Add(this.lnkEditFloor);
            this.Controls.Add(this.cmbFloors);
            this.Controls.Add(this.lnkAddFloor);
            this.Controls.Add(this.txtIconFile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTagline);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lnkAddCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditListingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditListingForm";
            this.Load += new System.EventHandler(this.AddEditListingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.LinkLabel lnkAddCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTagline;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIconFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lnkAddFloor;
        private System.Windows.Forms.ComboBox cmbFloors;
        private System.Windows.Forms.LinkLabel lnkEditFloor;
        private System.Windows.Forms.LinkLabel lnkDeleteFloor;
        private System.Windows.Forms.LinkLabel lnkDeleteCategory;
        private System.Windows.Forms.LinkLabel lnkEditCategory;
        private DotNetSkin.SkinControls.SkinButton btnClose;
        private DotNetSkin.SkinControls.SkinButton btnSave;
        private DotNetSkin.SkinControls.SkinButton btnBrowse;
    }
}