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
    
    public partial class Todo
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public System.DateTime DateInsert { get; set; }
        public System.DateTime DateRemind { get; set; }
        public System.DateTime DateEnd { get; set; }
        public Nullable<System.DateTime> DateDelete { get; set; }
        public string TimeInsert { get; set; }
        public string TimeRemind { get; set; }
        public string TimeEnde { get; set; }
        public Nullable<long> UserId { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
