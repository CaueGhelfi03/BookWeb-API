using BookWeb.Domain.DTOs.Book;
using BookWeb.Services.BookService;
using BookWeb.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookWeb.Controllers.Book
{
    [Route("api/books")]
    [ApiController]
    public class BookController(BookService bookService) : Controller
    {

        private readonly IBookService _bookService;


        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookResponseDTO>>> GetAllBooks() {
            try
            {

                IEnumerable<BookResponseDTO> books = await _bookService.GetAllBooksAsync();  
                if(books == null || !books.Any()) return NoContent();

                return Ok(books);

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
