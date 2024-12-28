using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Migrations
{
    /// <inheritdoc />
    public partial class mig10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Counter_Table",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counter_Table", x => x.id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Counter_Table");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c88b9b1-af20-4b2d-b20e-832b1a153413", "AQAAAAIAAYagAAAAELzOCq+7rd+ozRG0d3g9Nsu1fmkDy50MNzflE0cQKoVXwFz2/GFTxDZGXu7DPuY8hg==", "5457aa03-34a4-4c75-b344-8c021de92856" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3190c211-0efe-437f-aa70-d27e1f9f7eb7", "AQAAAAIAAYagAAAAEOTPIBq9zR3bwn8WAP5HInT18poT2eX19vSDJbDq97KBPIMQaRFbxfR0bCu84ZGFsA==", "adff24f3-d148-46e0-8da4-adbc7ff2afb9" });
        }
    }
}
