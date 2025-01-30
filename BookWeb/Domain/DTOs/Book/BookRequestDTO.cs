using BookWeb.Domain.Enums.Genre;

namespace BookWeb.Domain.DTOs.Book
{
    public class BookRequestDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedDatetime { get; set; }
        public GenreEnum Genre { get; set; }

    }
}
