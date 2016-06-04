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
            
                Lokacija lok = new Lokacija("Evropa", "BiH", "Sarajevo", "Trg Zlatnih Ljiljana", "71000");
                Konkurs konkurs = new Konkurs("Ležanje na poslu", DateTime.Now, DateTime.Now, lok,true);
                List<Konkurs> k = new List<Konkurs>();
                k.Add(konkurs);
                Poslodavac poslodavac = new Poslodavac("test", "poslodavac@posao", "123", "Fabrika za proizvodnju ničega",
                    "Ne proizvodimo ništa samo uzimamo", lok,k,true);
                OsobaKojaTraziPosao osoba = new OsobaKojaTraziPosao("jbajramovi1", "jasminabajramovic@gmail.com", "pass", "Jasmina", "Bajramović", DateTime.Now, DateTime.Now, false, k, true);
                context.Konkursi.Add(konkurs);
                
                context.Poslodavac.Add(poslodavac);
                context.OsobaKojaTraziPosao.Add(osoba);
                context.SaveChanges();
            
        }
    }
}
