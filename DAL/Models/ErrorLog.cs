using System;
using System.Collections.Generic;

namespace DAL.Models;

public partial class ErrorLog
{
    public int ErrorId { get; set; }

    public DateTime OccurredDate { get; set; }

    public string ErrorMessage { get; set; } = null!;

    public string ExceptionType { get; set; } = null!;
}
