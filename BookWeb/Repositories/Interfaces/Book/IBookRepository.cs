using BookWeb.Domain.DTOs.Book;
using BookWeb.Domain.Entities.BookEntity;

namespace BookWeb.Repositories.Interfaces.Author
{
    public interface IBookRepository
    {
        public Task<BookResponseDTO> AddAsync(Book newBook);
        public Task<IEnumerable<BookResponseDTO>> GetAllAsync();
        public Task<BookResponseDTO> GetByIdAsync(Guid id);
        public Task<BookRequestDTO> UpdateAsync(Guid id,  Book bookUpdated);
        public Task<bool> DeleteAsync(Guid id);
            
    }
}
