using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaZaBiblioteku
{
    internal class Posuditelji
    {
        
        public Posuditelji(int oib_const, string ime_const, string prezime_const)
        {
            OIB = oib_const;
            ime = ime_const;
            prezime = prezime_const;
        }

        int oib;
        string ime;
        string prezime;

        public int OIB { get => oib; set => oib = value; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
    }
}
