using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igre_ListaObjekata
{
    class Igra
    {
        private string naziv;        
        private string vrsta;
        private decimal cijena;
        private string opis;
        private DateTime datumIzdavanja;        
        private string izdavac;

        //1. verzija unosa u klasu
        public void UnesiPodatke(string naziv, string opis, string vrsta,
            DateTime datum, decimal cijena, string izdavac)
        {
            if (string.IsNullOrEmpty(naziv))
                throw new ArgumentException("Naziv mora biti upisan");
            this.naziv = naziv;
            this.opis = opis;
            if(vrsta != "Akcijska" && vrsta != "RPG" && vrsta != "Avantura")
            {
                throw new ArgumentException("Vrsta nije jedna od dozvoljenih: Akcijska, RPG, Avantura");
            }
            this.vrsta = vrsta;
            datumIzdavanja = datum;
            if (cijena < 0 || cijena > 1000)
                throw new ArgumentOutOfRangeException("Cijena nije u rasponu 0-1000");
            this.cijena = cijena;
            this.izdavac = izdavac;
        }

        //2. verzija unos preko get/set public properties
        public string Naziv
        {
            get
            {
                return naziv;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Naziv mora biti upisan");
                naziv = value;
            }
        }

        public string Vrsta
        {
            get
            {
                return vrsta;
            }
            set
            {
                if (value != "Akcijska" && value != "RPG" && value != "Avantura")
                {
                    throw new ArgumentException("Vrsta nije jedna od dozvoljenih: Akcijska, RPG, Avantura");
                }
                vrsta = value;
            }
        }

        public decimal Cijena
        {
            get
            {
                return cijena;
            }
            set
            {
                if(value < 0 || value > 1000)
                {
                    throw new ArgumentOutOfRangeException("Cijena je izvan raspona");
                }
                cijena = value;
            }
        }

        public string Opis { get => opis; set => opis = value; }
        public DateTime DatumIzdavanja { get => datumIzdavanja; set => datumIzdavanja = value; }
        public string Izdavac { get => izdavac; set => izdavac = value; }
    }
}
