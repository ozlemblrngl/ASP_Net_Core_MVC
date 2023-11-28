using Microsoft.EntityFrameworkCore;

namespace WebApplication_EFCoreWithMvcCore.Models.Entities
{
    public class DatabaseContext :DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer("Server = DESKTOP-N9UK4PN; Database = BookHouseDB; Trusted_Connection = true; TrustServerCertificate = true ");
                optionsBuilder.UseLazyLoadingProxies();
            }
        }
    }
}
