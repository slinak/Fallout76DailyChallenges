using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FODailyChallenges.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Challenge",
                columns: table => new
                {
                    ChallengeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChallengeType = table.Column<int>(type: "int", nullable: false),
                    ChallengeText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Challenge", x => x.ChallengeID);
                });

            migrationBuilder.CreateTable(
                name: "Resolution",
                columns: table => new
                {
                    ResolutionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChallengeID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResolutionLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResolutionQuantity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resolution", x => x.ResolutionID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Challenge");

            migrationBuilder.DropTable(
                name: "Resolution");
        }
    }
}
