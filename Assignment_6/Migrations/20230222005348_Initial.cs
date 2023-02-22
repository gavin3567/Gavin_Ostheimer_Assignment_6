using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment_6.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieCategories",
                columns: table => new
                {
                    MovieCategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCategories", x => x.MovieCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieTitle = table.Column<string>(nullable: false),
                    MovieYear = table.Column<short>(nullable: false),
                    MovieDirector = table.Column<string>(nullable: false),
                    MovieRating = table.Column<string>(nullable: false),
                    MovieEdited = table.Column<bool>(nullable: false),
                    MovieLent = table.Column<string>(nullable: true),
                    MovieNotes = table.Column<string>(nullable: true),
                    MovieCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.MovieID);
                    table.ForeignKey(
                        name: "FK_Responses_MovieCategories_MovieCategoryId",
                        column: x => x.MovieCategoryId,
                        principalTable: "MovieCategories",
                        principalColumn: "MovieCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieCategoryId", "CategoryName" },
                values: new object[] { 1, "Action/Adventure" });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieCategoryId", "CategoryName" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieCategoryId", "CategoryName" },
                values: new object[] { 3, "Drama" });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieCategoryId", "CategoryName" },
                values: new object[] { 4, "Family" });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieCategoryId", "CategoryName" },
                values: new object[] { 5, "Horror/Suspense" });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieCategoryId", "CategoryName" },
                values: new object[] { 6, "Miscellaneous" });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieCategoryId", "CategoryName" },
                values: new object[] { 7, "Television" });

            migrationBuilder.InsertData(
                table: "MovieCategories",
                columns: new[] { "MovieCategoryId", "CategoryName" },
                values: new object[] { 8, "VHS" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "MovieCategoryId", "MovieDirector", "MovieEdited", "MovieLent", "MovieNotes", "MovieRating", "MovieTitle", "MovieYear" },
                values: new object[] { 1, 1, "Captain Morb", true, "Sir Morb II", "It's trash", "PG-13", "Morbius", (short)2022 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "MovieCategoryId", "MovieDirector", "MovieEdited", "MovieLent", "MovieNotes", "MovieRating", "MovieTitle", "MovieYear" },
                values: new object[] { 2, 1, "Tom Holland", false, "Sir Tom III", "It's good", "PG-13", "Uncharted", (short)2022 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "MovieID", "MovieCategoryId", "MovieDirector", "MovieEdited", "MovieLent", "MovieNotes", "MovieRating", "MovieTitle", "MovieYear" },
                values: new object[] { 3, 1, "Iron Man", false, "The Hulk", "It's amazing", "PG-13", "Black Panther", (short)2017 });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_MovieCategoryId",
                table: "Responses",
                column: "MovieCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "MovieCategories");
        }
    }
}
