using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FODailyChallenges.Migrations
{
    /// <inheritdoc />
    public partial class TryingAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Challenges",
                columns: table => new
                {
                    ChallengeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChallengeType = table.Column<int>(type: "int", nullable: true),
                    ChallengeText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenges", x => x.ChallengeID);
                });

            migrationBuilder.CreateTable(
                name: "Resolutions",
                columns: table => new
                {
                    ResolutionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResolutionLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResolutionQuantity = table.Column<int>(type: "int", nullable: true),
                    ChallengeID = table.Column<int>(type: "int", nullable: true),
                    DailyChallengeChallengeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resolutions", x => x.ResolutionID);
                    table.ForeignKey(
                        name: "FK_Resolutions_Challenges_DailyChallengeChallengeID",
                        column: x => x.DailyChallengeChallengeID,
                        principalTable: "Challenges",
                        principalColumn: "ChallengeID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Resolutions_DailyChallengeChallengeID",
                table: "Resolutions",
                column: "DailyChallengeChallengeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resolutions");

            migrationBuilder.DropTable(
                name: "Challenges");
        }
    }
}
