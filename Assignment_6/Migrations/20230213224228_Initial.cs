using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment_6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieCategory = table.Column<string>(nullable: false),
                    MovieTitle = table.Column<string>(nullable: false),
                    MovieYear = table.Column<short>(nullable: false),
                    MovieDirector = table.Column<string>(nullable: false),
                    MovieRating = table.Column<string>(nullable: false),
                    MovieEdited = table.Column<bool>(nullable: false),
                    MovieLent = table.Column<string>(nullable: true),
                    MovieNotes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "MovieCategory", "MovieDirector", "MovieEdited", "MovieLent", "MovieNotes", "MovieRating", "MovieTitle", "MovieYear" },
                values: new object[] { 1, "Action", "Captain Morb", true, "Sir Morb II", "It's trash", "PG-13", "Morbius", (short)2022 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "MovieCategory", "MovieDirector", "MovieEdited", "MovieLent", "MovieNotes", "MovieRating", "MovieTitle", "MovieYear" },
                values: new object[] { 2, "Action", "Tom Holland", false, "Sir Tom III", "It's good", "PG-13", "Uncharted", (short)2022 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "MovieCategory", "MovieDirector", "MovieEdited", "MovieLent", "MovieNotes", "MovieRating", "MovieTitle", "MovieYear" },
                values: new object[] { 3, "Action", "Iron Man", false, "The Hulk", "It's amazing", "PG-13", "Black Panther", (short)2017 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
