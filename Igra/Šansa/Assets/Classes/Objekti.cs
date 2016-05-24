using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Classes
{
    public abstract class Objekti
    {
        public string name { get; set; }

        public Objekti(String name)
        {
            this.name = name;
        }
    }
}
