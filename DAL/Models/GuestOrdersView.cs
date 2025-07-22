using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class GuestOrdersView
{
    public int OrderId { get; set; }

    public string GuestName { get; set; } = null!;

    public int BookingId { get; set; }

    public string RoomNumber { get; set; } = null!;

    public string? OrderType { get; set; }

    public DateTime OrderDate { get; set; }

    public decimal? Fees { get; set; }
}
