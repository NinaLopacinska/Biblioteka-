using Biblioteka.Forms;
using Biblioteka;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Forms
{
    public partial class Dodaj_UzytwkonikaForm : Form
    {
        private List<Uzytkownik> uzytkownik;
        private DataGridView dataGridView2;

        public Dodaj_UzytwkonikaForm(List<Uzytkownik> uzytkownik, DataGridView dataGridView2)
        {
            InitializeComponent();
            this.uzytkownik = uzytkownik;
            this.dataGridView2 =  dataGridView2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UzytkownicyForm uzytkownicyForm = new UzytkownicyForm(uzytkownik);
            uzytkownicyForm.Show();
            this.Close();
            
        }

        private void button1Dodaj_Click(object sender, EventArgs e)
        {
            // Sprawdzenie, czy pola są wypełnione
            if (string.IsNullOrWhiteSpace(textBoxImie.Text) || string.IsNullOrWhiteSpace(textBoxNazwisko.Text) ||
                string.IsNullOrWhiteSpace(textBoxTelefon.Text) || string.IsNullOrWhiteSpace(textBoxNumerId.Text))
            {
                MessageBox.Show("Uzupełnij wszystkie pola formularza.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Walidacja numeru telefonu
            if (!int.TryParse(textBoxTelefon.Text, out _) || textBoxTelefon.Text.Length != 9)
            {
                MessageBox.Show("Numer telefonu powinien zawierać 9 cyfr.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Walidacja numeru ID
            if (!int.TryParse(textBoxNumerId.Text, out _))
            {
                MessageBox.Show("Numer ID powinien składać się tylko z cyfr.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Dodanie użytkownika do listy
            uzytkownik.Add(new Uzytkownik(textBoxImie.Text, textBoxNazwisko.Text, Convert.ToInt32(textBoxTelefon.Text), Convert.ToInt32(textBoxNumerId.Text)));
            
            RefreshDataGridView();
            MessageBox.Show("Użytkownik został dodany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }
        private void RefreshDataGridView()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = uzytkownik;
        }
    }
}
