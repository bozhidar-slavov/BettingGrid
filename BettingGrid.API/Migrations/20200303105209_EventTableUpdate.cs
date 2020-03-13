using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BettingGrid.API.Migrations
{
    public partial class EventTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AwaySideOdds",
                table: "Events",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "DrawOdds",
                table: "Events",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "HomeSideOdds",
                table: "Events",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Events",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwaySideOdds",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "DrawOdds",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "HomeSideOdds",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Events");
        }
    }
}
