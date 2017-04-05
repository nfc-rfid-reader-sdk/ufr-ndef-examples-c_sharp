namespace uFR_NDEF_example
{
    partial class dlgStoreNDEFEmulation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUseAAR = new System.Windows.Forms.CheckBox();
            this.eAAR = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUseAAR);
            this.groupBox1.Controls.Add(this.eAAR);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AAR for Tag emulation (min. firmware v4.0.20 and library v4.0.22 needed)";
            // 
            // chkUseAAR
            // 
            this.chkUseAAR.AutoSize = true;
            this.chkUseAAR.Location = new System.Drawing.Point(12, 19);
            this.chkUseAAR.Name = "chkUseAAR";
            this.chkUseAAR.Size = new System.Drawing.Size(180, 17);
            this.chkUseAAR.TabIndex = 2;
            this.chkUseAAR.Text = "&Use AAR in Tag emulation mode";
            this.chkUseAAR.UseVisualStyleBackColor = true;
            this.chkUseAAR.CheckedChanged += new System.EventHandler(this.chkUseAAR_CheckedChanged);
            // 
            // eAAR
            // 
            this.eAAR.Enabled = false;
            this.eAAR.Location = new System.Drawing.Point(82, 36);
            this.eAAR.Name = "eAAR";
            this.eAAR.Size = new System.Drawing.Size(355, 20);
            this.eAAR.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Enabled = false;
            this.label16.Location = new System.Drawing.Point(12, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Pkg &name : ";
            // 
            // btnStore
            // 
            this.btnStore.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnStore.Location = new System.Drawing.Point(28, 22);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(184, 41);
            this.btnStore.TabIndex = 2;
            this.btnStore.Text = "&Store";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(233, 22);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(184, 41);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dlgStoreNDEFEmulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 153);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "dlgStoreNDEFEmulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store NDEF for tag emulation mode";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkUseAAR;
        private System.Windows.Forms.TextBox eAAR;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnCancel;
    }
}