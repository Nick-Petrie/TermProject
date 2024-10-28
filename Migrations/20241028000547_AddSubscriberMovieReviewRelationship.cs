using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TermProject.Migrations
{
    public partial class AddSubscriberMovieReviewRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubscribersId",
                table: "MovieReviews",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Subscribers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GenderIdentity = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Zip = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribers", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Subscribers",
                columns: new[] { "ID", "Address", "City", "FirstName", "GenderIdentity", "LastName", "State", "Zip", "email", "phoneNumber" },
                values: new object[] { 1, null, null, "Nick", 0, "Petrie", null, null, "nick@example.com", null });

            migrationBuilder.InsertData(
                table: "Subscribers",
                columns: new[] { "ID", "Address", "City", "FirstName", "GenderIdentity", "LastName", "State", "Zip", "email", "phoneNumber" },
                values: new object[] { 2, null, null, "Jon", 2, "Doe", null, null, "jon@example.com", null });

            migrationBuilder.UpdateData(
                table: "MovieReviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubscribersId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "MovieReviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubscribersId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_MovieReviews_SubscribersId",
                table: "MovieReviews",
                column: "SubscribersId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieReviews_Subscribers_SubscribersId",
                table: "MovieReviews",
                column: "SubscribersId",
                principalTable: "Subscribers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieReviews_Subscribers_SubscribersId",
                table: "MovieReviews");

            migrationBuilder.DropTable(
                name: "Subscribers");

            migrationBuilder.DropIndex(
                name: "IX_MovieReviews_SubscribersId",
                table: "MovieReviews");

            migrationBuilder.DropColumn(
                name: "SubscribersId",
                table: "MovieReviews");
        }
    }
}
