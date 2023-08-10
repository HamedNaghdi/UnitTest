using Library.Api.Models;

namespace Library.Api.Services;

public interface IBookService
{
    IEnumerable<Book> GetAll();

    Book Add(Book book);

    Book? GetById(Guid id);

    void Delete(Guid id);
}
