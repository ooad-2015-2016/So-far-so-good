using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobRadar.LokacijaBaza.Models
{
    class DefaultPodaci
    {
        public static void Initialize(LokacijaDbContext context)
        {
            if (!context.Lokacije.Any())
            {
                context.Lokacije.AddRange(
                    new Lokacija("Evropa", "BiH", "Sarajevo", "Trg Zlatnih Ljiljana", "71000"));
                context.SaveChanges();
            }
        }
    }
}
