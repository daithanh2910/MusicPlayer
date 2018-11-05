using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using System;

namespace Repository
{
    public static class MusicSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {           
            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, AuthorName = "Viruss", UniqueId = Guid.NewGuid()},
                new Author { Id = 2, AuthorName = "Maroon5", UniqueId = Guid.NewGuid() }
            );
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, GenreName = "Việt Nam", UniqueId = Guid.NewGuid() },
                new Genre { Id = 2, GenreName = "US-UK", UniqueId = Guid.NewGuid() }
            );
            modelBuilder.Entity<Singer>().HasData(
                new Singer { Id = 1, SingerName = "Justatee", UniqueId = Guid.NewGuid() },
                new Singer { Id = 2, SingerName = "Maroon5", UniqueId = Guid.NewGuid() }
            );
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Comi", Username = "comitieutu", Email = "comi@gamil.com", BirthDay = DateTime.Now, Gender = true, UniqueId = Guid.NewGuid() },
                new User { Id = 2, Name = "Shiba", Username = "shibashiba", Email = "shiba@gmail.com", BirthDay = DateTime.Now, Gender = true, UniqueId = Guid.NewGuid() }
            );
            modelBuilder.Entity<Song>().HasData(
                new Song { Id = 1, SongName = "Thằng điên", UserId = 1, SingerId = 1, AuthorId = 1, GenreId = 1, UniqueId = Guid.NewGuid() },
                new Song { Id = 2, SongName = "Girl like you", UserId = 2, SingerId = 2, AuthorId = 2, GenreId = 2, UniqueId = Guid.NewGuid() }
            );
            modelBuilder.Entity<Comment>().HasKey(s => new { s.UserId, s.SongId });
            modelBuilder.Entity<Comment>().HasData(
                new Comment { UserId = 1, SongId = 1, Context = "Good", UniqueId = Guid.NewGuid() },
                new Comment { UserId = 2, SongId = 2, Context = "Good", UniqueId = Guid.NewGuid() }
            );
            modelBuilder.Entity<PlayList>().HasData(
               new PlayList { Id = 1, Title = "My favorite", UserId = 1, UniqueId = Guid.NewGuid() },
               new PlayList { Id = 2, Title = "My favorite", UserId = 2, UniqueId = Guid.NewGuid() }
            );
            modelBuilder.Entity<Album>().HasData(
                new Album { Id = 1, AlbumName = "Thằng điên", GenreId = 1, SingerId = 1, UniqueId = Guid.NewGuid() },
                new Album { Id = 2, AlbumName = "Girl like you", GenreId = 2, SingerId = 2, UniqueId = Guid.NewGuid() }
            );
            modelBuilder.Entity<SongAlbum>().HasKey(s => new { s.AlbumId, s.SongId });
            modelBuilder.Entity<SongAlbum>().HasData(
                new SongAlbum { AlbumId = 1, SongId = 1, UniqueId = Guid.NewGuid() },
                new SongAlbum { AlbumId = 2, SongId = 2, UniqueId = Guid.NewGuid() }
            );
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = 1, RoleName = "Admin" },
                new Role { RoleId = 2, RoleName = "Manage" }
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmpId = 1, EmpName = "Rai", RoleId = 1 },
                new Employee { EmpId = 2, EmpName = "Ki", RoleId = 2 }
            );
        }
    }
}
