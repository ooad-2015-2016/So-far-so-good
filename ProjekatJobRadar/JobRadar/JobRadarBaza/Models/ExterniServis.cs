using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;
using Windows.Web.Http;
using Windows.Web.Http.Headers;

namespace JobRadar.JobRadarBaza.Models
{
    class ExterniServis
    {
       
        JsonObject servicesConfig;
        string serviceHost;
        public static string konkursiName = "KonkursService";
        public static string lokacijeName = "LokacijaService";
        public static string korisniciName = "KorisnikService";
        public ExterniServis()
        {
            servicesConfig = JsonValue.Parse(File.ReadAllText("ServisConfig.json")).GetObject();
            serviceHost = servicesConfig.GetNamedString("serviceHost");
        }
      /*
        public async void dodajKorisnika(Korisnik korisnik)
        {
            System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();
            
            httpClient.DefaultRequestHeaders.Accept.Add(new
           HttpMediaTypeWithQualityHeaderValue("application/json"));
            //json se salje u body post zahtjeva
            string jsonContents = JsonConvert.SerializeObject(korisnik);
            System.Net.Http.HttpResponseMessage response = await httpClient.PostAsync(new Uri(serviceHost +
           korisniciName), new HttpStringContent(jsonContents, Windows.Storage.Streams.UnicodeEncoding.Utf8,
           "application/json"));
            //dalje sa odgovorom se moze uraditi sta god zatreba
            JsonValue value = JsonValue.Parse(response.Content.ToString());
        }
        public async void dajSveKorisnike()
        {
         
        HttpClient httpClient = new HttpClient();
            string response = await httpClient.GetStringAsync(new Uri(serviceHost + uposleniciName));
            JsonValue value = JsonValue.Parse(response);
        }*/
    }

}
