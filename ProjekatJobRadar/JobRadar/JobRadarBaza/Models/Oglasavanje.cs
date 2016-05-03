using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobRadar.JobRadarBaza.Models
{
    class Oglasavanje
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        private int OglasID { get; set; }
        private Poslodavac poslodavac { get; set; }
        private int brojPregleda { get; set; }
        private bool oglasavanjeKompanije { get; set; }
        private Konkurs konkurs { get; set; }
        private DateTime datumAktiviranja { get; set; }
        private DateTime datumIsteka { get; set; }
        private bool istekao { get; set; }

        public Oglasavanje() { oglasavanjeKompanije = false; istekao = false; }
        public Oglasavanje(Poslodavac poslodavac,int brojPregleda,Konkurs konkurs,DateTime datumAktiviranja,DateTime datumIsteka,bool oglasavanjeKompanije=false, bool istekao=false)
        {
            this.poslodavac = poslodavac;
            this.brojPregleda = brojPregleda;
            this.konkurs = konkurs;
            this.datumAktiviranja = datumAktiviranja;
            this.datumIsteka = datumIsteka;
            this.oglasavanjeKompanije = oglasavanjeKompanije;
            this.istekao = istekao;

        }
    }
}
