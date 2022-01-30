using System;
using System.Windows.Forms;

namespace AplikacijaZaBiblioteku
{
    public partial class GlavniIzbornik : Form
    {
        public GlavniIzbornik()
        {
            InitializeComponent();
        }

        private void UpisKorisnikaButton_Click(object sender, EventArgs e)
        {
            UpisPosuditelja Korisnik = new UpisPosuditelja();
            Korisnik.ShowDialog();
        }

        private void PVButton_Click(object sender, EventArgs e)
        {
            PosudbaVracanje PV = new PosudbaVracanje();
            PV.ShowDialog();
        }

        private void UpisKnjigeButton_Click(object sender, EventArgs e)
        {
            UpisKnjige Knjiga = new UpisKnjige();
            Knjiga.ShowDialog();
        }

        private void DBBrowserButun_Click(object sender, EventArgs e)
        {
            Pretraga pretraga = new Pretraga();
            pretraga.ShowDialog();
        }

    }
}
