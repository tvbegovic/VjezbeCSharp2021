using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Igre_ListaObjekata
{
    public partial class Glavna : Form
    {
        List<Igra> igre = new List<Igra>();
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
            if (!ok)
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
                igra.Opis = opis;
                igra.Izdavac = izdavac;
                igra.Vrsta = vrsta;
                igra.Cijena = cijena;
                igra.DatumIzdavanja = datumIzdavanja;
                igre.Add(igra);
                AzurirajGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Dogodila se pogreška. Tekst: {ex.Message}",
                    "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void AzurirajGrid()
        {
            dgvIgre.DataSource = null;
            dgvIgre.DataSource = igre;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            var datoteka = new StreamWriter("igre.txt");
            foreach (var igra in igre)
            {
                datoteka.WriteLine("{0};{1};{2};{3};{4};{5}",
                    igra.Naziv, igra.Opis, igra.Vrsta, igra.DatumIzdavanja,
                    igra.Cijena, igra.Izdavac);
            }
            datoteka.Close();
        }

        private void btnUcitaj_Click(object sender, EventArgs e)
        {
            igre.Clear();
            var redci = File.ReadAllLines("igre.txt");
            foreach ( var red in redci)
            {
                var stupci = red.Split(';');
                var igra = new Igra();
                igra.Naziv = stupci[0];
                igra.Opis = stupci[1];
                igra.Vrsta = stupci[2];
                var ok = DateTime.TryParse(stupci[3], out DateTime datum);
                if (ok)
                    igra.DatumIzdavanja = datum;
                ok = decimal.TryParse(stupci[4], out decimal cijena);
                if (ok)
                    igra.Cijena = cijena;
                igra.Izdavac = stupci[5];
                igre.Add(igra);
            }
            AzurirajGrid();
        }
    }
}
