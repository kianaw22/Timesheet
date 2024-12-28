using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Counter",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "Family",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "PositionCode",
                table: "Position",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PersonelCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Counter_Table",
                columns: table => new
                {
                    Counter = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counter_Table", x => x.Counter);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PersonelCode", "SecurityStamp" },
                values: new object[] { "a96bdf9b-73ec-4d5d-8951-7bee34e41636", "AQAAAAIAAYagAAAAELXiOhyIkpKwt13hsxG5Reb0U5t8oSTCAO1cxUV6A4QdRyvH+jWw2OJ5lNrFchET/g==", null, "94870a7f-9bea-4dda-b874-3e507c6dd7b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PersonelCode", "SecurityStamp" },
                values: new object[] { "4d064f4f-d325-4a01-8989-ca21400d4193", "AQAAAAIAAYagAAAAEBmziULuZtoX4jWyxnXcTy17iruqGP8mJD9C9zt6wEDoUy03ThSnbcsJEXnEY8VnCw==", null, "271e50e5-6d9f-4ddd-b128-ac1d2cf1ad0e" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Counter_Table");

            migrationBuilder.DropColumn(
                name: "PositionCode",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "PersonelCode",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "Counter",
                table: "Position",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Family",
                table: "Position",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Position",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Position",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PositionId", "SecurityStamp" },
                values: new object[] { "eaca700b-b29f-4344-9072-b09c76bc6dd2", "AQAAAAIAAYagAAAAELrUgbEXh9fwL9Dm/Q3DVge3nLmNPl3bgbewvfRYiem5eHRy5ap2t0p/7gBesQgk9g==", null, "e131a6b9-73d9-4cda-8da5-a8be48556de7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "PositionId", "SecurityStamp" },
                values: new object[] { "f9e71b08-7deb-47e8-99b6-1a720311a2aa", "AQAAAAIAAYagAAAAEIVOWRA7FsQTcb30NKLcdVdFrYT9D0I8Py1l2+Tcpqj5kuzC6e4lQMXdp1AH/rnEKA==", null, "86c3b249-4ad1-49cd-95ae-e3508ca8a39b" });
        }
    }
}
