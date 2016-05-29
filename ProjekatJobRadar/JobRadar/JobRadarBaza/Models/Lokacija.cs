using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace JobRadar.JobRadarBaza.Models
{
    [DataContract]
    public class Lokacija
    {
        [DataMember]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        private int LokacijaId { get; set; }
        public string fourSqaureId { get; set; }
        [DataMember]
        private string Kontinent { get; set; }
        [DataMember]
        private string Drzava { get; set; }
        [DataMember]
        public string Grad { get; set; }
        [DataMember]
        private string Adresa { get; set; }
        [DataMember]
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
