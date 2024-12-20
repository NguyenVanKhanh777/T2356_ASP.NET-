using System;
using System.Collections.Generic;

namespace DevXuongMoc.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int CustomerId { get; set; }

    public decimal TotalAmount { get; set; }
}
