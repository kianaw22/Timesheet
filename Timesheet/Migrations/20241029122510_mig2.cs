using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Migrations
{
    /// <inheritdoc />
    public partial class mig2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02b052de-cce9-457d-ace0-ba79aab47a07", "ADMIN", "AQAAAAIAAYagAAAAEAmCLE49qixIFbYNChsF9xBmyW9+YzSTKR6h/lwuhQ2MAptjJPmZHMXaXWUF1lmHlg==", "9ec637ee-443c-4dfc-9627-e7fe40fe1311" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9496c43-c0d0-4582-81a9-c5c7c46587e6", "USER", "AQAAAAIAAYagAAAAEDjNmeVeXAtu/pwYSDkuMMUxpn/aKFJ4veDamcUhV8hyV99hf37igU5jv6WF1tRsFw==", "67a67924-e497-4dcd-a6ad-799454149203" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4ca62bd-3c1d-4e23-82c5-8dec2ce742a7", null, "AQAAAAIAAYagAAAAENdXSJIsbtKKCxuAoP3OvrFnx9rMie5GnOeU6lOKa6EWX8bE4i0hfHuCvwjYZe/5nw==", "ded867d2-31f4-41e0-b7ee-9c033a108c54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "729b3371-379d-4c27-8eb3-a63eb29c19bb", null, "AQAAAAIAAYagAAAAEClHN9q3lXDspBSeuYlJvY6doweB6m8/itkZin2Ye1XiB9VrCBTsJkAnKowRXGa+dg==", "d71ec27f-35b8-4eef-ae26-f0c26a542afc" });
        }
    }
}
