using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobRadar.JobRadarBaza.Models
{
    class DefaultPodaci
    {
        public static void Initialize(JobRadarDBContext context)
        {
            if (!context.Lokacija.Any())
            {
                context.Lokacija.AddRange(
                    new Lokacija("Evropa", "BiH", "Sarajevo", "Trg Zlatnih Ljiljana", "71000"));
                context.SaveChanges();
            }
        }
    }
}
