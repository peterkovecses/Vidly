using System.Collections.Generic;
using System.Threading.Tasks;
using Vidly.Dtos;

namespace Vidly.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<BookDto>> GetBooksAsync();

        Task<BookDto> GetBookAsync(int id);

        Task<int> AddBookAsync(BookDto bookDto);

        Task UpdateBookAsync(BookDto bookDto);

        Task DeleteBookAsync(int id);

        Task<bool> IsBookExists(int id);
    }
}
