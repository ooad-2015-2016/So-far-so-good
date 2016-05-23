using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobRadarWeb.Models
{
    public class OsobaKojaTraziPosao
    {
        public int ID { get; set; }
        public string userName { get; set; }
        public string email { get; set; }
        public DateTime datumRegistracije { get; set; }
        public DateTime posljednjaAktivnost { get; set; }
        public string passwordHash { get; set; }
        public bool aktiviran { get; set; }
        public bool zabranjenPristup { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public DateTime datumRodjenja { get; set; }
        public DateTime godinaZavrsetkaObrazovanja { get; set; }
        //file CV dodati
        public bool zaposlen { get; set; }
        public List<Konkurs> prijavljenNaKonkurse { get; set; }

        public OsobaKojaTraziPosao() : base() { }
        public OsobaKojaTraziPosao(string username, string email, string passwd, string ime, string prezime, DateTime datumRodjenja, DateTime godinaZavrsetkaObrazovanja, bool zaposlen
           , List<Konkurs> prijavljenNaKonkurs, bool aktiviran)
        {
            this.userName = userName;
            this.email = email;
            this.passwordHash = getPwdHash(passwd);
            this.aktiviran = aktiviran;
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
            this.godinaZavrsetkaObrazovanja = godinaZavrsetkaObrazovanja;
            this.zaposlen = zaposlen;
            this.prijavljenNaKonkurse = prijavljenNaKonkurs;
        }
        private string getPwdHash(string pwd)
        {
            return "abcde123456";       //dodati
        }
    }
}