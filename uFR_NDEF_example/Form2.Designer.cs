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
            this.txtPayload = new System.Windows.Forms.RichTextBox();
            this.tabNFCWr = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPhone = new System.Windows.Forms.TabPage();
            this.bWritePhone = new System.Windows.Forms.Button();
            this.ePhone = new System.Windows.Forms.TextBox();
            this.tabSMS = new System.Windows.Forms.TabPage();
            this.bWrSMS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.eSMSPhone = new System.Windows.Forms.TextBox();
            this.lSMSChars = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.eSMS = new System.Windows.Forms.RichTextBox();
            this.tabURL = new System.Windows.Forms.TabPage();
            this.bWrURL = new System.Windows.Forms.Button();
            this.eURL = new System.Windows.Forms.TextBox();
            this.tabCard = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabTools = new System.Windows.Forms.TabPage();
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
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statInfo.SuspendLayout();
            this.statDevice.SuspendLayout();
            this.panelReader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabNFCRd.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SG1)).BeginInit();
            this.tabNFCWr.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPhone.SuspendLayout();
            this.tabSMS.SuspendLayout();
            this.tabURL.SuspendLayout();
            this.tabCard.SuspendLayout();
            this.tabTools.SuspendLayout();
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
            this.statInfo.Location = new System.Drawing.Point(0, 524);
            this.statInfo.Name = "statInfo";
            this.statInfo.Size = new System.Drawing.Size(444, 22);
            this.statInfo.TabIndex = 0;
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
            this.statDevice.Location = new System.Drawing.Point(0, 502);
            this.statDevice.Name = "statDevice";
            this.statDevice.Size = new System.Drawing.Size(444, 22);
            this.statDevice.Stretch = false;
            this.statDevice.TabIndex = 1;
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
            this.panelReader.Size = new System.Drawing.Size(444, 46);
            this.panelReader.TabIndex = 3;
            // 
            // bCloseReader
            // 
            this.bCloseReader.Location = new System.Drawing.Point(217, 2);
            this.bCloseReader.Name = "bCloseReader";
            this.bCloseReader.Size = new System.Drawing.Size(180, 38);
            this.bCloseReader.TabIndex = 1;
            this.bCloseReader.Text = "Close Reader";
            this.bCloseReader.UseVisualStyleBackColor = true;
            this.bCloseReader.Click += new System.EventHandler(this.bCloseReader_Click);
            // 
            // bOpenReader
            // 
            this.bOpenReader.Location = new System.Drawing.Point(3, 3);
            this.bOpenReader.Name = "bOpenReader";
            this.bOpenReader.Size = new System.Drawing.Size(208, 38);
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
            this.tabControl1.Size = new System.Drawing.Size(444, 434);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 4;
            // 
            // tabNFCRd
            // 
            this.tabNFCRd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabNFCRd.Controls.Add(this.bReadCard);
            this.tabNFCRd.Controls.Add(this.panel1);
            this.tabNFCRd.Location = new System.Drawing.Point(4, 35);
            this.tabNFCRd.Name = "tabNFCRd";
            this.tabNFCRd.Padding = new System.Windows.Forms.Padding(3);
            this.tabNFCRd.Size = new System.Drawing.Size(436, 395);
            this.tabNFCRd.TabIndex = 0;
            this.tabNFCRd.Text = "Read NFC data";
            this.tabNFCRd.UseVisualStyleBackColor = true;
            // 
            // bReadCard
            // 
            this.bReadCard.Location = new System.Drawing.Point(7, 6);
            this.bReadCard.Name = "bReadCard";
            this.bReadCard.Size = new System.Drawing.Size(75, 23);
            this.bReadCard.TabIndex = 0;
            this.bReadCard.Text = "bReadCard";
            this.bReadCard.UseVisualStyleBackColor = true;
            this.bReadCard.Click += new System.EventHandler(this.bReadCard_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SG1);
            this.panel1.Controls.Add(this.txtPayload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 343);
            this.panel1.TabIndex = 1;
            // 
            // SG1
            // 
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
            this.SG1.Size = new System.Drawing.Size(428, 192);
            this.SG1.TabIndex = 0;
            this.SG1.SelectionChanged += new System.EventHandler(this.SG1_SelectionChanged);
            // 
            // txtPayload
            // 
            this.txtPayload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPayload.Location = new System.Drawing.Point(0, 192);
            this.txtPayload.Name = "txtPayload";
            this.txtPayload.ReadOnly = true;
            this.txtPayload.Size = new System.Drawing.Size(428, 151);
            this.txtPayload.TabIndex = 1;
            this.txtPayload.Text = "Payload:";
            // 
            // tabNFCWr
            // 
            this.tabNFCWr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabNFCWr.Controls.Add(this.tabControl2);
            this.tabNFCWr.Location = new System.Drawing.Point(4, 35);
            this.tabNFCWr.Name = "tabNFCWr";
            this.tabNFCWr.Padding = new System.Windows.Forms.Padding(3);
            this.tabNFCWr.Size = new System.Drawing.Size(436, 395);
            this.tabNFCWr.TabIndex = 1;
            this.tabNFCWr.Text = "Write NFC data";
            this.tabNFCWr.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPhone);
            this.tabControl2.Controls.Add(this.tabSMS);
            this.tabControl2.Controls.Add(this.tabURL);
            this.tabControl2.Controls.Add(this.tabCard);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(428, 387);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPhone
            // 
            this.tabPhone.Controls.Add(this.bWritePhone);
            this.tabPhone.Controls.Add(this.ePhone);
            this.tabPhone.Location = new System.Drawing.Point(4, 22);
            this.tabPhone.Name = "tabPhone";
            this.tabPhone.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhone.Size = new System.Drawing.Size(420, 361);
            this.tabPhone.TabIndex = 0;
            this.tabPhone.Text = "Phone";
            this.tabPhone.UseVisualStyleBackColor = true;
            // 
            // bWritePhone
            // 
            this.bWritePhone.Location = new System.Drawing.Point(6, 32);
            this.bWritePhone.Name = "bWritePhone";
            this.bWritePhone.Size = new System.Drawing.Size(402, 23);
            this.bWritePhone.TabIndex = 1;
            this.bWritePhone.Text = "Write Phone";
            this.bWritePhone.UseVisualStyleBackColor = true;
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
            this.tabSMS.Controls.Add(this.bWrSMS);
            this.tabSMS.Controls.Add(this.label2);
            this.tabSMS.Controls.Add(this.eSMSPhone);
            this.tabSMS.Controls.Add(this.lSMSChars);
            this.tabSMS.Controls.Add(this.label1);
            this.tabSMS.Controls.Add(this.eSMS);
            this.tabSMS.Location = new System.Drawing.Point(4, 22);
            this.tabSMS.Name = "tabSMS";
            this.tabSMS.Padding = new System.Windows.Forms.Padding(3);
            this.tabSMS.Size = new System.Drawing.Size(420, 361);
            this.tabSMS.TabIndex = 1;
            this.tabSMS.Text = "SMS";
            this.tabSMS.UseVisualStyleBackColor = true;
            // 
            // bWrSMS
            // 
            this.bWrSMS.Location = new System.Drawing.Point(227, 49);
            this.bWrSMS.Name = "bWrSMS";
            this.bWrSMS.Size = new System.Drawing.Size(75, 23);
            this.bWrSMS.TabIndex = 5;
            this.bWrSMS.Text = "Write SMS";
            this.bWrSMS.UseVisualStyleBackColor = true;
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
            this.eSMSPhone.TabIndex = 3;
            // 
            // lSMSChars
            // 
            this.lSMSChars.AutoSize = true;
            this.lSMSChars.Location = new System.Drawing.Point(96, 172);
            this.lSMSChars.Name = "lSMSChars";
            this.lSMSChars.Size = new System.Drawing.Size(37, 13);
            this.lSMSChars.TabIndex = 2;
            this.lSMSChars.Text = "Chars:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message text (max. 160 chars).";
            // 
            // eSMS
            // 
            this.eSMS.Location = new System.Drawing.Point(10, 23);
            this.eSMS.Name = "eSMS";
            this.eSMS.Size = new System.Drawing.Size(151, 146);
            this.eSMS.TabIndex = 0;
            this.eSMS.Text = "";
            // 
            // tabURL
            // 
            this.tabURL.Controls.Add(this.bWrURL);
            this.tabURL.Controls.Add(this.eURL);
            this.tabURL.Location = new System.Drawing.Point(4, 22);
            this.tabURL.Name = "tabURL";
            this.tabURL.Padding = new System.Windows.Forms.Padding(3);
            this.tabURL.Size = new System.Drawing.Size(420, 361);
            this.tabURL.TabIndex = 2;
            this.tabURL.Text = "URL";
            this.tabURL.UseVisualStyleBackColor = true;
            // 
            // bWrURL
            // 
            this.bWrURL.Location = new System.Drawing.Point(6, 44);
            this.bWrURL.Name = "bWrURL";
            this.bWrURL.Size = new System.Drawing.Size(75, 23);
            this.bWrURL.TabIndex = 1;
            this.bWrURL.Text = "button1";
            this.bWrURL.UseVisualStyleBackColor = true;
            // 
            // eURL
            // 
            this.eURL.Location = new System.Drawing.Point(6, 18);
            this.eURL.Name = "eURL";
            this.eURL.Size = new System.Drawing.Size(345, 20);
            this.eURL.TabIndex = 0;
            // 
            // tabCard
            // 
            this.tabCard.Controls.Add(this.label14);
            this.tabCard.Controls.Add(this.label13);
            this.tabCard.Controls.Add(this.label12);
            this.tabCard.Controls.Add(this.label11);
            this.tabCard.Controls.Add(this.label10);
            this.tabCard.Controls.Add(this.label9);
            this.tabCard.Controls.Add(this.textBox12);
            this.tabCard.Controls.Add(this.textBox11);
            this.tabCard.Controls.Add(this.textBox10);
            this.tabCard.Controls.Add(this.textBox9);
            this.tabCard.Controls.Add(this.textBox8);
            this.tabCard.Controls.Add(this.textBox7);
            this.tabCard.Controls.Add(this.textBox6);
            this.tabCard.Controls.Add(this.textBox5);
            this.tabCard.Controls.Add(this.textBox4);
            this.tabCard.Controls.Add(this.textBox3);
            this.tabCard.Controls.Add(this.textBox2);
            this.tabCard.Controls.Add(this.textBox1);
            this.tabCard.Controls.Add(this.label8);
            this.tabCard.Controls.Add(this.label7);
            this.tabCard.Controls.Add(this.label6);
            this.tabCard.Controls.Add(this.label5);
            this.tabCard.Controls.Add(this.label4);
            this.tabCard.Controls.Add(this.label3);
            this.tabCard.Controls.Add(this.button2);
            this.tabCard.Location = new System.Drawing.Point(4, 22);
            this.tabCard.Name = "tabCard";
            this.tabCard.Padding = new System.Windows.Forms.Padding(3);
            this.tabCard.Size = new System.Drawing.Size(420, 361);
            this.tabCard.TabIndex = 3;
            this.tabCard.Text = "vCard";
            this.tabCard.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 299);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Skype name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Website URL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(63, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Company";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Title";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(43, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Private E-mail";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Bussiness E-mail";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(120, 296);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(197, 20);
            this.textBox12.TabIndex = 19;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(120, 270);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(197, 20);
            this.textBox11.TabIndex = 18;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(120, 244);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(197, 20);
            this.textBox10.TabIndex = 17;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(120, 218);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(197, 20);
            this.textBox9.TabIndex = 16;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(120, 192);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(197, 20);
            this.textBox8.TabIndex = 15;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(120, 140);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(197, 20);
            this.textBox7.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(120, 166);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(197, 20);
            this.textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(120, 114);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(197, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 88);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(197, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Private Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cell Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Bussiness Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 3;
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
            this.label3.TabIndex = 1;
            this.label3.Text = "* Display Name";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tabTools
            // 
            this.tabTools.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabTools.Controls.Add(this.progressBar1);
            this.tabTools.Controls.Add(this.bEraseAllRec);
            this.tabTools.Controls.Add(this.bEraseLastRec);
            this.tabTools.Controls.Add(this.bCardClear);
            this.tabTools.Controls.Add(this.bCardInit);
            this.tabTools.Location = new System.Drawing.Point(4, 35);
            this.tabTools.Name = "tabTools";
            this.tabTools.Padding = new System.Windows.Forms.Padding(3);
            this.tabTools.Size = new System.Drawing.Size(436, 395);
            this.tabTools.TabIndex = 2;
            this.tabTools.Text = "TOOLS";
            this.tabTools.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(3, 365);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(426, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // bEraseAllRec
            // 
            this.bEraseAllRec.Location = new System.Drawing.Point(143, 144);
            this.bEraseAllRec.Name = "bEraseAllRec";
            this.bEraseAllRec.Size = new System.Drawing.Size(248, 38);
            this.bEraseAllRec.TabIndex = 3;
            this.bEraseAllRec.Text = "bEraseAllRec";
            this.bEraseAllRec.UseVisualStyleBackColor = true;
            this.bEraseAllRec.Click += new System.EventHandler(this.bEraseAllRec_Click);
            // 
            // bEraseLastRec
            // 
            this.bEraseLastRec.Location = new System.Drawing.Point(9, 83);
            this.bEraseLastRec.Name = "bEraseLastRec";
            this.bEraseLastRec.Size = new System.Drawing.Size(244, 38);
            this.bEraseLastRec.TabIndex = 2;
            this.bEraseLastRec.Text = "bEraseLastRec";
            this.bEraseLastRec.UseVisualStyleBackColor = true;
            this.bEraseLastRec.Click += new System.EventHandler(this.bEraseLastRec_Click);
            // 
            // bCardClear
            // 
            this.bCardClear.Location = new System.Drawing.Point(143, 242);
            this.bCardClear.Name = "bCardClear";
            this.bCardClear.Size = new System.Drawing.Size(248, 38);
            this.bCardClear.TabIndex = 1;
            this.bCardClear.Text = "bCardClear";
            this.bCardClear.UseVisualStyleBackColor = true;
            this.bCardClear.Click += new System.EventHandler(this.bCardClear_Click);
            // 
            // bCardInit
            // 
            this.bCardInit.Location = new System.Drawing.Point(6, 6);
            this.bCardInit.Name = "bCardInit";
            this.bCardInit.Size = new System.Drawing.Size(385, 38);
            this.bCardInit.TabIndex = 0;
            this.bCardInit.Text = "bCardInit";
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
            this.statNDEF.Location = new System.Drawing.Point(0, 480);
            this.statNDEF.Name = "statNDEF";
            this.statNDEF.Size = new System.Drawing.Size(444, 22);
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 546);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelReader);
            this.Controls.Add(this.statNDEF);
            this.Controls.Add(this.statDevice);
            this.Controls.Add(this.statInfo);
            this.Name = "Form2";
            this.Text = "  NFC Type 2 Tag programming example -  D-Logic";
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
            this.tabControl2.ResumeLayout(false);
            this.tabPhone.ResumeLayout(false);
            this.tabPhone.PerformLayout();
            this.tabSMS.ResumeLayout(false);
            this.tabSMS.PerformLayout();
            this.tabURL.ResumeLayout(false);
            this.tabURL.PerformLayout();
            this.tabCard.ResumeLayout(false);
            this.tabCard.PerformLayout();
            this.tabTools.ResumeLayout(false);
            this.statNDEF.ResumeLayout(false);
            this.statNDEF.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPhone;
        private System.Windows.Forms.TabPage tabSMS;
        private System.Windows.Forms.TabPage tabURL;
        private System.Windows.Forms.TabPage tabCard;
        private System.Windows.Forms.Button bWritePhone;
        private System.Windows.Forms.TextBox ePhone;
        private System.Windows.Forms.Button bWrSMS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eSMSPhone;
        private System.Windows.Forms.Label lSMSChars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox eSMS;
        private System.Windows.Forms.Button bWrURL;
        private System.Windows.Forms.TextBox eURL;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payload;
    }
}