using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Migrations
{
    /// <inheritdoc />
    public partial class mig8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PostionName",
                table: "Position",
                newName: "PositionName");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fab3cc64-798a-4eda-a2c5-18be508d2e53", "AQAAAAIAAYagAAAAEOEBLsESl3uvhVQ8zPbSGxtSOuvca8L1ZoCO2T9sOfC4K0xgnlCw7WPv9x6iwrJHnA==", "5ff49df8-e7f8-4c4b-ae3d-e5175e4a8163" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c6ee096-a37b-40ae-8303-43cfaca8a49b", "AQAAAAIAAYagAAAAEFXF3KmEycD+OmxNNzYDYbCQMCKSAjdVI6wmtY3R8WW9rwkeBoXw14HbTzug3yXDAg==", "5b316ed4-e0e9-490c-9351-53fc5e782bf1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PositionName",
                table: "Position",
                newName: "PostionName");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "876a4482-af1b-4001-80fa-373f63c1e0b6", "AQAAAAIAAYagAAAAENdDEYkJGk0OReyaj89vMfH/bplr+vfVZOuirz1QXg2fPEsqL3zz7YJtLE/nV6HOCw==", "0eb81214-a6da-46e4-b77a-a531aa38b3d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05f2ebc3-9916-4535-9277-903b5f228eb1", "AQAAAAIAAYagAAAAEMYniN1pI27BE7swWYuUXHlpOUVv+ECQ2na/ij29QhudN3+OvgzrCvLXGONSvuR+wA==", "48f7e610-de00-406e-88f0-59aa91edec71" });
        }
    }
}
