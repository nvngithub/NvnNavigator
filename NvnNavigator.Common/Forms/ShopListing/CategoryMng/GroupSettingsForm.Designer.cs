namespace NvnNavigator.Common {
    partial class GroupSettingsForm {
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
            this.nudShopHeight = new System.Windows.Forms.NumericUpDown();
            this.nudShopWidth = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.nudLogoHeight = new System.Windows.Forms.NumericUpDown();
            this.nudLogoWidth = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.lnkConfigShopBackColor = new System.Windows.Forms.LinkLabel();
            this.pnlShopBackColor = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lnkConfigShopDescFont = new System.Windows.Forms.LinkLabel();
            this.lnkConfigShopDescColor = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.lnkConfigShopNameFont = new System.Windows.Forms.LinkLabel();
            this.pnlShopDescColor = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lnkConfigShopNameColor = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlShopNameColor = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lnkConfigGroupNameFont = new System.Windows.Forms.LinkLabel();
            this.lblGroupNameFont = new System.Windows.Forms.Label();
            this.lnkConfigGroupNameBackColor = new System.Windows.Forms.LinkLabel();
            this.pnlGroupNameBackColor = new System.Windows.Forms.Panel();
            this.lblGroupNameBackColor = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.lblSelectAGroup = new System.Windows.Forms.Label();
            this.lnkConfigGroupNameColor = new System.Windows.Forms.LinkLabel();
            this.pnlGroupNameColor = new System.Windows.Forms.Panel();
            this.lblGroupNameColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGroupNameFontPreview = new System.Windows.Forms.Label();
            this.lblShopNameFontPreview = new System.Windows.Forms.Label();
            this.lblShopDescriptionFontPreview = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lnkApplyToAll = new System.Windows.Forms.LinkLabel();
            this.lnkMakeDefaultSetting = new System.Windows.Forms.LinkLabel();
            this.listingViewGroupCtrl1 = new NvnNavigator.Common.ListingViewGroupCtrl();
            this.btnClose = new DotNetSkin.SkinControls.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudShopHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShopWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLogoHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLogoWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // nudShopHeight
            // 
            this.nudShopHeight.Location = new System.Drawing.Point(239, 313);
            this.nudShopHeight.Maximum = new decimal(new int[] {
            768,
            0,
            0,
            0});
            this.nudShopHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudShopHeight.Name = "nudShopHeight";
            this.nudShopHeight.Size = new System.Drawing.Size(60, 20);
            this.nudShopHeight.TabIndex = 65;
            this.nudShopHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudShopHeight.ValueChanged += new System.EventHandler(this.numericShopHeight_ValueChanged);
            // 
            // nudShopWidth
            // 
            this.nudShopWidth.Location = new System.Drawing.Point(129, 313);
            this.nudShopWidth.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.nudShopWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudShopWidth.Name = "nudShopWidth";
            this.nudShopWidth.Size = new System.Drawing.Size(60, 20);
            this.nudShopWidth.TabIndex = 64;
            this.nudShopWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudShopWidth.ValueChanged += new System.EventHandler(this.numericShopWidth_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 315);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 63;
            this.label15.Text = "Shop size";
            // 
            // nudLogoHeight
            // 
            this.nudLogoHeight.Location = new System.Drawing.Point(239, 287);
            this.nudLogoHeight.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudLogoHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLogoHeight.Name = "nudLogoHeight";
            this.nudLogoHeight.Size = new System.Drawing.Size(60, 20);
            this.nudLogoHeight.TabIndex = 62;
            this.nudLogoHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLogoHeight.ValueChanged += new System.EventHandler(this.numericLogoHeight_ValueChanged);
            // 
            // nudLogoWidth
            // 
            this.nudLogoWidth.Location = new System.Drawing.Point(129, 287);
            this.nudLogoWidth.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudLogoWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLogoWidth.Name = "nudLogoWidth";
            this.nudLogoWidth.Size = new System.Drawing.Size(60, 20);
            this.nudLogoWidth.TabIndex = 61;
            this.nudLogoWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLogoWidth.ValueChanged += new System.EventHandler(this.numericLogoWidth_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 289);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 60;
            this.label14.Text = "Logo size";
            // 
            // lnkConfigShopBackColor
            // 
            this.lnkConfigShopBackColor.AutoSize = true;
            this.lnkConfigShopBackColor.Location = new System.Drawing.Point(195, 255);
            this.lnkConfigShopBackColor.Name = "lnkConfigShopBackColor";
            this.lnkConfigShopBackColor.Size = new System.Drawing.Size(52, 13);
            this.lnkConfigShopBackColor.TabIndex = 59;
            this.lnkConfigShopBackColor.TabStop = true;
            this.lnkConfigShopBackColor.Text = "Configure";
            this.lnkConfigShopBackColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConfigShopBackColor_LinkClicked);
            // 
            // pnlShopBackColor
            // 
            this.pnlShopBackColor.Location = new System.Drawing.Point(129, 256);
            this.pnlShopBackColor.Name = "pnlShopBackColor";
            this.pnlShopBackColor.Size = new System.Drawing.Size(60, 25);
            this.pnlShopBackColor.TabIndex = 58;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 57;
            this.label13.Text = "Shop background color";
            // 
            // lnkConfigShopDescFont
            // 
            this.lnkConfigShopDescFont.AutoSize = true;
            this.lnkConfigShopDescFont.Location = new System.Drawing.Point(195, 225);
            this.lnkConfigShopDescFont.Name = "lnkConfigShopDescFont";
            this.lnkConfigShopDescFont.Size = new System.Drawing.Size(52, 13);
            this.lnkConfigShopDescFont.TabIndex = 53;
            this.lnkConfigShopDescFont.TabStop = true;
            this.lnkConfigShopDescFont.Text = "Configure";
            this.lnkConfigShopDescFont.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConfigShopDescFont_LinkClicked);
            // 
            // lnkConfigShopDescColor
            // 
            this.lnkConfigShopDescColor.AutoSize = true;
            this.lnkConfigShopDescColor.Location = new System.Drawing.Point(195, 195);
            this.lnkConfigShopDescColor.Name = "lnkConfigShopDescColor";
            this.lnkConfigShopDescColor.Size = new System.Drawing.Size(52, 13);
            this.lnkConfigShopDescColor.TabIndex = 54;
            this.lnkConfigShopDescColor.TabStop = true;
            this.lnkConfigShopDescColor.Text = "Configure";
            this.lnkConfigShopDescColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConfigShopDescColor_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 48;
            this.label12.Text = "Shop description font";
            // 
            // lnkConfigShopNameFont
            // 
            this.lnkConfigShopNameFont.AutoSize = true;
            this.lnkConfigShopNameFont.Location = new System.Drawing.Point(195, 165);
            this.lnkConfigShopNameFont.Name = "lnkConfigShopNameFont";
            this.lnkConfigShopNameFont.Size = new System.Drawing.Size(52, 13);
            this.lnkConfigShopNameFont.TabIndex = 56;
            this.lnkConfigShopNameFont.TabStop = true;
            this.lnkConfigShopNameFont.Text = "Configure";
            this.lnkConfigShopNameFont.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConfigShopNameFont_LinkClicked);
            // 
            // pnlShopDescColor
            // 
            this.pnlShopDescColor.Location = new System.Drawing.Point(129, 194);
            this.pnlShopDescColor.Name = "pnlShopDescColor";
            this.pnlShopDescColor.Size = new System.Drawing.Size(60, 25);
            this.pnlShopDescColor.TabIndex = 52;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Shop description color";
            // 
            // lnkConfigShopNameColor
            // 
            this.lnkConfigShopNameColor.AutoSize = true;
            this.lnkConfigShopNameColor.Location = new System.Drawing.Point(195, 135);
            this.lnkConfigShopNameColor.Name = "lnkConfigShopNameColor";
            this.lnkConfigShopNameColor.Size = new System.Drawing.Size(52, 13);
            this.lnkConfigShopNameColor.TabIndex = 55;
            this.lnkConfigShopNameColor.TabStop = true;
            this.lnkConfigShopNameColor.Text = "Configure";
            this.lnkConfigShopNameColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConfigShopNameColor_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Shop name font";
            // 
            // pnlShopNameColor
            // 
            this.pnlShopNameColor.Location = new System.Drawing.Point(129, 132);
            this.pnlShopNameColor.Name = "pnlShopNameColor";
            this.pnlShopNameColor.Size = new System.Drawing.Size(60, 25);
            this.pnlShopNameColor.TabIndex = 50;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Shop name color";
            // 
            // lnkConfigGroupNameFont
            // 
            this.lnkConfigGroupNameFont.AutoSize = true;
            this.lnkConfigGroupNameFont.Location = new System.Drawing.Point(195, 105);
            this.lnkConfigGroupNameFont.Name = "lnkConfigGroupNameFont";
            this.lnkConfigGroupNameFont.Size = new System.Drawing.Size(52, 13);
            this.lnkConfigGroupNameFont.TabIndex = 44;
            this.lnkConfigGroupNameFont.TabStop = true;
            this.lnkConfigGroupNameFont.Text = "Configure";
            this.lnkConfigGroupNameFont.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConfigGroupNameFont_LinkClicked);
            // 
            // lblGroupNameFont
            // 
            this.lblGroupNameFont.AutoSize = true;
            this.lblGroupNameFont.Location = new System.Drawing.Point(11, 107);
            this.lblGroupNameFont.Name = "lblGroupNameFont";
            this.lblGroupNameFont.Size = new System.Drawing.Size(64, 13);
            this.lblGroupNameFont.TabIndex = 42;
            this.lblGroupNameFont.Text = "# name font";
            // 
            // lnkConfigGroupNameBackColor
            // 
            this.lnkConfigGroupNameBackColor.AutoSize = true;
            this.lnkConfigGroupNameBackColor.Location = new System.Drawing.Point(195, 75);
            this.lnkConfigGroupNameBackColor.Name = "lnkConfigGroupNameBackColor";
            this.lnkConfigGroupNameBackColor.Size = new System.Drawing.Size(52, 13);
            this.lnkConfigGroupNameBackColor.TabIndex = 41;
            this.lnkConfigGroupNameBackColor.TabStop = true;
            this.lnkConfigGroupNameBackColor.Text = "Configure";
            this.lnkConfigGroupNameBackColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConfigGroupNameBackColor_LinkClicked);
            // 
            // pnlGroupNameBackColor
            // 
            this.pnlGroupNameBackColor.Location = new System.Drawing.Point(129, 70);
            this.pnlGroupNameBackColor.Name = "pnlGroupNameBackColor";
            this.pnlGroupNameBackColor.Size = new System.Drawing.Size(60, 25);
            this.pnlGroupNameBackColor.TabIndex = 40;
            // 
            // lblGroupNameBackColor
            // 
            this.lblGroupNameBackColor.Location = new System.Drawing.Point(11, 70);
            this.lblGroupNameBackColor.Name = "lblGroupNameBackColor";
            this.lblGroupNameBackColor.Size = new System.Drawing.Size(90, 35);
            this.lblGroupNameBackColor.TabIndex = 39;
            this.lblGroupNameBackColor.Text = "# name background color";
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(129, 12);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(175, 21);
            this.cmbGroup.TabIndex = 35;
            this.cmbGroup.SelectedIndexChanged += new System.EventHandler(this.cmbGroup_SelectedIndexChanged);
            // 
            // lblSelectAGroup
            // 
            this.lblSelectAGroup.AutoSize = true;
            this.lblSelectAGroup.Location = new System.Drawing.Point(11, 15);
            this.lblSelectAGroup.Name = "lblSelectAGroup";
            this.lblSelectAGroup.Size = new System.Drawing.Size(56, 13);
            this.lblSelectAGroup.TabIndex = 34;
            this.lblSelectAGroup.Text = "Select a #";
            // 
            // lnkConfigGroupNameColor
            // 
            this.lnkConfigGroupNameColor.AutoSize = true;
            this.lnkConfigGroupNameColor.Location = new System.Drawing.Point(195, 45);
            this.lnkConfigGroupNameColor.Name = "lnkConfigGroupNameColor";
            this.lnkConfigGroupNameColor.Size = new System.Drawing.Size(52, 13);
            this.lnkConfigGroupNameColor.TabIndex = 38;
            this.lnkConfigGroupNameColor.TabStop = true;
            this.lnkConfigGroupNameColor.Text = "Configure";
            this.lnkConfigGroupNameColor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkConfigGroupNameColor_LinkClicked);
            // 
            // pnlGroupNameColor
            // 
            this.pnlGroupNameColor.Location = new System.Drawing.Point(129, 39);
            this.pnlGroupNameColor.Name = "pnlGroupNameColor";
            this.pnlGroupNameColor.Size = new System.Drawing.Size(60, 25);
            this.pnlGroupNameColor.TabIndex = 37;
            // 
            // lblGroupNameColor
            // 
            this.lblGroupNameColor.AutoSize = true;
            this.lblGroupNameColor.Location = new System.Drawing.Point(11, 45);
            this.lblGroupNameColor.Name = "lblGroupNameColor";
            this.lblGroupNameColor.Size = new System.Drawing.Size(69, 13);
            this.lblGroupNameColor.TabIndex = 36;
            this.lblGroupNameColor.Text = "# name color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 72;
            this.label4.Text = "Height";
            // 
            // lblGroupNameFontPreview
            // 
            this.lblGroupNameFontPreview.AutoSize = true;
            this.lblGroupNameFontPreview.Location = new System.Drawing.Point(129, 107);
            this.lblGroupNameFontPreview.Name = "lblGroupNameFontPreview";
            this.lblGroupNameFontPreview.Size = new System.Drawing.Size(20, 13);
            this.lblGroupNameFontPreview.TabIndex = 73;
            this.lblGroupNameFontPreview.Text = "Aa";
            // 
            // lblShopNameFontPreview
            // 
            this.lblShopNameFontPreview.AutoSize = true;
            this.lblShopNameFontPreview.Location = new System.Drawing.Point(129, 169);
            this.lblShopNameFontPreview.Name = "lblShopNameFontPreview";
            this.lblShopNameFontPreview.Size = new System.Drawing.Size(20, 13);
            this.lblShopNameFontPreview.TabIndex = 74;
            this.lblShopNameFontPreview.Text = "Aa";
            // 
            // lblShopDescriptionFontPreview
            // 
            this.lblShopDescriptionFontPreview.AutoSize = true;
            this.lblShopDescriptionFontPreview.Location = new System.Drawing.Point(129, 231);
            this.lblShopDescriptionFontPreview.Name = "lblShopDescriptionFontPreview";
            this.lblShopDescriptionFontPreview.Size = new System.Drawing.Size(20, 13);
            this.lblShopDescriptionFontPreview.TabIndex = 75;
            this.lblShopDescriptionFontPreview.Text = "Aa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Preview";
            // 
            // lnkApplyToAll
            // 
            this.lnkApplyToAll.AutoSize = true;
            this.lnkApplyToAll.Location = new System.Drawing.Point(14, 493);
            this.lnkApplyToAll.Name = "lnkApplyToAll";
            this.lnkApplyToAll.Size = new System.Drawing.Size(77, 13);
            this.lnkApplyToAll.TabIndex = 79;
            this.lnkApplyToAll.TabStop = true;
            this.lnkApplyToAll.Text = "Apply this to all";
            this.lnkApplyToAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkApplyToAll_LinkClicked);
            // 
            // lnkMakeDefaultSetting
            // 
            this.lnkMakeDefaultSetting.AutoSize = true;
            this.lnkMakeDefaultSetting.Location = new System.Drawing.Point(15, 515);
            this.lnkMakeDefaultSetting.Name = "lnkMakeDefaultSetting";
            this.lnkMakeDefaultSetting.Size = new System.Drawing.Size(136, 13);
            this.lnkMakeDefaultSetting.TabIndex = 80;
            this.lnkMakeDefaultSetting.TabStop = true;
            this.lnkMakeDefaultSetting.Text = "Make this as default setting";
            this.lnkMakeDefaultSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMakeDefaultSetting_LinkClicked);
            // 
            // listingViewGroupCtrl1
            // 
            this.listingViewGroupCtrl1.GroupSettings = null;
            this.listingViewGroupCtrl1.Location = new System.Drawing.Point(12, 356);
            this.listingViewGroupCtrl1.Name = "listingViewGroupCtrl1";
            this.listingViewGroupCtrl1.Shops = null;
            this.listingViewGroupCtrl1.Size = new System.Drawing.Size(287, 134);
            this.listingViewGroupCtrl1.TabIndex = 81;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(214, 545);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 23);
            this.btnClose.TabIndex = 82;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GroupSettingsForm
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(318, 580);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.listingViewGroupCtrl1);
            this.Controls.Add(this.lnkMakeDefaultSetting);
            this.Controls.Add(this.lnkApplyToAll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblShopDescriptionFontPreview);
            this.Controls.Add(this.lblShopNameFontPreview);
            this.Controls.Add(this.lblGroupNameFontPreview);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudShopHeight);
            this.Controls.Add(this.nudShopWidth);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.nudLogoHeight);
            this.Controls.Add(this.nudLogoWidth);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lnkConfigShopBackColor);
            this.Controls.Add(this.pnlShopBackColor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lnkConfigShopDescFont);
            this.Controls.Add(this.lnkConfigShopDescColor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lnkConfigShopNameFont);
            this.Controls.Add(this.pnlShopDescColor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lnkConfigShopNameColor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pnlShopNameColor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lnkConfigGroupNameFont);
            this.Controls.Add(this.lblGroupNameFont);
            this.Controls.Add(this.lnkConfigGroupNameBackColor);
            this.Controls.Add(this.pnlGroupNameBackColor);
            this.Controls.Add(this.lblGroupNameBackColor);
            this.Controls.Add(this.cmbGroup);
            this.Controls.Add(this.lblSelectAGroup);
            this.Controls.Add(this.lnkConfigGroupNameColor);
            this.Controls.Add(this.pnlGroupNameColor);
            this.Controls.Add(this.lblGroupNameColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GroupSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings Form";
            this.Load += new System.EventHandler(this.GroupSettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudShopHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudShopWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLogoHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLogoWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudShopHeight;
        private System.Windows.Forms.NumericUpDown nudShopWidth;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudLogoHeight;
        private System.Windows.Forms.NumericUpDown nudLogoWidth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.LinkLabel lnkConfigShopBackColor;
        private System.Windows.Forms.Panel pnlShopBackColor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel lnkConfigShopDescFont;
        private System.Windows.Forms.LinkLabel lnkConfigShopDescColor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel lnkConfigShopNameFont;
        private System.Windows.Forms.Panel pnlShopDescColor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel lnkConfigShopNameColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlShopNameColor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel lnkConfigGroupNameFont;
        private System.Windows.Forms.Label lblGroupNameFont;
        private System.Windows.Forms.LinkLabel lnkConfigGroupNameBackColor;
        private System.Windows.Forms.Panel pnlGroupNameBackColor;
        private System.Windows.Forms.Label lblGroupNameBackColor;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label lblSelectAGroup;
        private System.Windows.Forms.LinkLabel lnkConfigGroupNameColor;
        private System.Windows.Forms.Panel pnlGroupNameColor;
        private System.Windows.Forms.Label lblGroupNameColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGroupNameFontPreview;
        private System.Windows.Forms.Label lblShopNameFontPreview;
        private System.Windows.Forms.Label lblShopDescriptionFontPreview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lnkApplyToAll;
        private System.Windows.Forms.LinkLabel lnkMakeDefaultSetting;
        private ListingViewGroupCtrl listingViewGroupCtrl1;
        private DotNetSkin.SkinControls.SkinButton btnClose;
    }
}