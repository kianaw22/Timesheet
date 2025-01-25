using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Migrations
{
    /// <inheritdoc />
    public partial class mig13 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PersonelCode",
                table: "Timesheet",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PersonelCode",
                table: "Timesheet");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3545ff75-6b2e-431b-97d5-6530e6740d15", "AQAAAAIAAYagAAAAEKEvl59PIfhW8ihsZUzxoWo9yHipcOJiJ3ANvKzNtmFO0DkK7hbl3VBH76Pruh/kaA==", "bdaf0fb0-44c7-405b-93a6-eb806600c94d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01d78148-3a7d-41a6-9b47-c221c7e87935", "AQAAAAIAAYagAAAAEAueb0xYphgWjFVISM6xttqqlqel1uRfijCs3086o1CFci7grWacQf585Is/7scS5g==", "3ca62b0d-4689-4753-b082-daf48a6f04b6" });
        }
    }
}
