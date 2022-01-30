using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AplikacijaZaBiblioteku
{
    public partial class UpisPosuditelja : Form
    {
        static List<Posuditelji> KorisniciList = new List<Posuditelji>();
        static string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/Posudtielji.xml";
        public UpisPosuditelja()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void UnosButun_Click(object sender, EventArgs e)
        {
            Posuditelji KorisnikUpis = new Posuditelji(Convert.ToInt32(OIBKorisnika.Text), ImeKorisnika.Text, PrezimeKorisnika.Text);
            KorisniciList.Add(KorisnikUpis);
            DialogResult dialogResult = MessageBox.Show("Zelite li dodati dodatni upis?", "Upis", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                try
                {
                    var Korisnici = XDocument.Load(path);
                    foreach (Posuditelji korisnik in KorisniciList)
                    {
                        var Korisnik = new XElement("Korisnik",
                        new XElement("OIB", korisnik.OIB),
                        new XElement("Ime", korisnik.Ime),
                        new XElement("Prezime", korisnik.Prezime));
                        Korisnici.Root.Add(Korisnik);
                    }
                    Korisnici.Save(path);
                }
                catch
                {
                    var Korisnici = new XDocument();
                    Korisnici.Add(new XElement("Korisnici"));
                    foreach (Posuditelji korisnik in KorisniciList)
                    {
                        var Korisnik = new XElement("Korisnik",
                        new XElement("OIB", korisnik.OIB),
                        new XElement("Ime", korisnik.Ime),
                        new XElement("Prezime", korisnik.Prezime));
                        Korisnici.Root.Add(Korisnik);
                    }

                    Korisnici.Save(path);
                }
                KorisniciList.Clear();
                this.Close();
                
            }
            OIBKorisnika.Text = "";
            ImeKorisnika.Text = "";
            PrezimeKorisnika.Text = "";
            if (!File.Exists(path)) File.Create(path);

        }
    }
}
