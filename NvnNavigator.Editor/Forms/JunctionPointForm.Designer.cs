namespace NvnNavigator.Editor {
    partial class JunctionPointForm {
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPathAngle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPathId = new System.Windows.Forms.ComboBox();
            this.rbStart = new System.Windows.Forms.RadioButton();
            this.rbEnd = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(115, 129);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(196, 129);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path Id";
            // 
            // txtPathAngle
            // 
            this.txtPathAngle.Location = new System.Drawing.Point(77, 38);
            this.txtPathAngle.Name = "txtPathAngle";
            this.txtPathAngle.Size = new System.Drawing.Size(194, 20);
            this.txtPathAngle.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Path Angle";
            // 
            // cmbPathId
            // 
            this.cmbPathId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPathId.FormattingEnabled = true;
            this.cmbPathId.Location = new System.Drawing.Point(77, 11);
            this.cmbPathId.Name = "cmbPathId";
            this.cmbPathId.Size = new System.Drawing.Size(194, 21);
            this.cmbPathId.TabIndex = 9;
            // 
            // rbStart
            // 
            this.rbStart.Location = new System.Drawing.Point(77, 64);
            this.rbStart.Name = "rbStart";
            this.rbStart.Size = new System.Drawing.Size(194, 36);
            this.rbStart.TabIndex = 10;
            this.rbStart.Text = "Start ? (Pointing to begining of connecting path)";
            this.rbStart.UseVisualStyleBackColor = true;
            // 
            // rbEnd
            // 
            this.rbEnd.AutoSize = true;
            this.rbEnd.Checked = true;
            this.rbEnd.Location = new System.Drawing.Point(77, 106);
            this.rbEnd.Name = "rbEnd";
            this.rbEnd.Size = new System.Drawing.Size(53, 17);
            this.rbEnd.TabIndex = 11;
            this.rbEnd.TabStop = true;
            this.rbEnd.Text = "End ?";
            this.rbEnd.UseVisualStyleBackColor = true;
            // 
            // JunctionPointForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(283, 164);
            this.Controls.Add(this.rbEnd);
            this.Controls.Add(this.rbStart);
            this.Controls.Add(this.cmbPathId);
            this.Controls.Add(this.txtPathAngle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "JunctionPointForm";
            this.Text = "JunctionPointForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPathAngle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPathId;
        private System.Windows.Forms.RadioButton rbStart;
        private System.Windows.Forms.RadioButton rbEnd;
    }
}