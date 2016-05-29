using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Classes
{
    class Cigla:StetniObjekti
    {
        public Cigla(string name, int damage):base(name,damage)
        {

        }

        public int getDamage()
        {
            return base.damage;
        }

        public void setDamage(int dmg)
        {
            base.damage = dmg;
        }
    }
}
