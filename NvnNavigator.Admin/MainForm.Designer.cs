namespace NvnNavigator.Admin {
    partial class MainForm {
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
            this.containerCtrl1 = new NvnNavigator.Admin.ContainerCtrl();
            this.SuspendLayout();
            // 
            // containerCtrl1
            // 
            this.containerCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerCtrl1.Location = new System.Drawing.Point(0, 0);
            this.containerCtrl1.Name = "containerCtrl1";
            this.containerCtrl1.Size = new System.Drawing.Size(870, 571);
            this.containerCtrl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 571);
            this.Controls.Add(this.containerCtrl1);
            this.Name = "MainForm";
            this.Text = "NvnNavigator Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private ContainerCtrl containerCtrl1;
    }
}

