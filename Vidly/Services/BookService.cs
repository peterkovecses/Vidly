using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vidly.Dtos;
using Vidly.Interfaces;
using Vidly.Models;

namespace Vidly.Services
{
    public class BookService : IBookService
    {
        private readonly VidlyDbContext _dbContext;
        private readonly IMapper _mapper;

        public BookService(VidlyDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BookDto>> GetBooksAsync()
        {
            var books = await _dbContext.Books.ToListAsync();

            return _mapper.Map<IEnumerable<Book>, IEnumerable<BookDto>>(books);
        }

        public async Task<BookDto> GetBookAsync(int id)
        {
            var book = await _dbContext.Books.FirstOrDefaultAsync(b => b.Id == id);

            return _mapper.Map<BookDto>(book);
        }

        public async Task<int> AddBookAsync(BookDto bookDto)
        {
            var book = _mapper.Map<Book>(bookDto);

            _dbContext.Books.Add(book);         
            await _dbContext.SaveChangesAsync();

            return book.Id;
        }

        public async Task UpdateBookAsync(BookDto bookDto)
        {
            var bookInDb = await _dbContext.Books.SingleAsync(b => b.Id == bookDto.Id);

            _mapper.Map(bookDto, bookInDb);

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteBookAsync(int id)
        {
            var book = await _dbContext.Books.SingleAsync(b => b.Id == id);

            _dbContext.Books.Remove(book);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> IsBookExists(int id)
        {
            return await _dbContext.Books.AnyAsync(b => b.Id == id);
        }
    }
}
