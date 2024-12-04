using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Migrations
{
    /// <inheritdoc />
    public partial class mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Filtering",
                table: "Position",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Grouping",
                table: "Position",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Position",
                type: "int",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Filtering",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "Grouping",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Position");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57a85d49-7ee5-4227-881e-e7b28d25c0f2", "AQAAAAIAAYagAAAAEFL3Vxe6/j7f1KaLkZOfhyLlk5I/f/DQ080oD79m5088nej2mVO8ODK6+ZAAXVg2AA==", "9ee28a94-5ca0-4812-aac8-960ce33e9e81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "130d7b8e-b6e5-4515-bcb7-d00e1f768371", "AQAAAAIAAYagAAAAECulyaNhpp5lQBmmvHX9sbrQwGVFx4IT99rzPZBzxzYuIDR2EV5Rs5z0GuVDbv1lZw==", "d148df9a-a82f-4700-bbb0-d7df7c93d485" });
        }
    }
}
