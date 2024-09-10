using System;
using System.IO;
using System.Security.Cryptography;

namespace Encrypt_Decrypt_Image_Example
{


    internal class Program
    {

        static void EncryptFile(string inputFile, string outputFile, string key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = System.Text.Encoding.UTF8.GetBytes(key);
                aesAlg.IV = iv;

                using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                using (ICryptoTransform encryptor = aesAlg.CreateEncryptor())
                using (CryptoStream cryptoStream = new CryptoStream(fsOutput, encryptor, CryptoStreamMode.Write))
                {
                    fsOutput.Write(iv, 0, iv.Length);
                    fsInput.CopyTo(cryptoStream);
                }
            }
        }

        static void DecryptFile(string inputFile, string outputFile, string key, byte[] iv)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = System.Text.Encoding.UTF8.GetBytes(key);
                aesAlg.IV = iv;

                using (FileStream fsInput = new FileStream(inputFile, FileMode.Open))
                using (FileStream fsOutput = new FileStream(outputFile, FileMode.Create))
                using (ICryptoTransform dectyptor = aesAlg.CreateDecryptor())
                using (CryptoStream cryptoStream = new CryptoStream(fsOutput, dectyptor, CryptoStreamMode.Write))
                {
                    fsInput.Seek(iv.Length, SeekOrigin.Begin);
                    fsInput.CopyTo(cryptoStream);
                }
            }
        }
        static void Main(string[] args)
        {
            string inputFile = "c:\\Image\\MyImage.jpg";
            string encryptedFile = "c:\\Image\\encrypted.jpg";
            string decryptedFile = "c:\\Image\\decrypted.jpg";


            // Generate a random IV for each encryption operation
            byte[] iv;
            using (Aes aesAlg = Aes.Create())
            {
                iv = aesAlg.IV;
            }


            string key = "1234567890123456";


            EncryptFile(inputFile, encryptedFile, key, iv);
            DecryptFile(encryptedFile, decryptedFile, key, iv);


            Console.WriteLine("Encryption and decryption completed successfully.");
            Console.WriteLine("go to c:\\Image folder to see the results");
            Console.ReadKey();
        }
    }
}
