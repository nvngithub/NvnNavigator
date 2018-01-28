namespace NvnNavigator.Common {
    partial class ListingViewCtrl {
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
            this.btnNone = new System.Windows.Forms.Button();
            this.btnSortByCategory = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSortByFloor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNone
            // 
            this.btnNone.Location = new System.Drawing.Point(3, 3);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(75, 23);
            this.btnNone.TabIndex = 1;
            this.btnNone.Text = "None";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // btnSortByCategory
            // 
            this.btnSortByCategory.Location = new System.Drawing.Point(84, 3);
            this.btnSortByCategory.Name = "btnSortByCategory";
            this.btnSortByCategory.Size = new System.Drawing.Size(75, 23);
            this.btnSortByCategory.TabIndex = 2;
            this.btnSortByCategory.Text = "Category";
            this.btnSortByCategory.UseVisualStyleBackColor = true;
            this.btnSortByCategory.Click += new System.EventHandler(this.btnSortByCategory_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.Location = new System.Drawing.Point(3, 32);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(531, 343);
            this.pnlContainer.TabIndex = 5;
            // 
            // btnSortByFloor
            // 
            this.btnSortByFloor.Location = new System.Drawing.Point(165, 3);
            this.btnSortByFloor.Name = "btnSortByFloor";
            this.btnSortByFloor.Size = new System.Drawing.Size(75, 23);
            this.btnSortByFloor.TabIndex = 6;
            this.btnSortByFloor.Text = "Floor";
            this.btnSortByFloor.UseVisualStyleBackColor = true;
            this.btnSortByFloor.Click += new System.EventHandler(this.btnSortByFloor_Click);
            // 
            // ListingViewCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnSortByFloor);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.btnSortByCategory);
            this.Controls.Add(this.btnNone);
            this.Name = "ListingViewCtrl";
            this.Size = new System.Drawing.Size(537, 378);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnSortByCategory;
        private System.Windows.Forms.FlowLayoutPanel pnlContainer;
        private System.Windows.Forms.Button btnSortByFloor;
    }
}