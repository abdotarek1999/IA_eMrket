//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace phase1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public Nullable<int> category_id { get; set; }
    
        public virtual category category { get; set; }
    }
}