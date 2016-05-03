using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobRadar.JobRadarBaza.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JobRadar.JobRadarBaza.Models
{
    public class OsobaKojaTraziPosao:Korisnik
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        private string ime { get; set; }
        private string prezime { get; set; }
        private DateTime datumRodjenja { get; set; }
        private DateTime godinaZavrsetkaObrazovanja { get; set; }
        //file CV dodati
        private bool zaposlen {
            get; set;
        }
   //     public List<Konkurs> prijavljenNaKonkurse { get; set; }

        public OsobaKojaTraziPosao(int id,string ime, string prezime, DateTime datumRodjenja, DateTime godinaZavrsetkaObrazovanja, bool zaposlen, 
            string username, string email, string passwd):base(username,email,passwd)
        {
            this.ID = id;
            this.ime = ime;
            this.prezime = prezime;
            this.datumRodjenja = datumRodjenja;
            this.godinaZavrsetkaObrazovanja = godinaZavrsetkaObrazovanja;
            this.zaposlen = zaposlen;
           // this.prijavljenNaKonkurse = prijavljenNaKonkurs;
        }
    }
}
