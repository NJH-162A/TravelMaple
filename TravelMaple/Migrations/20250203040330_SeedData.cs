using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelMaple.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Trip");

            migrationBuilder.AddColumn<int>(
                name: "DestinationId",
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

            migrationBuilder.CreateTable(
                name: "Destination",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destination", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportMode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportMode", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 3, 12, 3, 29, 69, DateTimeKind.Local).AddTicks(3634), new DateTime(2025, 2, 3, 12, 3, 29, 69, DateTimeKind.Local).AddTicks(3635), "Japan", "System" },
                    { 2, "System", new DateTime(2025, 2, 3, 12, 3, 29, 69, DateTimeKind.Local).AddTicks(3637), new DateTime(2025, 2, 3, 12, 3, 29, 69, DateTimeKind.Local).AddTicks(3638), "Italy", "System" },
                    { 3, "System", new DateTime(2025, 2, 3, 12, 3, 29, 69, DateTimeKind.Local).AddTicks(3640), new DateTime(2025, 2, 3, 12, 3, 29, 69, DateTimeKind.Local).AddTicks(3640), "USA", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 3, 12, 3, 29, 69, DateTimeKind.Local).AddTicks(3167), new DateTime(2025, 2, 3, 12, 3, 29, 69, DateTimeKind.Local).AddTicks(3188), "Hotel", "System" },
                    { 2, "System", new DateTime(2025, 2, 3, 12, 3, 29, 69, DateTimeKind.Local).AddTicks(3191), new DateTime(2025, 2, 3, 12, 3, 29, 69, DateTimeKind.Local).AddTicks(3192), "Resort", "System" },
                    { 3, "System", new DateTime(2025, 2, 3, 12, 3, 29, 69, DateTimeKind.Local).AddTicks(3195), new DateTime(2025, 2, 3, 12, 3, 29, 69, DateTimeKind.Local).AddTicks(3196), "B&B", "System" }
                });

            migrationBuilder.InsertData(
                table: "TransportMode",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 3, 12, 3, 29, 69, DateTimeKind.Local).AddTicks(3489), new DateTime(2025, 2, 3, 12, 3, 29, 69, DateTimeKind.Local).AddTicks(3490), "Air", "System" },
                    { 2, "System", new DateTime(2025, 2, 3, 12, 3, 29, 69, DateTimeKind.Local).AddTicks(3493), new DateTime(2025, 2, 3, 12, 3, 29, 69, DateTimeKind.Local).AddTicks(3493), "Land", "System" },
                    { 3, "System", new DateTime(2025, 2, 3, 12, 3, 29, 69, DateTimeKind.Local).AddTicks(3495), new DateTime(2025, 2, 3, 12, 3, 29, 69, DateTimeKind.Local).AddTicks(3496), "Sea", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destination");

            migrationBuilder.DropTable(
                name: "TransportMode");

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "DestinationId",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "TransportModeId",
                table: "Trip");

            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "Trip",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
