namespace AplikacijaZaBiblioteku
{
    internal class Knjige
    {
        public Knjige(float isbn_const, string ime, string autor_const, int kolicina_const)
        {
            isbn = isbn_const;
            naziv = ime;
            autor = autor_const;
            kolicina = kolicina_const;
        }

        float isbn;
        string naziv;
        string autor;
        int kolicina;

        public float ISBN { get => isbn; set => isbn = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public string Autor { get => autor; set => autor = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
    }
}
