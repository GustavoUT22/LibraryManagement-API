using System.ComponentModel.DataAnnotations;

namespace LibraryManagement_API.Entities
{
  public class Publisher
  {
    public int Id { get; set; }

    [Required]
    [StringLength(maximumLength: 100)]
    public string? Name { get; set; }

    [StringLength(maximumLength: 200)]
    public string? Email { get; set; }

    [StringLength(maximumLength: 15)]
    public string? Phone { get; set; }

    public HashSet<Book> Books { get; set; } = [];
  }
}