﻿//------------------------------------------------------------------------------
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
    
    public partial class CreditPayment : Payment
    {
        public CreditPayment()
        {
            this.CreditPaymentsDetails = new HashSet<CreditPaymentsDetail>();
            this.PaymentTypeName = "אשראי";
        }
    
        public string CardEndWith { get; set; }
        public int NumberOfPayments { get; set; }
    
        public virtual ICollection<CreditPaymentsDetail> CreditPaymentsDetails { get; set; }
    }
}
