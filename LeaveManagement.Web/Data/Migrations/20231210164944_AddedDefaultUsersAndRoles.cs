using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d3e495d-d388-4c1b-bf88-e039f322e9ae", null, "User", "USER" },
                    { "41c3d13b-aa32-4cea-add9-166ab4875243", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0d3e459d-d328-4c1b-bf08-e039f322e9ee", 0, "84084fab-934b-484d-a86f-fb62d9086b48", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "test2@test.com", false, "System", "Admin", false, null, "TEST2@TEST.COM", null, "AQAAAAIAAYagAAAAEIAKaj5tHvDUJeLOzwBm8S2sErwpekIz5V694wxJXY9TAUSzHzlRr08z419IV45B0Q==", null, false, "10778df8-4162-4570-a2a6-2f63f19cf560", null, false, null },
                    { "12ef8ca0-5f8f-4ae9-b931-51d00e068f9f", 0, "85cd6801-26d2-4a51-844c-54589f3d8573", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tata@tata.com", false, "System", "User", false, null, "TATA@TATA.COM", null, "AQAAAAIAAYagAAAAEB9I+vbnf8rnhP1RvssI84y1jXj6GU6YQF/NgSU29yWM5X6l/avRd/XwI17PvyfFng==", null, false, "982250f3-960b-4109-b55d-5d07e96718d1", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "41c3d13b-aa32-4cea-add9-166ab4875243", "0d3e459d-d328-4c1b-bf08-e039f322e9ee" },
                    { "3d3e495d-d388-4c1b-bf88-e039f322e9ae", "12ef8ca0-5f8f-4ae9-b931-51d00e068f9f" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "41c3d13b-aa32-4cea-add9-166ab4875243", "0d3e459d-d328-4c1b-bf08-e039f322e9ee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3d3e495d-d388-4c1b-bf88-e039f322e9ae", "12ef8ca0-5f8f-4ae9-b931-51d00e068f9f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d3e495d-d388-4c1b-bf88-e039f322e9ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "41c3d13b-aa32-4cea-add9-166ab4875243");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d3e459d-d328-4c1b-bf08-e039f322e9ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12ef8ca0-5f8f-4ae9-b931-51d00e068f9f");
        }
    }
}
