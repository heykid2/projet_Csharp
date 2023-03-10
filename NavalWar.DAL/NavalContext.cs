using Microsoft.EntityFrameworkCore;
using NavalWar.DAL.Models;
using NavalWar.Utils;

namespace NavalWar.DAL
{
    public class NavalContext : DbContext
    {
        public NavalContext(DbContextOptions<NavalContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Shot> Shots { get; set; }
        public DbSet<Ship> Ships { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Player> Players { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("User")
                .HasMany(u => u.Players)
                .WithOne(p => p.User)
                ;
            modelBuilder.Entity<Player>()
                .ToTable("Player")
                .HasOne(p => p.User)
                .WithMany(s => s.Players)
                ;

            modelBuilder.Entity<Player>()
                .HasMany(p => p.Ships)
                ;

            modelBuilder.Entity<Player>()
                .HasOne(p => p.Session)
                ;

            modelBuilder.Entity<Player>()
                .HasMany(p => p.Shots)
                ;

            modelBuilder.Entity<Shot>()
                .ToTable("Shot")
                ;
        }
    }
}
