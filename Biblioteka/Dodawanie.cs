using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Biblioteka
{
    public class Dodawanie
    {

        public Zasoby zasoby;
        List<Zasoby> biblioteka = new List<Zasoby>();

        List<Zasoby> filmy = new List<Zasoby>();

        List<Zasoby> albumy = new List<Zasoby>();

        List<Uzytkownik> uzytkownicy = new List<Uzytkownik>();

        public Dodawanie(Zasoby zasoby)
        {
            this.zasoby = zasoby;
            this.biblioteka = new List<Zasoby> { zasoby };
            this.filmy = new List<Zasoby> { zasoby };
            this.albumy = new List<Zasoby> { zasoby };
        }
        public Dodawanie(Uzytkownik uzytkownik) 
        { 
            this.uzytkownicy = uzytkownicy;
            this.uzytkownicy = new List<Uzytkownik> { uzytkownik };
        }

        public List<Zasoby> GetBiblioteka(List<Zasoby> biblioteka)
        {
            return biblioteka;
        }
        public List<Zasoby> GetFilmy(List<Zasoby> filmy)
        {
            return filmy;
        }
        public List<Zasoby> GetAlbumy(List<Zasoby> album)
        {
            return album;
        }
        public List<Uzytkownik> GetUzytkownik(List<Uzytkownik>uzytkownik)
        { return uzytkownik; }

        public void DodajPrzykladoweKsiazki(List<Ksiazka> biblioteka)
        {
            biblioteka.Add(new Ksiazka("Wiedźmin", "Andrzej Sapkowski", 1993, 10, "Fantastyka", false, 300));
            biblioteka.Add(new Ksiazka("Pan Tadeusz", "Adam Mickiewicz", 1834, 11, "Epopeja", true, 400));
            biblioteka.Add(new Ksiazka("Wilk z Wall Street", "Jordan Belfort", 2007, 12, "Biografia", true, 528));
            biblioteka.Add(new Ksiazka("Harry Potter i Kamień Filozoficzny", "J.K. Rowling", 1997, 13, "Fantastyka", false, 223));
            biblioteka.Add(new Ksiazka("Dziady", "Adam Mickiewicz", 1822, 14, "Dramat", false, 200));
            biblioteka.Add(new Ksiazka("Zbrodnia i kara", "Fiodor Dostojewski", 1866, 15, "Psychologiczna", true, 430));
            biblioteka.Add(new Ksiazka("Hobbit, czyli tam i z powrotem", "J.R.R. Tolkien", 1937, 16, "Fantasy", false, 304));
            biblioteka.Add(new Ksiazka("Metro 2033", "Dmitry Glukhovsky", 2005, 17, "Postapokaliptyczna", false, 459));
            biblioteka.Add(new Ksiazka("Lalka", "Bolesław Prus", 1890, 18, "Społeczno-obyczajowa", true, 624));

        }
        public static void DodajPrzykładoweFilmy(List<Film> filmy)
        {
            filmy.Add(new Film("Incepcja", "Christopher Nolan", 2010, 19, "Science Fiction", false, 148));
            filmy.Add(new Film("Szeregowiec Ryan", "Steven Spielberg", 1998, 20, "Dramat wojenny", false, 169));
            filmy.Add(new Film("Labirynt fauna", "Guillermo del Toro", 2006, 21, "Fantasy", false, 118));
            filmy.Add(new Film("Ojciec chrzestny", "Francis Ford Coppola", 1972, 22, "Gangsterski", true, 175));
            filmy.Add(new Film("Skazani na Shawshank", "Frank Darabont", 1994, 23, "Dramat", false, 142));
            filmy.Add(new Film("Forrest Gump", "Robert Zemeckis", 1994, 24, "Dramat", false, 142));
        }

        public static void DodajPrzykładoweAlbumy(List<Album> albumy)
        {
            albumy.Add(new Album("Łódź z czasów II wojny światowej", "Jan Kowalsko", 2022, 25, "Fotografia", false, 50));
            albumy.Add(new Album("Tajemnice natury", "National Geographic", 2020, 26, "Fotografia", true, 100));
            albumy.Add(new Album("Krajobrazy świata", "Anonimowy", 2019, 27, "Fotografia", false, 80));
            albumy.Add(new Album("Makrofotografia zwierząt", "John Smith", 2021, 28, "Fotografia", true, 120));
            albumy.Add(new Album("Historia miasta w fotografii", "Maria Nowak", 2018, 29, "Fotografia", false, 90));
        }
        public static void DodajPrzykladowegoUzytkownika(List<Uzytkownik> uzytkownik)
        {
            uzytkownik.Add(new Uzytkownik("Jan", "Kowalski", 123456789, 1));
            uzytkownik.Add(new Uzytkownik("Anna", "Nowak", 987654321, 2));
            uzytkownik.Add(new Uzytkownik("Piotr", "Wiśniewski", 111222333, 3));
            uzytkownik.Add(new Uzytkownik("Magdalena", "Kowalczyk", 444555666, 4));
            uzytkownik.Add(new Uzytkownik("Krzysztof", "Lewandowski", 777888999, 5));
        }

    }
}



