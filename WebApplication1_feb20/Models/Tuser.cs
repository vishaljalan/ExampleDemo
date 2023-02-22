using System;
using System.Collections.Generic;

namespace WebApplication1_feb20.Models;

public partial class Tuser
{
    public int Id { get; set; }

    public string? Userid { get; set; }

    public string? Password { get; set; }

    public string? Designation { get; set; }

    public string? Token { get; set; }

    public string? UserMessage { get; set; }
}
