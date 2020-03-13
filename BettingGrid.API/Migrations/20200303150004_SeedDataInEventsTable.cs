using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BettingGrid.API.Migrations
{
    public partial class SeedDataInEventsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "AwaySideOdds", "DrawOdds", "EventName", "HomeSideOdds", "StartDate" },
                values: new object[,]
                {
                    { 1, 1.60m, 3.65m, "Chelsea - Liverpool", 2.80m, new DateTime(2020, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 2, 1.40m, 14.50m, "Wilder - Fury", 4.50m, new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 3, 5.50m, 3.50m, "Inter - Ludogorets", 1.45m, new DateTime(2020, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 4, 2.60m, 3.45m, "Barcelona - Real Madrid", 2.30m, new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
