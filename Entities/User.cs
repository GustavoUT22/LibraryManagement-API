using System.ComponentModel.DataAnnotations;

namespace LibraryManagement_API.Entities
{
  public class User
  {
    public int Id { get; set; }

    [Required]
    [StringLength(maximumLength: 100)]
    public string? Name { get; set; }

    [Required]
    [StringLength(maximumLength: 100)]
    public string? Email { get; set; }
    public DateTime RegistrationDate { get; set; }
    public HashSet<Loan> Loans { get; set; } = [];
  }
}