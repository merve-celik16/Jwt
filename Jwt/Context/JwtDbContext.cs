using Jwt.Models;
using Microsoft.EntityFrameworkCore;

namespace Jwt.Context
{
    public class JwtDbContext :DbContext
    {
        public JwtDbContext(DbContextOptions<JwtDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                  .Property(x => x.Email)
                  .IsRequired()
                  .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(a => a.Password)
                .IsRequired();
            modelBuilder.Entity<User>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
