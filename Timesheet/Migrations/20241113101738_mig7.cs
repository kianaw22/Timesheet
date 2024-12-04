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
            migrationBuilder.DropColumn(
                name: "Formula",
                table: "Position");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Formula",
                table: "Position",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8262fc66-2ed5-48af-b4f0-fd9ddea20f68", "AQAAAAIAAYagAAAAEI15OkepJeS66/YDOfp4danx6jne964MpZKosUcMf4saFMxqtKgZtqu5T5azU/3d6A==", "8173d295-0f7a-4434-92b2-10ec760c0bd8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da49aa87-24a8-492f-a467-95d9d9ff8232", "AQAAAAIAAYagAAAAELgm1k0yXBQUbqHUPITn3x3146MllWMRNHb5qdtLBx4ofvkPRdWCfDCoGxXLTiesuw==", "b474350a-8ee5-4734-ad31-379f01c3be9e" });
        }
    }
}
