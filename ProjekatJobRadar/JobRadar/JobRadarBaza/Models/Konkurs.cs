using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobRadar.JobRadarBaza.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace JobRadar.JobRadarBaza.Models
{
    [DataContract]
    public class Konkurs
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [DataMember]
        private int ID { get; set; }
        [DataMember]
        private string NazivKonkursa;
        [DataMember]
        private DateTime datumObjave;
        [DataMember]
        private DateTime datumIsteka;
        //fali
        public int LokacijaId { get; set; }
        [ForeignKey("LokacijaId")]
        [DataMember]
        public Lokacija lokacijaPosla;
        [DataMember]
        private bool javnoVidljiv;
        [DataMember]
        private bool aktivan;
        [DataMember]
        private string opis;
        [DataMember]
        private int brojPregleda;

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
