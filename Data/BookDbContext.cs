using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BookTracker.Models;


namespace BookTracker.Data;
/// <summary>
/// Represents the Entity Framework Core database context for BookTracker.
/// Extends ASP.NET Core Identity to manage application users and provides
/// the access to book-related data
/// </summary>
public class BookDbContext : IdentityDbContext<ApplicationUser>
{
    public BookDbContext(DbContextOptions<BookDbContext> options)
        : base(options)
    {
        
    }
    public DbSet<Book> Books {get; set; } = default!;
}