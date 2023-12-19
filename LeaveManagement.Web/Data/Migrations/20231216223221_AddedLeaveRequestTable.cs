using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedLeaveRequestTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d3e459d-d328-4c1b-bf08-e039f322e9ee",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee54a822-885c-4941-a3a0-f6720b2c91fa", new DateTime(2023, 12, 16, 16, 32, 17, 755, DateTimeKind.Local).AddTicks(6416), "AQAAAAIAAYagAAAAECr2JqK7aYpTlbScUhOS6ft/NvJIGERDfoKLZ7h9ihOdF2s607vQIB13JwlJcb1Qgg==", "1950af86-87c1-4ea2-8597-6705e7ddd6ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12ef8ca0-5f8f-4ae9-b931-51d00e068f9f",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5250c473-2b85-458e-862e-c7be7de9148a", new DateTime(2023, 12, 16, 16, 32, 18, 65, DateTimeKind.Local).AddTicks(4978), "AQAAAAIAAYagAAAAEM4TBVCDG07rzHSJ0XTjJ7Nz7+MIwoQI0MHfklJOLADLZ64l+XTRyxAe+WqZ+YDj6g==", "59242fef-c005-4895-8c2d-74766a2fcdac" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d3e459d-d328-4c1b-bf08-e039f322e9ee",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29fef8d0-747c-45bf-9cc0-021a877a0e0f", new DateTime(2023, 12, 10, 14, 39, 59, 720, DateTimeKind.Local).AddTicks(9154), "AQAAAAIAAYagAAAAEB+cYsjXQH8MHYspZqW3XpemHJpBxVFr8J0yXLewx7uoDQ4mElPGwMWDCZ8/7DjpNQ==", "417111c8-9a80-41b1-8c7f-d90563547cb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12ef8ca0-5f8f-4ae9-b931-51d00e068f9f",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e836c2ff-73eb-4f1f-b043-4454eb94bd61", new DateTime(2023, 12, 10, 14, 39, 59, 897, DateTimeKind.Local).AddTicks(7048), "AQAAAAIAAYagAAAAEJk2LOIFwsmlOw9bmE31fp9eW+9dpO3cnBvLYAbJ6gQJOsEiv0d8WVi+hm2EUNg3/w==", "81e1bc80-d788-42ce-8097-82a89c7241de" });
        }
    }
}
