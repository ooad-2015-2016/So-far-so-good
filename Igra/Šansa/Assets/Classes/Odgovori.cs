using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Classes
{
    class Odgovori
    {
        private List<String> odgovori;

        public Odgovori(List<String> odg)
        {
            this.odgovori = odg;
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
