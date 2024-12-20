using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class AdminLog
    {
        [Display(Name = "Mã Nhật Ký")]
        public int LogId { get; set; }

        [Display(Name = "Trạng Thái")]
        public int? Status { get; set; }

        [Display(Name = "ID")]
        public string? SessionId { get; set; }

        [Display(Name = "Mã Ứng Dụng")]
        public string? AppCode { get; set; }

        [Display(Name = "ID Luồng")]
        public string? ThreadId { get; set; }

        [Display(Name = "Thời Gian Bắt Đầu")]
        public DateTime? StartTime { get; set; }

        [Display(Name = "Thời Gian Kết Thúc")]
        public DateTime? EndTime { get; set; }

        [Display(Name = "ID Quản Trị Viên")]
        public int? AdminUserId { get; set; }

        [Display(Name = "Tài Khoản Đăng Nhập")]
        public string? UserLogin { get; set; }

        [Display(Name = "Tên Người Dùng")]
        public string? UserName { get; set; }

        [Display(Name = "Địa Chỉ IP")]
        public string? IpAddress { get; set; }

        [Display(Name = "Mã Hành Động")]
        public string? ActionCode { get; set; }

        [Display(Name = "Tên Hành Động")]
        public string? ActionName { get; set; }

        [Display(Name = "Mã Menu")]
        public string? MenuCode { get; set; }

        [Display(Name = "Tên Menu")]
        public string? MenuName { get; set; }

        [Display(Name = "ID Hành Động Trang Web")]
        public int? WebpagesActionId { get; set; }

        [Display(Name = "Loại Hành Động")]
        public int? ActionType { get; set; }

        [Display(Name = "ID Đối Tượng")]
        public int? ObjectId { get; set; }

        [Display(Name = "Nội Dung")]
        public string? Content { get; set; }

        [Display(Name = "Mô Tả")]
        public string? Description { get; set; }

        [Display(Name = "Cấp Độ Nhật Ký")]
        public int? LogLevel { get; set; }

        [Display(Name = "Mã Lỗi")]
        public string? ErrorCode { get; set; }
    }
}
