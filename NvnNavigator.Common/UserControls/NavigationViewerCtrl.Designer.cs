namespace NvnNavigator.Common
{
    partial class NavigationViewerCtrl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbNavigationImage = new System.Windows.Forms.PictureBox();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.btnLoadProject = new System.Windows.Forms.Button();
            this.lblImageName = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblCurrentAngle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbNavigationImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbNavigationImage
            // 
            this.pbNavigationImage.Location = new System.Drawing.Point(3, 3);
            this.pbNavigationImage.Name = "pbNavigationImage";
            this.pbNavigationImage.Size = new System.Drawing.Size(485, 532);
            this.pbNavigationImage.TabIndex = 0;
            this.pbNavigationImage.TabStop = false;
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(660, 215);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 23);
            this.btnForward.TabIndex = 1;
            this.btnForward.Text = "Forward";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(589, 244);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(735, 244);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 3;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.Location = new System.Drawing.Point(660, 273);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(75, 23);
            this.btnBackward.TabIndex = 4;
            this.btnBackward.Text = "Backward";
            this.btnBackward.UseVisualStyleBackColor = true;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // btnLoadProject
            // 
            this.btnLoadProject.Location = new System.Drawing.Point(693, 400);
            this.btnLoadProject.Name = "btnLoadProject";
            this.btnLoadProject.Size = new System.Drawing.Size(122, 23);
            this.btnLoadProject.TabIndex = 6;
            this.btnLoadProject.Text = "load project";
            this.btnLoadProject.UseVisualStyleBackColor = true;
            this.btnLoadProject.Click += new System.EventHandler(this.btnLoadProject_Click);
            // 
            // lblImageName
            // 
            this.lblImageName.AutoSize = true;
            this.lblImageName.Location = new System.Drawing.Point(673, 94);
            this.lblImageName.Name = "lblImageName";
            this.lblImageName.Size = new System.Drawing.Size(35, 13);
            this.lblImageName.TabIndex = 8;
            this.lblImageName.Text = "label1";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(673, 123);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(35, 13);
            this.lblPath.TabIndex = 9;
            this.lblPath.Text = "label1";
            // 
            // lblCurrentAngle
            // 
            this.lblCurrentAngle.AutoSize = true;
            this.lblCurrentAngle.Location = new System.Drawing.Point(673, 151);
            this.lblCurrentAngle.Name = "lblCurrentAngle";
            this.lblCurrentAngle.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentAngle.TabIndex = 10;
            this.lblCurrentAngle.Text = "label1";
            // 
            // NavigationViewerCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCurrentAngle);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.pbNavigationImage);
            this.Controls.Add(this.lblImageName);
            this.Controls.Add(this.btnLoadProject);
            this.Controls.Add(this.btnBackward);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnForward);
            this.Name = "NavigationViewerCtrl";
            this.Size = new System.Drawing.Size(844, 538);
            ((System.ComponentModel.ISupportInitialize)(this.pbNavigationImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbNavigationImage;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnLoadProject;
        private System.Windows.Forms.Label lblImageName;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblCurrentAngle;
    }
}
