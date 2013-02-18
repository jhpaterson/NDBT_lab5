using System.Data.Entity;

namespace NDBT_lab5.Models
{
    public class LibraryContext : DbContext
    {
       
        public LibraryContext() : base("name=LibraryContext")
        {
            Database.SetInitializer<LibraryContext>(new LibraryContextInitializer());
        }

        public DbSet<Title> Titles { get; set; }
    }
}
