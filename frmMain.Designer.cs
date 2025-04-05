namespace Encrypt_Decrypt_Files
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblInputFile = new System.Windows.Forms.Label();
            this.txtInputFile = new System.Windows.Forms.TextBox();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.lblOutputFile = new System.Windows.Forms.Label();
            this.rbEncryption = new System.Windows.Forms.RadioButton();
            this.rbDecryption = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbAES256 = new System.Windows.Forms.RadioButton();
            this.rbAES128 = new System.Windows.Forms.RadioButton();
            this.rbAES192 = new System.Windows.Forms.RadioButton();
            this.cbUseOriginalKey = new System.Windows.Forms.CheckBox();
            this.cbDeleteAfterFinish = new System.Windows.Forms.CheckBox();
            this.cbDontSwapProcess = new System.Windows.Forms.CheckBox();
            this.btnSwap = new System.Windows.Forms.Button();
            this.btnBrowseOutputFile = new System.Windows.Forms.Button();
            this.btnBrowseInputFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInputFile
            // 
            this.lblInputFile.AutoSize = true;
            this.lblInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblInputFile.Location = new System.Drawing.Point(12, 24);
            this.lblInputFile.Name = "lblInputFile";
            this.lblInputFile.Size = new System.Drawing.Size(97, 25);
            this.lblInputFile.TabIndex = 1;
            this.lblInputFile.Text = "Input File:";
            // 
            // txtInputFile
            // 
            this.txtInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtInputFile.Location = new System.Drawing.Point(115, 21);
            this.txtInputFile.Name = "txtInputFile";
            this.txtInputFile.ReadOnly = true;
            this.txtInputFile.Size = new System.Drawing.Size(227, 30);
            this.txtInputFile.TabIndex = 1;
            this.txtInputFile.TextChanged += new System.EventHandler(this.txtInputFile_TextChanged);
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtOutputFile.Location = new System.Drawing.Point(129, 68);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.ReadOnly = true;
            this.txtOutputFile.Size = new System.Drawing.Size(213, 30);
            this.txtOutputFile.TabIndex = 3;
            this.txtOutputFile.TextChanged += new System.EventHandler(this.txtOutputFile_TextChanged);
            // 
            // lblOutputFile
            // 
            this.lblOutputFile.AutoSize = true;
            this.lblOutputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblOutputFile.Location = new System.Drawing.Point(12, 73);
            this.lblOutputFile.Name = "lblOutputFile";
            this.lblOutputFile.Size = new System.Drawing.Size(113, 25);
            this.lblOutputFile.TabIndex = 4;
            this.lblOutputFile.Text = "Output File:";
            // 
            // rbEncryption
            // 
            this.rbEncryption.AutoSize = true;
            this.rbEncryption.Checked = true;
            this.rbEncryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbEncryption.Location = new System.Drawing.Point(6, 21);
            this.rbEncryption.Name = "rbEncryption";
            this.rbEncryption.Size = new System.Drawing.Size(125, 29);
            this.rbEncryption.TabIndex = 7;
            this.rbEncryption.TabStop = true;
            this.rbEncryption.Text = "Encryption";
            this.rbEncryption.UseVisualStyleBackColor = true;
            // 
            // rbDecryption
            // 
            this.rbDecryption.AutoSize = true;
            this.rbDecryption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbDecryption.Location = new System.Drawing.Point(6, 56);
            this.rbDecryption.Name = "rbDecryption";
            this.rbDecryption.Size = new System.Drawing.Size(126, 29);
            this.rbDecryption.TabIndex = 8;
            this.rbDecryption.Text = "Decryption";
            this.rbDecryption.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSave.Location = new System.Drawing.Point(309, 285);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 45);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Location = new System.Drawing.Point(200, 285);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 45);
            this.btnClose.TabIndex = 15;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtKey.Location = new System.Drawing.Point(71, 116);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(271, 30);
            this.txtKey.TabIndex = 5;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            this.txtKey.Validating += new System.ComponentModel.CancelEventHandler(this.txtKey_Validating);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblKey.Location = new System.Drawing.Point(12, 116);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(53, 25);
            this.lblKey.TabIndex = 10;
            this.lblKey.Text = "Key:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEncryption);
            this.groupBox1.Controls.Add(this.rbDecryption);
            this.groupBox1.Location = new System.Drawing.Point(17, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbAES256);
            this.groupBox2.Controls.Add(this.rbAES128);
            this.groupBox2.Controls.Add(this.rbAES192);
            this.groupBox2.Location = new System.Drawing.Point(173, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 127);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AES Key Size";
            // 
            // rbAES256
            // 
            this.rbAES256.AutoSize = true;
            this.rbAES256.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbAES256.Location = new System.Drawing.Point(6, 91);
            this.rbAES256.Name = "rbAES256";
            this.rbAES256.Size = new System.Drawing.Size(209, 29);
            this.rbAES256.TabIndex = 11;
            this.rbAES256.Text = "AES-256 (32 Bytes)";
            this.rbAES256.UseVisualStyleBackColor = true;
            this.rbAES256.CheckedChanged += new System.EventHandler(this.rbAES256_CheckedChanged);
            // 
            // rbAES128
            // 
            this.rbAES128.AutoSize = true;
            this.rbAES128.Checked = true;
            this.rbAES128.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbAES128.Location = new System.Drawing.Point(6, 21);
            this.rbAES128.Name = "rbAES128";
            this.rbAES128.Size = new System.Drawing.Size(209, 29);
            this.rbAES128.TabIndex = 9;
            this.rbAES128.TabStop = true;
            this.rbAES128.Text = "AES-128 (16 Bytes)";
            this.rbAES128.UseVisualStyleBackColor = true;
            this.rbAES128.CheckedChanged += new System.EventHandler(this.rbAES128_CheckedChanged);
            // 
            // rbAES192
            // 
            this.rbAES192.AutoSize = true;
            this.rbAES192.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbAES192.Location = new System.Drawing.Point(6, 56);
            this.rbAES192.Name = "rbAES192";
            this.rbAES192.Size = new System.Drawing.Size(209, 29);
            this.rbAES192.TabIndex = 10;
            this.rbAES192.Text = "AES-192 (24 Bytes)";
            this.rbAES192.UseVisualStyleBackColor = true;
            this.rbAES192.CheckedChanged += new System.EventHandler(this.rbAES192_CheckedChanged);
            // 
            // cbUseOriginalKey
            // 
            this.cbUseOriginalKey.AutoSize = true;
            this.cbUseOriginalKey.Location = new System.Drawing.Point(17, 259);
            this.cbUseOriginalKey.Name = "cbUseOriginalKey";
            this.cbUseOriginalKey.Size = new System.Drawing.Size(129, 20);
            this.cbUseOriginalKey.TabIndex = 13;
            this.cbUseOriginalKey.Text = "Use Original Key";
            this.cbUseOriginalKey.UseVisualStyleBackColor = true;
            this.cbUseOriginalKey.CheckedChanged += new System.EventHandler(this.cbUseOriginalKey_CheckedChanged);
            // 
            // cbDeleteAfterFinish
            // 
            this.cbDeleteAfterFinish.AutoSize = true;
            this.cbDeleteAfterFinish.Location = new System.Drawing.Point(17, 285);
            this.cbDeleteAfterFinish.Name = "cbDeleteAfterFinish";
            this.cbDeleteAfterFinish.Size = new System.Drawing.Size(168, 20);
            this.cbDeleteAfterFinish.TabIndex = 14;
            this.cbDeleteAfterFinish.Text = "Delete Input After Finish";
            this.cbDeleteAfterFinish.UseVisualStyleBackColor = true;
            // 
            // cbDontSwapProcess
            // 
            this.cbDontSwapProcess.AutoSize = true;
            this.cbDontSwapProcess.Location = new System.Drawing.Point(17, 308);
            this.cbDontSwapProcess.Name = "cbDontSwapProcess";
            this.cbDontSwapProcess.Size = new System.Drawing.Size(150, 20);
            this.cbDontSwapProcess.TabIndex = 15;
            this.cbDontSwapProcess.Text = "Don\'t Swap Process";
            this.cbDontSwapProcess.UseVisualStyleBackColor = true;
            this.cbDontSwapProcess.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnSwap
            // 
            this.btnSwap.BackgroundImage = global::Encrypt_Decrypt_Files.Properties.Resources.swap;
            this.btnSwap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSwap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSwap.Location = new System.Drawing.Point(348, 108);
            this.btnSwap.Name = "btnSwap";
            this.btnSwap.Size = new System.Drawing.Size(51, 42);
            this.btnSwap.TabIndex = 6;
            this.btnSwap.UseVisualStyleBackColor = true;
            this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
            // 
            // btnBrowseOutputFile
            // 
            this.btnBrowseOutputFile.BackgroundImage = global::Encrypt_Decrypt_Files.Properties.Resources.save;
            this.btnBrowseOutputFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrowseOutputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBrowseOutputFile.Location = new System.Drawing.Point(348, 64);
            this.btnBrowseOutputFile.Name = "btnBrowseOutputFile";
            this.btnBrowseOutputFile.Size = new System.Drawing.Size(51, 38);
            this.btnBrowseOutputFile.TabIndex = 4;
            this.btnBrowseOutputFile.UseVisualStyleBackColor = true;
            this.btnBrowseOutputFile.Click += new System.EventHandler(this.btnBrowseOutputFile_Click);
            // 
            // btnBrowseInputFile
            // 
            this.btnBrowseInputFile.BackgroundImage = global::Encrypt_Decrypt_Files.Properties.Resources.open;
            this.btnBrowseInputFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBrowseInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBrowseInputFile.Location = new System.Drawing.Point(348, 17);
            this.btnBrowseInputFile.Name = "btnBrowseInputFile";
            this.btnBrowseInputFile.Size = new System.Drawing.Size(51, 39);
            this.btnBrowseInputFile.TabIndex = 2;
            this.btnBrowseInputFile.UseVisualStyleBackColor = true;
            this.btnBrowseInputFile.Click += new System.EventHandler(this.btnBrowseInputFile_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(407, 341);
            this.Controls.Add(this.cbDontSwapProcess);
            this.Controls.Add(this.btnSwap);
            this.Controls.Add(this.cbDeleteAfterFinish);
            this.Controls.Add(this.cbUseOriginalKey);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOutputFile);
            this.Controls.Add(this.lblOutputFile);
            this.Controls.Add(this.btnBrowseOutputFile);
            this.Controls.Add(this.txtInputFile);
            this.Controls.Add(this.lblInputFile);
            this.Controls.Add(this.btnBrowseInputFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Secure Files";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowseInputFile;
        private System.Windows.Forms.Label lblInputFile;
        private System.Windows.Forms.TextBox txtInputFile;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Label lblOutputFile;
        private System.Windows.Forms.Button btnBrowseOutputFile;
        private System.Windows.Forms.RadioButton rbEncryption;
        private System.Windows.Forms.RadioButton rbDecryption;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbAES128;
        private System.Windows.Forms.RadioButton rbAES192;
        private System.Windows.Forms.RadioButton rbAES256;
        private System.Windows.Forms.CheckBox cbUseOriginalKey;
        private System.Windows.Forms.CheckBox cbDeleteAfterFinish;
        private System.Windows.Forms.Button btnSwap;
        private System.Windows.Forms.CheckBox cbDontSwapProcess;
    }
}

