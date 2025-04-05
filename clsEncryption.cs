using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt_Decrypt_Files
{
    internal class clsEncryption
    {
        
        static string GenerateAesKey(string key, int keySize = 32,bool IsOriginalKey = false) // Default to AES-256
        {
            if(IsOriginalKey)
            {
                return key;
            }
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(key));
                return Convert.ToBase64String(hashBytes).Substring(0, keySize); // Trim to keySize
            }
        }
        
        public static bool EncryptFile(string inputFile, string outputFile, string key,int KeySize=16,bool IsOriginalKey=false)
        {
            bool result = false;
            try
            {
                if (!File.Exists(inputFile) || new FileInfo(inputFile).Length == 0)
                {
                    clsLogger.Log("Error: Input file does not exist or is empty.");
                    return false;
                }

                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Encoding.UTF8.GetBytes(GenerateAesKey(key,KeySize,IsOriginalKey));
                    aesAlg.GenerateIV();
                    byte[] iv = aesAlg.IV;

                    using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                    using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                    using (ICryptoTransform encryptor = aesAlg.CreateEncryptor())
                    using (CryptoStream cryptoStream = new CryptoStream(fsOutput, encryptor, CryptoStreamMode.Write))
                    {
                        // Write IV to the beginning of the file
                        fsOutput.Write(iv, 0, iv.Length);
                        fsInput.CopyTo(cryptoStream);
                    }
                }

                if (new FileInfo(outputFile).Length > 0)
                {
                    result = true;
                }
                else
                {
                    clsLogger.Log("Encryption failed: Output file is empty.");
                }
            }
            catch (Exception ex)
            {
                clsLogger.Log("Encryption failed: " + ex.Message);
            }
            return result;
        }


        public static bool DecryptFile(string inputFile, string outputFile, string key, int KeySize= 16, bool IsOriginalKey = false)
        {
            bool result = false;
            try
            {
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Encoding.UTF8.GetBytes(GenerateAesKey(key, KeySize, IsOriginalKey));
                    byte[] iv = new byte[16]; // AES IV size is always 16 bytes

                    using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                    {
                        // Read the IV from the beginning of the file
                        fsInput.Read(iv, 0, iv.Length);
                        aesAlg.IV = iv;

                        using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                        using (ICryptoTransform decryptor = aesAlg.CreateDecryptor())
                        using (CryptoStream cryptoStream = new CryptoStream(fsOutput, decryptor, CryptoStreamMode.Write))
                        {
                            // Decrypt the rest of the file
                            fsInput.CopyTo(cryptoStream);
                        }
                    }
                }
                result = true;
            }
            catch (Exception ex)
            {
                clsLogger.Log("Decryption failed: " + ex.Message);
            }
            return result;
        }

    }
}
