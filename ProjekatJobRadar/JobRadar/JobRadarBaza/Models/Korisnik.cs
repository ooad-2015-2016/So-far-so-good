using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobRadar.JobRadarBaza.Models
{
    public abstract class Korisnik
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        private int userID { get; set; }
        protected string userName { get; set; }
        protected string email { get; set; }
        protected DateTime datumRegistracije { get; set; }
        protected DateTime posljednjaAktivnost { get; set; }
        private string passwordHash { get; set; }
        protected bool aktiviran { get; set; }
        protected bool zabranjenPristup { get; set; }

        public Korisnik() { aktiviran = false; }
        public Korisnik(string userName, string email, string pwd, bool aktiviran = false)
        {
            userID = getUID();
            this.userName = userName;
            this.email = email;
            this.datumRegistracije = DateTime.Now;
            this.posljednjaAktivnost = DateTime.Now;
            this.passwordHash = getPwdHash(pwd);
            this.aktiviran = false;
            this.zabranjenPristup = false;

        }

        private int getUID()
        {
            return 1;       //dodati
        }

        private string getPwdHash(string pwd)
        {
            return "abcde123456";       //dodati
        } 
    }
}
