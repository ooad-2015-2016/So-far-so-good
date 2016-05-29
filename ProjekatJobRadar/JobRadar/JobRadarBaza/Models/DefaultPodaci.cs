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
            if (!context.Poslodavac.Any())
            {
                Lokacija lok = new Lokacija("Evropa", "BiH", "Sarajevo", "Trg Zlatnih Ljiljana", "71000");
                Konkurs konkurs = new Konkurs("Ležanje na poslu", DateTime.Now, DateTime.Now, lok,true);
                List<Konkurs> k = new List<Konkurs>();
                k.Add(konkurs);
                Poslodavac poslodavac = new Poslodavac("testUsername", "poslodavac@posao", "12grkoj34oijt3", "Fabrika za proizvodnju ničega",
                    "Ne proizvodimo ništa samo uzimamo", lok,k,true);

                context.Konkursi.Add(konkurs);

                context.Konkursi.Add(konkurs);
                context.Poslodavac.Add(poslodavac);

                context.SaveChanges();
            }
        }
    }
}
