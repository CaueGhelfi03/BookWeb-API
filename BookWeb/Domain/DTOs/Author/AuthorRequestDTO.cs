using System.ComponentModel.DataAnnotations;

namespace BookWeb.Domain.DTOs.Author
{
    public class AuthorRequestDTO
    {
        [Required]
        public string Name { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Nationality { get; set; }
        public string Biography { get; set; }

    }
}
