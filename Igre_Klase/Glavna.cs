using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igre_Klase
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            var naziv = txtNaziv.Text;
            var opis = txtOpis.Text;
            var vrsta = txtVrsta.Text;
            var izdavac = txtIzdavac.Text;

            var ok = DateTime.TryParse(txtDatum.Text, out DateTime datumIzdavanja);
            if(!ok)
            {
                MessageBox.Show("Pogrešan format", "Pogreška", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            ok = decimal.TryParse(txtCijena.Text, out decimal cijena);
            if (!ok)
            {
                MessageBox.Show("Pogrešan format", "Pogreška", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var igra = new Igra();
            try
            {
                igra.Naziv = naziv;
                var a = igra.Naziv;
                igra.UnesiPodatke(naziv, opis, vrsta, datumIzdavanja, cijena, izdavac);
                MessageBox.Show("Podaci su uspješni uneseni", "Uspjeh", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dogodila se pogreška. Tekst: {ex.Message}",
                    "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
