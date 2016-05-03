using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobRadar.JobRadarBaza.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JobRadar.JobRadarBaza.Models
{
    class Konkurs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        private int ID { get; set; }
        private string NazivKonkursa;
        private DateTime datumObjave;
        private DateTime datumIsteka;
        //fali
        public int LokacijaId { get; set; }
        [ForeignKey("LokacijaId")]
        public Lokacija lokacijaPosla;
        private bool javnoVidljiv;
        private bool aktivan;
        private int brojPregleda;

        public Konkurs(string NazivKonkursa, DateTime datumObjave, DateTime datumIsteka, Lokacija lokacija, bool vidljiv)
        {

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
