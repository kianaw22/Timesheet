using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Migrations
{
    /// <inheritdoc />
    public partial class mig12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Contract",
                table: "Timesheet",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PrjControl",
                table: "Timesheet",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contract",
                table: "Timesheet");

            migrationBuilder.DropColumn(
                name: "PrjControl",
                table: "Timesheet");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c20389d-caf4-485a-ab9b-5e0305ae17e7", "AQAAAAIAAYagAAAAEAmyGBPnOyK0lDGagdJp/0bXJutMuVH8PkJbLdlINN52cKcarrslgOF3s24jxpUhyw==", "59239826-458f-4105-9eac-1139eaf42bc6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ef6a32f-1fff-45d5-9e40-0c4111fbba08", "AQAAAAIAAYagAAAAEMjsM3tKnLKB6wo7j9Dmc3sWriVFYdVGjZrNCWGbvxBsmTLmcwPn9NEIqixKxla5rQ==", "73a19216-f3e1-4b0e-98cc-3f735b3bf762" });
        }
    }
}
