using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PurpleYam_POS.helper
{
    public class EncryptPass
    {
        private static string Password;
        private static byte[] encryptedTxt;
        private static string key = "pNbZfi5Z73jU5A7130TDg/A5GkE6J3ILPSwHaBR3Gho=";
        private static string IV = "OCKXnfWePKrdOl1SJCAJVQ==";

        public static byte[] EncryptStringToBytes_Aes(string pass)
        {
            Password = pass;
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Convert.FromBase64String(key);
                aesAlg.IV = Convert.FromBase64String(IV);

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(Password);
                        }
                        encrypted = msEncrypt.ToArray();
                        encryptedTxt = encrypted;
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

    }
}
