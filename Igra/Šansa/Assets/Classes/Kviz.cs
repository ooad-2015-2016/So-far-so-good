using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Classes
{
    public class Kviz
    {
        private List<Pitanje> pitanja;

        public Kviz(List<Pitanje> listaPitanja)
        {
            this.pitanja = listaPitanja;
        }

        public String getPitanje(int index)
        {
            return pitanja[index].PitanjeA;
        }

        public List<String> getOdgovori(int index)
        {
            return pitanja[index].getOdgovori();
        }

        public String getTacanOdgovor(int index)
        {
            return pitanja[index].getTacanOdgovor();
        }
    }
}
