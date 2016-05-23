using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobRadarWeb.Models
{
    public class Oglasavanje
    {
       
        public int ID { get; set; }
        public Poslodavac poslodavac { get; set; }
        public int brojPregleda { get; set; }
        public bool oglasavanjeKompanije { get; set; }
        public Konkurs konkurs { get; set; }
        public DateTime datumAktiviranja { get; set; }
        public DateTime datumIsteka { get; set; }
        public bool istekao { get; set; }

        public Oglasavanje() { oglasavanjeKompanije = false; istekao = false; }
        public Oglasavanje(Poslodavac poslodavac, int brojPregleda, Konkurs konkurs, DateTime datumAktiviranja, DateTime datumIsteka, bool oglasavanjeKompanije = false, bool istekao = false)
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