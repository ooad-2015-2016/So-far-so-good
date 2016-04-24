using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobRadar.OglasavanjeBaza.Models
{
    class Oglasavanje
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idOglasa { get; set; }
        //private Poslodavac poslodavac { get; set; }
        private int brojPregleda { get; set; }
        private Boolean oglasavanjeKompanije = false;
        //private Konkurs konkurs { get; set; }
        private DateTime datumAktiviranja { get; set; }
        private DateTime datumIsteka { get; set; }
        private Boolean istekao = false;

        public bool OglasavanjeKompanije
        {
            get
            {
                return oglasavanjeKompanije;
            }

            set
            {
                oglasavanjeKompanije = value;
            }
        }

        public bool Istekao
        {
            get
            {
                return istekao;
            }

            set
            {
                istekao = value;
            }
        }


    }
}
