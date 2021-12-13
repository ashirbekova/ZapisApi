using DB.Entities;
using Microsoft.EntityFrameworkCore;


namespace DB.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
        }

        #region Entities
        public DbSet<Category> Categories { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        #endregion
    }
}
