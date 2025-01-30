using BookWeb.Domain.DTOs.Book;
using BookWeb.Repositories.Interfaces.Author;

namespace BookWeb.Services.Interfaces
{
    public interface IBookService
    {

        Task<IEnumerable<BookResponseDTO>> GetAllBooksAsync();
        Task<BookResponseDTO> GetBookByIdAsync(Guid id);
        Task<BookResponseDTO> AddBookAsync(BookRequestDTO newBook);
        Task<BookResponseDTO> UpdateBookAsync(BookRequestDTO updatedBook, Guid id);
        Task<BookResponseDTO> DeleteBookAsync(Guid id);

    }
}
