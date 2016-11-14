using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PersonTracker.Services.Models
{
    [DataContract]
    public class PrestupnikDO
    {
        [DataMember]
        public int idPrestupnik { get; set; }
        [DataMember]
        public Nullable<int> idSkica { get; set; }
        [DataMember]
        public Nullable<int> idKorisnik { get; set; }
        [DataMember]
        public string opis { get; set; }
        [DataMember]
        public byte[] fotografija { get; set; }
        [DataMember]
        public string mjestoPrijestupa { get; set; }
        [DataMember]
        public Nullable<System.DateTime> datumPrijestupa { get; set; }
        [DataMember]
        public virtual KorisnikDO Korisnik { get; set; }
        [DataMember]
        public virtual SkicaDO Skica { get; set; }
    }
}