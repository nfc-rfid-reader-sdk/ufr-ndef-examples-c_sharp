namespace uFR_NDEF_example
{
    partial class frmTestNDEF
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
            this.bOpenReader = new System.Windows.Forms.Button();
            this.bRdNDEF = new System.Windows.Forms.Button();
            this.bWrNDEF = new System.Windows.Forms.Button();
            this.bGetCnt = new System.Windows.Forms.Button();
            this.bEraseAll = new System.Windows.Forms.Button();
            this.bEraseLast = new System.Windows.Forms.Button();
            this.bCardInit = new System.Windows.Forms.Button();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.EditRecordNr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.EditUriText = new System.Windows.Forms.TextBox();
            this.labelOpenStatus = new System.Windows.Forms.Label();
            this.dbgInfo = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelTnf = new System.Windows.Forms.Label();
            this.LabelRecordType = new System.Windows.Forms.Label();
            this.LabelMessageCnt = new System.Windows.Forms.Label();
            this.LabelRecordCnt = new System.Windows.Forms.Label();
            this.LabelEmptyMessage = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bOpenReader
            // 
            this.bOpenReader.Location = new System.Drawing.Point(12, 12);
            this.bOpenReader.Name = "bOpenReader";
            this.bOpenReader.Size = new System.Drawing.Size(108, 23);
            this.bOpenReader.TabIndex = 0;
            this.bOpenReader.Text = "Open Reader";
            this.bOpenReader.UseVisualStyleBackColor = true;
            this.bOpenReader.Click += new System.EventHandler(this.bOpenReader_Click);
            // 
            // bRdNDEF
            // 
            this.bRdNDEF.Location = new System.Drawing.Point(12, 220);
            this.bRdNDEF.Name = "bRdNDEF";
            this.bRdNDEF.Size = new System.Drawing.Size(126, 23);
            this.bRdNDEF.TabIndex = 1;
            this.bRdNDEF.Text = "Read NDEF record";
            this.bRdNDEF.UseVisualStyleBackColor = true;
            this.bRdNDEF.Click += new System.EventHandler(this.bRdNDEF_Click);
            // 
            // bWrNDEF
            // 
            this.bWrNDEF.Location = new System.Drawing.Point(250, 220);
            this.bWrNDEF.Name = "bWrNDEF";
            this.bWrNDEF.Size = new System.Drawing.Size(108, 23);
            this.bWrNDEF.TabIndex = 2;
            this.bWrNDEF.Text = "Write NDEF record";
            this.bWrNDEF.UseVisualStyleBackColor = true;
            this.bWrNDEF.Click += new System.EventHandler(this.bWrNDEF_Click);
            // 
            // bGetCnt
            // 
            this.bGetCnt.Location = new System.Drawing.Point(12, 294);
            this.bGetCnt.Name = "bGetCnt";
            this.bGetCnt.Size = new System.Drawing.Size(108, 23);
            this.bGetCnt.TabIndex = 3;
            this.bGetCnt.Text = "Get Record Count";
            this.bGetCnt.UseVisualStyleBackColor = true;
            this.bGetCnt.Click += new System.EventHandler(this.bGetCnt_Click);
            // 
            // bEraseAll
            // 
            this.bEraseAll.Location = new System.Drawing.Point(250, 323);
            this.bEraseAll.Name = "bEraseAll";
            this.bEraseAll.Size = new System.Drawing.Size(108, 23);
            this.bEraseAll.TabIndex = 4;
            this.bEraseAll.Text = "Erase All Record";
            this.bEraseAll.UseVisualStyleBackColor = true;
            this.bEraseAll.Click += new System.EventHandler(this.bEraseAll_Click);
            // 
            // bEraseLast
            // 
            this.bEraseLast.Location = new System.Drawing.Point(12, 323);
            this.bEraseLast.Name = "bEraseLast";
            this.bEraseLast.Size = new System.Drawing.Size(108, 23);
            this.bEraseLast.TabIndex = 5;
            this.bEraseLast.Text = "Erase Last Record";
            this.bEraseLast.UseVisualStyleBackColor = true;
            this.bEraseLast.Click += new System.EventHandler(this.bEraseLast_Click);
            // 
            // bCardInit
            // 
            this.bCardInit.Location = new System.Drawing.Point(250, 369);
            this.bCardInit.Name = "bCardInit";
            this.bCardInit.Size = new System.Drawing.Size(108, 23);
            this.bCardInit.TabIndex = 7;
            this.bCardInit.Text = "Card Initialization";
            this.bCardInit.UseVisualStyleBackColor = true;
            this.bCardInit.Click += new System.EventHandler(this.bCardInit_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.Enabled = false;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
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
            "urn:epc:tag:",
            "urn:epc:pat:",
            "urn:epc:raw:",
            "urn:epc:",
            "urn:nfc:"});
            this.ComboBox1.Location = new System.Drawing.Point(12, 247);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(207, 21);
            this.ComboBox1.TabIndex = 8;
            this.ComboBox1.Text = "Select URI Abbreviation";
            this.ComboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // EditRecordNr
            // 
            this.EditRecordNr.Location = new System.Drawing.Point(184, 222);
            this.EditRecordNr.Name = "EditRecordNr";
            this.EditRecordNr.Size = new System.Drawing.Size(35, 20);
            this.EditRecordNr.TabIndex = 9;
            this.EditRecordNr.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "URI text (payload)";
            // 
            // EditUriText
            // 
            this.EditUriText.Location = new System.Drawing.Point(12, 67);
            this.EditUriText.Name = "EditUriText";
            this.EditUriText.Size = new System.Drawing.Size(346, 20);
            this.EditUriText.TabIndex = 16;
            this.EditUriText.Text = "d-logic.net";
            // 
            // labelOpenStatus
            // 
            this.labelOpenStatus.AutoSize = true;
            this.labelOpenStatus.Location = new System.Drawing.Point(126, 17);
            this.labelOpenStatus.Name = "labelOpenStatus";
            this.labelOpenStatus.Size = new System.Drawing.Size(64, 13);
            this.labelOpenStatus.TabIndex = 18;
            this.labelOpenStatus.Text = "Open status";
            // 
            // dbgInfo
            // 
            this.dbgInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dbgInfo.Location = new System.Drawing.Point(0, 398);
            this.dbgInfo.Name = "dbgInfo";
            this.dbgInfo.Size = new System.Drawing.Size(370, 124);
            this.dbgInfo.TabIndex = 19;
            this.dbgInfo.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelTnf);
            this.panel1.Controls.Add(this.LabelRecordType);
            this.panel1.Controls.Add(this.LabelMessageCnt);
            this.panel1.Controls.Add(this.LabelRecordCnt);
            this.panel1.Controls.Add(this.LabelEmptyMessage);
            this.panel1.Location = new System.Drawing.Point(12, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 119);
            this.panel1.TabIndex = 21;
            // 
            // LabelTnf
            // 
            this.LabelTnf.AutoSize = true;
            this.LabelTnf.Location = new System.Drawing.Point(3, 11);
            this.LabelTnf.Name = "LabelTnf";
            this.LabelTnf.Size = new System.Drawing.Size(31, 13);
            this.LabelTnf.TabIndex = 25;
            this.LabelTnf.Text = "TNF:";
            // 
            // LabelRecordType
            // 
            this.LabelRecordType.AutoSize = true;
            this.LabelRecordType.Location = new System.Drawing.Point(3, 33);
            this.LabelRecordType.Name = "LabelRecordType";
            this.LabelRecordType.Size = new System.Drawing.Size(95, 13);
            this.LabelRecordType.TabIndex = 21;
            this.LabelRecordType.Text = "NDEF record type:";
            // 
            // LabelMessageCnt
            // 
            this.LabelMessageCnt.AutoSize = true;
            this.LabelMessageCnt.Location = new System.Drawing.Point(3, 55);
            this.LabelMessageCnt.Name = "LabelMessageCnt";
            this.LabelMessageCnt.Size = new System.Drawing.Size(93, 13);
            this.LabelMessageCnt.TabIndex = 22;
            this.LabelMessageCnt.Text = "Message Counter:";
            // 
            // LabelRecordCnt
            // 
            this.LabelRecordCnt.AutoSize = true;
            this.LabelRecordCnt.Location = new System.Drawing.Point(3, 77);
            this.LabelRecordCnt.Name = "LabelRecordCnt";
            this.LabelRecordCnt.Size = new System.Drawing.Size(85, 13);
            this.LabelRecordCnt.TabIndex = 23;
            this.LabelRecordCnt.Text = "Record Counter:";
            // 
            // LabelEmptyMessage
            // 
            this.LabelEmptyMessage.AutoSize = true;
            this.LabelEmptyMessage.Location = new System.Drawing.Point(3, 99);
            this.LabelEmptyMessage.Name = "LabelEmptyMessage";
            this.LabelEmptyMessage.Size = new System.Drawing.Size(125, 13);
            this.LabelEmptyMessage.TabIndex = 24;
            this.LabelEmptyMessage.Text = "Empty Message Counter:";
            // 
            // frmTestNDEF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 522);
            this.Controls.Add(this.bOpenReader);
            this.Controls.Add(this.labelOpenStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EditUriText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bRdNDEF);
            this.Controls.Add(this.EditRecordNr);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.bWrNDEF);
            this.Controls.Add(this.bGetCnt);
            this.Controls.Add(this.bEraseLast);
            this.Controls.Add(this.bEraseAll);
            this.Controls.Add(this.bCardInit);
            this.Controls.Add(this.dbgInfo);
            this.Name = "frmTestNDEF";
            this.Text = "uFR NDEF URI service RTD example";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bOpenReader;
        private System.Windows.Forms.Button bRdNDEF;
        private System.Windows.Forms.Button bWrNDEF;
        private System.Windows.Forms.Button bGetCnt;
        private System.Windows.Forms.Button bEraseAll;
        private System.Windows.Forms.Button bEraseLast;
        private System.Windows.Forms.Button bCardInit;
        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.TextBox EditRecordNr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox EditUriText;
        private System.Windows.Forms.Label labelOpenStatus;
        private System.Windows.Forms.RichTextBox dbgInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelTnf;
        private System.Windows.Forms.Label LabelRecordType;
        private System.Windows.Forms.Label LabelMessageCnt;
        private System.Windows.Forms.Label LabelRecordCnt;
        private System.Windows.Forms.Label LabelEmptyMessage;
    }
}

