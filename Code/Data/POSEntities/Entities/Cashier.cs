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
    
    public partial class Cashier
    {
        public Cashier()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int ID { get; set; }
        public string PCName { get; set; }
        public string description { get; set; }
        public string Name { get; set; }
        public int StoreID { get; set; }
    
        public virtual StoreInfo StoreInfo { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
