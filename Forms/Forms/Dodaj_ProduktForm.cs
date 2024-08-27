using Biblioteka;
using Biblioteka.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Forms.Forms
{
    public partial class Dodaj_ProduktForm : Form
    {
        private DataGridView dataGridView1; // Dodaj pole do przechowywania referencji do dataGridView1
        public List<Ksiazka> biblioteka;
        public List<Film> filmy;
        public List<Album> albumy;
        public Dodaj_ProduktForm(List<Ksiazka> biblioteka, List<Film> filmy, List<Album> albumy, DataGridView dataGridView1)
        {

            InitializeComponent();
            this.biblioteka = biblioteka;
            this.filmy = filmy;
            this.albumy = albumy;
            this.dataGridView1 = dataGridView1; // Przypisz referencję do dataGridView1

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Sprawdzenie, czy wybrano jakiś produkt
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Wybierz produkt.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Sprawdzenie, czy wszystkie pola są wypełnione
            if (string.IsNullOrWhiteSpace(textBoxTytul.Text) || string.IsNullOrWhiteSpace(textBoxAutor.Text) ||
                string.IsNullOrWhiteSpace(textBoxRokWydania.Text) || string.IsNullOrWhiteSpace(textBoxNrKatalogowy.Text) ||
                string.IsNullOrWhiteSpace(textBoxTyp.Text) || string.IsNullOrWhiteSpace(textBoxDodatkowe.Text))
            {
                MessageBox.Show("Uzupełnij wszystkie pola formularza.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Przygotowanie danych produktu
            string tytul = textBoxTytul.Text;
            string autor = textBoxAutor.Text;
            int rokWydania = int.Parse(textBoxRokWydania.Text);
            int nrKatalogowy = int.Parse(textBoxNrKatalogowy.Text);
            string typ = textBoxTyp.Text;
            string dodatkowe = textBoxDodatkowe.Text;

            int liczbaStron = 0;
            int czasTrwania = 0;
            int liczbaZdjec = 0;

            // Sprawdzenie, czy dodatkowe dane są liczbą
            if (!int.TryParse(dodatkowe, out _))
            {
                MessageBox.Show("Dodatkowe dane muszą być liczbą.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Dodanie produktów zaznaczonych w checkedListBox1 do listy zasobów
            foreach (var item in checkedListBox1.CheckedItems)
            {
                switch (item.ToString())
                {
                    case "Książka":
                        // Przypisanie liczby stron dla książki
                        liczbaStron = int.Parse(dodatkowe);
                        biblioteka.Add(new Ksiazka(tytul, autor, rokWydania, nrKatalogowy, typ, false, liczbaStron));
                        MessageBox.Show("Książka została pomyślnie dodana.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Film":
                        // Przypisanie czasu trwania dla filmu
                        czasTrwania = int.Parse(dodatkowe);
                        filmy.Add(new Film(tytul, autor, rokWydania, nrKatalogowy, typ, false, czasTrwania));
                        MessageBox.Show("Film został pomyślnie dodany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Album":
                        // Przypisanie liczby zdjęć dla albumu
                        liczbaZdjec = int.Parse(dodatkowe);
                        albumy.Add(new Album(tytul, autor, rokWydania, nrKatalogowy, typ, false, liczbaZdjec));
                        MessageBox.Show("Album został pomyślnie dodany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            // Sprawdzenie, jaki typ produktu jest aktualnie wyświetlany w DataGridView
            if (dataGridView1.DataSource == biblioteka)
            {
                // Aktualizacja DataGridView dla listy książek
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = biblioteka;
            }
            else if (dataGridView1.DataSource == filmy)
            {
                // Aktualizacja DataGridView dla listy filmów
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = filmy;
            }
            else if (dataGridView1.DataSource == albumy)
            {
                // Aktualizacja DataGridView dla listy albumów
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = albumy;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ZasobyForm zasobyForm = new ZasobyForm(biblioteka, filmy, albumy);
            zasobyForm.Show();
            this.Close();
        }

    }
}
