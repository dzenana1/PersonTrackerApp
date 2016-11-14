using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PersonTracker.Services.Models
{
    [DataContract]
    public class NestaliDO
    {
        [DataMember]
        public int idNestali { get; set; }
        [DataMember]
        public string ime { get; set; }
        [DataMember]
        public string prezime { get; set; }
        [DataMember]
        public Nullable<int> godinaRodenja { get; set; }
        [DataMember]
        public byte[] fotografija { get; set; }
        [DataMember]
        public Nullable<System.DateTime> datumNestanka { get; set; }
        [DataMember]
        public string mjestoNestanka { get; set; }
        [DataMember]
        public Nullable<int> idKorisnik { get; set; }
        [DataMember]
        public byte[] spol { get; set; }
        [DataMember]
        public string komentar { get; set; }
        [DataMember]
        public string visina { get; set; }
        [DataMember]
        public string tezina { get; set; }
        [DataMember]
        public virtual KorisnikDO Korisnik { get; set; }
    }
}