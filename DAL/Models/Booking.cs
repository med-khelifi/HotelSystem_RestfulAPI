using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Booking
{
    public int BookingId { get; set; }

    public int ReservationId { get; set; }

    public int GuestId { get; set; }

    public DateTime CheckInDate { get; set; }

    public DateTime? CheckOutDate { get; set; }

    public byte Status { get; set; }

    public int CreatedByUserId { get; set; }

    public virtual User CreatedByUser { get; set; } = null!;

    public virtual Guest Guest { get; set; } = null!;

    public virtual ICollection<GuestCompanion> GuestCompanions { get; set; } = new List<GuestCompanion>();

    public virtual ICollection<GuestOrder> GuestOrders { get; set; } = new List<GuestOrder>();

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual Reservation Reservation { get; set; } = null!;
}
