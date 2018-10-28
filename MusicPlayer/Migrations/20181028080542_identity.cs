using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Migrations
{
    public partial class identity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "Username");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("65822d98-fbfe-43bb-877f-ba3686bd7295"));

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("a6f76495-542d-43a5-9711-7517a83d9474"));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("83114ae1-8aef-424d-9e66-ee777ef55c93"));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("445d5a09-90c3-4240-8bbd-cfc8b5757e5f"));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumns: new[] { "UserId", "SongId" },
                keyValues: new object[] { 1, 1 },
                column: "UniqueId",
                value: new Guid("0aa8858a-0257-4d19-b02b-de4db7d77ff9"));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumns: new[] { "UserId", "SongId" },
                keyValues: new object[] { 2, 2 },
                column: "UniqueId",
                value: new Guid("13dd49c4-511e-4d97-bd2a-b9bb97321752"));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("c048262e-56ff-464f-9d4f-d3b0854eb18d"));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("99210d0e-839b-4d4a-9546-1beff24e49e4"));

            migrationBuilder.UpdateData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("eae02a3c-d47a-46cd-84b2-89ab04c5f4a7"));

            migrationBuilder.UpdateData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("5238d974-587f-450b-a600-a750dc74db82"));

            migrationBuilder.UpdateData(
                table: "Singers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("146cd28d-748e-4db4-9814-7ab2fb34152f"));

            migrationBuilder.UpdateData(
                table: "Singers",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("9836b83c-cebd-4263-a7d9-b28d79ea8a82"));

            migrationBuilder.UpdateData(
                table: "SongAlbums",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 1, 1 },
                column: "UniqueId",
                value: new Guid("0fd66797-0f97-4bd9-a109-b2a64668edfe"));

            migrationBuilder.UpdateData(
                table: "SongAlbums",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 2, 2 },
                column: "UniqueId",
                value: new Guid("fff65fc5-5f57-4164-9e68-1252491f42d8"));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("c15d058c-9a8a-4e7d-8565-73a223de1a22"));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("f8c550c1-80f9-48e1-a965-4a1cb59475d7"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "Email", "UniqueId", "Username" },
                values: new object[] { new DateTime(2018, 10, 28, 15, 5, 41, 755, DateTimeKind.Local), "comi@gamil.com", new Guid("001a58fb-0cb2-42b5-b1f2-b5acce13b62e"), "comitieutu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "Email", "UniqueId", "Username" },
                values: new object[] { new DateTime(2018, 10, 28, 15, 5, 41, 756, DateTimeKind.Local), "shiba@gmail.com", new Guid("b0f7fd59-0a9d-457c-af6f-1db1c82220ea"), "shibashiba" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "Password");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("48e69be9-54f7-4f60-bf27-571861a4aee7"));

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("21f5e7b1-9190-4f1e-960c-80ef2c390ffe"));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("5a97c3b5-3783-4a01-93cc-9ee2b9f6a31a"));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("0ee3e540-df48-4e8e-86dc-ae70b2fd91ed"));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumns: new[] { "UserId", "SongId" },
                keyValues: new object[] { 1, 1 },
                column: "UniqueId",
                value: new Guid("caa91989-bf88-4376-8183-6c6aee47cb8a"));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumns: new[] { "UserId", "SongId" },
                keyValues: new object[] { 2, 2 },
                column: "UniqueId",
                value: new Guid("697206b8-7260-4929-a7fc-865bd5e65500"));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("a51aba76-8704-43ce-a9b4-490e0e66e497"));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("240ae3b7-201a-4882-ac4f-1204205b0800"));

            migrationBuilder.UpdateData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("03428a28-d745-45b7-b793-cb25d467b6fa"));

            migrationBuilder.UpdateData(
                table: "PlayLists",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("0bcf7a2e-5ef8-4444-adbb-6f9be7905d98"));

            migrationBuilder.UpdateData(
                table: "Singers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("39b624d2-1ce5-4ac3-8b0d-53c9b9083166"));

            migrationBuilder.UpdateData(
                table: "Singers",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("b65bd850-77bb-4467-8719-629b046b9216"));

            migrationBuilder.UpdateData(
                table: "SongAlbums",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 1, 1 },
                column: "UniqueId",
                value: new Guid("9611d8ae-26b7-40b1-a56c-23d09382721f"));

            migrationBuilder.UpdateData(
                table: "SongAlbums",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 2, 2 },
                column: "UniqueId",
                value: new Guid("2b4cb00d-b02e-43e2-bcc2-80c8548ceb5b"));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("8ec2f178-49ba-4dd1-a53c-3507fe30f271"));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("89586da4-c1a1-44ba-9ade-2076fd355ff0"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "Email", "Password", "UniqueId" },
                values: new object[] { new DateTime(2018, 10, 24, 0, 34, 12, 903, DateTimeKind.Local), null, null, new Guid("d992bad3-fc33-47e3-92de-fccafc13e7b7") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "Email", "Password", "UniqueId" },
                values: new object[] { new DateTime(2018, 10, 24, 0, 34, 12, 904, DateTimeKind.Local), null, null, new Guid("bd994904-9016-4199-ac54-3f4e8b7ee37d") });
        }
    }
}
