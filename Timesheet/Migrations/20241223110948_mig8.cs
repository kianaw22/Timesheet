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
            migrationBuilder.AddColumn<bool>(
                name: "BusDpt",
                table: "Timesheet",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33bfa873-4803-49ca-b922-72bbb5a2f8bd", "AQAAAAIAAYagAAAAEGAMnTqOLvjreVCpRN6hPEwaUDc646PKKZ/aqOuD588quW/9XWGcIBqw2licZ3r7tg==", "780df6e4-63ae-4ef5-93f8-4292dccc581d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa11aeed-d4f4-494c-aaa3-7e475e0e2fe8", "AQAAAAIAAYagAAAAEBk1cMoltRRURJ5bvq1cSTK4unYwNgaLEzuSdEVWuXeOgWS5q9PvupgeYi1LY1p9Kw==", "9a7c19d6-af65-48d0-903a-3cb368da2136" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BusDpt",
                table: "Timesheet");

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
    }
}
