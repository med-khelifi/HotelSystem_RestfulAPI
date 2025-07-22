using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class OrderItem
{
    public int OrderItemId { get; set; }

    public int ItemId { get; set; }

    public int OrderId { get; set; }

    public int BookingId { get; set; }

    public byte Quantity { get; set; }

    public decimal Price { get; set; }

    public virtual Booking Booking { get; set; } = null!;

    public virtual MenuItem Item { get; set; } = null!;

    public virtual GuestOrder Order { get; set; } = null!;
}
