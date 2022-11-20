using System;
using GameLibrary.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace GameLibrary.DataAccessLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLOCALDB;Database=GameLibrary;Trusted_Connection=True");
        }
    
        public DbSet<User> Users { get; set; }
        public DbSet<App> Apps { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}