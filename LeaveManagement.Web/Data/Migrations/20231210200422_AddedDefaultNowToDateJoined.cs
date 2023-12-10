using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultNowToDateJoined : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateJoined",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d3e459d-d328-4c1b-bf08-e039f322e9ee",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0052771-e090-4a91-b8c2-3e9f8967300e", new DateTime(2023, 12, 10, 14, 4, 20, 702, DateTimeKind.Local).AddTicks(3415), "AQAAAAIAAYagAAAAEA/rWNsFwJqXBhuRbjhET9qLoJF6pFrsuj2SI/yd/MAq7kvF1fdwNlpytkDfo21vaA==", "3a835bc5-becb-4867-9e17-6317d709d9c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12ef8ca0-5f8f-4ae9-b931-51d00e068f9f",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9451481a-4dea-42e8-b624-b98e4199fa95", new DateTime(2023, 12, 10, 14, 4, 20, 873, DateTimeKind.Local).AddTicks(6071), "AQAAAAIAAYagAAAAEMUYpRA2iMmAlLAowkEjlPeiT9dJ/8VHwAxpdeWii8hFT8S2vP7nnA9QeyTTSPCKew==", "40f30987-3edb-4cd1-b91e-1bc3ad9ef1c4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateJoined",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d3e459d-d328-4c1b-bf08-e039f322e9ee",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cef4071-9049-4214-8a7a-4d374f9fe00b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAIAAYagAAAAEEPhA5X8dEE7CSdemBHID5u5mNVTACXZhLz9gKHYiS267iWdurGTVKOz4EuZASJg7A==", "82a74153-1f3e-4ef0-80dd-0288d7b23459" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12ef8ca0-5f8f-4ae9-b931-51d00e068f9f",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05867c51-c0ac-4df9-92a0-f5dececf277e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAIAAYagAAAAEFTsrvOx8sWb6NNA3jIc9i6GjfKZQ92O2eaFl66mugp4y817lN1RpgjLOrFU32wnJw==", "7bda8a52-e6f6-41d4-b39b-558248bc7a38" });
        }
    }
}
