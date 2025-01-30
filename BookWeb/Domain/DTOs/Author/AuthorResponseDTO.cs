using BookWeb.Domain.DTOs.Book;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookWeb.Domain.DTOs.Author
{
    public class AuthorResponseDTO
    {
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Nationality { get; set; }
        public string Biography { get; set; }
        public ICollection<BookResponseDTO> Books { get; set; } = new List<BookResponseDTO>();
    }
}
