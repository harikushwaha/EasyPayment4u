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
    
    public partial class AspNetRole
    {
        public AspNetRole()
        {
            this.AspNetUsers = new HashSet<AspNetUser>();
        }
    
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    
        public virtual AspNetRole AspNetRoles1 { get; set; }
        public virtual AspNetRole AspNetRole1 { get; set; }
        public virtual ICollection<AspNetUser> AspNetUsers { get; set; }
    }
}
