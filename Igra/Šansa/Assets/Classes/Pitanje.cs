using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Classes
{
    public class Pitanje
    {
        private string pitanjeA;
        private Odgovori odgovori;

        public string PitanjeA
        {
            get
            {
                return pitanjeA;
            }

            set
            {
                pitanjeA = value;
            }
        }

        public Pitanje(String pitanje, List<String> odg, String tacanOdgovor)
        {
            this.PitanjeA = pitanjeA;
            odgovori = new Odgovori(odg,tacanOdgovor);
        }

        public List<String> getOdgovori()
        {
            return odgovori.getOdgovori();
        }

        public String getTacanOdgovor()
        {
            return odgovori.getTacanOdgovor();
        }
    }
}
