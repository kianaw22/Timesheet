using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Migrations
{
    /// <inheritdoc />
    public partial class mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posiiton",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PositionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Formula = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posiiton", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posiiton");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02b052de-cce9-457d-ace0-ba79aab47a07", "AQAAAAIAAYagAAAAEAmCLE49qixIFbYNChsF9xBmyW9+YzSTKR6h/lwuhQ2MAptjJPmZHMXaXWUF1lmHlg==", "9ec637ee-443c-4dfc-9627-e7fe40fe1311" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9496c43-c0d0-4582-81a9-c5c7c46587e6", "AQAAAAIAAYagAAAAEDjNmeVeXAtu/pwYSDkuMMUxpn/aKFJ4veDamcUhV8hyV99hf37igU5jv6WF1tRsFw==", "67a67924-e497-4dcd-a6ad-799454149203" });
        }
    }
}
