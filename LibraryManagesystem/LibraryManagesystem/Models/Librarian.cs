using System;
using System.Collections.Generic;

namespace LibraryManagesystem.Models;

public partial class Librarian
{
    public int LibrarianId { get; set; }

    public string? FullName { get; set; }

    public string? Phone { get; set; }

    public int? AccountId { get; set; }

    public virtual Account? Account { get; set; }
}
