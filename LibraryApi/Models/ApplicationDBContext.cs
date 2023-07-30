using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Models
{
    public class ApplicationDbContext : DbContext
    {
        
        public DbSet<Book> Books { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

          
        }
    }
}