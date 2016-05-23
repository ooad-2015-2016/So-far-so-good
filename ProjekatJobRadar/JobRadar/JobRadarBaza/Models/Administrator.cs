using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobRadar.JobRadarBaza.Models
{
    public class Administrator:Korisnik
    {
        private string ime { get; set; }
        private string prezime { get; set; }

        public Administrator():base() { }
        public Administrator(string userName, string email, string pwd, string ime, string prezime, bool aktiviran) : base(userName, email, pwd, aktiviran)
        {
            this.ime = ime;
            this.prezime = prezime;
        }
    }
}
