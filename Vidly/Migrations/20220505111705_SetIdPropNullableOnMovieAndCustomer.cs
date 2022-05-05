using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Migrations
{
    public partial class SetIdPropNullableOnMovieAndCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Birthdate", "IsSubscribedForNewsletter", "MembershipTypeId", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1976, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, (byte)1, "Tim" },
                    { 2, new DateTime(1983, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, (byte)2, "Tom" },
                    { 3, null, false, (byte)3, "Tod" },
                    { 4, new DateTime(1989, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, (byte)4, "Jane" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DateAdded", "GenreId", "NumberInStock", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, (byte)15, new DateTime(1984, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terminator" },
                    { 2, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, (byte)15, new DateTime(1991, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terminator2" },
                    { 3, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, (byte)15, new DateTime(1982, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rambo" },
                    { 4, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, (byte)15, new DateTime(1985, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rambo 2" },
                    { 5, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, (byte)15, new DateTime(1988, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rambo 3" },
                    { 6, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)5, (byte)15, new DateTime(1991, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oscar" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Birthdate", "IsSubscribedForNewsletter", "MembershipTypeId", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1976, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, (byte)1, "Tim" },
                    { 2, new DateTime(1983, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), true, (byte)2, "Tom" },
                    { 3, null, false, (byte)3, "Tod" },
                    { 4, new DateTime(1989, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), true, (byte)4, "Jane" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "DateAdded", "GenreId", "NumberInStock", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, (byte)15, new DateTime(1984, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terminator" },
                    { 2, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, (byte)15, new DateTime(1991, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Terminator2" },
                    { 3, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, (byte)15, new DateTime(1982, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rambo" },
                    { 4, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, (byte)15, new DateTime(1985, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rambo 2" },
                    { 5, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)1, (byte)15, new DateTime(1988, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rambo 3" },
                    { 6, new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)5, (byte)15, new DateTime(1991, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oscar" }
                });
        }
    }
}
