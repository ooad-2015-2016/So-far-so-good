using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobRadarWeb.Models
{
    public class Konkurs
    {
     
        public int ID { get; set; }
        public string NazivKonkursa;
        public DateTime datumObjave;
        public DateTime datumIsteka;
        
        public int LokacijaId { get; set; }
        public Lokacija lokacijaPosla;
        public bool javnoVidljiv;
        public bool aktivan;
        public int brojPregleda;

        public Konkurs() { }
        public Konkurs(string NazivKonkursa, DateTime datumObjave, DateTime datumIsteka, Lokacija lokacija, bool vidljiv)
        {
            this.NazivKonkursa = NazivKonkursa;
            this.datumObjave = datumObjave;
            this.datumIsteka = datumIsteka;
            this.lokacijaPosla = lokacija;
            this.javnoVidljiv = vidljiv;
            this.brojPregleda = 0;
            aktivan = true;
            
        }

        public string getNaziv() { return NazivKonkursa; }
        public DateTime getDatumObjave() { return datumObjave; }
        public DateTime getDatumIsteka() { return datumIsteka; }
        public Lokacija getLokacija() { return lokacijaPosla; }
        public bool getJavnoVidljiv() { return javnoVidljiv; }
        public bool getAktivan() { return aktivan; }
        public int getBrojPregleda() { return brojPregleda; }

        public void setNaziv(string naziv)
        {
            this.NazivKonkursa = naziv;
        }

        public void setDatumIsteka(DateTime datum)
        {
            this.datumIsteka = datum;
        }

        public void setLokacija(Lokacija lokacija)
        {
            this.lokacijaPosla = lokacija;
        }

        public void setJavnoVidljiv(bool vidljiv)
        {
            this.javnoVidljiv = vidljiv;
        }
    }
}
