using BookTracker.Data;
using BookTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace BookTracker.Services;
/// <summary>
/// In the BookService file I handled the CRUD operations for the book cards
/// </summary>
public class BookService
{
    private readonly BookDbContext _context;

    public BookService(BookDbContext context)
    {
        _context = context;
    }
/// <summary>
/// This help us to retrieve all books for the specified user
/// </summary>
/// <param name="userId">
/// It is the unique identifier of the user whose books should be retrieved.
/// </param>
/// <returns>
/// returns a list that contain the users books.
/// </returns>
    public async Task<List<Book>> GetBooksAsync(string userId)
    {
        return await _context.Books
            .Where(b => b.UserId == userId)
            .ToListAsync();
    }
/// <summary>
/// This allow us to add new books to the users library.
/// </summary>
/// <param name="book">The book to add</param>
/// <returns> A task async operation</returns>
    public async Task AddBookAsync(Book book)
    {
        _context.Books.Add(book);
        await _context.SaveChangesAsync();
    }
/// <summary>
/// This allow us to update the books of the users library.
/// </summary>
/// <param name="book">The book to update</param>
/// <returns> A task async operation with the update</returns>
    public async Task UpdateBookAsync(Book book)
    {
        _context.Books.Update(book);
        await _context.SaveChangesAsync();
    }
/// <summary>
/// This allow us to Delete books from the users library.
/// </summary>
/// <param name="book">The book to delete</param>
/// returns> A task async operation with the delete operation</returns>

    public async Task DeleteBookAsync(int bookId, string userId)
    {
        var book = await _context.Books.FirstOrDefaultAsync(b => 
        b.BookId == bookId && 
        b.UserId == userId);

        if (book == null)
        {
            return;
        }
        _context.Books.Remove(book);
        await _context.SaveChangesAsync();
    }

    public async Task<Book?> GetBookByIdAsync(int id)
    {
        return await _context.Books.FindAsync(id);
    }
}