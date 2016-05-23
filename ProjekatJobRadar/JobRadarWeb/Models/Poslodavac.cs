using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobRadarWeb.Models
{
    public class Poslodavac
    {
        public int ID { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public DateTime datumRegistracije { get; set; }
        public DateTime posljednjaAktivnost { get; set; }
        public string passwordHash { get; set; }
        public bool aktiviran { get; set; }
        public bool zabranjenPristup { get; set; }
        public string nazivPoslodavca { get; set; }
        public string opis { get; set; }
        public Lokacija lokacija { get; set; }
        public List<Konkurs> konkursi { get; set; }

        public Poslodavac() : base() { konkursi = new List<Konkurs>(); }
        public Poslodavac(string userName, string email, string pwd, string nazivPoslodavca, string opis, Lokacija lokacija, List<Konkurs> konkursi, bool aktiviran)
            
        {
            this.userName = userName;
            this.email = email;
            this.passwordHash = getPwdHash(pwd);
            this.aktiviran = aktiviran;
            this.nazivPoslodavca = nazivPoslodavca;
            this.opis = opis;
            this.lokacija = lokacija;
            this.konkursi = new List<Konkurs>(konkursi);
        }

        public void dodajKonkurs(Konkurs konkurs) { }
        private string getPwdHash(string pwd)
        {
            return "abcde123456";       //dodati
        }
    }
}