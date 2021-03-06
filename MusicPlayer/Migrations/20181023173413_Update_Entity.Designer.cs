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
    [Migration("20181023173413_Update_Entity")]
    partial class Update_Entity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
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
                        new { Id = 1, AlbumName = "Thằng điên", AuthorId = 0, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GenreId = 1, ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), SingerId = 1, UniqueId = new Guid("48e69be9-54f7-4f60-bf27-571861a4aee7") },
                        new { Id = 2, AlbumName = "Girl like you", AuthorId = 0, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GenreId = 2, ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), SingerId = 2, UniqueId = new Guid("21f5e7b1-9190-4f1e-960c-80ef2c390ffe") }
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
                        new { Id = 1, AuthorName = "Viruss", CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("5a97c3b5-3783-4a01-93cc-9ee2b9f6a31a") },
                        new { Id = 2, AuthorName = "Maroon5", CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("0ee3e540-df48-4e8e-86dc-ae70b2fd91ed") }
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
                        new { UserId = 1, SongId = 1, Context = "Good", CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("caa91989-bf88-4376-8183-6c6aee47cb8a") },
                        new { UserId = 2, SongId = 2, Context = "Good", CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("697206b8-7260-4929-a7fc-865bd5e65500") }
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
                        new { Id = 1, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GenreName = "Việt Nam", ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("a51aba76-8704-43ce-a9b4-490e0e66e497") },
                        new { Id = 2, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GenreName = "US-UK", ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("240ae3b7-201a-4882-ac4f-1204205b0800") }
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
                        new { Id = 1, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "My favorite", UniqueId = new Guid("03428a28-d745-45b7-b793-cb25d467b6fa"), UserId = 1 },
                        new { Id = 2, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Title = "My favorite", UniqueId = new Guid("0bcf7a2e-5ef8-4444-adbb-6f9be7905d98"), UserId = 2 }
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
                        new { Id = 1, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), SingerName = "Justatee", UniqueId = new Guid("39b624d2-1ce5-4ac3-8b0d-53c9b9083166") },
                        new { Id = 2, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), SingerName = "Maroon5", UniqueId = new Guid("b65bd850-77bb-4467-8719-629b046b9216") }
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
                        new { Id = 1, AuthorId = 1, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GenreId = 1, ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PlayListId = 0, SingerId = 1, SongName = "Thằng điên", UniqueId = new Guid("8ec2f178-49ba-4dd1-a53c-3507fe30f271"), UserId = 1 },
                        new { Id = 2, AuthorId = 2, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), GenreId = 2, ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PlayListId = 0, SingerId = 2, SongName = "Girl like you", UniqueId = new Guid("89586da4-c1a1-44ba-9ade-2076fd355ff0"), UserId = 2 }
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
                        new { AlbumId = 1, SongId = 1, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("9611d8ae-26b7-40b1-a56c-23d09382721f") },
                        new { AlbumId = 2, SongId = 2, CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), UniqueId = new Guid("2b4cb00d-b02e-43e2-bcc2-80c8548ceb5b") }
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

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.Property<Guid>("UniqueId");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new { Id = 1, BirthDay = new DateTime(2018, 10, 24, 0, 34, 12, 903, DateTimeKind.Local), CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Gender = true, ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Comi", UniqueId = new Guid("d992bad3-fc33-47e3-92de-fccafc13e7b7") },
                        new { Id = 2, BirthDay = new DateTime(2018, 10, 24, 0, 34, 12, 904, DateTimeKind.Local), CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Gender = true, ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Shiba", UniqueId = new Guid("bd994904-9016-4199-ac54-3f4e8b7ee37d") }
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
