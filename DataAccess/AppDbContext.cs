using Library.Core;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace Library.DataAccess
{
    public class AppDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Issue> Issues { get; set; } = null!;
        public DbSet<Librarian> Librarians { get; set; } = null!;
        public DbSet<Reader> Readers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LibraryDb;TrustServerCertificate=True;Integrated Security=SSPI;" +
                "");
        }
    }
}





