﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace WebApplication.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20181028080542_identity")]
    partial class identity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Repository.Entities.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AlbumName");

                    b.Property<int>("AuthorId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<int>("GenreId");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<int>("SingerId");

                    b.Property<Guid>("UniqueId");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.HasIndex("SingerId");

                    b.ToTable("Albums");

                    b.HasData(
                        new { Id = 1, AlbumName = "Thằng điên", AuthorId = 0, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GenreId = 1, ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), SingerId = 1, UniqueId = new Guid("65822d98-fbfe-43bb-877f-ba3686bd7295") },
                        new { Id = 2, AlbumName = "Girl like you", AuthorId = 0, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GenreId = 2, ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), SingerId = 2, UniqueId = new Guid("a6f76495-542d-43a5-9711-7517a83d9474") }
                    );
                });

            modelBuilder.Entity("Repository.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorName");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<Guid>("UniqueId");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new { Id = 1, AuthorName = "Viruss", CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("83114ae1-8aef-424d-9e66-ee777ef55c93") },
                        new { Id = 2, AuthorName = "Maroon5", CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("445d5a09-90c3-4240-8bbd-cfc8b5757e5f") }
                    );
                });

            modelBuilder.Entity("Repository.Entities.Comment", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("SongId");

                    b.Property<string>("Context");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<Guid>("UniqueId");

                    b.HasKey("UserId", "SongId");

                    b.HasAlternateKey("SongId", "UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new { UserId = 1, SongId = 1, Context = "Good", CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("0aa8858a-0257-4d19-b02b-de4db7d77ff9") },
                        new { UserId = 2, SongId = 2, Context = "Good", CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("13dd49c4-511e-4d97-bd2a-b9bb97321752") }
                    );
                });

            modelBuilder.Entity("Repository.Entities.Employee", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmpName");

                    b.Property<int>("RoleId");

                    b.HasKey("EmpId");

                    b.HasIndex("RoleId");

                    b.ToTable("Employees");

                    b.HasData(
                        new { EmpId = 1, EmpName = "Rai", RoleId = 1 },
                        new { EmpId = 2, EmpName = "Ki", RoleId = 2 }
                    );
                });

            modelBuilder.Entity("Repository.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("GenreName");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<Guid>("UniqueId");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new { Id = 1, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GenreName = "Việt Nam", ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("c048262e-56ff-464f-9d4f-d3b0854eb18d") },
                        new { Id = 2, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GenreName = "US-UK", ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("99210d0e-839b-4d4a-9546-1beff24e49e4") }
                    );
                });

            modelBuilder.Entity("Repository.Entities.PlayList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("Description");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Title");

                    b.Property<Guid>("UniqueId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("PlayLists");

                    b.HasData(
                        new { Id = 1, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "My favorite", UniqueId = new Guid("eae02a3c-d47a-46cd-84b2-89ab04c5f4a7"), UserId = 1 },
                        new { Id = 2, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "My favorite", UniqueId = new Guid("5238d974-587f-450b-a600-a750dc74db82"), UserId = 2 }
                    );
                });

            modelBuilder.Entity("Repository.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new { RoleId = 1, RoleName = "Admin" },
                        new { RoleId = 2, RoleName = "Manage" }
                    );
                });

            modelBuilder.Entity("Repository.Entities.Singer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("SingerName");

                    b.Property<Guid>("UniqueId");

                    b.HasKey("Id");

                    b.ToTable("Singers");

                    b.HasData(
                        new { Id = 1, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), SingerName = "Justatee", UniqueId = new Guid("146cd28d-748e-4db4-9814-7ab2fb34152f") },
                        new { Id = 2, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), SingerName = "Maroon5", UniqueId = new Guid("9836b83c-cebd-4263-a7d9-b28d79ea8a82") }
                    );
                });

            modelBuilder.Entity("Repository.Entities.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("Description");

                    b.Property<int>("GenreId");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("PathSong");

                    b.Property<string>("PhotoPath");

                    b.Property<int>("PlayListId");

                    b.Property<int>("SingerId");

                    b.Property<string>("SongName");

                    b.Property<Guid>("UniqueId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("GenreId");

                    b.HasIndex("SingerId");

                    b.HasIndex("UserId");

                    b.ToTable("Songs");

                    b.HasData(
                        new { Id = 1, AuthorId = 1, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GenreId = 1, ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PlayListId = 0, SingerId = 1, SongName = "Thằng điên", UniqueId = new Guid("c15d058c-9a8a-4e7d-8565-73a223de1a22"), UserId = 1 },
                        new { Id = 2, AuthorId = 2, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GenreId = 2, ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PlayListId = 0, SingerId = 2, SongName = "Girl like you", UniqueId = new Guid("f8c550c1-80f9-48e1-a965-4a1cb59475d7"), UserId = 2 }
                    );
                });

            modelBuilder.Entity("Repository.Entities.SongAlbum", b =>
                {
                    b.Property<int>("AlbumId");

                    b.Property<int>("SongId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<Guid>("UniqueId");

                    b.HasKey("AlbumId", "SongId");

                    b.HasIndex("SongId");

                    b.ToTable("SongAlbums");

                    b.HasData(
                        new { AlbumId = 1, SongId = 1, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("0fd66797-0f97-4bd9-a109-b2a64668edfe") },
                        new { AlbumId = 2, SongId = 2, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("fff65fc5-5f57-4164-9e68-1252491f42d8") }
                    );
                });

            modelBuilder.Entity("Repository.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDay");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool?>("Deleted");

                    b.Property<string>("Email");

                    b.Property<bool>("Gender");

                    b.Property<DateTime>("ModifiedDate");

                    b.Property<string>("Name");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("Phone");

                    b.Property<Guid>("UniqueId");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1, BirthDay = new DateTime(2018, 10, 28, 15, 5, 41, 755, DateTimeKind.Local), CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Email = "comi@gamil.com", Gender = true, ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Comi", UniqueId = new Guid("001a58fb-0cb2-42b5-b1f2-b5acce13b62e"), Username = "comitieutu" },
                        new { Id = 2, BirthDay = new DateTime(2018, 10, 28, 15, 5, 41, 756, DateTimeKind.Local), CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Email = "shiba@gmail.com", Gender = true, ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Shiba", UniqueId = new Guid("b0f7fd59-0a9d-457c-af6f-1db1c82220ea"), Username = "shibashiba" }
                    );
                });

            modelBuilder.Entity("Repository.Entities.Album", b =>
                {
                    b.HasOne("Repository.Entities.Genre", "Genre")
                        .WithMany("Albums")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Repository.Entities.Singer", "Singer")
                        .WithMany("Albums")
                        .HasForeignKey("SingerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Repository.Entities.Comment", b =>
                {
                    b.HasOne("Repository.Entities.Song", "Song")
                        .WithMany("Comments")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Repository.Entities.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Repository.Entities.Employee", b =>
                {
                    b.HasOne("Repository.Entities.Role", "Role")
                        .WithMany("Employees")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Repository.Entities.PlayList", b =>
                {
                    b.HasOne("Repository.Entities.User", "User")
                        .WithMany("PlayLists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Repository.Entities.Song", b =>
                {
                    b.HasOne("Repository.Entities.Author", "Author")
                        .WithMany("Songs")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Repository.Entities.Genre", "Genre")
                        .WithMany("Songs")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Repository.Entities.Singer", "Singer")
                        .WithMany("Songs")
                        .HasForeignKey("SingerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Repository.Entities.User", "User")
                        .WithMany("Songs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Repository.Entities.SongAlbum", b =>
                {
                    b.HasOne("Repository.Entities.Album", "Album")
                        .WithMany("SongAlbums")
                        .HasForeignKey("AlbumId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Repository.Entities.Song", "Song")
                        .WithMany("SongAlbums")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
