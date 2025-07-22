using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class GuestCompanion
{
    public int GuestCompanionId { get; set; }

    public int PersonId { get; set; }

    public int GuestId { get; set; }

    public int BookingId { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual Booking Booking { get; set; } = null!;

    public virtual User CreatedByUser { get; set; } = null!;

    public virtual Guest Guest { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;
}
