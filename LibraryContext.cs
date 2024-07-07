using LibraryManagement_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement_API
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
    { }

    public DbSet<Book> Books => Set<Book>();
    public DbSet<Author> Authors => Set<Author>();
    public DbSet<Publisher> Publishers => Set<Publisher>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Loan> Loans => Set<Loan>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      // Datos iniciales para Authors
      modelBuilder.Entity<Author>().HasData(
        new Author { Id = 1, Name = "Author 1", Nationality = "Nationality 1", BornDate = new DateTime(1970, 1, 1) },
        new Author { Id = 2, Name = "Author 2", Nationality = "Nationality 2", BornDate = new DateTime(1980, 2, 2) }
      );

      // Datos iniciales para Publishers
      modelBuilder.Entity<Publisher>().HasData(
        new Publisher { Id = 1, Name = "Publisher 1", Email = "publisher1@example.com", Phone = "123-456-7890" },
        new Publisher { Id = 2, Name = "Publisher 2", Email = "publisher2@example.com", Phone = "098-765-4321" }
      );

      // Datos iniciales para Books
      modelBuilder.Entity<Book>().HasData(
        new Book { Id = 1, Title = "Book 1", PublicationYear = 2000, Genre = "Fiction", Available = true, Quantity = 5, AuthorId = 1, PublisherId = 1 },
        new Book { Id = 2, Title = "Book 2", PublicationYear = 2010, Genre = "Non-Fiction", Available = true, Quantity = 3, AuthorId = 2, PublisherId = 2 }
      );

      // Datos iniciales para Users
      modelBuilder.Entity<User>().HasData(
        new User { Id = 1, Name = "User 1", Email = "user1@example.com", RegistrationDate = DateTime.Now },
        new User { Id = 2, Name = "User 2", Email = "user2@example.com", RegistrationDate = DateTime.Now }
      );

      // Datos iniciales para Loans
      modelBuilder.Entity<Loan>().HasData(
        new Loan { Id = 1, UserId = 1, BookId = 1, LoanDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(14) },
        new Loan { Id = 2, UserId = 2, BookId = 2, LoanDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(14) }
      );
    }
  }
}