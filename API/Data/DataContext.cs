using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<GameImage> GameImages { get; set; }
        public DbSet<GameTag> GameTags { get; set; }
        public DbSet<GameUser> GameUsers { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }

}