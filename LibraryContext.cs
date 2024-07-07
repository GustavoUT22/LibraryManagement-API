using Microsoft.EntityFrameworkCore;

namespace LibraryManagement_API
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    { }
  }
}