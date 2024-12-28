using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Timesheet.Migrations
{
    /// <inheritdoc />
    public partial class mig9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56d676bf-5e06-421e-b98c-fa8b326c0957", "AQAAAAIAAYagAAAAEFhEcISnXJ3PZQzDH46cCMosBWfDRIBOsLR2D6lRNitQJcG17o1ZS03iKsPIU2uh4A==", "4e8f7191-b783-49ba-a4e9-943b38f9d929" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "565be557-9d24-4882-91b9-d639cfcf14de", "AQAAAAIAAYagAAAAEIkbxNJsu1yz+waL153t9IGAHdPzh7kpwqT+0JIrrKr7ES7AkYmVJnXu+Uyvo/1sNg==", "23ca8807-3467-4e7c-8f2b-d93384bf12c1" });
        }
    }
}
