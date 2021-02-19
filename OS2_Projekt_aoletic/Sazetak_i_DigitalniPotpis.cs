using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OS2_Projekt_aoletic
{
    class Sazetak_i_DigitalniPotpis
    {
        string workingDirectory = Environment.CurrentDirectory;

        private byte[] _hashedText;

        public void GetData(string data)
        {
            var crypt = new SHA256Managed();
            _hashedText = crypt.ComputeHash(Encoding.UTF8.GetBytes(data));
            using (StreamWriter sazetak = new StreamWriter(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Datoteke\\sazetak.txt"))
            {
                sazetak.Write(Convert.ToBase64String(_hashedText));
            }
            
        }
        public string SignHash(string message, string hashFunctionName)
        {
            byte[] output;
            string privatnikljucpath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\privatni_kljuc.txt";
            var privatnikljuc = File.ReadAllText(privatnikljucpath);

            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    rsa.FromXmlString(privatnikljuc);
                    RSAPKCS1SignatureFormatter signatureFormatter = new RSAPKCS1SignatureFormatter();
                    signatureFormatter.SetKey(rsa);
                    signatureFormatter.SetHashAlgorithm(hashFunctionName);
                    byte[] originalData = Convert.FromBase64String(message);

                    output = signatureFormatter.CreateSignature(originalData);
                    using (StreamWriter digitalnipotpis = new StreamWriter(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Datoteke\\digitalni_potpis.txt"))
                    {
                        digitalnipotpis.Write(Convert.ToBase64String(output));
                    }
                    return Convert.ToBase64String(output);
                }
                finally
                {

                }
            }
            
        }
        public bool VerifyHash(string signedHash, string hashFunctionName, string hash)
        {
            string javnikljucpath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\javni_kljuc.txt";
            var javnikljuc = File.ReadAllText(javnikljucpath);
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    rsa.FromXmlString(javnikljuc);
                    RSAPKCS1SignatureDeformatter signatureDeformatter = new RSAPKCS1SignatureDeformatter();
                    signatureDeformatter.SetKey(rsa);
                    signatureDeformatter.SetHashAlgorithm(hashFunctionName);
                    byte[] originalSignedHash = Convert.FromBase64String(signedHash);
                    byte[] originalHash = Convert.FromBase64String(hash);
                    bool output1 = signatureDeformatter.VerifySignature(originalHash, originalSignedHash);
                    return output1;

                }
                finally
                {

                }
            }
            
        }
   

    }
    }


