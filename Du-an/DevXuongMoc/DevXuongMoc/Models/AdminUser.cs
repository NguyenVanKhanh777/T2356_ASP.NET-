using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class AdminUser
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Tài Khoản")]
        public string? Account { get; set; }

        [Display(Name = "Mật Khẩu")]
        public string? Password { get; set; }

        [Display(Name = "Mã Nhân Sự")]
        public int? MaNhanSu { get; set; }

        [Display(Name = "Họ Và Tên")]
        public string? Name { get; set; }

        [Display(Name = "Số Điện Thoại")]
        public string? Phone { get; set; }

        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Display(Name = "Ảnh Đại Diện")]
        public string? Avatar { get; set; }

        [Display(Name = "ID Phòng Ban")]
        public int? IdPhongBan { get; set; }

        [Display(Name = "Ngày Tạo")]
        public DateTime? NgayTao { get; set; }

        [Display(Name = "Người Tạo")]
        public string? NguoiTao { get; set; }

        [Display(Name = "Ngày Cập Nhật")]
        public DateTime? NgayCapNhat { get; set; }

        [Display(Name = "Người Cập Nhật")]
        public string? NguoiCapNhat { get; set; }

        [Display(Name = "Mã Phiên Token")]
        public string? SessionToken { get; set; }

        [Display(Name = "Mã Băm Salt")]
        public string? Salt { get; set; }

        [Display(Name = "Quản Trị Viên")]
        public bool? IsAdmin { get; set; }

        [Display(Name = "Trạng Thái")]
        public int? TrangThai { get; set; }

        [Display(Name = "Đã Xóa")]
        public bool? IsDelete { get; set; }
    }
}
