using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Migrations
{
    public partial class AddMusicAlbumsTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MusicAlbums",
                columns: new[] { "Id", "Artist", "DateAdded", "GenreId", "NumberInStock", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, "Metallica", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)3, (byte)15, new DateTime(1983, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kill 'Em All" },
                    { 2, "Metallica", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)3, (byte)15, new DateTime(1984, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ride the Lightning" },
                    { 3, "Metallica", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)3, (byte)15, new DateTime(1986, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Master of Puppets" },
                    { 4, "Metallica", new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)3, (byte)15, new DateTime(1988, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "...And Justice for All" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MusicAlbums",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MusicAlbums",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MusicAlbums",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MusicAlbums",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
