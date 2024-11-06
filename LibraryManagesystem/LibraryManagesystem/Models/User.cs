using System;
using System.Collections.Generic;

namespace LibraryManagesystem.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? FullName { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public int? AccountId { get; set; }

    public virtual Account? Account { get; set; }

    public virtual ICollection<BorrowBook> BorrowBooks { get; set; } = new List<BorrowBook>();
}
