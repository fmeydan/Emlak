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
    
    public partial class GelirTurleri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GelirTurleri()
        {
            this.Gelirler = new HashSet<Gelirler>();
        }
    
        public int GelirTurlerID { get; set; }
        public string Adi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gelirler> Gelirler { get; set; }
    }
}
