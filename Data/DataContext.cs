using Microsoft.EntityFrameworkCore;

namespace SistemaLogin.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<SistemaLogin> SistemaLogins { get; set; }

    }
}
