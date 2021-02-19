using Org.BouncyCastle.Bcpg;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS2_Projekt_aoletic
{
    public partial class GlavnaForma : Form
    {
        string workingDirectory = Environment.CurrentDirectory;

        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {

        }

        private void btn_savetext_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            using (StreamWriter text = new StreamWriter(Path.Combine(Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\text.txt")))
            {
                text.Write(tboText.Text);
            }

        }

        private void btn_kreirajkljuceve_Click(object sender, EventArgs e)
        {
            Asimetricno_RSA asimetricno_RSA = new Asimetricno_RSA();
            asimetricno_RSA.GenerateKeys(1024);

            Simetricno_AES simetricno_AES = new Simetricno_AES();
            simetricno_AES.GenerateKey();
          

        }

        private void btn_AsimetricnoKriptiraj_Click(object sender, EventArgs e)
        {
            Asimetricno_RSA asimetricno_RSA = new Asimetricno_RSA();

            asimetricno_RSA.EncryptData();
        }

        private void btn_AsimetricoDekriptiraj_Click(object sender, EventArgs e)
        {
            Asimetricno_RSA asimetricno_RSA = new Asimetricno_RSA();

            asimetricno_RSA.DecryptData();
        }

        private void btn_SimetricnoKriptiraj_Click(object sender, EventArgs e)
        {
            string textpath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\text.txt";
            var text = File.ReadAllText(textpath);
            string tajni_kljucpath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\tajni_kljuc.txt";
            string tajni_kljuc = File.ReadAllText(tajni_kljucpath);
            Simetricno_AES simetricno_AES = new Simetricno_AES();
            simetricno_AES.EncryptData(text, tajni_kljuc);
        }

        private void btn_SimetricnoDekriptiraj_Click(object sender, EventArgs e)
        {
            string simetricno_kriptiranopath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\Simetricno_kriptirano.txt";
            string tajni_kljucpath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\tajni_kljuc.txt";
            string simetricno_kriptirano = File.ReadAllText(simetricno_kriptiranopath);
            string tajni_kljuc = File.ReadAllText(tajni_kljucpath);

            Simetricno_AES simetricno_AES = new Simetricno_AES();
            simetricno_AES.DecryptData(simetricno_kriptirano, tajni_kljuc);


        }

        private void btn_izracunajSazetak_Click(object sender, EventArgs e)
        {
            string textpath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\text.txt";
            var text = File.ReadAllText(textpath);

            Sazetak_i_DigitalniPotpis sazetak = new Sazetak_i_DigitalniPotpis();
            sazetak.GetData(text);
        }

        private void btn_digitalnipotpis_Click(object sender, EventArgs e)
        {
            string sazetakpath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\sazetak.txt";
            string sazetak = File.ReadAllText(sazetakpath);
            string hash = "SHA256";

            Sazetak_i_DigitalniPotpis digitalniPotpis = new Sazetak_i_DigitalniPotpis();
            digitalniPotpis.SignHash(sazetak, hash);
        }

        private void btn_provjerapotpisa_Click(object sender, EventArgs e)
        {
            
            string sazetakpath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\sazetak.txt";
            string sazetak = File.ReadAllText(sazetakpath); 
            string signedsazetakpath = Directory.GetParent(workingDirectory).Parent.Parent.FullName + "\\Datoteke\\digitalni_potpis.txt";
            string signedsazetak = File.ReadAllText(signedsazetakpath);
            string hash = "SHA256";

            Sazetak_i_DigitalniPotpis digitalniPotpis = new Sazetak_i_DigitalniPotpis();
            if (digitalniPotpis.VerifyHash(signedsazetak, "SHA256", sazetak))
            {
                MessageBox.Show("Potpis valjan!");
            }
            else
            {
                MessageBox.Show("Potpis nije valjan!");
            }


        }
    }
}
