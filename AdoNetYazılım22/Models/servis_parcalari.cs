//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdoNetYazılım22.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class servis_parcalari
    {
        public int id { get; set; }
        public int servis_id { get; set; }
        public int parca_id { get; set; }
        public int miktar { get; set; }
        public decimal toplam_fiyat { get; set; }
    }
}
