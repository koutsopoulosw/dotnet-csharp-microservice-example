using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;
using System.Security.Policy;
using NTierExample.Data.Types;

namespace NTierExample.Data.Context
{
    public class LibraryContext : DbContext
    {
        public DbSet<Barista> Barista { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=library;user=user;password=password");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Barista>(entity =>
            {
                entity.HasKey(e => e.id);
                entity.Property(e => e.round).IsRequired();
                entity.Property(e => e.currentDmg).IsRequired();
                entity.Property(e => e.currentHealth).IsRequired();
            });
        }
    }
}
