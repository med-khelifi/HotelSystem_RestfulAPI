using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class RoomService
{
    public int RoomServiceId { get; set; }

    public string RoomServiceTitle { get; set; } = null!;

    public string RoomServiceDescription { get; set; } = null!;

    public decimal RoomServiceFees { get; set; }

    public virtual ICollection<GuestOrder> GuestOrders { get; set; } = new List<GuestOrder>();
}
