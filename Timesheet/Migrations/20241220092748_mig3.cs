using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PositionCode",
                table: "Position",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c180cfd3-00b1-4454-8df7-7c485ef67f3b", "AQAAAAIAAYagAAAAEFDQ+xH76FSOhYmZ1JTFK2IxnwqWAVKXNfTxG6sic9exE414ey14dBkv8vHJmwcgzQ==", "c0fd8d87-c0a3-4699-8d2e-d7815c6f0e8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c621e300-e916-4eb1-bba1-d51c24193c92", "AQAAAAIAAYagAAAAEH5mBGc7iyCJEXM8+ZkTVkRg4QKknWl8GLcuQfKfEZ+vQ1zz/dnUnuIGVcefW3W92w==", "bc15da05-3eb4-4d1c-bccd-86b5da4c7b9f" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PositionCode",
                table: "Position",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a96bdf9b-73ec-4d5d-8951-7bee34e41636", "AQAAAAIAAYagAAAAELXiOhyIkpKwt13hsxG5Reb0U5t8oSTCAO1cxUV6A4QdRyvH+jWw2OJ5lNrFchET/g==", "94870a7f-9bea-4dda-b874-3e507c6dd7b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d064f4f-d325-4a01-8989-ca21400d4193", "AQAAAAIAAYagAAAAEBmziULuZtoX4jWyxnXcTy17iruqGP8mJD9C9zt6wEDoUy03ThSnbcsJEXnEY8VnCw==", "271e50e5-6d9f-4ddd-b128-ac1d2cf1ad0e" });
        }
    }
}
