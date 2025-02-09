using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelMaple.Migrations
{
    /// <inheritdoc />
    public partial class datecreateUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Make");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Trip",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Trip",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TransportMode",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 31, 28, 470, DateTimeKind.Local).AddTicks(8434), new DateTime(2025, 2, 9, 22, 31, 28, 470, DateTimeKind.Local).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "TransportMode",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 31, 28, 470, DateTimeKind.Local).AddTicks(8439), new DateTime(2025, 2, 9, 22, 31, 28, 470, DateTimeKind.Local).AddTicks(8438) });

            migrationBuilder.UpdateData(
                table: "TransportMode",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 9, 22, 31, 28, 470, DateTimeKind.Local).AddTicks(8441), new DateTime(2025, 2, 9, 22, 31, 28, 470, DateTimeKind.Local).AddTicks(8441) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Trip");

            migrationBuilder.CreateTable(
                name: "Make",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Make", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "EndDate", "Name", "StartDate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 9, 21, 19, 33, 722, DateTimeKind.Local).AddTicks(5189), "Hotel", new DateTime(2025, 2, 9, 21, 19, 33, 722, DateTimeKind.Local).AddTicks(5170), "System" },
                    { 2, "System", new DateTime(2025, 2, 9, 21, 19, 33, 722, DateTimeKind.Local).AddTicks(5194), "Resort", new DateTime(2025, 2, 9, 21, 19, 33, 722, DateTimeKind.Local).AddTicks(5193), "System" },
                    { 3, "System", new DateTime(2025, 2, 9, 21, 19, 33, 722, DateTimeKind.Local).AddTicks(5197), "B&B", new DateTime(2025, 2, 9, 21, 19, 33, 722, DateTimeKind.Local).AddTicks(5196), "System" }
                });

            migrationBuilder.UpdateData(
                table: "TransportMode",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 19, 33, 722, DateTimeKind.Local).AddTicks(5562), new DateTime(2025, 2, 9, 21, 19, 33, 722, DateTimeKind.Local).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "TransportMode",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 19, 33, 722, DateTimeKind.Local).AddTicks(5566), new DateTime(2025, 2, 9, 21, 19, 33, 722, DateTimeKind.Local).AddTicks(5565) });

            migrationBuilder.UpdateData(
                table: "TransportMode",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 19, 33, 722, DateTimeKind.Local).AddTicks(5569), new DateTime(2025, 2, 9, 21, 19, 33, 722, DateTimeKind.Local).AddTicks(5568) });
        }
    }
}
