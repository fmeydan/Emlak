//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmlakMelegi.DatabaseLogicLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Musteriler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musteriler()
        {
            this.MusteriDaireleri = new HashSet<MusteriDaireleri>();
            this.Taksitler = new HashSet<Taksitler>();
        }
    
        public int MusterilerID { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public string Cinsiyeti { get; set; }
        public string Numarasi { get; set; }
        public string Epostasi { get; set; }
        public string Adresi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MusteriDaireleri> MusteriDaireleri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Taksitler> Taksitler { get; set; }
    }
}
