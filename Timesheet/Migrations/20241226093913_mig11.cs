using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Migrations
{
    /// <inheritdoc />
    public partial class mig11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Counter",
                table: "Counter_Table",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Counter",
                table: "Counter_Table");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49959b08-713b-4b6e-a429-eca6fe6529ce", "AQAAAAIAAYagAAAAEDKlNjSBXU+drw//LxhmFT5E4iZqlW+gaaXxZBHZmzff2GHuGc18Dr13Rs63tIyhPw==", "765af3ce-3b9f-49e6-a0bd-593a61cb9baf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80ebf3aa-c82a-4fa0-8dfa-cdc88cddd89c", "AQAAAAIAAYagAAAAEGsSIs2zym5yYcAp3FTemJ4AV/2x7jvTD9fH8N1p4SNcuBs1Y8sfGmt8+7cSvimPTw==", "caa29b0b-5f77-44a2-8199-3f69b727f727" });
        }
    }
}
