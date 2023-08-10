using Library.Api.Models;
using Library.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            var items = _bookService.GetAll();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public ActionResult<Book> Get(Guid id)
        {
            var item = _bookService.GetById(id);
            if (item is null)
                return NotFound();
            return Ok(item);
        }

        [HttpPost]
        public ActionResult Post(Book book)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var item = _bookService.Add(book);
            return CreatedAtAction("Get", new {id =  item.Id}, item);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            var existingItem = _bookService.GetById(id);
            if (existingItem is null)
                return NotFound();

            _bookService.Delete(id);
            return Ok();
        }
    }
}