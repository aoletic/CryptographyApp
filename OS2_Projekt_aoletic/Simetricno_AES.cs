using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace OS2_Projekt_aoletic
{

    class Simetricno_AES
    {
        private static SymmetricAlgorithm _cryptoService = new TripleDESCryptoServiceProvider();
        string workingDirectory = Environment.CurrentDirectory;
        public string keyRandom = "";
        public byte[] ini_vektor2;

        public Simetricno_AES()
        {

            using (Aes aes = Aes.Create())
            {
                byte[] ini_vektor = new byte[16];
                aes.IV = ini_vektor;
                ini_vektor2 = ini_vektor;
            }

        }

        public string GenerateKey()
        {


            using (Aes aes = Aes.Create())
            {
                aes.GenerateKey();
                keyRandom = Convert.ToBase64String(aes.Key);
                //int velicinaKljuca = aes.KeySize.ToString();

                using (StreamWriter javniKljuc = new StreamWriter(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\tajni_kljuc.txt"))
                {
                    javniKljuc.Write(keyRandom);
                }
                return keyRandom;
            }
        }

        public string EncryptData(string plainText, string key)
        {


            byte[] array;

            using (Aes aes = Aes.Create())
            {

                ICryptoTransform encryptor = aes.CreateEncryptor(Convert.FromBase64String(key), ini_vektor2);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                       
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }
                        array = memoryStream.ToArray();

                    }
                }
            }
            using (StreamWriter aes_kriptirano = new StreamWriter(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\Simetricno_kriptirano.txt"))
            {
               aes_kriptirano.Write(Convert.ToBase64String(array));
            }
            return Convert.ToBase64String(array);

        }

        public string DecryptData(string cipherText, string key)
        {
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                ICryptoTransform decryptor = aes.CreateDecryptor(Convert.FromBase64String(key), ini_vektor2);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            using (StreamWriter aes_dekriptirano = new StreamWriter(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\Simetricno_dekriptirano.txt"))
                            {
                                aes_dekriptirano.Write(streamReader.ReadToEnd());
                            }
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }


       


    }
}