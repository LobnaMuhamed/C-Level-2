using System;
using System.Security.Cryptography;
using System.Text;


namespace Cryptography_In_C_
{
    internal class Program
    {

        // Hashing Encryption :-)
        static string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        /*
           // Symmetric Encryption :-)
           static string Encrypt(string plainText, string key)
           {
               using (Aes aesAlg = Aes.Create())
               {
                   aesAlg.Key = Encoding.UTF8.GetBytes(key);
                   aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                   ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                   using (var msEncrypt = new System.IO.MemoryStream())
                   {
                       using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                       using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                       {
                           swEncrypt.Write(plainText);
                       }
                       return Convert.ToBase64String(msEncrypt.ToArray());
                   }
               }
           }

           static string Decrypt(string cipherText, string key)
           {
               using (Aes aesAlg = Aes.Create())
               {
                   // Set the key and IV for AES decryption
                   aesAlg.Key = Encoding.UTF8.GetBytes(key);
                   aesAlg.IV = new byte[aesAlg.BlockSize / 8];


                   // Create a decryptor
                   ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);


                   // Decrypt the data
                   using (var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(cipherText)))
                   using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                   using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                   {
                       // Read the decrypted data from the StreamReader
                       return srDecrypt.ReadToEnd();
                   }
               }
           }


           */


        static string Encrypt(string plainText, string publicKey)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(publicKey);

                    byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(plainText), false);
                    return Convert.ToBase64String(encryptedData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Encryption error: {ex.Message}");
                throw;
            }
        }

        static string Decrept(string cipherText, string privateKey)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(privateKey);

                    byte[] encyptedData = Convert.FromBase64String(cipherText);
                    byte[] decryptedData = rsa.Decrypt(encyptedData, false);
                    return Encoding.UTF8.GetString(decryptedData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Decryption error: {ex.Message}");
                throw;
            }
        }

        static void Main()
        {
            /*
             // Hashing Encryption
            string data = "Lobna Abd El-moaty Muhammed";
            string hashedData = ComputeHash(data);


            Console.WriteLine($"Original Data: {data}");
            Console.WriteLine($"Hashed Data: {hashedData}");
            */

            /*
            string originalData = "Sensitive information";


            // Key for AES encryption (128-bit key)
            string key = "1234567890123456";


            // Encrypt the original data
            string encryptedData = Encrypt(originalData, key);


            // Decrypt the encrypted data
            string decryptedData = Decrypt(encryptedData, key);


            // Display results
            Console.WriteLine($"Original Data: {originalData}");
            Console.WriteLine($"Encrypted Data: {encryptedData}");
            Console.WriteLine($"Decrypted Data: {decryptedData}");
            */


            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    string publicKey = rsa.ToXmlString(false);
                    string privateKey = rsa.ToXmlString(true);
                    string originalMessage = "Hello, this is a secret message!";

                    string encryptedMessage = Encrypt(originalMessage, publicKey);
                    string decryptedMessage = Decrept(encryptedMessage, privateKey);

                    Console.WriteLine($"\n\nPublic Key:\n{publicKey}");
                    Console.WriteLine($"\n\nPrivate Key:\n{privateKey}");
                    Console.WriteLine($"\nOriginal Message:\n {originalMessage}");
                    Console.WriteLine($"\nDecrypted Message:\n {decryptedMessage}");
                    Console.WriteLine("\nPress any key to exit.... :)");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexepcted error occured : {ex.Message}");


            }
            Console.ReadKey();


        }
    }
}
