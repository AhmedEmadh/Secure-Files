using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encrypt_Decrypt_Files
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            rbEncryption.Checked = true;
        }

        private void btnBrowseInputFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtInputFile.Text = openFileDialog1.FileName;
            }
        }

        private void btnBrowseOutputFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtOutputFile.Text = saveFileDialog1.FileName;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int GetKeySize()
        {
            if (rbAES128.Checked)
            {
                return 16;
            }
            else if (rbAES192.Checked)
            {
                return 24;
            }
            else
            {
                return 32;
            }
        }
        bool GetIsOriginalKey()
        {
            return cbUseOriginalKey.Checked;
        }
        bool DeleteFile(string file)
        {
            try
            {
                System.IO.File.Delete(file);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        void DeleteInputIfChecked(string inputFile, string outputFile)
        {
            if (inputFile != outputFile)
            {
                if (System.IO.File.Exists(outputFile) && System.IO.File.Exists(inputFile))
                {
                    if (cbDeleteAfterFinish.Checked)
                    {
                        if (!DeleteFile(inputFile))
                        {
                            MessageBox.Show("Failed to delete original file.");
                        }
                    }
                }
            }
        }
        void DeleteOutputIfExists(string outputFile, string InputFile)
        {
            if (InputFile != outputFile)
            {
                if (System.IO.File.Exists(outputFile) && System.IO.File.Exists(InputFile))
                {
                    if (!DeleteFile(outputFile))
                    {
                        //MessageBox.Show("Failed to delete output file.");
                    }
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string inputFile = txtInputFile.Text;
            string outputFile = txtOutputFile.Text;
            string key = txtKey.Text;
            if (string.IsNullOrEmpty(inputFile) || string.IsNullOrEmpty(outputFile) || string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (string.Equals(inputFile, outputFile))
            {
                MessageBox.Show("Input and output files cannot be the same.");
                return;
            }
            if (rbEncryption.Checked)
            {
                if (clsEncryption.EncryptFile(inputFile, outputFile, key, GetKeySize(), GetIsOriginalKey()))
                {
                    DeleteInputIfChecked(inputFile, outputFile);
                    btnSave.Enabled = false;
                    MessageBox.Show("Encryption successful.");
                }
                else
                {
                    DeleteOutputIfExists(outputFile, inputFile);
                    MessageBox.Show("Encryption failed.");
                }
            }
            else
            {
                if (clsEncryption.DecryptFile(inputFile, outputFile, key, GetKeySize(), GetIsOriginalKey()))
                {
                    DeleteInputIfChecked(inputFile, outputFile);
                    btnSave.Enabled = false;
                    MessageBox.Show("Decryption successful.");
                }
                else
                {
                    DeleteOutputIfExists(outputFile, inputFile);
                    MessageBox.Show("Decryption failed.");
                }
            }
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            // Swap URL
            string tempURL = txtInputFile.Text;
            txtInputFile.Text = txtOutputFile.Text;
            txtOutputFile.Text = tempURL;
            // Swap Process
            if (!cbDontSwapProcess.Checked)
            {
                if (rbEncryption.Checked)
                {
                    rbDecryption.Checked = true;
                }
                else
                {
                    rbEncryption.Checked = true;
                }
            }
        }

        private void txtInputFile_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtOutputFile_TextChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void txtKey_Validating(object sender, CancelEventArgs e)
        {

        }
        void CheckKeyValue()
        {
            if (cbUseOriginalKey.Checked)
            {
                if (txtKey.Text.Length != GetKeySize())
                {
                    btnSave.Enabled = false;
                }
                else
                {
                    btnSave.Enabled = true;
                }

            }
            else
            {
                btnSave.Enabled = true;
            }
        }
        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            CheckKeyValue();
        }

        private void rbAES128_CheckedChanged(object sender, EventArgs e)
        {
            CheckKeyValue();
        }

        private void rbAES192_CheckedChanged(object sender, EventArgs e)
        {
            CheckKeyValue();
        }

        private void rbAES256_CheckedChanged(object sender, EventArgs e)
        {
            CheckKeyValue();
        }

        private void cbUseOriginalKey_CheckedChanged(object sender, EventArgs e)
        {
            CheckKeyValue();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
