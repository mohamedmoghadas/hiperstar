//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HiperStar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class paymentfactor
    {
        public long Id { get; set; }
        public string PaymentFactorCode { get; set; }
        public Nullable<System.DateTime> dateinsert { get; set; }
        public Nullable<System.DateTime> dateupdate { get; set; }
        public Nullable<System.DateTime> datedelete { get; set; }
        public string prcount { get; set; }
        public Nullable<long> customerId { get; set; }
        public Nullable<long> totalprice { get; set; }
        public Nullable<bool> statedelete { get; set; }
        public string RefNum { get; set; }
        public string RefId { get; set; }
        public string SaleRefrence { get; set; }
        public string State { get; set; }
        public string StateCode { get; set; }
        public string ResNum { get; set; }
        public string MID { get; set; }
        public string CID { get; set; }
        public string TRACENO { get; set; }
        public string PRN { get; set; }
        public string Amount { get; set; }
        public string SecurePan { get; set; }
    }
}
