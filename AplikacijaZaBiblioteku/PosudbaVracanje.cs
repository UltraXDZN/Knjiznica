using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AplikacijaZaBiblioteku
{
    public partial class PosudbaVracanje : Form
    {
        static List<Posudba> PosudbaVracanjeList = new List<Posudba>();
        static string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/PosudbaVracanje.xml";

        public PosudbaVracanje()
        {
            InitializeComponent();
        }

        private void ZavrsiButun_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Zelite li dodati dodatni upis?", "Upis", MessageBoxButtons.YesNo);
            Posudba PosudbaVracanje = new Posudba(DateTime.Today, Convert.ToInt32(KnjigaText.Text), Convert.ToInt32(KorisnikText.Text), VracanjeCheck.Checked);
            PosudbaVracanjeList.Add(PosudbaVracanje);
            if (dialogResult == DialogResult.No)
            {
                try
                {
                    var PosudbaVracanja = XDocument.Load(path);
                    foreach (Posudba posudbavracanje in PosudbaVracanjeList)
                    {
                        if (posudbavracanje.Vracanje == true)
                        {
                            var posudbavracanjeXML = new XElement("Vracanje",
                            new XElement("Vracanje" + "Datum", posudbavracanje.Datum_posudbe_vracanja),
                            new XElement("Knjiga", posudbavracanje.ISBN),
                            new XElement("Korisnik", posudbavracanje.OIB));
                            PosudbaVracanja.Root.Add(posudbavracanjeXML);
                        }
                        else
                        {
                            var posudbavracanjeXML = new XElement("Posudivanje",
                            new XElement("Posudivanje" + "Datum", posudbavracanje.Datum_posudbe_vracanja),
                            new XElement("Knjiga", posudbavracanje.ISBN),
                            new XElement("Korisnik", posudbavracanje.OIB));
                            PosudbaVracanja.Root.Add(posudbavracanjeXML);
                        }
                    }
                    PosudbaVracanja.Save(path);
                }
                catch
                {
                    var PosudbaVracanja = new XDocument();
                    PosudbaVracanja.Add(new XElement("PosudivanjaVracanja"));
                    foreach (Posudba posudbavracanje in PosudbaVracanjeList)
                    {
                        if (posudbavracanje.Vracanje == true)
                        {
                            var posudbavracanjeXML = new XElement("Vracanje",
                            new XElement("Vracanje" + "Datum", posudbavracanje.Datum_posudbe_vracanja),
                            new XElement("Knjiga", posudbavracanje.ISBN),
                            new XElement("Korisnik", posudbavracanje.OIB));
                            PosudbaVracanja.Root.Add(posudbavracanjeXML);
                        }
                        else
                        {
                            var posudbavracanjeXML = new XElement("Posudivanje",
                            new XElement("Posudivanje" + "Datum", posudbavracanje.Datum_posudbe_vracanja),
                            new XElement("Knjiga", posudbavracanje.ISBN),
                            new XElement("Korisnik", posudbavracanje.OIB));
                            PosudbaVracanja.Root.Add(posudbavracanjeXML);
                        }
                    }
                    PosudbaVracanja.Save(path);
                }
                PosudbaVracanjeList.Clear();
                KnjigaText.Clear();
                KorisnikText.Clear();

                if (!File.Exists(path)) File.Create(path);
                this.Close();
            }
        }

        private void VracanjeCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
