using Microsoft.EntityFrameworkCore;
using Teladoc.Domain.Entities;

namespace Teladoc.Domain
{
    public class TeladocApiContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }

        protected override void OnConfiguring
       (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "TeladocDb");
        }
    }
}
