using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JobRadar.JobRadarBaza.Models
{   [DataContract]
    public abstract class Korisnik
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [DataMember]
        private int userID { get; set; }
        [DataMember]
        protected string userName { get; set; }
        [DataMember]
        protected string email { get; set; }
        [DataMember]
        protected DateTime datumRegistracije { get; set; }
        [DataMember]
        protected DateTime posljednjaAktivnost { get; set; }
        [DataMember]
        private string passwordHash { get; set; }
        [DataMember]
        protected bool aktiviran { get; set; }
        [DataMember]
        protected bool zabranjenPristup { get; set; }

        public Korisnik() { aktiviran = false; }
        public Korisnik(string userName, string email, string pwd, bool aktiviran = false)
        {
            this.userName = userName;
            this.email = email;
            this.datumRegistracije = DateTime.Now;
            this.posljednjaAktivnost = DateTime.Now;
            this.passwordHash = getPwdHash(pwd);
            this.aktiviran = false;
            this.zabranjenPristup = false;
            

        }

       
        private string getPwdHash(string pwd)
        {
            return "abcde123456";       //dodati
        } 
    }
}
