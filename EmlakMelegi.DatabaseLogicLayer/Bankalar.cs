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
    
    public partial class Bankalar
    {
        public int BankalarID { get; set; }
        public string BankaAdi { get; set; }
        public string SubeKodu { get; set; }
        public Nullable<int> ilceKoduID { get; set; }
        public string KartTanimi { get; set; }
        public string KartSeriNo { get; set; }
        public string Iban { get; set; }
        public string HesapNo { get; set; }
    }
}
