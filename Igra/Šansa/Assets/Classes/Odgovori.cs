using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Classes
{
    class Odgovori
    {
        private List<String> odgovori;
        private String tacanOdgovor;

        public Odgovori(List<String> odg, String tacanOdgovor)
        {
            this.odgovori = odg;
            this.tacanOdgovor = tacanOdgovor;
        }

        public String getTacanOdgovor()
        {
            return tacanOdgovor;
        }

        public List<String> getOdgovori()
        {
            return odgovori;
        }

        public void setOdgovori(List<String> odg)
        {
            odgovori = odg;
        }
    }
}
