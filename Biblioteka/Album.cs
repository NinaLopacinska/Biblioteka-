using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Album : Zasoby
    {
        public int LiczbaZdjec {  get; set; }

        public Album(string tytul, string autor,int  rokWydania, int numerKatalogowy, string typ, bool czyWypozyczone, int liczbaZdjec)
            : base(tytul, autor, rokWydania, numerKatalogowy, typ, czyWypozyczone)

        {
            LiczbaZdjec = liczbaZdjec;
        }
        public override string Informacje()
        {
            return $"To jest album o tytule \"{Tytul}\" autorem zdjęć jest {Autor}.";
        }
    }
}
