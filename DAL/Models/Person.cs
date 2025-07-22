using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DAL.Models;

public partial class Person
{
    public int PersonId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string NationalNo { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public string Address { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int NationalityCountryId { get; set; }

    public string? PersonalImagePath { get; set; }
    [JsonIgnore]
    public virtual ICollection<GuestCompanion> GuestCompanions { get; set; } = new List<GuestCompanion>();
    [JsonIgnore]
    public virtual ICollection<Guest> Guests { get; set; } = new List<Guest>();
    [JsonIgnore]
    public virtual Country NationalityCountry { get; set; } = null!;
    [JsonIgnore]
    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
    [JsonIgnore]
    public virtual User? User { get; set; }
}
