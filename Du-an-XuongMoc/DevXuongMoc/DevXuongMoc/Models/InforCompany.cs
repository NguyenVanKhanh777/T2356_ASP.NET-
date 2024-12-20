using System;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class InforCompany
    {
        [Display(Name = "Mã công ty")]
        public int Id { get; set; }

        [Display(Name = "Tên công ty")]
        public string? Name { get; set; }

        [Display(Name = "Logo")]
        public string? Logo { get; set; }

        [Display(Name = "Số điện thoại")]
        public string? Phone { get; set; }

        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Display(Name = "Địa chỉ")]
        public string? Address { get; set; }

        [Display(Name = "Youtube")]
        public string? Youtube { get; set; }

        [Display(Name = "Instagram")]
        public string? Instagram { get; set; }

        [Display(Name = "Facebook")]
        public string? Facebook { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateOnly? CreatedDate { get; set; }

        [Display(Name = "Ngày cập nhật")]
        public DateOnly? UpdateDate { get; set; }

        [Display(Name = "Người tạo")]
        public string? AdminCreated { get; set; }

        [Display(Name = "Người cập nhật")]
        public string? AdminUpdated { get; set; }

        [Display(Name = "Meta Title")]
        public string? MetaTitle { get; set; }

        [Display(Name = "Meta Keyword")]
        public string? MetaKeyword { get; set; }

        [Display(Name = "Meta Description")]
        public string? MetaDescription { get; set; }
    }
}
