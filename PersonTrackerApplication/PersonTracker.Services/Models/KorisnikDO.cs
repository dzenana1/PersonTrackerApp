using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PersonTracker.Services.Models
{
    [DataContract]
    public class KorisnikDO
    {
        [DataMember]
        public int idKorisnik { get; set; }
        [DataMember]
        public string ime { get; set; }
        [DataMember]
        public string prezime { get; set; }
        [DataMember]
        public string email { get; set; }
        [DataMember]
        public string brojTelefona { get; set; }
    }
}