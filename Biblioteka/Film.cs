using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Film : Zasoby
    {
        public int CzasTrwania { get; set; }

        public Film(string tytul, string autor, int rokWydania, int numerKatalogowy, string typ, bool czyWypozyczone, int czasTrwania)
            : base(tytul, autor, rokWydania, numerKatalogowy, typ, czyWypozyczone)
        {
            CzasTrwania = czasTrwania;
        }
        public override string Informacje()
        {
            return $"To jest film o tytule \"{Tytul}\" w reżyserii {Autor}.";
        }
    }
}
