using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BettingGrid.API.Migrations
{
    public partial class AddedNewRecordInEventsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2020, 3, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2020, 3, 12, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "AwaySideOdds", "DrawOdds", "EventName", "HomeSideOdds", "StartDate" },
                values: new object[] { 5, 2.50m, 3.60m, "CSKA - Liverpool", 3.20m, new DateTime(1982, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2020, 3, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2020, 4, 2, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2020, 3, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2020, 3, 11, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
