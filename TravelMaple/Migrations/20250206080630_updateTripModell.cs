using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelMaple.Migrations
{
    /// <inheritdoc />
    public partial class updateTripModell : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Trip",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Trip");

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 5, 12, 59, 17, 820, DateTimeKind.Local).AddTicks(9059), new DateTime(2025, 2, 5, 12, 59, 17, 820, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 5, 12, 59, 17, 820, DateTimeKind.Local).AddTicks(9066), new DateTime(2025, 2, 5, 12, 59, 17, 820, DateTimeKind.Local).AddTicks(9065) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 5, 12, 59, 17, 820, DateTimeKind.Local).AddTicks(9069), new DateTime(2025, 2, 5, 12, 59, 17, 820, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "TransportMode",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 5, 12, 59, 17, 820, DateTimeKind.Local).AddTicks(9527), new DateTime(2025, 2, 5, 12, 59, 17, 820, DateTimeKind.Local).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "TransportMode",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 5, 12, 59, 17, 820, DateTimeKind.Local).AddTicks(9532), new DateTime(2025, 2, 5, 12, 59, 17, 820, DateTimeKind.Local).AddTicks(9531) });

            migrationBuilder.UpdateData(
                table: "TransportMode",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2025, 2, 5, 12, 59, 17, 820, DateTimeKind.Local).AddTicks(9536), new DateTime(2025, 2, 5, 12, 59, 17, 820, DateTimeKind.Local).AddTicks(9535) });
        }
    }
}
