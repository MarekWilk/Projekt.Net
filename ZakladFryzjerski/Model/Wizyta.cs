//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZakladFryzjerski.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Wizyta
    {
        public int WizytaID { get; set; }
        public Nullable<int> KlientID { get; set; }
        public Nullable<int> FryzjerID { get; set; }
        public System.DateTime DataCzas { get; set; }
        public string Uwagi { get; set; }
        public Nullable<int> UsługaID { get; set; }
    
        public virtual Fryzjer Fryzjer { get; set; }
        public virtual Klient Klient { get; set; }
        public virtual Usługa Usługa { get; set; }
    }
}
