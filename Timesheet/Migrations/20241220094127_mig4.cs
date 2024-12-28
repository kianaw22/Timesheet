using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fa09c28-c4e5-49bb-9980-fd9a509a63b3", "AQAAAAIAAYagAAAAEKltCmE20E0ce0xvfHkyK8e2EPV4qbzRJcC5gPjkQfNkYu/R/GlSG3kNaX5qQbRUGg==", "36501414-060f-4b48-8afb-a731dc276743" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d176fb5-d360-4be4-af7b-87916a2c673e", "AQAAAAIAAYagAAAAEI9uHBVDwdrMMX2zyKOnff6mtyi2kYk4BLtDBg4joDdXwk5i6ycDhCBRwXRvE1ASaw==", "992a2b81-c93b-405d-b07c-436586eaed62" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
