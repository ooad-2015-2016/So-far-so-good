using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Classes
{
    class Nagrada:Objekti
    {
        public int bonus { get; set; }
        public Nagrada(String name, int bonus):base(name)
        {

        }
    }
}
