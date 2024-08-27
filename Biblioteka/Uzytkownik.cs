using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Uzytkownik
    {
        public string Imie {  get; set; }
        public string Nazwisko { get; set; }
        public int NumerTelefonu { get; set; }
        public int IdUzytkownika { get; set; }

        public Uzytkownik(string imie, string nazwisko, int numerTelefonu, int idUzytkownika)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            NumerTelefonu = numerTelefonu;
            IdUzytkownika = idUzytkownika;
            
        }


    }

    
}
