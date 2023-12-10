using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersAndUsernames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d3e459d-d328-4c1b-bf08-e039f322e9ee",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2cef4071-9049-4214-8a7a-4d374f9fe00b", true, "TEST2@TEST.COM", "AQAAAAIAAYagAAAAEEPhA5X8dEE7CSdemBHID5u5mNVTACXZhLz9gKHYiS267iWdurGTVKOz4EuZASJg7A==", "82a74153-1f3e-4ef0-80dd-0288d7b23459", "test2@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12ef8ca0-5f8f-4ae9-b931-51d00e068f9f",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "05867c51-c0ac-4df9-92a0-f5dececf277e", true, "TATA@TATA.COM", "AQAAAAIAAYagAAAAEFTsrvOx8sWb6NNA3jIc9i6GjfKZQ92O2eaFl66mugp4y817lN1RpgjLOrFU32wnJw==", "7bda8a52-e6f6-41d4-b39b-558248bc7a38", "tata@tata.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d3e459d-d328-4c1b-bf08-e039f322e9ee",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "84084fab-934b-484d-a86f-fb62d9086b48", false, null, "AQAAAAIAAYagAAAAEIAKaj5tHvDUJeLOzwBm8S2sErwpekIz5V694wxJXY9TAUSzHzlRr08z419IV45B0Q==", "10778df8-4162-4570-a2a6-2f63f19cf560", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12ef8ca0-5f8f-4ae9-b931-51d00e068f9f",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "85cd6801-26d2-4a51-844c-54589f3d8573", false, null, "AQAAAAIAAYagAAAAEB9I+vbnf8rnhP1RvssI84y1jXj6GU6YQF/NgSU29yWM5X6l/avRd/XwI17PvyfFng==", "982250f3-960b-4109-b55d-5d07e96718d1", null });
        }
    }
}
