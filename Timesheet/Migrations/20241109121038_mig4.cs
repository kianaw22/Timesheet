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
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Posiiton",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Posiiton",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5255519e-913c-4dc2-8d2e-995fd706b24e", "AQAAAAIAAYagAAAAEJU01Bb7Ioi44RmtrBXpGSUWIsk7mbRfC1giGWp/95bEGKBDOHyCRCd5HPkGoyfXGg==", "fe8a74c3-ac6e-41f9-8861-b5c5ad1bcc9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25c76733-80fb-4480-b3b3-eff8aa0c1dcd", "AQAAAAIAAYagAAAAEDd+nJ0ABs37riO737RvWnMij0PT2ZuHqP1cORPhWFhM/cFM4dwrnH+l6Az7Isk3gA==", "6806f002-ed53-41ea-b08f-25d73652792c" });
        }
    }
}
