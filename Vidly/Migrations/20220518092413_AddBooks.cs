using Microsoft.EntityFrameworkCore.Migrations;

namespace Vidly.Migrations
{
    public partial class AddBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Courtney Maum", "At the age of thirty-seven, Courtney Maum finds herself in an indoor arena in Connecticut, moments away from stepping back into the saddle. For her, this is not just a riding lesson, but a last-ditch attempt to pull herself back from the brink even though riding is a relic from the past she walked away from. She hasn’t been on or near a horse in over thirty years. ", "The Year of the Horses" },
                    { 2, "A.F. Steadman", "Soar into a breathtaking world of heroes and unicorns as you’ve never seen them before in this fantastical middle grade debut perfect for fans of the Percy Jackson and Eragon series!", "Skandar and the Unicorn Thief" },
                    { 3, "Robert Thorogood", "Meet Judith: a seventy-seven-year-old whiskey drinking, crossword puzzle author living her best life in a dilapidated mansion on the outskirts of Marlow.", "The Marlow Murder Club" },
                    { 4, "Mike Chen", "Obi-Wan Kenobi and Anakin Skywalker must stem the tide of the raging Clone Wars and forge a new bond as Jedi Knights in a high-stakes adventure set just after the events of Star Wars: Attack of the Clones.", "Star Wars: Brotherhood" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
