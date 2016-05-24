using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Classes
{
    public class StetniObjekti:Objekti
    {
        public int damage { get; set; }

        public StetniObjekti(String name, int damage) : base(name)
        {
            this.damage = damage;
        }


    }
}
