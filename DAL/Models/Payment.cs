using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int BookingId { get; set; }

    public DateTime PaymentDate { get; set; }

    public decimal PaidAmount { get; set; }

    public int CreatedByUserId { get; set; }

    public virtual Booking Booking { get; set; } = null!;

    public virtual User CreatedByUser { get; set; } = null!;
}
