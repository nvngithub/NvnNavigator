using NvnNavigator.Common;
namespace NvnNavigator
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
            this.navigatorLayoutCtrl1 = new NvnNavigator.Common.LayoutViewCtrl();
            this.SuspendLayout();
            // 
            // navigatorLayoutCtrl1
            // 
            this.navigatorLayoutCtrl1.Location = new System.Drawing.Point(78, 12);
            this.navigatorLayoutCtrl1.Name = "navigatorLayoutCtrl1";
            this.navigatorLayoutCtrl1.Size = new System.Drawing.Size(900, 504);
            this.navigatorLayoutCtrl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 564);
            this.Controls.Add(this.navigatorLayoutCtrl1);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Nvn Navigator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private LayoutViewCtrl navigatorLayoutCtrl1;

    }
}

