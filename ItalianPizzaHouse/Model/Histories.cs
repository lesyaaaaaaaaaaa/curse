//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ItalianPizzaHouse.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Histories
    {
        public int IdHistory { get; set; }
        public Nullable<int> UserId { get; set; }
        public System.DateTime DateHistory { get; set; }
        public string HistoryText { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
