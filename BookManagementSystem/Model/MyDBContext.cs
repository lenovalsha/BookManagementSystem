
using System.Data.Entity;

//using Microsoft.EntityFrameworkCore;


namespace BookManagementSystem.Model
{
     class MyDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Author> Authors { get; set; }

        
    }
}
