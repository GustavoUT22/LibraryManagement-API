using System.ComponentModel.DataAnnotations;

namespace LibraryManagement_API.Entities
{
  public class Author
  {
    public int Id { get; set; }

    [Required]
    [StringLength(maximumLength: 100)]
    public string? Name { get; set; }

    [StringLength(maximumLength: 50)]
    public string? Nationality { get; set; }
    public DateTime BornDate { get; set; }
    public HashSet<Book> Books = [];
  }
}