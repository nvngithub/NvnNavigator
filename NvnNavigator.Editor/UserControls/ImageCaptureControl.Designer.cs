namespace NvnNavigator.Editor {
    partial class ImageCaptureControl {
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
            this.pbLiveImage = new System.Windows.Forms.PictureBox();
            this.pbStraight = new System.Windows.Forms.PictureBox();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.pbBehind = new System.Windows.Forms.PictureBox();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSetStraight = new System.Windows.Forms.Button();
            this.btnSetLeft = new System.Windows.Forms.Button();
            this.btnSetBehind = new System.Windows.Forms.Button();
            this.btnSetRight = new System.Windows.Forms.Button();
            this.lnkStart = new System.Windows.Forms.LinkLabel();
            this.lnkStop = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbLiveImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStraight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBehind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLiveImage
            // 
            this.pbLiveImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLiveImage.Location = new System.Drawing.Point(29, 4);
            this.pbLiveImage.Name = "pbLiveImage";
            this.pbLiveImage.Size = new System.Drawing.Size(400, 400);
            this.pbLiveImage.TabIndex = 0;
            this.pbLiveImage.TabStop = false;
            // 
            // pbStraight
            // 
            this.pbStraight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbStraight.Location = new System.Drawing.Point(12, 423);
            this.pbStraight.Name = "pbStraight";
            this.pbStraight.Size = new System.Drawing.Size(106, 78);
            this.pbStraight.TabIndex = 1;
            this.pbStraight.TabStop = false;
            // 
            // pbRight
            // 
            this.pbRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbRight.Location = new System.Drawing.Point(348, 423);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(106, 78);
            this.pbRight.TabIndex = 2;
            this.pbRight.TabStop = false;
            // 
            // pbBehind
            // 
            this.pbBehind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBehind.Location = new System.Drawing.Point(236, 423);
            this.pbBehind.Name = "pbBehind";
            this.pbBehind.Size = new System.Drawing.Size(106, 78);
            this.pbBehind.TabIndex = 3;
            this.pbBehind.TabStop = false;
            // 
            // pbLeft
            // 
            this.pbLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbLeft.Location = new System.Drawing.Point(124, 423);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(106, 78);
            this.pbLeft.TabIndex = 4;
            this.pbLeft.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Straight - 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Left - 90";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Right - 270";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Behind - 180";
            // 
            // btnSetStraight
            // 
            this.btnSetStraight.Location = new System.Drawing.Point(455, 40);
            this.btnSetStraight.Name = "btnSetStraight";
            this.btnSetStraight.Size = new System.Drawing.Size(62, 23);
            this.btnSetStraight.TabIndex = 9;
            this.btnSetStraight.Text = "Straight";
            this.btnSetStraight.UseVisualStyleBackColor = true;
            this.btnSetStraight.Click += new System.EventHandler(this.AssignCapturedImage_Click);
            // 
            // btnSetLeft
            // 
            this.btnSetLeft.Location = new System.Drawing.Point(455, 107);
            this.btnSetLeft.Name = "btnSetLeft";
            this.btnSetLeft.Size = new System.Drawing.Size(62, 23);
            this.btnSetLeft.TabIndex = 10;
            this.btnSetLeft.Text = "Left";
            this.btnSetLeft.UseVisualStyleBackColor = true;
            this.btnSetLeft.Click += new System.EventHandler(this.AssignCapturedImage_Click);
            // 
            // btnSetBehind
            // 
            this.btnSetBehind.Location = new System.Drawing.Point(455, 174);
            this.btnSetBehind.Name = "btnSetBehind";
            this.btnSetBehind.Size = new System.Drawing.Size(62, 23);
            this.btnSetBehind.TabIndex = 11;
            this.btnSetBehind.Text = "Behind";
            this.btnSetBehind.UseVisualStyleBackColor = true;
            this.btnSetBehind.Click += new System.EventHandler(this.AssignCapturedImage_Click);
            // 
            // btnSetRight
            // 
            this.btnSetRight.Location = new System.Drawing.Point(455, 241);
            this.btnSetRight.Name = "btnSetRight";
            this.btnSetRight.Size = new System.Drawing.Size(62, 23);
            this.btnSetRight.TabIndex = 12;
            this.btnSetRight.Text = "Right";
            this.btnSetRight.UseVisualStyleBackColor = true;
            this.btnSetRight.Click += new System.EventHandler(this.AssignCapturedImage_Click);
            // 
            // lnkStart
            // 
            this.lnkStart.AutoSize = true;
            this.lnkStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkStart.Location = new System.Drawing.Point(455, 309);
            this.lnkStart.Name = "lnkStart";
            this.lnkStart.Size = new System.Drawing.Size(43, 17);
            this.lnkStart.TabIndex = 13;
            this.lnkStart.TabStop = true;
            this.lnkStart.Text = "Start";
            this.lnkStart.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStart_LinkClicked);
            // 
            // lnkStop
            // 
            this.lnkStop.AutoSize = true;
            this.lnkStop.Location = new System.Drawing.Point(455, 340);
            this.lnkStop.Name = "lnkStop";
            this.lnkStop.Size = new System.Drawing.Size(29, 13);
            this.lnkStop.TabIndex = 14;
            this.lnkStop.TabStop = true;
            this.lnkStop.Text = "Stop";
            this.lnkStop.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStop_LinkClicked);
            // 
            // ImageCaptureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lnkStop);
            this.Controls.Add(this.lnkStart);
            this.Controls.Add(this.btnSetRight);
            this.Controls.Add(this.btnSetBehind);
            this.Controls.Add(this.btnSetLeft);
            this.Controls.Add(this.btnSetStraight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLeft);
            this.Controls.Add(this.pbBehind);
            this.Controls.Add(this.pbRight);
            this.Controls.Add(this.pbStraight);
            this.Controls.Add(this.pbLiveImage);
            this.Name = "ImageCaptureControl";
            this.Size = new System.Drawing.Size(542, 504);
            ((System.ComponentModel.ISupportInitialize)(this.pbLiveImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStraight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBehind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLiveImage;
        private System.Windows.Forms.PictureBox pbStraight;
        private System.Windows.Forms.PictureBox pbRight;
        private System.Windows.Forms.PictureBox pbBehind;
        private System.Windows.Forms.PictureBox pbLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSetStraight;
        private System.Windows.Forms.Button btnSetLeft;
        private System.Windows.Forms.Button btnSetBehind;
        private System.Windows.Forms.Button btnSetRight;
        private System.Windows.Forms.LinkLabel lnkStart;
        private System.Windows.Forms.LinkLabel lnkStop;
    }
}
