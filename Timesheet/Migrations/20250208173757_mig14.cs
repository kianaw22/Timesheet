using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Migrations
{
    /// <inheritdoc />
    public partial class mig14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Date",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Date", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0eb4ebaf-a5ee-4a1d-90a8-a887d0a559d4", "AQAAAAIAAYagAAAAEK0TIH6uAa3PrxHFOIML3cZoyEc4MdGirbymGxGbSIInPq45QB0rzKLOtUmcjazSGQ==", "944665ab-4a48-40ce-81ab-af79ef9c3dd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a13e5111-8618-44dd-b535-1b76ed524ee7", "AQAAAAIAAYagAAAAEDznCRuWs5r4osIxQxfYbZUDAoNHv6WQ88uU2ghwDFcYWLZRy4qwxqTeVQgAuzpYdA==", "e5e149a7-10fc-4e19-ac97-e71917157136" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Date");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "758bb984-ab9f-451f-b1ee-9733fb45aaf8", "AQAAAAIAAYagAAAAEMegz6A4cM/ygRf7r5tKpR8nngpIpg/HL+VKZjgC7doBWKONll4qSGgr0qL6VX9p5Q==", "9d61736e-40c9-42a0-be4b-071740a996d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd7fe134-1300-47c4-b373-470aed83d6d6", "AQAAAAIAAYagAAAAEIB+cCkGTEjN+Ggv3WbtvNqnhTYovr6SMlqY6YAmMBToVJegoYk9EggV5Nfc5cmMyQ==", "dc03a6ca-2fa3-438c-95a0-29dd1fb9a599" });
        }
    }
}
