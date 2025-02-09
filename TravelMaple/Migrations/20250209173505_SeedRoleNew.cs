using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelMaple.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoleNew : Migration
    {
        /// <inheritdoc />

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var hasher = new PasswordHasher<IdentityUser>();
            string passwordHash = hasher.HashPassword(null, "P@ssword1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "Name", "NormalizedName", "ConcurrencyStamp" },
                values: new object[,]
                {
            { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "Administrator", "ADMINISTRATOR", Guid.NewGuid().ToString() },
            { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "User", "USER", Guid.NewGuid().ToString() }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] {
            "Id",
            "UserName",
            "NormalizedUserName",
            "Email",
            "NormalizedEmail",
            "EmailConfirmed",
            "PasswordHash",
            "SecurityStamp",
            "ConcurrencyStamp",
            "PhoneNumber",
            "PhoneNumberConfirmed",
            "TwoFactorEnabled",
            "LockoutEnd",
            "LockoutEnabled",
            "AccessFailedCount",
            "FirstName",
            "LastName"
                },
                values: new object[] {
            "3781efa7-66dc-47f0-860f-e506d04102e4",
            "admin@localhost.com",
            "ADMIN@LOCALHOST.COM",
            "admin@localhost.com",
            "ADMIN@LOCALHOST.COM",
            true,
            passwordHash, // Use the valid hash generated above
            Guid.NewGuid().ToString(),
            Guid.NewGuid().ToString(),
            null,
            false,
            false,
            null,
            false,
            0,
            "Admin",
            "User"
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] {
            "3781efa7-66dc-47f0-860f-e506d04102e4",
            "ad2bcf0c-20db-474f-8407-5a6b159518ba"
                });
        }



        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
            table: "AspNetUserRoles",
            keyColumns: new[] { "UserId", "RoleId" },
            keyValues: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", "ad2bcf0c-20db-474f-8407-5a6b159518ba" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}

