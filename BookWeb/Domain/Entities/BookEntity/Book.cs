using BookWeb.Domain.Entities.AuthorEntity;
using BookWeb.Domain.Enums.Genre;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookWeb.Domain.Entities.BookEntity
{
    [Table("books")]
    public class Book
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("book_title")]
        [Required]
        public string Title { get; set; }

        [Column("published_date")]
        public DateTime? PublishedDate { get; set; }

        [Column("book_genre")]
        [Required]
        public GenreEnum Genre { get; set; }

        [Column("fk_author_id")]
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
