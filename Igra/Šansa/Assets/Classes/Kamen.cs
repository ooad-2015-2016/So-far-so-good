using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Classes
{
    class Kamen:StetniObjekti
    {
        public Kamen(String name, int damage):base(name,damage)
        { }

        public int getDamage()
        {
            return base.damage;
        }

        public int setDamage()
        {
            return base.damage;
        }
    }
}
