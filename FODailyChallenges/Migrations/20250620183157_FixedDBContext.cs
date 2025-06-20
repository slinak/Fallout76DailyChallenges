using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FODailyChallenges.Migrations
{
    /// <inheritdoc />
    public partial class FixedDBContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DailyChallengeChallengeID",
                table: "Resolution",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Resolution_DailyChallengeChallengeID",
                table: "Resolution",
                column: "DailyChallengeChallengeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Resolution_Challenge_DailyChallengeChallengeID",
                table: "Resolution",
                column: "DailyChallengeChallengeID",
                principalTable: "Challenge",
                principalColumn: "ChallengeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resolution_Challenge_DailyChallengeChallengeID",
                table: "Resolution");

            migrationBuilder.DropIndex(
                name: "IX_Resolution_DailyChallengeChallengeID",
                table: "Resolution");

            migrationBuilder.DropColumn(
                name: "DailyChallengeChallengeID",
                table: "Resolution");
        }
    }
}
