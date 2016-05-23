using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JobRadar.JobRadarBaza.Models
{
    [DataContract]
    public class Oglasavanje
    {
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        private int OglasID { get; set; }
        [DataMember]
        private Poslodavac poslodavac { get; set; }
        [DataMember]
        private int brojPregleda { get; set; }
        private bool oglasavanjeKompanije { get; set; }
        [DataMember]
        private Konkurs konkurs { get; set; }
        [DataMember]
        private DateTime datumAktiviranja { get; set; }
        [DataMember]
        private DateTime datumIsteka { get; set; }
        [DataMember]
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
