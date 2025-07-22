using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class GuestOrder
{
    public int GuestOrderId { get; set; }

    public int GuestId { get; set; }

    public int RoomId { get; set; }

    public DateTime OrderDate { get; set; }

    public int CreatedByUserId { get; set; }

    public int BookingId { get; set; }

    public byte OrderType { get; set; }

    public int? RoomServiceId { get; set; }

    public virtual Booking Booking { get; set; } = null!;

    public virtual User CreatedByUser { get; set; } = null!;

    public virtual Guest Guest { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual Room Room { get; set; } = null!;

    public virtual RoomService? RoomService { get; set; }
}
