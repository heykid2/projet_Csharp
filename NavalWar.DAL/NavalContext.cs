using Microsoft.EntityFrameworkCore;
using NavalWar.DAL.Models;

namespace NavalWar.DAL
{
    public class NavalContext : DbContext
    {
        public NavalContext(DbContextOptions<NavalContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("User")
                .HasMany(u => u.Players)
                .WithOne(p => p.User)
                ;
            modelBuilder.Entity<Player>()
                .ToTable("Player");

            modelBuilder.Entity<Player>()
                .HasOne(p => p.isUser)
                .WithMany(s => s.Players);

            modelBuilder.Entity<Player>()
                .HasOne(p => p.ofSession);
        }
    }
}
