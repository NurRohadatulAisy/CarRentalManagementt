using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagementt.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "7714a6e3-970d-4e57-864f-7595cd83ab81", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEHDHwGHUL+RGZslyhT5FvtNaGPKJdRmjm3NjiNdftLIVV838BqQy5IrVF5PfyexB+g==", null, false, "7459066c-3676-4f83-ae7a-4d2bbde0cba4", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 28, 16, 14, 53, 820, DateTimeKind.Local).AddTicks(215), new DateTime(2023, 11, 28, 16, 14, 53, 820, DateTimeKind.Local).AddTicks(230), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 28, 16, 14, 53, 820, DateTimeKind.Local).AddTicks(234), new DateTime(2023, 11, 28, 16, 14, 53, 820, DateTimeKind.Local).AddTicks(235), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 28, 16, 14, 53, 820, DateTimeKind.Local).AddTicks(681), new DateTime(2023, 11, 28, 16, 14, 53, 820, DateTimeKind.Local).AddTicks(682), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 28, 16, 14, 53, 820, DateTimeKind.Local).AddTicks(684), new DateTime(2023, 11, 28, 16, 14, 53, 820, DateTimeKind.Local).AddTicks(685), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 28, 16, 14, 53, 820, DateTimeKind.Local).AddTicks(951), new DateTime(2023, 11, 28, 16, 14, 53, 820, DateTimeKind.Local).AddTicks(952), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 28, 16, 14, 53, 820, DateTimeKind.Local).AddTicks(953), new DateTime(2023, 11, 28, 16, 14, 53, 820, DateTimeKind.Local).AddTicks(954), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 28, 16, 14, 53, 820, DateTimeKind.Local).AddTicks(955), new DateTime(2023, 11, 28, 16, 14, 53, 820, DateTimeKind.Local).AddTicks(956), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 28, 16, 14, 53, 820, DateTimeKind.Local).AddTicks(957), new DateTime(2023, 11, 28, 16, 14, 53, 820, DateTimeKind.Local).AddTicks(958), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
