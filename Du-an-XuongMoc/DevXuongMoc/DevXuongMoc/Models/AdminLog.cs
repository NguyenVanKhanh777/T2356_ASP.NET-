using System;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class AdminLog
    {
        [Display(Name = "Mã Log")]
        public int LogId { get; set; }

        [Display(Name = "Trạng thái")]
        public int? Status { get; set; }

        [Display(Name = "Mã phiên làm việc")]
        public string? SessionId { get; set; }

        [Display(Name = "Mã ứng dụng")]
        public string? AppCode { get; set; }

        [Display(Name = "Mã luồng")]
        public string? ThreadId { get; set; }

        [Display(Name = "Thời gian bắt đầu")]
        public DateTime? StartTime { get; set; }

        [Display(Name = "Thời gian kết thúc")]
        public DateTime? EndTime { get; set; }

        [Display(Name = "Mã người quản trị")]
        public int? AdminUserId { get; set; }

        [Display(Name = "Tên đăng nhập")]
        public string? UserLogin { get; set; }

        [Display(Name = "Tên người dùng")]
        public string? UserName { get; set; }

        [Display(Name = "Địa chỉ IP")]
        public string? IpAddress { get; set; }

        [Display(Name = "Mã hành động")]
        public string? ActionCode { get; set; }

        [Display(Name = "Tên hành động")]
        public string? ActionName { get; set; }

        [Display(Name = "Mã menu")]
        public string? MenuCode { get; set; }

        [Display(Name = "Tên menu")]
        public string? MenuName { get; set; }

        [Display(Name = "Mã hành động trên trang")]
        public int? WebpagesActionId { get; set; }

        [Display(Name = "Loại hành động")]
        public int? ActionType { get; set; }

        [Display(Name = "Mã đối tượng")]
        public int? ObjectId { get; set; }

        [Display(Name = "Nội dung")]
        public string? Content { get; set; }

        [Display(Name = "Mô tả")]
        public string? Description { get; set; }

        [Display(Name = "Cấp độ log")]
        public int? LogLevel { get; set; }

        [Display(Name = "Mã lỗi")]
        public string? ErrorCode { get; set; }
    }
}
