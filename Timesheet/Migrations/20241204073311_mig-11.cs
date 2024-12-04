using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Migrations
{
    /// <inheritdoc />
    public partial class mig11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Counter",
                table: "Position",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Signed",
                table: "Position",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0fb481f-5a8d-42b6-a8a3-94519ce7cda2", "AQAAAAIAAYagAAAAEAwvR+sWLtxEdXfDaTO+G9ThEk2kFwjiExBEw9BLKgbKy8GevH7fXSSFEzVOdspYYw==", "627b2371-3a15-40b1-943c-0f3e2da62fc5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e9659d8-cfd5-43f3-86c3-b757dfb4fcfe", "AQAAAAIAAYagAAAAECQfBJbgmZkZ3pZ3LjKn3eNvqpjUXaz/+aI/SPhSJOmIx53mnQFbUiK6qmQRNt6Nyw==", "a1354825-2b58-46f9-8b9b-792fb7ae2063" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Counter",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "Signed",
                table: "Position");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "374dcca6-5af7-4fde-90e2-d3ed628334d8", "AQAAAAIAAYagAAAAEPs7LEVutWMA3VhSyiKMfywk/XNJMq8xg9X60NmyuwoWlMtD617PxeCG0rOgmfREqg==", "9710bf88-90f9-432a-ac2d-6200e3a95f4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3991a9c9-c18b-4445-99f6-0c10dbfc1921", "AQAAAAIAAYagAAAAEBTQDVir+40TYssE/U5oCBjYGFrp+yhSKhTh+OyL4koBcHG4hrSs2UJa1qDnruPPiA==", "511b99e5-3f29-4edd-bfd2-54139a1c01c2" });
        }
    }
}
