using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelMaple.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransportMode");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "TravelMapleUser");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "TravelMapleUser");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "TravelMapleUser",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "TravelMapleUser",
                newName: "SecurityStamp");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "TravelMapleUser",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "TravelMapleUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "TravelMapleUser",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "TravelMapleUser",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "TravelMapleUser",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "TravelMapleUser",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "TravelMapleUser",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "TravelMapleUser",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "TravelMapleUser",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "TravelMapleUser",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "TravelMapleUser",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "TravelMapleUser",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "TravelMapleUser",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "TravelMapleUser");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "TravelMapleUser");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "TravelMapleUser");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "TravelMapleUser");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "TravelMapleUser");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "TravelMapleUser");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "TravelMapleUser");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "TravelMapleUser");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "TravelMapleUser");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "TravelMapleUser");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "TravelMapleUser");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "TravelMapleUser");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "TravelMapleUser",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "SecurityStamp",
                table: "TravelMapleUser",
                newName: "CreatedBy");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "TravelMapleUser",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "TravelMapleUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "TravelMapleUser",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "TransportMode",
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
                    table.PrimaryKey("PK_TransportMode", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TransportMode",
                columns: new[] { "Id", "CreatedBy", "EndDate", "Name", "StartDate", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 2, 9, 22, 31, 28, 470, DateTimeKind.Local).AddTicks(8434), "Air", new DateTime(2025, 2, 9, 22, 31, 28, 470, DateTimeKind.Local).AddTicks(8417), "System" },
                    { 2, "System", new DateTime(2025, 2, 9, 22, 31, 28, 470, DateTimeKind.Local).AddTicks(8439), "Land", new DateTime(2025, 2, 9, 22, 31, 28, 470, DateTimeKind.Local).AddTicks(8438), "System" },
                    { 3, "System", new DateTime(2025, 2, 9, 22, 31, 28, 470, DateTimeKind.Local).AddTicks(8441), "Sea", new DateTime(2025, 2, 9, 22, 31, 28, 470, DateTimeKind.Local).AddTicks(8441), "System" }
                });
        }
    }
}
