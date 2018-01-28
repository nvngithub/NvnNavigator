namespace NvnNavigator.Editor
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCreatePlace = new System.Windows.Forms.Button();
            this.btnRealView = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDeletePoint = new System.Windows.Forms.Button();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.lstPoints = new System.Windows.Forms.ListBox();
            this.btnDeletePath = new System.Windows.Forms.Button();
            this.btnCreatePath = new System.Windows.Forms.Button();
            this.lstPaths = new System.Windows.Forms.ListBox();
            this.txtNextPointAngle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPointInfoSave = new System.Windows.Forms.Button();
            this.txtPointId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlJunctionPoints = new System.Windows.Forms.FlowLayoutPanel();
            this.lnkAddJunctionPoint = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnPathIdSave = new System.Windows.Forms.Button();
            this.txtPathId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFindUnusedImages = new System.Windows.Forms.Button();
            this.pointImages = new NvnNavigator.Editor.PointImages();
            this.imageCaptureControl1 = new NvnNavigator.Editor.ImageCaptureControl();
            this.markControl1 = new NvnNavigator.Editor.MarkControl();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(1012, 744);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(931, 744);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCreatePlace
            // 
            this.btnCreatePlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreatePlace.Location = new System.Drawing.Point(2, 744);
            this.btnCreatePlace.Name = "btnCreatePlace";
            this.btnCreatePlace.Size = new System.Drawing.Size(98, 23);
            this.btnCreatePlace.TabIndex = 4;
            this.btnCreatePlace.Text = "Create Place";
            this.btnCreatePlace.UseVisualStyleBackColor = true;
            this.btnCreatePlace.Click += new System.EventHandler(this.btnCreatePlace_Click);
            // 
            // btnRealView
            // 
            this.btnRealView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRealView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealView.Location = new System.Drawing.Point(200, 744);
            this.btnRealView.Name = "btnRealView";
            this.btnRealView.Size = new System.Drawing.Size(98, 23);
            this.btnRealView.TabIndex = 5;
            this.btnRealView.Text = "Real View";
            this.btnRealView.UseVisualStyleBackColor = true;
            this.btnRealView.Click += new System.EventHandler(this.btnRealView_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(2, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDeletePoint);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddPoint);
            this.splitContainer1.Panel1.Controls.Add(this.lstPoints);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeletePath);
            this.splitContainer1.Panel1.Controls.Add(this.btnCreatePath);
            this.splitContainer1.Panel1.Controls.Add(this.lstPaths);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtNextPointAngle);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.btnPointInfoSave);
            this.splitContainer1.Panel2.Controls.Add(this.txtPointId);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Controls.Add(this.btnPathIdSave);
            this.splitContainer1.Panel2.Controls.Add(this.txtPathId);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Size = new System.Drawing.Size(1088, 735);
            this.splitContainer1.SplitterDistance = 219;
            this.splitContainer1.TabIndex = 3;
            // 
            // btnDeletePoint
            // 
            this.btnDeletePoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeletePoint.Location = new System.Drawing.Point(84, 623);
            this.btnDeletePoint.Name = "btnDeletePoint";
            this.btnDeletePoint.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePoint.TabIndex = 9;
            this.btnDeletePoint.Text = "Delete Point";
            this.btnDeletePoint.UseVisualStyleBackColor = true;
            this.btnDeletePoint.Click += new System.EventHandler(this.btnDeletePoint_Click);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddPoint.Location = new System.Drawing.Point(3, 623);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(75, 23);
            this.btnAddPoint.TabIndex = 8;
            this.btnAddPoint.Text = "Add Point";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // lstPoints
            // 
            this.lstPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPoints.FormattingEnabled = true;
            this.lstPoints.Location = new System.Drawing.Point(3, 156);
            this.lstPoints.Name = "lstPoints";
            this.lstPoints.Size = new System.Drawing.Size(211, 459);
            this.lstPoints.TabIndex = 7;
            this.lstPoints.SelectedIndexChanged += new System.EventHandler(this.lstPoints_SelectedIndexChanged);
            // 
            // btnDeletePath
            // 
            this.btnDeletePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeletePath.Location = new System.Drawing.Point(95, 707);
            this.btnDeletePath.Name = "btnDeletePath";
            this.btnDeletePath.Size = new System.Drawing.Size(86, 23);
            this.btnDeletePath.TabIndex = 6;
            this.btnDeletePath.Text = "Delete Path";
            this.btnDeletePath.UseVisualStyleBackColor = true;
            this.btnDeletePath.Click += new System.EventHandler(this.btnDeletePath_Click);
            // 
            // btnCreatePath
            // 
            this.btnCreatePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreatePath.Location = new System.Drawing.Point(4, 707);
            this.btnCreatePath.Name = "btnCreatePath";
            this.btnCreatePath.Size = new System.Drawing.Size(85, 23);
            this.btnCreatePath.TabIndex = 5;
            this.btnCreatePath.Text = "Create Path";
            this.btnCreatePath.UseVisualStyleBackColor = true;
            this.btnCreatePath.Click += new System.EventHandler(this.btnCreatePath_Click);
            // 
            // lstPaths
            // 
            this.lstPaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPaths.FormattingEnabled = true;
            this.lstPaths.Location = new System.Drawing.Point(3, 3);
            this.lstPaths.Name = "lstPaths";
            this.lstPaths.Size = new System.Drawing.Size(211, 147);
            this.lstPaths.TabIndex = 0;
            this.lstPaths.SelectedIndexChanged += new System.EventHandler(this.lstPaths_SelectedIndexChanged);
            // 
            // txtNextPointAngle
            // 
            this.txtNextPointAngle.Location = new System.Drawing.Point(403, 31);
            this.txtNextPointAngle.Name = "txtNextPointAngle";
            this.txtNextPointAngle.Size = new System.Drawing.Size(53, 20);
            this.txtNextPointAngle.TabIndex = 24;
            this.txtNextPointAngle.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Next point angle";
            // 
            // btnPointInfoSave
            // 
            this.btnPointInfoSave.Location = new System.Drawing.Point(465, 29);
            this.btnPointInfoSave.Name = "btnPointInfoSave";
            this.btnPointInfoSave.Size = new System.Drawing.Size(118, 23);
            this.btnPointInfoSave.TabIndex = 20;
            this.btnPointInfoSave.Text = "Save Point";
            this.btnPointInfoSave.UseVisualStyleBackColor = true;
            this.btnPointInfoSave.Click += new System.EventHandler(this.btnPointInfoSave_Click);
            // 
            // txtPointId
            // 
            this.txtPointId.Location = new System.Drawing.Point(63, 31);
            this.txtPointId.Name = "txtPointId";
            this.txtPointId.Size = new System.Drawing.Size(244, 20);
            this.txtPointId.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Point Id";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(3, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(857, 667);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pointImages);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(849, 641);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Point Images";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnlJunctionPoints);
            this.tabPage3.Controls.Add(this.lnkAddJunctionPoint);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(849, 641);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Junction Points";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlJunctionPoints
            // 
            this.pnlJunctionPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlJunctionPoints.AutoScroll = true;
            this.pnlJunctionPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlJunctionPoints.Location = new System.Drawing.Point(0, 16);
            this.pnlJunctionPoints.Name = "pnlJunctionPoints";
            this.pnlJunctionPoints.Size = new System.Drawing.Size(735, 539);
            this.pnlJunctionPoints.TabIndex = 16;
            // 
            // lnkAddJunctionPoint
            // 
            this.lnkAddJunctionPoint.AutoSize = true;
            this.lnkAddJunctionPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAddJunctionPoint.Location = new System.Drawing.Point(3, 0);
            this.lnkAddJunctionPoint.Name = "lnkAddJunctionPoint";
            this.lnkAddJunctionPoint.Size = new System.Drawing.Size(114, 13);
            this.lnkAddJunctionPoint.TabIndex = 17;
            this.lnkAddJunctionPoint.TabStop = true;
            this.lnkAddJunctionPoint.Text = "Add Junction Point";
            this.lnkAddJunctionPoint.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAddJunctionPoint_LinkClicked);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.imageCaptureControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(849, 641);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Live Capture Single";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.markControl1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(849, 641);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Maps";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtLog);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(849, 641);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Logs";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(849, 641);
            this.txtLog.TabIndex = 19;
            // 
            // btnPathIdSave
            // 
            this.btnPathIdSave.Location = new System.Drawing.Point(313, 3);
            this.btnPathIdSave.Name = "btnPathIdSave";
            this.btnPathIdSave.Size = new System.Drawing.Size(101, 23);
            this.btnPathIdSave.TabIndex = 7;
            this.btnPathIdSave.Text = "Save Path Id";
            this.btnPathIdSave.UseVisualStyleBackColor = true;
            this.btnPathIdSave.Click += new System.EventHandler(this.btnPathIdSave_Click);
            // 
            // txtPathId
            // 
            this.txtPathId.Location = new System.Drawing.Point(63, 5);
            this.txtPathId.Name = "txtPathId";
            this.txtPathId.Size = new System.Drawing.Size(244, 20);
            this.txtPathId.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Path Id";
            // 
            // btnFindUnusedImages
            // 
            this.btnFindUnusedImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFindUnusedImages.Location = new System.Drawing.Point(337, 744);
            this.btnFindUnusedImages.Name = "btnFindUnusedImages";
            this.btnFindUnusedImages.Size = new System.Drawing.Size(117, 23);
            this.btnFindUnusedImages.TabIndex = 6;
            this.btnFindUnusedImages.Text = "Find Unused Images";
            this.btnFindUnusedImages.UseVisualStyleBackColor = true;
            this.btnFindUnusedImages.Click += new System.EventHandler(this.btnFindUnusedImages_Click);
            // 
            // pointImages
            // 
            this.pointImages.Location = new System.Drawing.Point(6, 6);
            this.pointImages.Name = "pointImages";
            this.pointImages.NavigatorPath = null;
            this.pointImages.Point = null;
            this.pointImages.Size = new System.Drawing.Size(570, 460);
            this.pointImages.TabIndex = 15;
            // 
            // imageCaptureControl1
            // 
            this.imageCaptureControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageCaptureControl1.Location = new System.Drawing.Point(6, 3);
            this.imageCaptureControl1.Name = "imageCaptureControl1";
            this.imageCaptureControl1.NavigatorPath = null;
            this.imageCaptureControl1.NavigatorPoint = null;
            this.imageCaptureControl1.Size = new System.Drawing.Size(606, 525);
            this.imageCaptureControl1.TabIndex = 0;
            // 
            // markControl1
            // 
            this.markControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.markControl1.Location = new System.Drawing.Point(0, 0);
            this.markControl1.Name = "markControl1";
            this.markControl1.Size = new System.Drawing.Size(849, 641);
            this.markControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 774);
            this.Controls.Add(this.btnFindUnusedImages);
            this.Controls.Add(this.btnRealView);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnCreatePlace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCreatePlace;
        private System.Windows.Forms.TextBox txtPathId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstPaths;
        private System.Windows.Forms.Button btnDeletePath;
        private System.Windows.Forms.Button btnCreatePath;
        private System.Windows.Forms.Button btnPathIdSave;
        private System.Windows.Forms.ListBox lstPoints;
        private PointImages pointImages;
        private System.Windows.Forms.FlowLayoutPanel pnlJunctionPoints;
        private System.Windows.Forms.LinkLabel lnkAddJunctionPoint;
        private System.Windows.Forms.Button btnDeletePoint;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnRealView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ImageCaptureControl imageCaptureControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnFindUnusedImages;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TabPage tabPage4;
        private MarkControl markControl1;
        private System.Windows.Forms.TextBox txtNextPointAngle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPointInfoSave;
        private System.Windows.Forms.TextBox txtPointId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage5;
    }
}

