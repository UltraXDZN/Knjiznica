using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AplikacijaZaBiblioteku
{
    public partial class UpisKnjige : Form
    {
        static List<Knjige> KnjigeList = new List<Knjige>();
        static string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/Knjige.xml";
        public UpisKnjige()
        {
            InitializeComponent();
        }

        private void AutorKnjige_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Ime_Click(object sender, EventArgs e)
        {

        }

        private void UnosButun_Click(object sender, EventArgs e)
        {
            Knjige KnjigeUpis = new Knjige(float.Parse(ISBNKnjige.Text), NazivKnjige.Text, AutorKnjige.Text, Convert.ToInt32(KolicinaKnjige.Text));
            KnjigeList.Add(KnjigeUpis);
            DialogResult dialogResult = MessageBox.Show("Zelite li dodati dodatni upis?", "Upis", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    var Knjige = XDocument.Load(path);
                    foreach (Knjige knjiga in KnjigeList)
                    {
                        var Knjiga = new XElement("Knjiga",
                        new XElement("ISBN", knjiga.ISBN),
                        new XElement("Naziv", knjiga.Naziv),
                        new XElement("Autor", knjiga.Autor),
                        new XElement("Kolicina", knjiga.Kolicina));
                        Knjige.Root.Add(Knjiga);
                    }
                    Knjige.Save(path);
                }
                catch
                {
                    var Knjige = new XDocument();
                    Knjige.Add(new XElement("Knjige"));
                    foreach (Knjige knjiga in KnjigeList)
                    {
                        var Knjiga = new XElement("Knjiga",
                        new XElement("ISBN", knjiga.ISBN),
                        new XElement("Naziv", knjiga.Naziv),
                        new XElement("Autor", knjiga.Autor),
                        new XElement("Kolicina", knjiga.Kolicina));
                        Knjige.Root.Add(Knjiga);
                    }
                    Knjige.Save(path);
                }
                KnjigeList.Clear();
                this.Close();
            }
            ISBNKnjige.Text = "";
            NazivKnjige.Text = "";
            AutorKnjige.Text = "";
            KolicinaKnjige.Text = "";
            if (!File.Exists(path)) File.Create(path);
        }

        private void KolicinaKnjige_TextChanged(object sender, EventArgs e)
        {

        }

        private void NazivKnjige_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
