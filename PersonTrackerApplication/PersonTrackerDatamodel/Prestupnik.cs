//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PersonTrackerDatamodel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prestupnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prestupnik()
        {
            this.Komentar = new HashSet<Komentar>();
        }
    
        public int idPrestupnik { get; set; }
        public Nullable<int> idSkica { get; set; }
        public Nullable<int> idKorisnik { get; set; }
        public string opis { get; set; }
        public byte[] fotografija { get; set; }
        public string mjestoPrijestupa { get; set; }
        public Nullable<System.DateTime> datumPrijestupa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Komentar> Komentar { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public virtual Skica Skica { get; set; }
    }
}
