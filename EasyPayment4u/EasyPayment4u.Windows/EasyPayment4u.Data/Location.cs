//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyPayment4u.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Location
    {
        public int LocationID { get; set; }
        public string City { get; set; }
        public int StateID { get; set; }
        public int CountryID { get; set; }
    
        public virtual Operator Operator { get; set; }
    }
}
