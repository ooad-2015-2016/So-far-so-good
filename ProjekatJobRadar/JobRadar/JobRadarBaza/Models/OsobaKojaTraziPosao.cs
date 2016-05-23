using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JobRadar.JobRadarBaza.Models
{
    public class OsobaKojaTraziPosao:Korisnik
    {
        
        private string ime { get; set; }
        private string prezime { get; set; }
        private DateTime datumRodjenja { get; set; }
        private DateTime godinaZavrsetkaObrazovanja { get; set; }
        //file CV dodati
        private bool zaposlen {get; set; }
        private List<Konkurs> prijavljenNaKonkurse { get; set; }

        public OsobaKojaTraziPosao():base() { }
        public OsobaKojaTraziPosao( string username, string email, string passwd, string ime, string prezime, DateTime datumRodjenja, DateTime godinaZavrsetkaObrazovanja, bool zaposlen
           ,List<Konkurs> prijavljenNaKonkurs, bool aktiviran) :base(username,email,passwd,aktiviran)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
            this.godinaZavrsetkaObrazovanja = godinaZavrsetkaObrazovanja;
            this.zaposlen = zaposlen;
            this.prijavljenNaKonkurse = prijavljenNaKonkurs;
        }
    }
}
