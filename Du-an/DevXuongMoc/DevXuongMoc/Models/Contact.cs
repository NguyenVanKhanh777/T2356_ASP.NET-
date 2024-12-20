using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class Contact
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Tiêu Đề")]
        public string? Title { get; set; }

        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Display(Name = "Số Điện Thoại")]
        public string? Phone { get; set; }

        [Display(Name = "Địa Chỉ")]
        public string? Address { get; set; }

        [Display(Name = "Nội Dung")]
        public string? Content { get; set; }

        [Display(Name = "Ngày Tạo")]
        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Ngày Cập Nhật")]
        public DateTime? UpdatedDate { get; set; }

        [Display(Name = "Quản Trị Tạo")]
        public string? AdminCreated { get; set; }

        [Display(Name = "Quản Trị Cập Nhật")]
        public string? AdminUpdated { get; set; }

        [Display(Name = "Trạng Thái")]
        public byte? Status { get; set; }

        [Display(Name = "Đã Xóa")]
        public bool? Isdelete { get; set; }
    }
}
