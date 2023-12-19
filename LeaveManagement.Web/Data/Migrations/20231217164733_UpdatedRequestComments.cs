using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRequestComments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d3e459d-d328-4c1b-bf08-e039f322e9ee",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98f44de3-2655-4641-8331-0a32cb300180", new DateTime(2023, 12, 17, 10, 47, 30, 988, DateTimeKind.Local).AddTicks(5794), "AQAAAAIAAYagAAAAEKp2mEWbN493S1ow388+x5IMACQ/4v9oGFADOJOo8bNtgX0i/aTgTaBslaeNu3slCA==", "ac637f86-07b5-435f-8494-f6fc18cf56bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12ef8ca0-5f8f-4ae9-b931-51d00e068f9f",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0c248c5-b001-4447-a458-00b4e378bb40", new DateTime(2023, 12, 17, 10, 47, 31, 127, DateTimeKind.Local).AddTicks(197), "AQAAAAIAAYagAAAAEMYCX0mOGWDCGxG9jmPgzwqt5WK7HOXD5+E15lZ/dEcSplDeZatA603SXA5mWF+KQA==", "f4414dff-8bcb-4199-96d8-7248533eb64b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
        }
    }
}
