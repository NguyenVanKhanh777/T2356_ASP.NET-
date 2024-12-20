using Microsoft.Extensions.Primitives;
using System;
using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models
{
    public partial class Order
    {
        [Display(Name = "Mã đơn hàng")]
        public int OrderId { get; set; }

        [Display(Name = "Mã khách hàng")]
        public int CustomerId { get; set; }

        [Display(Name = "Tổng số tiền")]
        public decimal TotalAmount { get; set; }
        public string Idorders { get; internal set; }
        public decimal TotalMoney { get; internal set; }
        public object Idcustomer { get; internal set; }
        public DateTime OrdersDate { get; internal set; }
        public long Idpayment { get; internal set; }
        public StringValues Notes { get; internal set; }
        public StringValues Address { get; internal set; }
        public StringValues Phone { get; internal set; }
        public StringValues Email { get; internal set; }
        public StringValues NameReciver { get; internal set; }
    }
}
