using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelMaple.Migrations
{
    /// <inheritdoc />
    public partial class updateTripModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destination");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Trip",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Trip",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "TravelMapleUser",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "TravelMapleUser",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "TransportMode",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "TransportMode",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Make",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Make",
                newName: "EndDate");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Booking",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "DateCreated",
                table: "Booking",
                newName: "EndDate");

            migrationBuilder.AddColumn<string>(
                name: "Aim",
                table: "Trip",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "Trip",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstBudget",
                table: "Trip",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Aim",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "EstBudget",
                table: "Trip");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Trip",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Trip",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "TravelMapleUser",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "TravelMapleUser",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "TransportMode",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "TransportMode",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Make",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Make",
                newName: "DateCreated");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Booking",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "Booking",
                newName: "DateCreated");

            migrationBuilder.CreateTable(
                name: "Destination",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destination", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 4, 12, 21, 15, 105, DateTimeKind.Local).AddTicks(2868), new DateTime(2025, 2, 4, 12, 21, 15, 105, DateTimeKind.Local).AddTicks(2868), "Japan", "System" },
                    { 2, "System", new DateTime(2025, 2, 4, 12, 21, 15, 105, DateTimeKind.Local).AddTicks(2870), new DateTime(2025, 2, 4, 12, 21, 15, 105, DateTimeKind.Local).AddTicks(2871), "Italy", "System" },
                    { 3, "System", new DateTime(2025, 2, 4, 12, 21, 15, 105, DateTimeKind.Local).AddTicks(2873), new DateTime(2025, 2, 4, 12, 21, 15, 105, DateTimeKind.Local).AddTicks(2874), "USA", "System" }
                });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 12, 21, 15, 105, DateTimeKind.Local).AddTicks(2331), new DateTime(2025, 2, 4, 12, 21, 15, 105, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 12, 21, 15, 105, DateTimeKind.Local).AddTicks(2352), new DateTime(2025, 2, 4, 12, 21, 15, 105, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 12, 21, 15, 105, DateTimeKind.Local).AddTicks(2356), new DateTime(2025, 2, 4, 12, 21, 15, 105, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "TransportMode",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 12, 21, 15, 105, DateTimeKind.Local).AddTicks(2715), new DateTime(2025, 2, 4, 12, 21, 15, 105, DateTimeKind.Local).AddTicks(2716) });

            migrationBuilder.UpdateData(
                table: "TransportMode",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 12, 21, 15, 105, DateTimeKind.Local).AddTicks(2718), new DateTime(2025, 2, 4, 12, 21, 15, 105, DateTimeKind.Local).AddTicks(2719) });

            migrationBuilder.UpdateData(
                table: "TransportMode",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 2, 4, 12, 21, 15, 105, DateTimeKind.Local).AddTicks(2721), new DateTime(2025, 2, 4, 12, 21, 15, 105, DateTimeKind.Local).AddTicks(2722) });
        }
    }
}
