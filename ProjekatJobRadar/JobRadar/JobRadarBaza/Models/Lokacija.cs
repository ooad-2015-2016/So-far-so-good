﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobRadar.JobRadarBaza.Models
{
    public class Lokacija
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int LokacijaId { get; set; }
        public string fourSqaureId { get; set; }
        private string Kontinent { get; set; }
        private string Drzava { get; set; }
        private string Grad { get; set; }
        private string Adresa { get; set; }
        private string PostanskiBroj { get; set; }

        public Lokacija() { }
        public Lokacija(string kontinent,string drzava,string grad,string adresa,string postanskiBroj)
        {
            Kontinent = kontinent;
            Drzava = drzava;
            Grad = grad;
            Adresa = adresa;
            PostanskiBroj = postanskiBroj;
        }
       

    }
}
