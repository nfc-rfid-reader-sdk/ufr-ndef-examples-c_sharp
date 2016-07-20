namespace uFR_NDEF_example
{
    partial class Form2
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
            this.statInfo = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusReader = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusResult = new System.Windows.Forms.ToolStripStatusLabel();
            this.statDevice = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DevInfoSN = new System.Windows.Forms.ToolStripStatusLabel();
            this.DevInfoHW = new System.Windows.Forms.ToolStripStatusLabel();
            this.DevInfoFW = new System.Windows.Forms.ToolStripStatusLabel();
            this.DevInfoDLL = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelReader = new System.Windows.Forms.Panel();
            this.bCloseReader = new System.Windows.Forms.Button();
            this.bOpenReader = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNFCRd = new System.Windows.Forms.TabPage();
            this.bReadCard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SG1 = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPayload = new System.Windows.Forms.RichTextBox();
            this.tabNFCWr = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bWrAAR = new System.Windows.Forms.Button();
            this.eAAR = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPhone = new System.Windows.Forms.TabPage();
            this.btnStorePhoneToReader = new System.Windows.Forms.Button();
            this.bWritePhone = new System.Windows.Forms.Button();
            this.ePhone = new System.Windows.Forms.TextBox();
            this.tabSMS = new System.Windows.Forms.TabPage();
            this.btnStoreSmsToReader = new System.Windows.Forms.Button();
            this.bWrSMS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.eSMSPhone = new System.Windows.Forms.TextBox();
            this.lSMSChars = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eSMS = new System.Windows.Forms.RichTextBox();
            this.tabURL = new System.Windows.Forms.TabPage();
            this.lbPayload = new System.Windows.Forms.Label();
            this.tbPayload = new System.Windows.Forms.TextBox();
            this.lbAsciiMirror = new System.Windows.Forms.Label();
            this.tbAsciiMirror = new System.Windows.Forms.TextBox();
            this.chkCounterAsciiMirror = new System.Windows.Forms.CheckBox();
            this.chkUidAsciiMirror = new System.Windows.Forms.CheckBox();
            this.cbUriIdentifierCode = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnStoreUrlToReader = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.bWrURI = new System.Windows.Forms.Button();
            this.eURL = new System.Windows.Forms.TextBox();
            this.tabCard = new System.Windows.Forms.TabPage();
            this.btnStoreVCardToReader = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.eSkype = new System.Windows.Forms.TextBox();
            this.eWeb = new System.Windows.Forms.TextBox();
            this.eCompany = new System.Windows.Forms.TextBox();
            this.eTitle = new System.Windows.Forms.TextBox();
            this.ePEmail = new System.Windows.Forms.TextBox();
            this.eBEmail = new System.Windows.Forms.TextBox();
            this.ePPhone = new System.Windows.Forms.TextBox();
            this.eCPhone = new System.Windows.Forms.TextBox();
            this.eBPhone = new System.Windows.Forms.TextBox();
            this.eFirst = new System.Windows.Forms.TextBox();
            this.eLast = new System.Windows.Forms.TextBox();
            this.eDisplay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bWrvCard = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStoreBluetoothToReader = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.tabTools = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStartCombinedEmulationMode = new System.Windows.Forms.Button();
            this.btnStopTagEmulation = new System.Windows.Forms.Button();
            this.btnStartTagEmulation = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.bEraseAllRec = new System.Windows.Forms.Button();
            this.bEraseLastRec = new System.Windows.Forms.Button();
            this.bCardClear = new System.Windows.Forms.Button();
            this.bCardInit = new System.Windows.Forms.Button();
            this.statNDEF = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.NdefInfoCardType = new System.Windows.Forms.ToolStripStatusLabel();
            this.NdefInfoMsgs = new System.Windows.Forms.ToolStripStatusLabel();
            this.NdefInfoRecs = new System.Windows.Forms.ToolStripStatusLabel();
            this.NdefInfoEmpty = new System.Windows.Forms.ToolStripStatusLabel();
            this.NdefInfoTNF = new System.Windows.Forms.ToolStripStatusLabel();
            this.statInfo.SuspendLayout();
            this.statDevice.SuspendLayout();
            this.panelReader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabNFCRd.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SG1)).BeginInit();
            this.tabNFCWr.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPhone.SuspendLayout();
            this.tabSMS.SuspendLayout();
            this.tabURL.SuspendLayout();
            this.tabCard.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabTools.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statNDEF.SuspendLayout();
            this.SuspendLayout();
            // 
            // statInfo
            // 
            this.statInfo.AutoSize = false;
            this.statInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel6,
            this.statusReader,
            this.statusResult});
            this.statInfo.Location = new System.Drawing.Point(0, 596);
            this.statInfo.Name = "statInfo";
            this.statInfo.Size = new System.Drawing.Size(443, 22);
            this.statInfo.TabIndex = 4;
            this.statInfo.Text = "statusStrip1";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.AutoSize = false;
            this.toolStripStatusLabel6.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel6.Text = "STATUS";
            // 
            // statusReader
            // 
            this.statusReader.AutoSize = false;
            this.statusReader.Name = "statusReader";
            this.statusReader.Size = new System.Drawing.Size(160, 17);
            this.statusReader.Text = "statusReader";
            // 
            // statusResult
            // 
            this.statusResult.AutoSize = false;
            this.statusResult.Name = "statusResult";
            this.statusResult.Size = new System.Drawing.Size(200, 17);
            this.statusResult.Text = "statusResult";
            // 
            // statDevice
            // 
            this.statDevice.AutoSize = false;
            this.statDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.statDevice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel5,
            this.DevInfoSN,
            this.DevInfoHW,
            this.DevInfoFW,
            this.DevInfoDLL});
            this.statDevice.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statDevice.Location = new System.Drawing.Point(0, 574);
            this.statDevice.Name = "statDevice";
            this.statDevice.Size = new System.Drawing.Size(443, 22);
            this.statDevice.Stretch = false;
            this.statDevice.TabIndex = 3;
            this.statDevice.Text = "statusStrip2";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.AutoSize = false;
            this.toolStripStatusLabel5.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel5.Text = "DEVICE";
            // 
            // DevInfoSN
            // 
            this.DevInfoSN.AutoSize = false;
            this.DevInfoSN.Name = "DevInfoSN";
            this.DevInfoSN.Size = new System.Drawing.Size(94, 17);
            this.DevInfoSN.Text = "DevInfoSN";
            this.DevInfoSN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DevInfoHW
            // 
            this.DevInfoHW.AutoSize = false;
            this.DevInfoHW.Name = "DevInfoHW";
            this.DevInfoHW.Size = new System.Drawing.Size(94, 17);
            this.DevInfoHW.Text = "DevInfoHW";
            this.DevInfoHW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DevInfoFW
            // 
            this.DevInfoFW.AutoSize = false;
            this.DevInfoFW.Name = "DevInfoFW";
            this.DevInfoFW.Size = new System.Drawing.Size(94, 17);
            this.DevInfoFW.Text = "DevInfoFW";
            this.DevInfoFW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DevInfoDLL
            // 
            this.DevInfoDLL.AutoSize = false;
            this.DevInfoDLL.Name = "DevInfoDLL";
            this.DevInfoDLL.Size = new System.Drawing.Size(94, 17);
            this.DevInfoDLL.Text = "DevInfoDLL";
            this.DevInfoDLL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelReader
            // 
            this.panelReader.BackColor = System.Drawing.Color.Red;
            this.panelReader.Controls.Add(this.bCloseReader);
            this.panelReader.Controls.Add(this.bOpenReader);
            this.panelReader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReader.Location = new System.Drawing.Point(0, 0);
            this.panelReader.Name = "panelReader";
            this.panelReader.Size = new System.Drawing.Size(443, 46);
            this.panelReader.TabIndex = 0;
            // 
            // bCloseReader
            // 
            this.bCloseReader.Location = new System.Drawing.Point(241, 3);
            this.bCloseReader.Name = "bCloseReader";
            this.bCloseReader.Size = new System.Drawing.Size(190, 38);
            this.bCloseReader.TabIndex = 1;
            this.bCloseReader.Text = "Close Reader";
            this.bCloseReader.UseVisualStyleBackColor = true;
            this.bCloseReader.Click += new System.EventHandler(this.bCloseReader_Click);
            // 
            // bOpenReader
            // 
            this.bOpenReader.Location = new System.Drawing.Point(12, 3);
            this.bOpenReader.Name = "bOpenReader";
            this.bOpenReader.Size = new System.Drawing.Size(190, 38);
            this.bOpenReader.TabIndex = 0;
            this.bOpenReader.Text = "Open Reader";
            this.bOpenReader.UseVisualStyleBackColor = true;
            this.bOpenReader.Click += new System.EventHandler(this.bOpenReader_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabNFCRd);
            this.tabControl1.Controls.Add(this.tabNFCWr);
            this.tabControl1.Controls.Add(this.tabTools);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(6, 8);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(443, 506);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 1;
            // 
            // tabNFCRd
            // 
            this.tabNFCRd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabNFCRd.Controls.Add(this.bReadCard);
            this.tabNFCRd.Controls.Add(this.panel1);
            this.tabNFCRd.Location = new System.Drawing.Point(4, 35);
            this.tabNFCRd.Name = "tabNFCRd";
            this.tabNFCRd.Padding = new System.Windows.Forms.Padding(3);
            this.tabNFCRd.Size = new System.Drawing.Size(435, 467);
            this.tabNFCRd.TabIndex = 0;
            this.tabNFCRd.Text = "Read NFC data";
            this.tabNFCRd.UseVisualStyleBackColor = true;
            // 
            // bReadCard
            // 
            this.bReadCard.Location = new System.Drawing.Point(7, 6);
            this.bReadCard.Name = "bReadCard";
            this.bReadCard.Size = new System.Drawing.Size(419, 38);
            this.bReadCard.TabIndex = 0;
            this.bReadCard.Text = "Read Card";
            this.bReadCard.UseVisualStyleBackColor = true;
            this.bReadCard.Click += new System.EventHandler(this.bReadCard_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SG1);
            this.panel1.Controls.Add(this.txtPayload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 410);
            this.panel1.TabIndex = 1;
            // 
            // SG1
            // 
            this.SG1.AllowUserToAddRows = false;
            this.SG1.AllowUserToDeleteRows = false;
            this.SG1.AllowUserToResizeRows = false;
            this.SG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SG1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Type,
            this.Length,
            this.Payload});
            this.SG1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SG1.Location = new System.Drawing.Point(0, 0);
            this.SG1.Name = "SG1";
            this.SG1.RowHeadersVisible = false;
            this.SG1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SG1.Size = new System.Drawing.Size(427, 265);
            this.SG1.TabIndex = 0;
            this.SG1.SelectionChanged += new System.EventHandler(this.SG1_SelectionChanged);
            // 
            // No
            // 
            this.No.Frozen = true;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 30;
            // 
            // Type
            // 
            this.Type.Frozen = true;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 40;
            // 
            // Length
            // 
            this.Length.Frozen = true;
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            this.Length.Width = 50;
            // 
            // Payload
            // 
            this.Payload.Frozen = true;
            this.Payload.HeaderText = "Payload";
            this.Payload.Name = "Payload";
            this.Payload.ReadOnly = true;
            this.Payload.Width = 250;
            // 
            // txtPayload
            // 
            this.txtPayload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPayload.Location = new System.Drawing.Point(0, 265);
            this.txtPayload.Name = "txtPayload";
            this.txtPayload.ReadOnly = true;
            this.txtPayload.Size = new System.Drawing.Size(427, 145);
            this.txtPayload.TabIndex = 1;
            this.txtPayload.Text = "Payload:";
            // 
            // tabNFCWr
            // 
            this.tabNFCWr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabNFCWr.Controls.Add(this.groupBox1);
            this.tabNFCWr.Controls.Add(this.panel4);
            this.tabNFCWr.Location = new System.Drawing.Point(4, 35);
            this.tabNFCWr.Name = "tabNFCWr";
            this.tabNFCWr.Padding = new System.Windows.Forms.Padding(3);
            this.tabNFCWr.Size = new System.Drawing.Size(435, 467);
            this.tabNFCWr.TabIndex = 1;
            this.tabNFCWr.Text = "Write NFC data";
            this.tabNFCWr.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bWrAAR);
            this.groupBox1.Controls.Add(this.eAAR);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 387);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Launch Application ( AAR )";
            // 
            // bWrAAR
            // 
            this.bWrAAR.Location = new System.Drawing.Point(9, 45);
            this.bWrAAR.Name = "bWrAAR";
            this.bWrAAR.Size = new System.Drawing.Size(412, 23);
            this.bWrAAR.TabIndex = 2;
            this.bWrAAR.Text = "Write AAR";
            this.bWrAAR.UseVisualStyleBackColor = true;
            this.bWrAAR.Click += new System.EventHandler(this.bWrAAR_Click);
            // 
            // eAAR
            // 
            this.eAAR.Location = new System.Drawing.Point(76, 19);
            this.eAAR.Name = "eAAR";
            this.eAAR.Size = new System.Drawing.Size(345, 20);
            this.eAAR.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Pkg name : ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControl2);
            this.panel4.Location = new System.Drawing.Point(-1, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 387);
            this.panel4.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPhone);
            this.tabControl2.Controls.Add(this.tabSMS);
            this.tabControl2.Controls.Add(this.tabURL);
            this.tabControl2.Controls.Add(this.tabCard);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(435, 387);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPhone
            // 
            this.tabPhone.Controls.Add(this.btnStorePhoneToReader);
            this.tabPhone.Controls.Add(this.bWritePhone);
            this.tabPhone.Controls.Add(this.ePhone);
            this.tabPhone.Location = new System.Drawing.Point(4, 22);
            this.tabPhone.Name = "tabPhone";
            this.tabPhone.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhone.Size = new System.Drawing.Size(427, 361);
            this.tabPhone.TabIndex = 0;
            this.tabPhone.Text = "Phone";
            this.tabPhone.UseVisualStyleBackColor = true;
            // 
            // btnStorePhoneToReader
            // 
            this.btnStorePhoneToReader.Location = new System.Drawing.Point(6, 122);
            this.btnStorePhoneToReader.Name = "btnStorePhoneToReader";
            this.btnStorePhoneToReader.Size = new System.Drawing.Size(402, 84);
            this.btnStorePhoneToReader.TabIndex = 2;
            this.btnStorePhoneToReader.Text = "Store phone number for tag emulation mode\r\n(min. v3.8.0 firmware and library need" +
    "ed)";
            this.btnStorePhoneToReader.UseVisualStyleBackColor = true;
            this.btnStorePhoneToReader.Click += new System.EventHandler(this.btnStorePhoneToReader_Click);
            // 
            // bWritePhone
            // 
            this.bWritePhone.Location = new System.Drawing.Point(6, 32);
            this.bWritePhone.Name = "bWritePhone";
            this.bWritePhone.Size = new System.Drawing.Size(402, 84);
            this.bWritePhone.TabIndex = 1;
            this.bWritePhone.Text = "Write Phone";
            this.bWritePhone.UseVisualStyleBackColor = true;
            this.bWritePhone.Click += new System.EventHandler(this.bWritePhone_Click);
            // 
            // ePhone
            // 
            this.ePhone.Location = new System.Drawing.Point(6, 6);
            this.ePhone.Name = "ePhone";
            this.ePhone.Size = new System.Drawing.Size(402, 20);
            this.ePhone.TabIndex = 0;
            // 
            // tabSMS
            // 
            this.tabSMS.Controls.Add(this.btnStoreSmsToReader);
            this.tabSMS.Controls.Add(this.bWrSMS);
            this.tabSMS.Controls.Add(this.label2);
            this.tabSMS.Controls.Add(this.eSMSPhone);
            this.tabSMS.Controls.Add(this.lSMSChars);
            this.tabSMS.Controls.Add(this.label1);
            this.tabSMS.Controls.Add(this.eSMS);
            this.tabSMS.Location = new System.Drawing.Point(4, 22);
            this.tabSMS.Name = "tabSMS";
            this.tabSMS.Padding = new System.Windows.Forms.Padding(3);
            this.tabSMS.Size = new System.Drawing.Size(427, 361);
            this.tabSMS.TabIndex = 1;
            this.tabSMS.Text = "SMS";
            this.tabSMS.UseVisualStyleBackColor = true;
            // 
            // btnStoreSmsToReader
            // 
            this.btnStoreSmsToReader.Location = new System.Drawing.Point(10, 232);
            this.btnStoreSmsToReader.Name = "btnStoreSmsToReader";
            this.btnStoreSmsToReader.Size = new System.Drawing.Size(283, 61);
            this.btnStoreSmsToReader.TabIndex = 6;
            this.btnStoreSmsToReader.Text = "Store SMS for tag emulation mode\r\n(min. v3.8.0 firmware and library needed)";
            this.btnStoreSmsToReader.UseVisualStyleBackColor = true;
            this.btnStoreSmsToReader.Click += new System.EventHandler(this.btnStoreSmsToReader_Click);
            // 
            // bWrSMS
            // 
            this.bWrSMS.Location = new System.Drawing.Point(167, 23);
            this.bWrSMS.Name = "bWrSMS";
            this.bWrSMS.Size = new System.Drawing.Size(126, 203);
            this.bWrSMS.TabIndex = 2;
            this.bWrSMS.Text = "Write SMS";
            this.bWrSMS.UseVisualStyleBackColor = true;
            this.bWrSMS.Click += new System.EventHandler(this.bWrSMS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Phone No.";
            // 
            // eSMSPhone
            // 
            this.eSMSPhone.Location = new System.Drawing.Point(10, 206);
            this.eSMSPhone.Name = "eSMSPhone";
            this.eSMSPhone.Size = new System.Drawing.Size(151, 20);
            this.eSMSPhone.TabIndex = 5;
            // 
            // lSMSChars
            // 
            this.lSMSChars.AutoSize = true;
            this.lSMSChars.Location = new System.Drawing.Point(96, 172);
            this.lSMSChars.Name = "lSMSChars";
            this.lSMSChars.Size = new System.Drawing.Size(37, 13);
            this.lSMSChars.TabIndex = 3;
            this.lSMSChars.Text = "Chars:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Message text (max. 160 chars).";
            // 
            // eSMS
            // 
            this.eSMS.Location = new System.Drawing.Point(10, 23);
            this.eSMS.Name = "eSMS";
            this.eSMS.Size = new System.Drawing.Size(151, 146);
            this.eSMS.TabIndex = 1;
            this.eSMS.Text = "";
            // 
            // tabURL
            // 
            this.tabURL.Controls.Add(this.lbPayload);
            this.tabURL.Controls.Add(this.tbPayload);
            this.tabURL.Controls.Add(this.lbAsciiMirror);
            this.tabURL.Controls.Add(this.tbAsciiMirror);
            this.tabURL.Controls.Add(this.chkCounterAsciiMirror);
            this.tabURL.Controls.Add(this.chkUidAsciiMirror);
            this.tabURL.Controls.Add(this.cbUriIdentifierCode);
            this.tabURL.Controls.Add(this.label18);
            this.tabURL.Controls.Add(this.btnStoreUrlToReader);
            this.tabURL.Controls.Add(this.label15);
            this.tabURL.Controls.Add(this.bWrURI);
            this.tabURL.Controls.Add(this.eURL);
            this.tabURL.Location = new System.Drawing.Point(4, 22);
            this.tabURL.Name = "tabURL";
            this.tabURL.Padding = new System.Windows.Forms.Padding(3);
            this.tabURL.Size = new System.Drawing.Size(427, 361);
            this.tabURL.TabIndex = 2;
            this.tabURL.Text = "URI";
            this.tabURL.UseVisualStyleBackColor = true;
            // 
            // lbPayload
            // 
            this.lbPayload.AutoSize = true;
            this.lbPayload.Location = new System.Drawing.Point(6, 255);
            this.lbPayload.Name = "lbPayload";
            this.lbPayload.Size = new System.Drawing.Size(80, 13);
            this.lbPayload.TabIndex = 10;
            this.lbPayload.Text = "Result payload:";
            // 
            // tbPayload
            // 
            this.tbPayload.Location = new System.Drawing.Point(6, 271);
            this.tbPayload.Multiline = true;
            this.tbPayload.Name = "tbPayload";
            this.tbPayload.ReadOnly = true;
            this.tbPayload.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPayload.Size = new System.Drawing.Size(195, 84);
            this.tbPayload.TabIndex = 11;
            // 
            // lbAsciiMirror
            // 
            this.lbAsciiMirror.AutoSize = true;
            this.lbAsciiMirror.Enabled = false;
            this.lbAsciiMirror.Location = new System.Drawing.Point(38, 148);
            this.lbAsciiMirror.Name = "lbAsciiMirror";
            this.lbAsciiMirror.Size = new System.Drawing.Size(213, 13);
            this.lbAsciiMirror.TabIndex = 5;
            this.lbAsciiMirror.Text = "ASCII Prefix (delimiter and parameter name):";
            // 
            // tbAsciiMirror
            // 
            this.tbAsciiMirror.Enabled = false;
            this.tbAsciiMirror.Location = new System.Drawing.Point(41, 164);
            this.tbAsciiMirror.Name = "tbAsciiMirror";
            this.tbAsciiMirror.Size = new System.Drawing.Size(250, 20);
            this.tbAsciiMirror.TabIndex = 6;
            this.tbAsciiMirror.Text = "?m=";
            this.tbAsciiMirror.TextChanged += new System.EventHandler(this.updatePayload);
            // 
            // chkCounterAsciiMirror
            // 
            this.chkCounterAsciiMirror.AutoSize = true;
            this.chkCounterAsciiMirror.Location = new System.Drawing.Point(41, 119);
            this.chkCounterAsciiMirror.Name = "chkCounterAsciiMirror";
            this.chkCounterAsciiMirror.Size = new System.Drawing.Size(307, 17);
            this.chkCounterAsciiMirror.TabIndex = 7;
            this.chkCounterAsciiMirror.Text = "Enable NFC Counter ASCII Mirror (NTAG213/215/216 only)";
            this.chkCounterAsciiMirror.UseVisualStyleBackColor = true;
            this.chkCounterAsciiMirror.CheckedChanged += new System.EventHandler(this.chkCounterAsciiMirror_CheckedChanged);
            // 
            // chkUidAsciiMirror
            // 
            this.chkUidAsciiMirror.AutoSize = true;
            this.chkUidAsciiMirror.Location = new System.Drawing.Point(41, 96);
            this.chkUidAsciiMirror.Name = "chkUidAsciiMirror";
            this.chkUidAsciiMirror.Size = new System.Drawing.Size(218, 17);
            this.chkUidAsciiMirror.TabIndex = 4;
            this.chkUidAsciiMirror.Text = "Enable UID ASCII Mirror (NTAG21x only)";
            this.chkUidAsciiMirror.UseVisualStyleBackColor = true;
            this.chkUidAsciiMirror.CheckedChanged += new System.EventHandler(this.chkUidAsciiMirror_CheckedChanged);
            // 
            // cbUriIdentifierCode
            // 
            this.cbUriIdentifierCode.FormattingEnabled = true;
            this.cbUriIdentifierCode.Items.AddRange(new object[] {
            "N/A. No prepending is done.",
            "http://www.",
            "https://www.",
            "http://",
            "https://",
            "tel:",
            "mailto:",
            "ftp://anonymous:anonymous@",
            "ftp://ftp.",
            "ftps://",
            "sftp://",
            "smb://",
            "nfs://",
            "ftp://",
            "dav://",
            "news:",
            "telnet://",
            "imap:",
            "rtsp://",
            "urn:",
            "pop:",
            "sip:",
            "sips:",
            "tftp:",
            "btspp://",
            "btl2cap://",
            "btgoep://",
            "tcpobex://",
            "irdaobex://",
            "file://",
            "urn:epc:id:",
            " urn:epc:tag:",
            "urn:epc:pat:",
            "urn:epc:raw:",
            "urn:epc:",
            "urn:nfc:"});
            this.cbUriIdentifierCode.Location = new System.Drawing.Point(152, 17);
            this.cbUriIdentifierCode.Name = "cbUriIdentifierCode";
            this.cbUriIdentifierCode.Size = new System.Drawing.Size(230, 21);
            this.cbUriIdentifierCode.TabIndex = 1;
            this.cbUriIdentifierCode.SelectedIndexChanged += new System.EventHandler(this.updatePayload);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(38, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "URI Identifier Code:";
            // 
            // btnStoreUrlToReader
            // 
            this.btnStoreUrlToReader.Location = new System.Drawing.Point(207, 315);
            this.btnStoreUrlToReader.Name = "btnStoreUrlToReader";
            this.btnStoreUrlToReader.Size = new System.Drawing.Size(214, 40);
            this.btnStoreUrlToReader.TabIndex = 13;
            this.btnStoreUrlToReader.Text = "Store URL for tag emulation mode\r\n(min. v3.8.0 firmware and library needed)";
            this.btnStoreUrlToReader.UseVisualStyleBackColor = true;
            this.btnStoreUrlToReader.Click += new System.EventHandler(this.btnStoreUrlToReader_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "URI field:";
            // 
            // bWrURI
            // 
            this.bWrURI.Location = new System.Drawing.Point(207, 271);
            this.bWrURI.Name = "bWrURI";
            this.bWrURI.Size = new System.Drawing.Size(214, 38);
            this.bWrURI.TabIndex = 12;
            this.bWrURI.Text = "Write URI";
            this.bWrURI.UseVisualStyleBackColor = true;
            this.bWrURI.Click += new System.EventHandler(this.bWrURL_Click);
            // 
            // eURL
            // 
            this.eURL.Location = new System.Drawing.Point(41, 61);
            this.eURL.Name = "eURL";
            this.eURL.Size = new System.Drawing.Size(341, 20);
            this.eURL.TabIndex = 3;
            this.eURL.TextChanged += new System.EventHandler(this.updatePayload);
            // 
            // tabCard
            // 
            this.tabCard.Controls.Add(this.btnStoreVCardToReader);
            this.tabCard.Controls.Add(this.label14);
            this.tabCard.Controls.Add(this.label13);
            this.tabCard.Controls.Add(this.label12);
            this.tabCard.Controls.Add(this.label11);
            this.tabCard.Controls.Add(this.label10);
            this.tabCard.Controls.Add(this.label9);
            this.tabCard.Controls.Add(this.eSkype);
            this.tabCard.Controls.Add(this.eWeb);
            this.tabCard.Controls.Add(this.eCompany);
            this.tabCard.Controls.Add(this.eTitle);
            this.tabCard.Controls.Add(this.ePEmail);
            this.tabCard.Controls.Add(this.eBEmail);
            this.tabCard.Controls.Add(this.ePPhone);
            this.tabCard.Controls.Add(this.eCPhone);
            this.tabCard.Controls.Add(this.eBPhone);
            this.tabCard.Controls.Add(this.eFirst);
            this.tabCard.Controls.Add(this.eLast);
            this.tabCard.Controls.Add(this.eDisplay);
            this.tabCard.Controls.Add(this.label8);
            this.tabCard.Controls.Add(this.label7);
            this.tabCard.Controls.Add(this.label6);
            this.tabCard.Controls.Add(this.label5);
            this.tabCard.Controls.Add(this.label4);
            this.tabCard.Controls.Add(this.label3);
            this.tabCard.Controls.Add(this.bWrvCard);
            this.tabCard.Location = new System.Drawing.Point(4, 22);
            this.tabCard.Name = "tabCard";
            this.tabCard.Padding = new System.Windows.Forms.Padding(3);
            this.tabCard.Size = new System.Drawing.Size(427, 361);
            this.tabCard.TabIndex = 3;
            this.tabCard.Text = "vCard";
            this.tabCard.UseVisualStyleBackColor = true;
            // 
            // btnStoreVCardToReader
            // 
            this.btnStoreVCardToReader.Location = new System.Drawing.Point(323, 218);
            this.btnStoreVCardToReader.Name = "btnStoreVCardToReader";
            this.btnStoreVCardToReader.Size = new System.Drawing.Size(98, 137);
            this.btnStoreVCardToReader.TabIndex = 25;
            this.btnStoreVCardToReader.Text = "Store vCard for tag emulation mode\r\n(min. v3.8.0 firmware and library needed)";
            this.btnStoreVCardToReader.UseVisualStyleBackColor = true;
            this.btnStoreVCardToReader.Click += new System.EventHandler(this.btnStoreVCardToReader_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 299);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Skype name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Website URL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Company";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Title";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Private E-mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Bussiness E-mail";
            // 
            // eSkype
            // 
            this.eSkype.Location = new System.Drawing.Point(120, 296);
            this.eSkype.Name = "eSkype";
            this.eSkype.Size = new System.Drawing.Size(197, 20);
            this.eSkype.TabIndex = 23;
            // 
            // eWeb
            // 
            this.eWeb.Location = new System.Drawing.Point(120, 270);
            this.eWeb.Name = "eWeb";
            this.eWeb.Size = new System.Drawing.Size(197, 20);
            this.eWeb.TabIndex = 21;
            // 
            // eCompany
            // 
            this.eCompany.Location = new System.Drawing.Point(120, 244);
            this.eCompany.Name = "eCompany";
            this.eCompany.Size = new System.Drawing.Size(197, 20);
            this.eCompany.TabIndex = 19;
            // 
            // eTitle
            // 
            this.eTitle.Location = new System.Drawing.Point(120, 218);
            this.eTitle.Name = "eTitle";
            this.eTitle.Size = new System.Drawing.Size(197, 20);
            this.eTitle.TabIndex = 17;
            // 
            // ePEmail
            // 
            this.ePEmail.Location = new System.Drawing.Point(120, 192);
            this.ePEmail.Name = "ePEmail";
            this.ePEmail.Size = new System.Drawing.Size(197, 20);
            this.ePEmail.TabIndex = 15;
            // 
            // eBEmail
            // 
            this.eBEmail.Location = new System.Drawing.Point(120, 166);
            this.eBEmail.Name = "eBEmail";
            this.eBEmail.Size = new System.Drawing.Size(197, 20);
            this.eBEmail.TabIndex = 13;
            // 
            // ePPhone
            // 
            this.ePPhone.Location = new System.Drawing.Point(120, 140);
            this.ePPhone.Name = "ePPhone";
            this.ePPhone.Size = new System.Drawing.Size(197, 20);
            this.ePPhone.TabIndex = 11;
            // 
            // eCPhone
            // 
            this.eCPhone.Location = new System.Drawing.Point(120, 114);
            this.eCPhone.Name = "eCPhone";
            this.eCPhone.Size = new System.Drawing.Size(197, 20);
            this.eCPhone.TabIndex = 9;
            // 
            // eBPhone
            // 
            this.eBPhone.Location = new System.Drawing.Point(120, 88);
            this.eBPhone.Name = "eBPhone";
            this.eBPhone.Size = new System.Drawing.Size(197, 20);
            this.eBPhone.TabIndex = 7;
            // 
            // eFirst
            // 
            this.eFirst.Location = new System.Drawing.Point(120, 62);
            this.eFirst.Name = "eFirst";
            this.eFirst.Size = new System.Drawing.Size(197, 20);
            this.eFirst.TabIndex = 5;
            // 
            // eLast
            // 
            this.eLast.Location = new System.Drawing.Point(120, 36);
            this.eLast.Name = "eLast";
            this.eLast.Size = new System.Drawing.Size(197, 20);
            this.eLast.TabIndex = 3;
            // 
            // eDisplay
            // 
            this.eDisplay.Location = new System.Drawing.Point(120, 10);
            this.eDisplay.Name = "eDisplay";
            this.eDisplay.Size = new System.Drawing.Size(197, 20);
            this.eDisplay.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Private Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cell Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bussiness Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "* Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "* Display Name";
            // 
            // bWrvCard
            // 
            this.bWrvCard.Location = new System.Drawing.Point(21, 332);
            this.bWrvCard.Name = "bWrvCard";
            this.bWrvCard.Size = new System.Drawing.Size(296, 23);
            this.bWrvCard.TabIndex = 24;
            this.bWrvCard.Text = "Write vCard";
            this.bWrvCard.UseVisualStyleBackColor = true;
            this.bWrvCard.Click += new System.EventHandler(this.bWrvCard_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(427, 361);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Bluetooth";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStoreBluetoothToReader);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(41, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 268);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bluetooth secure simple pairing";
            // 
            // btnStoreBluetoothToReader
            // 
            this.btnStoreBluetoothToReader.Location = new System.Drawing.Point(35, 172);
            this.btnStoreBluetoothToReader.Name = "btnStoreBluetoothToReader";
            this.btnStoreBluetoothToReader.Size = new System.Drawing.Size(274, 62);
            this.btnStoreBluetoothToReader.TabIndex = 3;
            this.btnStoreBluetoothToReader.Text = "Store Bluetooth Address for tag emulation mode\r\n(min. v3.8.0 firmware and library" +
    " needed)";
            this.btnStoreBluetoothToReader.UseVisualStyleBackColor = true;
            this.btnStoreBluetoothToReader.Click += new System.EventHandler(this.btnStoreBluetoothToReader_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maskedTextBox1.Location = new System.Drawing.Point(80, 72);
            this.maskedTextBox1.Mask = ">AA:AA:AA:AA:AA:AA";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(182, 23);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.Enter += new System.EventHandler(this.maskedTextBox1_Enter);
            this.maskedTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Write Bluetooth Address";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(124, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Bluetooth address:";
            // 
            // tabTools
            // 
            this.tabTools.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabTools.Controls.Add(this.groupBox3);
            this.tabTools.Controls.Add(this.progressBar1);
            this.tabTools.Controls.Add(this.bEraseAllRec);
            this.tabTools.Controls.Add(this.bEraseLastRec);
            this.tabTools.Controls.Add(this.bCardClear);
            this.tabTools.Controls.Add(this.bCardInit);
            this.tabTools.Location = new System.Drawing.Point(4, 35);
            this.tabTools.Name = "tabTools";
            this.tabTools.Padding = new System.Windows.Forms.Padding(3);
            this.tabTools.Size = new System.Drawing.Size(435, 467);
            this.tabTools.TabIndex = 2;
            this.tabTools.Text = "TOOLS";
            this.tabTools.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStartCombinedEmulationMode);
            this.groupBox3.Controls.Add(this.btnStopTagEmulation);
            this.groupBox3.Controls.Add(this.btnStartTagEmulation);
            this.groupBox3.Location = new System.Drawing.Point(9, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 215);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tag emulation mode (min. firmware v3.9.2 and library v3.9.7 needed)";
            // 
            // btnStartCombinedEmulationMode
            // 
            this.btnStartCombinedEmulationMode.Location = new System.Drawing.Point(104, 88);
            this.btnStartCombinedEmulationMode.Name = "btnStartCombinedEmulationMode";
            this.btnStartCombinedEmulationMode.Size = new System.Drawing.Size(226, 38);
            this.btnStartCombinedEmulationMode.TabIndex = 5;
            this.btnStartCombinedEmulationMode.Text = "Start combined tag emulation mode";
            this.btnStartCombinedEmulationMode.UseVisualStyleBackColor = true;
            this.btnStartCombinedEmulationMode.Click += new System.EventHandler(this.btnStartCombinedEmulationMode_Click);
            // 
            // btnStopTagEmulation
            // 
            this.btnStopTagEmulation.Location = new System.Drawing.Point(104, 132);
            this.btnStopTagEmulation.Name = "btnStopTagEmulation";
            this.btnStopTagEmulation.Size = new System.Drawing.Size(226, 38);
            this.btnStopTagEmulation.TabIndex = 4;
            this.btnStopTagEmulation.Text = "Stop tag emulation mode";
            this.btnStopTagEmulation.UseVisualStyleBackColor = true;
            this.btnStopTagEmulation.Click += new System.EventHandler(this.btnStopTagEmulation_Click);
            // 
            // btnStartTagEmulation
            // 
            this.btnStartTagEmulation.Location = new System.Drawing.Point(104, 44);
            this.btnStartTagEmulation.Name = "btnStartTagEmulation";
            this.btnStartTagEmulation.Size = new System.Drawing.Size(226, 38);
            this.btnStartTagEmulation.TabIndex = 3;
            this.btnStartTagEmulation.Text = "Start dedicated tag emulation mode";
            this.btnStartTagEmulation.UseVisualStyleBackColor = true;
            this.btnStartTagEmulation.Click += new System.EventHandler(this.btnStartTagEmulation_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(3, 437);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(425, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // bEraseAllRec
            // 
            this.bEraseAllRec.Location = new System.Drawing.Point(143, 106);
            this.bEraseAllRec.Name = "bEraseAllRec";
            this.bEraseAllRec.Size = new System.Drawing.Size(248, 38);
            this.bEraseAllRec.TabIndex = 2;
            this.bEraseAllRec.Text = "Erase All Records";
            this.bEraseAllRec.UseVisualStyleBackColor = true;
            this.bEraseAllRec.Click += new System.EventHandler(this.bEraseAllRec_Click);
            // 
            // bEraseLastRec
            // 
            this.bEraseLastRec.Location = new System.Drawing.Point(143, 62);
            this.bEraseLastRec.Name = "bEraseLastRec";
            this.bEraseLastRec.Size = new System.Drawing.Size(248, 38);
            this.bEraseLastRec.TabIndex = 1;
            this.bEraseLastRec.Text = "Erase Last Record";
            this.bEraseLastRec.UseVisualStyleBackColor = true;
            this.bEraseLastRec.Click += new System.EventHandler(this.bEraseLastRec_Click);
            // 
            // bCardClear
            // 
            this.bCardClear.Location = new System.Drawing.Point(143, 150);
            this.bCardClear.Name = "bCardClear";
            this.bCardClear.Size = new System.Drawing.Size(248, 38);
            this.bCardClear.TabIndex = 3;
            this.bCardClear.Text = "Card Clear";
            this.bCardClear.UseVisualStyleBackColor = true;
            this.bCardClear.Click += new System.EventHandler(this.bCardClear_Click);
            // 
            // bCardInit
            // 
            this.bCardInit.Location = new System.Drawing.Point(9, 18);
            this.bCardInit.Name = "bCardInit";
            this.bCardInit.Size = new System.Drawing.Size(416, 38);
            this.bCardInit.TabIndex = 0;
            this.bCardInit.Text = "Card Initialize for NDEF messages";
            this.bCardInit.UseVisualStyleBackColor = true;
            this.bCardInit.Click += new System.EventHandler(this.bCardInit_Click);
            // 
            // statNDEF
            // 
            this.statNDEF.AutoSize = false;
            this.statNDEF.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statNDEF.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.NdefInfoCardType,
            this.NdefInfoMsgs,
            this.NdefInfoRecs,
            this.NdefInfoEmpty,
            this.NdefInfoTNF});
            this.statNDEF.Location = new System.Drawing.Point(0, 552);
            this.statNDEF.Name = "statNDEF";
            this.statNDEF.Size = new System.Drawing.Size(443, 22);
            this.statNDEF.TabIndex = 2;
            this.statNDEF.Text = "statusStrip3";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 17);
            this.toolStripStatusLabel1.Text = "NDEF";
            // 
            // NdefInfoCardType
            // 
            this.NdefInfoCardType.AutoSize = false;
            this.NdefInfoCardType.Name = "NdefInfoCardType";
            this.NdefInfoCardType.Size = new System.Drawing.Size(160, 17);
            this.NdefInfoCardType.Text = "NdefInfoCardType";
            // 
            // NdefInfoMsgs
            // 
            this.NdefInfoMsgs.AutoSize = false;
            this.NdefInfoMsgs.Name = "NdefInfoMsgs";
            this.NdefInfoMsgs.Size = new System.Drawing.Size(50, 17);
            this.NdefInfoMsgs.Text = "Msgs";
            // 
            // NdefInfoRecs
            // 
            this.NdefInfoRecs.AutoSize = false;
            this.NdefInfoRecs.Name = "NdefInfoRecs";
            this.NdefInfoRecs.Size = new System.Drawing.Size(50, 17);
            this.NdefInfoRecs.Text = "Recs";
            // 
            // NdefInfoEmpty
            // 
            this.NdefInfoEmpty.AutoSize = false;
            this.NdefInfoEmpty.Name = "NdefInfoEmpty";
            this.NdefInfoEmpty.Size = new System.Drawing.Size(50, 17);
            this.NdefInfoEmpty.Text = "Empty";
            // 
            // NdefInfoTNF
            // 
            this.NdefInfoTNF.AutoSize = false;
            this.NdefInfoTNF.Name = "NdefInfoTNF";
            this.NdefInfoTNF.Size = new System.Drawing.Size(50, 17);
            this.NdefInfoTNF.Text = "TNF";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 618);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelReader);
            this.Controls.Add(this.statNDEF);
            this.Controls.Add(this.statDevice);
            this.Controls.Add(this.statInfo);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  NFC Type 2 Tag programming example v3.1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.statInfo.ResumeLayout(false);
            this.statInfo.PerformLayout();
            this.statDevice.ResumeLayout(false);
            this.statDevice.PerformLayout();
            this.panelReader.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabNFCRd.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SG1)).EndInit();
            this.tabNFCWr.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPhone.ResumeLayout(false);
            this.tabPhone.PerformLayout();
            this.tabSMS.ResumeLayout(false);
            this.tabSMS.PerformLayout();
            this.tabURL.ResumeLayout(false);
            this.tabURL.PerformLayout();
            this.tabCard.ResumeLayout(false);
            this.tabCard.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabTools.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.statNDEF.ResumeLayout(false);
            this.statNDEF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Windows Form Designer object

        private System.Windows.Forms.StatusStrip statInfo;
        private System.Windows.Forms.StatusStrip statDevice;
        private System.Windows.Forms.Panel panelReader;
        private System.Windows.Forms.Button bCloseReader;
        private System.Windows.Forms.Button bOpenReader;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNFCRd;
        private System.Windows.Forms.TabPage tabNFCWr;
        private System.Windows.Forms.TabPage tabTools;
        private System.Windows.Forms.Button bEraseAllRec;
        private System.Windows.Forms.Button bEraseLastRec;
        private System.Windows.Forms.Button bCardClear;
        private System.Windows.Forms.Button bCardInit;
        private System.Windows.Forms.StatusStrip statNDEF;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel NdefInfoCardType;
        private System.Windows.Forms.ToolStripStatusLabel NdefInfoMsgs;
        private System.Windows.Forms.ToolStripStatusLabel NdefInfoRecs;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel statusReader;
        private System.Windows.Forms.ToolStripStatusLabel statusResult;
        private System.Windows.Forms.ToolStripStatusLabel DevInfoSN;
        private System.Windows.Forms.ToolStripStatusLabel DevInfoHW;
        private System.Windows.Forms.ToolStripStatusLabel DevInfoFW;
        private System.Windows.Forms.ToolStripStatusLabel DevInfoDLL;
        private System.Windows.Forms.ToolStripStatusLabel NdefInfoEmpty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtPayload;
        private System.Windows.Forms.DataGridView SG1;
        private System.Windows.Forms.Button bReadCard;
        private System.Windows.Forms.ToolStripStatusLabel NdefInfoTNF;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payload;

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPhone;
        private System.Windows.Forms.Button bWritePhone;
        private System.Windows.Forms.TextBox ePhone;
        private System.Windows.Forms.TabPage tabSMS;
        private System.Windows.Forms.Button bWrSMS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eSMSPhone;
        private System.Windows.Forms.Label lSMSChars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox eSMS;
        private System.Windows.Forms.TabPage tabURL;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button bWrURI;
        private System.Windows.Forms.TextBox eURL;
        private System.Windows.Forms.TabPage tabCard;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox eSkype;
        private System.Windows.Forms.TextBox eWeb;
        private System.Windows.Forms.TextBox eCompany;
        private System.Windows.Forms.TextBox eTitle;
        private System.Windows.Forms.TextBox ePEmail;
        private System.Windows.Forms.TextBox eBEmail;
        private System.Windows.Forms.TextBox ePPhone;
        private System.Windows.Forms.TextBox eCPhone;
        private System.Windows.Forms.TextBox eBPhone;
        private System.Windows.Forms.TextBox eFirst;
        private System.Windows.Forms.TextBox eLast;
        private System.Windows.Forms.TextBox eDisplay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bWrvCard;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bWrAAR;
        private System.Windows.Forms.TextBox eAAR;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button btnStorePhoneToReader;
        private System.Windows.Forms.Button btnStoreSmsToReader;
        private System.Windows.Forms.Button btnStoreUrlToReader;
        private System.Windows.Forms.Button btnStoreVCardToReader;
        private System.Windows.Forms.Button btnStoreBluetoothToReader;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStopTagEmulation;
        private System.Windows.Forms.Button btnStartTagEmulation;
        private System.Windows.Forms.Button btnStartCombinedEmulationMode;
        private System.Windows.Forms.ComboBox cbUriIdentifierCode;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox chkUidAsciiMirror;
        private System.Windows.Forms.CheckBox chkCounterAsciiMirror;
        private System.Windows.Forms.TextBox tbAsciiMirror;
        private System.Windows.Forms.TextBox tbPayload;
        private System.Windows.Forms.Label lbPayload;
        private System.Windows.Forms.Label lbAsciiMirror;
    }
}