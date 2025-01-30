using BookWeb.Domain.Entities.BookEntity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookWeb.Domain.Entities.AuthorEntity
{
    [Table("authors")]
    public class Author
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Column("author_name")]
        public string Name { get; set; }

        [Column("author_birthdate")]
        public DateTime? BirthDate { get; set; }

        [Column("author_nationality")]
        public string Nationality { get; set; }

        [Column("author_biography")]
        public string Biography { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();


    }
}
