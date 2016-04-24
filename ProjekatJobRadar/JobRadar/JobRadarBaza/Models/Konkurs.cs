using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobRadar.JobRadarBaza.Models
{
    class Konkurs
    {
        private int idKonkursa;
        private string NazivKonkursa;
        private DateTime datumObjave;
        private DateTime datumIsteka;
        //fali
        private LokacijaBaza.Models.Lokacija lokacijaPosla;
        private bool javnoVidljiv;
        private bool aktivan;
        private int brojPregleda;

        public Konkurs(string NazivKonkursa, DateTime datumObjave, DateTime datumIsteka, LokacijaBaza.Models.Lokacija lokacija, bool vidljiv)
        {

        } 
    }
}
