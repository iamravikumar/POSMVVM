//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POSEntities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contact : Person
    {
        public Contact()
        {
            this.Vendors = new HashSet<Vendor>();
        }

        public override bool IsContact { get { return true; } }
    
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}