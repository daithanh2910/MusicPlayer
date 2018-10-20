using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Migrations
{
    public partial class SeederData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropSequence(
                name: "SeqId");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("09cf3129-ff68-4ef4-a87b-26907e3d9d06"));

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("9e7567f5-d3ef-48be-94ab-65fdd4beb5ef"));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("3b5b0576-d0a4-43d9-a589-c22e2fa65fb4"));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("07c5de39-a5c2-4d0a-a3df-cdb2e40a33e8"));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("9c6fa301-2bce-432a-a020-9b8183150d05"));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("9886e9b0-eda6-42f1-acb0-0c031ea11d68"));

            migrationBuilder.UpdateData(
                table: "Singers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("bb7bd508-b781-45fe-bc18-57e3acc87ec6"));

            migrationBuilder.UpdateData(
                table: "Singers",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("089bb5de-3923-4fe3-8de2-e18295f285cd"));

            migrationBuilder.UpdateData(
                table: "SongAlbums",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 1, 1 },
                column: "UniqueId",
                value: new Guid("6b06fdea-0267-46ae-b62c-4390f526fa06"));

            migrationBuilder.UpdateData(
                table: "SongAlbums",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 2, 2 },
                column: "UniqueId",
                value: new Guid("5155f6df-5f88-4ba0-803c-f2d167cac464"));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("14c90a34-ae92-4a79-a5d4-58ce4caed6c7"));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("cd1943ae-ff79-4938-aac6-512cebc7b844"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "UniqueId" },
                values: new object[] { new DateTime(2018, 10, 20, 20, 20, 36, 284, DateTimeKind.Local), new Guid("28284fba-a478-4b4d-a779-95d758fa220b") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "UniqueId" },
                values: new object[] { new DateTime(2018, 10, 20, 20, 20, 36, 285, DateTimeKind.Local), new Guid("585a1683-8197-413c-b852-17ef12e8fd21") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "SeqId");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Singers",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Singers",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "SongAlbums",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 1, 1 },
                column: "UniqueId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "SongAlbums",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 2, 2 },
                column: "UniqueId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1,
                column: "UniqueId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2,
                column: "UniqueId",
                value: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "UniqueId" },
                values: new object[] { new DateTime(2018, 10, 19, 19, 34, 25, 573, DateTimeKind.Local), new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "UniqueId" },
                values: new object[] { new DateTime(2018, 10, 19, 19, 34, 25, 574, DateTimeKind.Local), new Guid("00000000-0000-0000-0000-000000000000") });
        }
    }
}
