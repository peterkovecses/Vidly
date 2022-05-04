using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Migrations
{
    public partial class UpdateMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<byte>(
                name: "NumberInStock",
                table: "Movies",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateAdded", "NumberInStock", "ReleaseDate" },
                values: new object[] { new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)15, new DateTime(1984, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateAdded", "NumberInStock", "ReleaseDate" },
                values: new object[] { new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)15, new DateTime(1991, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateAdded", "NumberInStock", "ReleaseDate" },
                values: new object[] { new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)15, new DateTime(1982, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateAdded", "NumberInStock", "ReleaseDate" },
                values: new object[] { new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)15, new DateTime(1985, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateAdded", "NumberInStock", "ReleaseDate" },
                values: new object[] { new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)15, new DateTime(1988, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateAdded", "NumberInStock", "ReleaseDate" },
                values: new object[] { new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)15, new DateTime(1991, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "NumberInStock",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Movies");
        }
    }
}
