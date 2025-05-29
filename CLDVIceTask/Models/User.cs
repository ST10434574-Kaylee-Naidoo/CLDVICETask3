using System;
using System.Collections.Generic;

namespace CLDVIceTask.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string? ProfilePicture { get; set; }

    public string Email { get; set; } = null!;
}
