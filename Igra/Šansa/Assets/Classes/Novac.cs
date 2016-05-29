using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Classes
{
    class Novac:Nagrada
    {
        public Novac(String name, int bonus) :base(name,bonus) { }

        public int getBonus()
        {
            return base.bonus;
        }

        public void setBonus(int bonus)
        {
            base.bonus = bonus;
        }


    }
}
