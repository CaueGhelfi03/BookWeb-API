using BookWeb.Domain.DTOs.Book;
using BookWeb.Domain.Entities.BookEntity;
using BookWeb.Repositories.Interfaces.Author;
using BookWeb.Services.Interfaces;

namespace BookWeb.Services.BookService
{
    public class BookService(IBookRepository bookRepository) : IBookService
    {
        public async Task<BookResponseDTO> AddBookAsync(BookRequestDTO newBook)
        {
            throw new NotImplementedException();
        }

        public async Task<BookResponseDTO> DeleteBookAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BookResponseDTO>> GetAllBooksAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<BookResponseDTO> GetBookByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<BookResponseDTO> UpdateBookAsync(BookRequestDTO updatedBook, Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
