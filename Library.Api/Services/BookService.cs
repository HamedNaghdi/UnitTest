using Library.Api.Context;
using Library.Api.Models;

namespace Library.Api.Services;

public class BookService : IBookService
{
    private readonly AppDbContext _context;

    public BookService(AppDbContext context)
    {
        _context = context;
    }

    public Book Add(Book book)
    {
        book.Id = Guid.NewGuid();
        _context.Books.Add(book);
        _context.SaveChanges();
        return book;
    }

    public void Delete(Guid id)
    {
        var existing = _context.Books.First(a => a.Id == id);
        _context.Books.Remove(existing);
        _context.SaveChanges();
    }

    public IEnumerable<Book> GetAll() => _context.Books.ToList();

    public Book? GetById(Guid id) => _context.Books.FirstOrDefault(a => a.Id == id);
}
