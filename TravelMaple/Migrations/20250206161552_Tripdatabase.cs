using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelMaple.Migrations
{
    /// <inheritdoc />
    public partial class Tripdatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DestinationId",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "MakeId",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "TransportModeId",
                table: "Trip");

            migrationBuilder.CreateTable(
                name: "ItineraryDay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayNumber = table.Column<int>(type: "int", nullable: false),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItineraryDay", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItineraryDay_Trip_TripId",
                        column: x => x.TripId,
                        principalTable: "Trip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ItineraryDayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activity_ItineraryDay_ItineraryDayId",
                        column: x => x.ItineraryDayId,
                        principalTable: "ItineraryDay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 7, 0, 15, 50, 756, DateTimeKind.Local).AddTicks(5756), new DateTime(2025, 2, 7, 0, 15, 50, 756, DateTimeKind.Local).AddTicks(5732) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 7, 0, 15, 50, 756, DateTimeKind.Local).AddTicks(5760), new DateTime(2025, 2, 7, 0, 15, 50, 756, DateTimeKind.Local).AddTicks(5759) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 7, 0, 15, 50, 756, DateTimeKind.Local).AddTicks(5763), new DateTime(2025, 2, 7, 0, 15, 50, 756, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "TransportMode",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 7, 0, 15, 50, 756, DateTimeKind.Local).AddTicks(6150), new DateTime(2025, 2, 7, 0, 15, 50, 756, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "TransportMode",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 7, 0, 15, 50, 756, DateTimeKind.Local).AddTicks(6153), new DateTime(2025, 2, 7, 0, 15, 50, 756, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "TransportMode",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 7, 0, 15, 50, 756, DateTimeKind.Local).AddTicks(6156), new DateTime(2025, 2, 7, 0, 15, 50, 756, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.CreateIndex(
                name: "IX_Activity_ItineraryDayId",
                table: "Activity",
                column: "ItineraryDayId");

            migrationBuilder.CreateIndex(
                name: "IX_ItineraryDay_TripId",
                table: "ItineraryDay",
                column: "TripId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "ItineraryDay");

            migrationBuilder.AddColumn<int>(
                name: "DestinationId",
                table: "Trip",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MakeId",
                table: "Trip",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TransportModeId",
                table: "Trip",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 6, 29, 361, DateTimeKind.Local).AddTicks(3363), new DateTime(2025, 2, 6, 16, 6, 29, 361, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 6, 29, 361, DateTimeKind.Local).AddTicks(3366), new DateTime(2025, 2, 6, 16, 6, 29, 361, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 6, 29, 361, DateTimeKind.Local).AddTicks(3369), new DateTime(2025, 2, 6, 16, 6, 29, 361, DateTimeKind.Local).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "TransportMode",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 6, 29, 361, DateTimeKind.Local).AddTicks(3624), new DateTime(2025, 2, 6, 16, 6, 29, 361, DateTimeKind.Local).AddTicks(3623) });

            migrationBuilder.UpdateData(
                table: "TransportMode",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 6, 29, 361, DateTimeKind.Local).AddTicks(3627), new DateTime(2025, 2, 6, 16, 6, 29, 361, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "TransportMode",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 6, 16, 6, 29, 361, DateTimeKind.Local).AddTicks(3629), new DateTime(2025, 2, 6, 16, 6, 29, 361, DateTimeKind.Local).AddTicks(3628) });
        }
    }
}
