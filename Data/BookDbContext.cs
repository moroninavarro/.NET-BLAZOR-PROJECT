using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BookTracker.Models;


namespace BookTracker.Data;

public class BookDbContext : IdentityDbContext<ApplicationUser>
{
    public BookDbContext(DbContextOptions<BookDbContext> options)
        : base(options)
    {
        
    }
    public DbSet<Book> Books {get; set; } = default!;
}