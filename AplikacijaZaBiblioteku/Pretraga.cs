using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using System.Collections;

namespace AplikacijaZaBiblioteku
{
    public partial class Pretraga : Form
    {

        static string pathPosudbaVracanje = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/PosudbaVracanje.xml";
        static string pathPosuditelji = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/Posudtielji.xml";
        static string pathKnjige = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/Knjige.xml";
        public Pretraga()
        {
            InitializeComponent();

        }

        private void PretragaButun_Click(object sender, EventArgs e)
        {
            try
            {
                //PretragaRichTextbox.Text = "";
                //var Knjige = XDocument.Load(pathKnjige);
                //var Posuditelji = XDocument.Load(pathPosuditelji);
                //var PosudbaVracanje = XDocument.Load(pathPosudbaVracanje);
                //if (OIBCheck.Checked)
                //{
                //    IEnumerable<string> OIBList = from s in Posuditelji.Descendants("Korisnik")
                //                                  where s.Element("OIB").Value == KorisnikPretraga.Text
                //                                  select "OIB: " + s.Element("OIB").Value +
                //                                       "\nIme: " + s.Element("Ime").Value +
                //                                       "\nPrezime: " + s.Element("Prezime").Value + "\n\n";
                //    foreach (string s in OIBList) { PretragaRichTextbox.Text += s; }
                //}
                //if (ISBNCheck.Checked)
                //{
                //    IEnumerable<string> ISBNList = from s in Knjige.Descendants("Knjiga")
                //                                   where s.Element("ISBN").Value == KnjigaPretraga.Text
                //                                   select "ISBN: " + s.Element("ISBN").Value +
                //                                          "\nNaziv: " + s.Element("Naziv").Value +
                //                                          "\nAutor: " + s.Element("Autor").Value +
                //                                          "\nKolicina: " + s.Element("Kolicina").Value + "\n\n";
                //    foreach (string s in ISBNList) { PretragaRichTextbox.Text += s; }
                //}
                //if (VracanjeCheck.Checked)
                //{
                //    IEnumerable<string> VRACANJEList = from s in PosudbaVracanje.Descendants("Vracanje")
                //                                       where s.Element("Knjiga").Value == VracanjePretraga.Text
                //                                       select "Datum Vracanja: " + s.Element("VracanjeDatum").Value +
                //                                              "\nOIB: " + s.Element("Korisnik").Value +
                //                                              "\nISBN: " + s.Element("Knjiga").Value + "\n\n";
                //    foreach (string s in VRACANJEList) { PretragaRichTextbox.Text += s; }
                //}
                //if (PosudbaCheck.Checked)
                //{
                //    IEnumerable<string> POSUDBAList = from s in PosudbaVracanje.Descendants("Posudivanje")
                //                                      where s.Element("Knjiga").Value == PosudbaPretraga.Text
                //                                      select "Datum Posudbe: " + s.Element("PosudivanjeDatum").Value +
                //                                             "\nOIB: " + s.Element("Korisnik").Value +
                //                                             "\nISBN: " + s.Element("Knjiga").Value + "\n\n";
                //    foreach (string s in POSUDBAList) { PretragaRichTextbox.Text += s; }
                //}
            }
            catch (Exception except)
            {
                if (except.Message.Contains("Knjig")) MessageBox.Show("Niste unijeli ni jednu knjigu", "Pogreska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (except.Message.Contains("Posuditelj")) MessageBox.Show("Niste unijeli ni jednog posuditelja!", "Pogreska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (except.Message.Contains("PosudbaVracanje")) MessageBox.Show("Niste unijeli ni jednu posudbu!", "Pogreska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeState(bool state)
        {
            imeTextBox.Enabled = state;
            prezimeTextBox.Enabled = state;
            OIBtextBox.Enabled = state;

            NazivtextBox.Enabled = !state;
            AutortextBox.Enabled = !state;
            ISBNtextBox.Enabled = !state;
        }

        private void pretragaKorisnikaButton_Click(object sender, EventArgs e)
        {
            changeState(true);
        }

        private void pretragaKnjigeButton_Click(object sender, EventArgs e)
        {
            changeState(false);
        }

        private void pretragaPosuditeljaKnjigeButton_Click(object sender, EventArgs e)
        {
            imeTextBox.Enabled = true;
            prezimeTextBox.Enabled = true;
            OIBtextBox.Enabled = true;

            NazivtextBox.Enabled = true;
            AutortextBox.Enabled = true;
            ISBNtextBox.Enabled = true;
        }
    }
}
