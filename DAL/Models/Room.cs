using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Room
{
    public int RoomId { get; set; }

    public int RoomTypeId { get; set; }

    public string RoomNumber { get; set; } = null!;

    public byte RoomFloor { get; set; }

    public decimal RoomSize { get; set; }

    public byte AvailabilityStatus { get; set; }

    public bool IsSmokingAllowed { get; set; }

    public bool IsPetFriendly { get; set; }

    public string? AdditionalNotes { get; set; }

    public virtual ICollection<GuestOrder> GuestOrders { get; set; } = new List<GuestOrder>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual RoomType RoomType { get; set; } = null!;
}
