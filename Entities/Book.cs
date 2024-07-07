using System.ComponentModel.DataAnnotations;

namespace LibraryManagement_API.Entities
{
  public class Book
  {
    public int Id { get; set; }

    [Required]
    [StringLength(maximumLength: 200)]
    public string? Title { get; set; }
    public int PublicationYear { get; set; }

    [StringLength(maximumLength: 50)]
    public string? Genre { get; set; }
    public bool Available { get; set; }
    public int Quantity { get; set; }

    public HashSet<Loan> Loans { get; set; } = [];
    public int AuthorId { get; set; }
    public Author? Author { get; set; }

    public int PublisherId { get; set; }
    public Publisher? Publisher { get; set; }
  }
}