//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookShop.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feedback
    {
        public long ID { get; set; }
        public Nullable<long> User_ID { get; set; }
        public string Content { get; set; }
        public Nullable<int> Rating { get; set; }
        public string Rating_Description { get; set; }
        public Nullable<long> Book_ID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual User User { get; set; }
    }
}
