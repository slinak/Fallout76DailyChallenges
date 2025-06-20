using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FODailyChallenges.Migrations
{
    /// <inheritdoc />
    public partial class FixedDatabaseTableNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resolution_Challenge_DailyChallengeChallengeID",
                table: "Resolution");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resolution",
                table: "Resolution");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Challenge",
                table: "Challenge");

            migrationBuilder.RenameTable(
                name: "Resolution",
                newName: "Resolutions");

            migrationBuilder.RenameTable(
                name: "Challenge",
                newName: "Challenges");

            migrationBuilder.RenameIndex(
                name: "IX_Resolution_DailyChallengeChallengeID",
                table: "Resolutions",
                newName: "IX_Resolutions_DailyChallengeChallengeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resolutions",
                table: "Resolutions",
                column: "ResolutionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Challenges",
                table: "Challenges",
                column: "ChallengeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Resolutions_Challenges_DailyChallengeChallengeID",
                table: "Resolutions",
                column: "DailyChallengeChallengeID",
                principalTable: "Challenges",
                principalColumn: "ChallengeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resolutions_Challenges_DailyChallengeChallengeID",
                table: "Resolutions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Resolutions",
                table: "Resolutions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Challenges",
                table: "Challenges");

            migrationBuilder.RenameTable(
                name: "Resolutions",
                newName: "Resolution");

            migrationBuilder.RenameTable(
                name: "Challenges",
                newName: "Challenge");

            migrationBuilder.RenameIndex(
                name: "IX_Resolutions_DailyChallengeChallengeID",
                table: "Resolution",
                newName: "IX_Resolution_DailyChallengeChallengeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Resolution",
                table: "Resolution",
                column: "ResolutionID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Challenge",
                table: "Challenge",
                column: "ChallengeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Resolution_Challenge_DailyChallengeChallengeID",
                table: "Resolution",
                column: "DailyChallengeChallengeID",
                principalTable: "Challenge",
                principalColumn: "ChallengeID");
        }
    }
}
