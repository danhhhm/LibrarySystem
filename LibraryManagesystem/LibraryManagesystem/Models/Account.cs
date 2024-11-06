using System;
using System.Collections.Generic;

namespace LibraryManagesystem.Models;

public partial class Account
{
    public int AccountId { get; set; }

    public string Username { get; set; } 

    public string Role { get; set; }

    public string? Password { get; set; }

    public virtual Librarian? Librarian { get; set; }

    public virtual User? User { get; set; }
}
