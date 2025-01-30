using BookWeb.Domain.Entities.AuthorEntity;
using BookWeb.Domain.Entities.BookEntity;
using Microsoft.EntityFrameworkCore;

namespace BookWeb.Data
{
    public class BookWebDBContext : DbContext
    {
        public BookWebDBContext(DbContextOptions<BookWebDBContext> options) : base(options) { }    
        
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Author { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilber)
        {
            base.OnModelCreating(modelBuilber);

            modelBuilber.Entity<Book>()
                    .HasOne(b => b.Author) // The relation between Author and Book is that one author can have one or many books. 
                    .WithMany()
                    .HasForeignKey(b => b.AuthorId); // Defining the foreign key AuthorId
        }

    }
}
