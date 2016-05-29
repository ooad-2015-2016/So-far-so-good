using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace JobRadar.JobRadarBaza.Models
{
    [DataContract]
    public class OsobaKojaTraziPosao:Korisnik
    {
        [Key]
        private int id { get; set; }
        [DataMember]
        private string ime { get; set; }
        [DataMember]
        private string prezime { get; set; }
        [DataMember]
        private DateTime datumRodjenja { get; set; }
        [DataMember]
        private DateTime godinaZavrsetkaObrazovanja { get; set; }
        //file CV dodati
        [DataMember]
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
