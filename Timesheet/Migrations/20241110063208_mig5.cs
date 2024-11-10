using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Posiiton",
                table: "Posiiton");

            migrationBuilder.RenameTable(
                name: "Posiiton",
                newName: "Position");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Position",
                table: "Position",
                column: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Position",
                table: "Position");

            migrationBuilder.RenameTable(
                name: "Position",
                newName: "Posiiton");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posiiton",
                table: "Posiiton",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e92f017-b5fa-4121-8f6a-cf11a1fa311c", "AQAAAAIAAYagAAAAEAn01Xyf2i0T5qMiPklJX0bIMiuPLBARI7wrVo2NXnfsVfY55ryJUIpyuJ1cBYtmCA==", "c92f93f6-9506-4d84-9aaa-41e22bff318e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "890cbe87-233b-41f7-8934-d6a81f96d719", "AQAAAAIAAYagAAAAEMHxaFvc/Qawft2CdQ9WyKVR5xf5cvDUQWa9URGRXtWqeQjgeQFmmD+tuJY+qaoUqA==", "ad10d1be-440f-4f1d-9273-738d0630ee19" });
        }
    }
}
