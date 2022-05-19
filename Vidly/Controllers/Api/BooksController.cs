using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Vidly.Dtos;
using Vidly.Interfaces;

namespace Vidly.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooksAsync()
        {
            var books = await _bookService.GetBooksAsync();
            return Ok(books);
        }

        [HttpGet("{id}", Name = "GetBook")]
        public async Task<IActionResult> GetBookAsync(int id)
        {
            var book = await _bookService.GetBookAsync(id);

            if (book == null)
                return NotFound();

            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddBookAsync(BookDto bookDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            bookDto.Id = await _bookService.AddBookAsync(bookDto);

            return CreatedAtAction("GetBook", new { id = bookDto.Id }, bookDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBookAsync(int id, BookDto bookDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (id != bookDto.Id)
                return BadRequest(ModelState);

            try
            {
                await _bookService.UpdateBookAsync(bookDto);
                return Ok(bookDto);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await _bookService.IsBookExists(id))
                    return NotFound();
                else
                    return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookAsync(int id)
        {
            if (!await _bookService.IsBookExists(id))
                return NotFound();

            await _bookService.DeleteBookAsync(id);
            return Ok();
        }
    }
}
