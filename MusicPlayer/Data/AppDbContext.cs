using Microsoft.EntityFrameworkCore;
using MusicPlayer.Data.Entities;
using MusicPlayer.Data.Migrations.Seeder;

namespace MusicPlayer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<SongAlbum> SongAlbums { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasSequence<int>("SeqId");
           // modelBuilder.ForSqlServerUseIdentityColumns();
            modelBuilder.Seed();
        }
    }
}
