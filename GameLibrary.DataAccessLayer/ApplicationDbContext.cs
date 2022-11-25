using System;
using GameLibrary.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace GameLibrary.DataAccessLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() => Database.EnsureCreatedAsync();

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Favorite>().HasNoKey();
        //     modelBuilder.Entity<Profile>().HasKey(p => p.UserId);
        //
        //     base.OnModelCreating(modelBuilder);
        // }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-LSPMPFI\\SQLEXPRESS, 49172;Database=GameLibrary;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;");
        }
    
        public DbSet<User> Users { get; set; }
        public DbSet<App> Apps { get; set; }
        // public DbSet<Favorite> Favorites { get; set; }
        // public DbSet<Profile> Profiles { get; set; }
        public DbSet<TypeApp> TypeApps { get; set; }
        public DbSet<Platform> Platforms { get; set; }
    }
}