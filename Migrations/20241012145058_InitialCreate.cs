using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TermProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieReviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReviewerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ReviewText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieReviews", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MovieReviews",
                columns: new[] { "Id", "MovieTitle", "Rating", "ReviewText", "ReviewerName" },
                values: new object[] { 1, "Inception", 9, "A brilliant, mind-bending thriller!", "Nick" });

            migrationBuilder.InsertData(
                table: "MovieReviews",
                columns: new[] { "Id", "MovieTitle", "Rating", "ReviewText", "ReviewerName" },
                values: new object[] { 2, "The Matrix", 10, "An absolute sci-fi classic!", "Jon" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieReviews");
        }
    }
}
