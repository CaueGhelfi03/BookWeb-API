using BookWeb.Domain.DTOs.Author;
using BookWeb.Domain.Enums.Genre;

namespace BookWeb.Domain.DTOs.BookAuthor
{
    public class BookWithAuthorResponseDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedDatetime { get; set; }
        public GenreEnum Genre { get; set; }
        public AuthorResponseDTO Author { get; set; }

    }
}
