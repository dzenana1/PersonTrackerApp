using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PersonTracker.Services.Models
{
    [DataContract]
    public class SkicaDO
    {
        [DataMember]
        public int idSkica { get; set; }
        [DataMember]
        public virtual BradaDO Brada { get; set; }
        [DataMember]
        public virtual CeljustDO Celjust { get; set; }
        [DataMember]
        public virtual GlavaDO Glava { get; set; }
        [DataMember]
        public virtual KosaDO Kosa { get; set; }
        [DataMember]
        public virtual NosDO Nos { get; set; }
        [DataMember]
        public virtual ObrveDO Obrve { get; set; }
        [DataMember]
        public virtual OciDO Oci { get; set; }
        [DataMember]
        public virtual PrestupnikDO Prestupnik { get; set; }
        [DataMember]
        public virtual UsneDO usne { get; set; }
    }
}