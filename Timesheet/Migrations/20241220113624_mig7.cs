using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Migrations
{
    /// <inheritdoc />
    public partial class mig7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "NormalizedName",
                value: "ADMIN");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "NormalizedName",
                value: "USER");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4d15ac5-bb4c-4e0f-adf0-6d828923b7e1", "AQAAAAIAAYagAAAAEA47dWmoolotjFW25v1F9hfNwnqHcOZmkSRT4U+3oC5vFOoCmSwwbZk9S1mLYUhmZg==", "958a20a7-6843-4b8b-be74-d0b0861472ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "891abfda-3d33-4b09-8bc6-fa39ffa5b3df", "AQAAAAIAAYagAAAAEBqjPG5M856nrl/jwiRmA+3uhr1wlsDk8ITHXwlz6Ll57RfnR4YbWmhU/K9BBaoDxw==", "24e85d1f-3f13-442d-a28c-2d4f875326d7" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "NormalizedName",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "NormalizedName",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52ea8b02-16db-42e1-bdec-23c6a788a92d", "AQAAAAIAAYagAAAAELnDVKamOPmqpuxQs1JpLaOM0/kexZAhMgwtQSAqEPL2Oy4McglnJdF/75bNbhPWJQ==", "e5995642-8be2-4c6c-9424-4fd55973c535" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b279ffb9-6ad6-405d-bd78-6c1ae3103a03", "AQAAAAIAAYagAAAAELj3dgIGYGTZdarkiIqV9is2rLOsZPw5fkdwDAPs1y11Kwc7Ot3OPDvr7NLh2VQATg==", "e4583331-891c-4c3f-bc17-02df165acb1e" });
        }
    }
}
