using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Biblioteka;
using Forms.Forms;
using Forms;

namespace Biblioteka.Forms
{
    public partial class ZasobyForm : Form
    {
        private List<Ksiazka> biblioteka;
        private List<Film> filmy;
        private List<Album> albumy;

        public ZasobyForm(List<Ksiazka> biblioteka, List<Film> filmy, List<Album> albumy)
        {
            InitializeComponent();
            this.biblioteka = biblioteka;
            this.filmy = filmy;
            this.albumy = albumy;

            // Ustawienie źródła danych dla kontrolki DataGridView na listę książek jako domyślną
            dataGridView1.DataSource = biblioteka;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Przejście do Form1
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Przejście do Dodaj_ProduktForm
            Dodaj_ProduktForm dodaj_produktForm = new Dodaj_ProduktForm(biblioteka, filmy, albumy, dataGridView1);
            dodaj_produktForm.Show();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Wybór danych do wyświetlenia w zależności od wyboru użytkownika w comboBox1
            if (comboBox1.SelectedItem != null)
            {
                string selectedItem = comboBox1.SelectedItem.ToString();

                if (selectedItem == "Książka")
                {
                    dataGridView1.DataSource = biblioteka;
                }
                else if (selectedItem == "Film")
                {
                    dataGridView1.DataSource = filmy;
                }
                else if (selectedItem == "Album")
                {
                    dataGridView1.DataSource = albumy;
                }
            }
        }
        public void RefreshDataGridView()
        {
            // Odświeżenie danych w dataGridView1
            dataGridView1.DataSource = null;

            // Sprawdź, czy wybrano element w comboBox1
            if (comboBox1.SelectedItem != null)
            {
                // Sprawdź wybrany typ i ustaw źródło danych dataGridView1
                if (comboBox1.SelectedItem.ToString() == "Książka")
                {
                    dataGridView1.DataSource = biblioteka;
                }
                else if (comboBox1.SelectedItem.ToString() == "Film")
                {
                    dataGridView1.DataSource = filmy;
                }
                else if (comboBox1.SelectedItem.ToString() == "Album")
                {
                    dataGridView1.DataSource = albumy;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Pobierz indeks zaznaczonego wiersza
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                // Pobierz wybrany obiekt z listy na podstawie indeksu zaznaczonego wiersza
                object selectedItem = dataGridView1.Rows[selectedRowIndex].DataBoundItem;

                // Sprawdź typ wybranego obiektu i usuń go z odpowiedniej listy oraz odśwież dataGridView1
                if (selectedItem is Ksiazka)
                {
                    Ksiazka selectedBook = (Ksiazka)selectedItem;
                    biblioteka.Remove(selectedBook);
                }
                else if (selectedItem is Film)
                {
                    Film selectedFilm = (Film)selectedItem;
                    filmy.Remove(selectedFilm);
                }
                else if (selectedItem is Album)
                {
                    Album selectedAlbum = (Album)selectedItem;
                    albumy.Remove(selectedAlbum);
                }

                // Odśwież dataGridView1
                RefreshDataGridView();
            }
        }

        private void buttonInformacje_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Pobierz indeks zaznaczonego wiersza
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;

                // Pobierz wybrany obiekt z listy na podstawie indeksu zaznaczonego wiersza
                object selectedItem = dataGridView1.Rows[selectedRowIndex].DataBoundItem;

                // Wyświetl informacje o zasobie
                if (selectedItem is Zasoby)
                {
                    Zasoby selectedZasob = (Zasoby)selectedItem;
                    MessageBox.Show(selectedZasob.Informacje(), "Informacje o zasobie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
