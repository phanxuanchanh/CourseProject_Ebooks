//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SachDienTu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class InvoiceDetail
    {
        public long invoiceId { get; set; }
        public long bookId { get; set; }
        public double unitPrice { get; set; }
        public double intoMoney { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Invoice Invoice { get; set; }
    }
}