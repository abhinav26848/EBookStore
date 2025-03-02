using Microsoft.EntityFrameworkCore;

namespace EBookStore.Models.Domain
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options):base(options) 
        {
            
        }
        public DbSet<Book> Book { get; set; }
        public DbSet<Gener> Gener { get; set; }
        public DbSet<Author> Author { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
    }
}
