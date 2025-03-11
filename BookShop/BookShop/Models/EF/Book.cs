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
    
    public partial class Book
    {
        public Book()
        {
            this.Feedbacks = new HashSet<Feedback>();
            this.Inward_Detail = new HashSet<Inward_Detail>();
            this.Order_Detail = new HashSet<Order_Detail>();
            this.Slides = new HashSet<Slide>();
        }
    
        public long ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Released { get; set; }
        public string NXB { get; set; }
        public Nullable<int> Buys { get; set; }
        public Nullable<int> Weight { get; set; }
        public string Form { get; set; }
        public Nullable<int> NumberPage { get; set; }
        public Nullable<System.DateTime> PublishDate { get; set; }
        public string code { get; set; }
        public string MetaTitle { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Modelmage { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> PromotionPrice { get; set; }
        public Nullable<long> CategoryID { get; set; }
        public string Detail { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string MetaKeyword { get; set; }
        public string MetaDescription { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> TopHot { get; set; }
        public Nullable<int> ViewCount { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual Book Book1 { get; set; }
        public virtual Book Book2 { get; set; }
        public virtual BookCategory BookCategory { get; set; }
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<Inward_Detail> Inward_Detail { get; set; }
        public virtual ICollection<Order_Detail> Order_Detail { get; set; }
        public virtual ICollection<Slide> Slides { get; set; }
    }
}
