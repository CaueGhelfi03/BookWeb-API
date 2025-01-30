using BookWeb.Domain.Enums.Genre;

namespace BookWeb.Domain.DTOs.Book
{
    public class BookResponseDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedDatetime { get; set; }
        public GenreEnum Genre { get; set; }
    }
}
