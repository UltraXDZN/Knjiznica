using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaZaBiblioteku
{
    internal class Posudba
    {
        DateTime datum_posudbe_vracanja;
        int isbn;
        int oib;
        bool vracanje;

        public Posudba(DateTime datum_posudbe_vracanja_const, int isbn_cont, int oib_const, bool vracanje_const = false)
        {
            datum_posudbe_vracanja = datum_posudbe_vracanja_const;
            isbn = isbn_cont;
            oib = oib_const;
            vracanje = vracanje_const;
        }

        public DateTime Datum_posudbe_vracanja { get => datum_posudbe_vracanja; set => datum_posudbe_vracanja = value; }
        public int ISBN { get => isbn; set => isbn = value; }
        public int OIB { get => oib; set => oib = value; }
        public bool Vracanje { get => vracanje; set => vracanje = value; }
    }
}
