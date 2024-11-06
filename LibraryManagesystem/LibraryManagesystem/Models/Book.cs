using System;
using System.Collections.Generic;

namespace LibraryManagesystem.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public int? AuthorId { get; set; }

    public int? CategoryId { get; set; }

    public int? PublishedYear { get; set; }

    public int? Quantity { get; set; }

    public virtual Author? Author { get; set; }

    public virtual ICollection<BorrowBook> BorrowBooks { get; set; } = new List<BorrowBook>();

    public virtual Category? Category { get; set; }
}
