﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JobRadar.JobRadarBaza.Models
{
    public class Poslodavac:Korisnik
    {
        [Key]
        private int ID { get; set; }
        public string nazivPoslodavca { get; set; }
        private string opis { get; set; }
        private Lokacija lokacija { get; set; }
        private List<Konkurs> konkursi { get; set; }

        public Poslodavac():base() { konkursi = new List<Konkurs>(); }
        public Poslodavac(string userName, string email, string pwd, string nazivPoslodavca,string opis,Lokacija lokacija,List<Konkurs> konkursi,  bool aktiviran)
            :base(userName,email,pwd,aktiviran)
        {
            this.nazivPoslodavca = nazivPoslodavca;
            this.opis = opis;
            this.lokacija = lokacija;
            this.konkursi = new List<Konkurs>(konkursi);
        }

        public void dodajKonkurs(Konkurs konkurs) { }
    }
}
