using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedPeriodToLeaveAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d3e459d-d328-4c1b-bf08-e039f322e9ee",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcb86e89-ac43-4e6d-8171-944584fdfacb", new DateTime(2023, 12, 10, 14, 35, 47, 204, DateTimeKind.Local).AddTicks(2992), "AQAAAAIAAYagAAAAEAAFMvPS6ceX8CH0akuPSFHPfESiY+CZHX3pXM+yhe0bsexVQB/tFJLslCouo9plPA==", "0ee2042c-4667-4991-b660-2bec614c97a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12ef8ca0-5f8f-4ae9-b931-51d00e068f9f",
                columns: new[] { "ConcurrencyStamp", "DateJoined", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbc87ee8-9956-4ece-87a8-1834c0e86e4b", new DateTime(2023, 12, 10, 14, 35, 47, 358, DateTimeKind.Local).AddTicks(3863), "AQAAAAIAAYagAAAAEIMk3szPnCfU/tCUnEhufTjEyTkO+CGQMCnO/wrr7fHa9CbvbdOtHWXNXQ7jy+3qhw==", "3455d29f-79a7-4077-9088-bd0d9e76b24e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
    }
}
