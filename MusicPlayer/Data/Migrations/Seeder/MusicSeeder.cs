using Microsoft.EntityFrameworkCore;
using MusicPlayer.Data.Entities;
using System;

namespace MusicPlayer.Data.Migrations.Seeder
{
    public static class MusicSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {           
            modelBuilder.Entity<Author>().HasData(
                new Author { AuthorName = "Viruss"},
                new Author { AuthorName = "Maroon5" }
            );
            modelBuilder.Entity<Genre>().HasData(
                new Genre { GenreName = "Việt Nam"},
                new Genre { GenreName = "US-UK" }
            );
            modelBuilder.Entity<Singer>().HasData(
                new Singer { SingerName = "Justatee"},
                new Singer { SingerName = "Maroon5" }
            );
            modelBuilder.Entity<User>().HasData(
                new User { Name = "Comi", BirthDay = DateTime.Now, Gender = true},
                new User { Name = "Shiba", BirthDay = DateTime.Now, Gender = true }
            );
            modelBuilder.Entity<Song>().HasData(
                new Song { SongName = "Thằng điên", UserId = 1, SingerId = 1, AuthorId = 1, GenreId = 1},
                new Song { SongName = "Girl like you", UserId = 2, SingerId = 2, AuthorId = 2, GenreId = 2 }
            );
            modelBuilder.Entity<Album>().HasData(
                new Album { AlbumName = "Thằng điên", AuthorId = 1, GenreId = 1 },
                new Album { AlbumName = "Girl like you", AuthorId = 2, GenreId = 2 }
            );
            modelBuilder.Entity<SongAlbum>().HasData(
                new SongAlbum { AlbumId = 1, SongId = 1},
                new SongAlbum { AlbumId = 2, SongId = 2 }
            );
        }
    }
}
