using Biblioteka;
using Biblioteka.Forms;
using Forms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form1 : Form
    {
        public List<Ksiazka> biblioteka;
        public List<Film> filmy;
        public List<Album> albumy;
        public List<Uzytkownik> uzytkownik;
        public Form1()
        {
            InitializeComponent();
            this.biblioteka = new List<Ksiazka>();
            this.filmy = new List<Film>();
            this.albumy = new List<Album>();
            this.uzytkownik = new List<Uzytkownik>();
            // Dodaj przykładowe książki, filmy i albumy
            Dodawanie dodawanie = new Dodawanie(new Zasoby("Tytuł", "Autor", 2000, 1, "Typ", false)); // Tworzymy instancję klasy Dodawanie i przekazujemy przykładowe dane do konstruktora klasy Zasoby
            Uzytkownik nowyuzytkownik = new Uzytkownik("Imie", "Nazwisko", 111222333, 1);
            dodawanie.DodajPrzykladoweKsiazki(biblioteka); // Dodajemy przykładowe książki do listy biblioteka
            Dodawanie.DodajPrzykładoweFilmy(filmy);
            Dodawanie.DodajPrzykładoweAlbumy(albumy);
            Dodawanie.DodajPrzykladowegoUzytkownika(uzytkownik);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void Zasoby_Click_1(object sender, EventArgs e)
        {

            ZasobyForm zasobyForm = new ZasobyForm(biblioteka, filmy, albumy);
            zasobyForm.Show();
            //this.Close();

        }

        private void Uzytkownicy_Click(object sender, EventArgs e)
        {
            UzytkownicyForm uzytkownicyForm = new UzytkownicyForm(uzytkownik);
            uzytkownicyForm.Show();
            
        }
    }
}
