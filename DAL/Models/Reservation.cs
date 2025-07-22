using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class Reservation
{
    public int ReservationId { get; set; }

    public int ReservationPersonId { get; set; }

    public int RoomId { get; set; }

    public DateTime ReservationDate { get; set; }

    public byte NumberOfPeople { get; set; }

    public byte Status { get; set; }

    public DateTime LastStatusDate { get; set; }

    public int CreatedByUserId { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

    public virtual User CreatedByUser { get; set; } = null!;

    public virtual Person ReservationPerson { get; set; } = null!;

    public virtual Room Room { get; set; } = null!;
}
