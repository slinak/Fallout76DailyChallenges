﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FODailyChallenges.Migrations
{
    /// <inheritdoc />
    public partial class PerhapsLastTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ChallengeID",
                table: "Resolutions",
                type: "uniqueidentifier",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChallengeID",
                table: "Resolutions");
        }
    }
}
