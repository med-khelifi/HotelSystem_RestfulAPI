using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Guest
{
    public int GuestId { get; set; }

    public int PersonId { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual User CreatedByUser { get; set; } = null!;

    public virtual ICollection<GuestCompanion> GuestCompanions { get; set; } = new List<GuestCompanion>();

    public virtual ICollection<GuestOrder> GuestOrders { get; set; } = new List<GuestOrder>();

    public virtual Person Person { get; set; } = null!;
}
