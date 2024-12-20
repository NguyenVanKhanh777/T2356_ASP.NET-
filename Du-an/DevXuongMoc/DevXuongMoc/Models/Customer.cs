using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class Customer
    {
        [Display(Name = "ID")]
        public long Id { get; set; }

        [Display(Name = "Họ Tên")]
        public string? Name { get; set; }

        [Display(Name = "Tên Đăng Nhập")]
        public string? Username { get; set; }

        [Display(Name = "Mật Khẩu")]
        public string? Password { get; set; }

        [Display(Name = "Địa Chỉ")]
        public string? Address { get; set; }

        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Display(Name = "Số Điện Thoại")]
        public string? Phone { get; set; }

        [Display(Name = "Ảnh Đại Diện")]
        public string? Avatar { get; set; }

        [Display(Name = "Ngày Tạo")]
        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Ngày Cập Nhật")]
        public DateTime? UpdatedDate { get; set; }

        [Display(Name = "Người Tạo")]
        public long? CreatedBy { get; set; }

        [Display(Name = "Người Cập Nhật")]
        public long? UpdatedBy { get; set; }

        [Display(Name = "Đã Xóa")]
        public byte? Isdelete { get; set; }

        [Display(Name = "Kích Hoạt")]
        public byte? Isactive { get; set; }
    }
}
