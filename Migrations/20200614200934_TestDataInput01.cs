using Microsoft.EntityFrameworkCore.Migrations;

namespace PlayaCore.Migrations
{
    public partial class TestDataInput01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "He keeps the gates safe...", "GoalKeeper" },
                    { 2, "He defends until they drop...", "Defender" },
                    { 3, "He stays in the middle...", "Midfielder" },
                    { 4, "He attacks with full wrath...", "Forward" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Juventus" });

            migrationBuilder.InsertData(
                table: "Playas",
                columns: new[] { "Id", "FirstName", "ImageUrl", "IsNotInjured", "LastName", "PositionId", "TeamId" },
                values: new object[] { 1, "Gianluigi", "https://s.hs-data.com/bilder/spieler/gross/1337.jpg", true, "Buffon", 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Playas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
