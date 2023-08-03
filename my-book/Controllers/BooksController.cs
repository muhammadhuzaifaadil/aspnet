using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_book.Data.Services;
using my_book.Data.VModels;

namespace my_book.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BookService _bookService;//bookservice method
        public BooksController(BookService bookService)
        {
            _bookService = bookService;
        }
        [HttpGet("get-all-books")]
        public IActionResult GetAllBooks()
        {
            var allBooks = _bookService.GetAllBooks();
            return Ok(allBooks);
        }
        [HttpGet("get-book-by-id/{id}")]
        public IActionResult GetBookbyId(int id)
        {
            var getBook = _bookService.GetBookbyId(id);
            return Ok(getBook);
        }
        [HttpPost("add-book")]
        public IActionResult AddBook([FromBody]BookVm book)
        {
            _bookService.AddBook(book);
            return Ok();
        }
    }
}
