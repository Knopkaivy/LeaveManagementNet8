using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedForeignKeyToLeaveAllocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
