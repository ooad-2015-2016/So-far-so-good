using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobRadarWeb.Models
{
    public class Lokacija
    {
        
        public int LokacijaId { get; set; }
        public string fourSqaureId { get; set; }
        public string Kontinent { get; set; }
        public string Drzava { get; set; }
        public string Grad { get; set; }
        public string Adresa { get; set; }
        public string PostanskiBroj { get; set; }

        public Lokacija() { }
        public Lokacija(string kontinent, string drzava, string grad, string adresa, string postanskiBroj)
        {
            Kontinent = kontinent;
            Drzava = drzava;
            Grad = grad;
            Adresa = adresa;
            PostanskiBroj = postanskiBroj;
        }


    }
}
