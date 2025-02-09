using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelMaple.Migrations
{
    /// <inheritdoc />
    public partial class feedback : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 19, 33, 722, DateTimeKind.Local).AddTicks(5189), new DateTime(2025, 2, 9, 21, 19, 33, 722, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 19, 33, 722, DateTimeKind.Local).AddTicks(5194), new DateTime(2025, 2, 9, 21, 19, 33, 722, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 9, 21, 19, 33, 722, DateTimeKind.Local).AddTicks(5197), new DateTime(2025, 2, 9, 21, 19, 33, 722, DateTimeKind.Local).AddTicks(5196) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedback");

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
        }
    }
}
