using Biblioteka;
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
    public partial class UzytkownicyForm : Form
    {
        private List<Uzytkownik> uzytkownik;

        public UzytkownicyForm(List<Uzytkownik> uzytkownik)
        {
            InitializeComponent();
            this.uzytkownik = uzytkownik;
            dataGridView2.DataSource = uzytkownik;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dodaj_UzytwkonikaForm dodaj_UzytkownikaForm = new Dodaj_UzytwkonikaForm(uzytkownik, dataGridView2);
            dodaj_UzytkownikaForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Sprawdź, czy coś jest zaznaczone w dataGridView2
            if (dataGridView2.SelectedRows.Count > 0)
            {
                // Pobierz zaznaczonego użytkownika
                Uzytkownik zaznaczonyUzytkownik = dataGridView2.SelectedRows[0].DataBoundItem as Uzytkownik;

                // Usuń zaznaczonego użytkownika z listy uzytkownicy
                uzytkownik.Remove(zaznaczonyUzytkownik);

                // Odśwież dane w dataGridView2
                RefreshDataGridView();
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć użytkownika do usunięcia.");
            }
        }
        private void RefreshDataGridView()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = uzytkownik;
        }
    }
}
