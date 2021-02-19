using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Security;
using System.IO;
using System.Runtime.InteropServices;

namespace OS2_Projekt_aoletic
{
    class Asimetricno_RSA
    {
         
        public Boolean GenerateKeys(int keysize)
        {
            RSA rsa = new RSACryptoServiceProvider(keysize);
            string publicPrivateKey = rsa.ToXmlString(true);
            string publicOnlyKeyXML = rsa.ToXmlString(false);

            string workingDirectory = Environment.CurrentDirectory;
            string docPath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke";

            using (StreamWriter javniKljuc = new StreamWriter(Path.Combine(docPath, "javni_kljuc.txt")))
            {
                javniKljuc.Write(publicOnlyKeyXML);
            }

            using (StreamWriter privatniKljuc = new StreamWriter(Path.Combine(docPath, "privatni_kljuc.txt")))
            {
                privatniKljuc.Write(publicPrivateKey);
            }

            return true;
        }

        public void EncryptData()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string textpath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\text.txt";
            string javnikljucpath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\javni_kljuc.txt";
            string privatnikljucpath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\privatni_kljuc.txt";
            var text = Encoding.UTF8.GetBytes(File.ReadAllText(textpath));
            var javnikljuc = File.ReadAllText(javnikljucpath);
            var privatnikljuc = File.ReadAllText(privatnikljucpath);


            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    rsa.FromXmlString(javnikljuc);
                    var encryptedData = rsa.Encrypt(text, true);
                    var base64Encrypted = Convert.ToBase64String(encryptedData);
                    using (StreamWriter kriptiranitekst = new StreamWriter(Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\Asimetricno_kriptirano.txt")))
                    {
                        kriptiranitekst.Write(base64Encrypted);
                    }

                }
                finally
                {
                    
                }
            }
        }

        public void DecryptData()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string textkriptiranopath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\Asimetricno_kriptirano.txt";
            string privatnikljucpath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\privatni_kljuc.txt";
            var textkriptirani = Convert.FromBase64String(File.ReadAllText(textkriptiranopath));
            var privatnikljuc = File.ReadAllText(privatnikljucpath);


            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    rsa.FromXmlString(privatnikljuc);
                    var decryptedBytes = rsa.Decrypt(textkriptirani, true);
                    var decryptedData = Encoding.UTF8.GetString(decryptedBytes);
                    using (StreamWriter dekriptiranitekst = new StreamWriter(Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\Asimetricno_dekriptirano.txt")))
                    {
                        dekriptiranitekst.Write(decryptedData);
                    }

                }
                finally
                {

                }
            }
        }

    }
}
