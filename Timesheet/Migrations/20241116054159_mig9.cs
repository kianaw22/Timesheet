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
            migrationBuilder.CreateTable(
                name: "Timesheet",
                columns: table => new
                {
                    autoNumber = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    persCode = table.Column<int>(type: "int", nullable: false),
                    fName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    lName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    domainName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    userName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    discipline = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    prjCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    prjName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    phase = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    docCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    docName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    pPercent = table.Column<int>(type: "int", nullable: false),
                    missionM = table.Column<int>(type: "int", nullable: false),
                    homeWorkM = table.Column<int>(type: "int", nullable: false),
                    extraWork = table.Column<int>(type: "int", nullable: false),
                    vacationM = table.Column<int>(type: "int", nullable: false),
                    vacationPayM = table.Column<int>(type: "int", nullable: false),
                    delayPercM = table.Column<int>(type: "int", nullable: false),
                    iExitM = table.Column<int>(type: "int", nullable: false),
                    absenceM = table.Column<int>(type: "int", nullable: false),
                    overTimeM = table.Column<int>(type: "int", nullable: false),
                    dMWork = table.Column<float>(type: "real", nullable: false),
                    tMWork = table.Column<int>(type: "int", nullable: false),
                    timeSheetMWork = table.Column<int>(type: "int", nullable: false),
                    interTime = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    exitTime = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    dayOfWeek = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    extraMissionM = table.Column<int>(type: "int", nullable: false),
                    sumM_tMWork_extraWork_extraMission_homeWork_extraWorkFraction = table.Column<int>(type: "int", nullable: false),
                    flag = table.Column<int>(type: "int", nullable: false),
                    dailyPercent = table.Column<int>(type: "int", nullable: false),
                    extraWorkFraction = table.Column<int>(type: "int", nullable: false),
                    fNamePersian = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    lNamePersian = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    description1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    personnelDepartment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    monthlyDue = table.Column<int>(type: "int", nullable: false),
                    overtimeLimitM = table.Column<int>(type: "int", nullable: false),
                    extraWorkLimitM = table.Column<int>(type: "int", nullable: false),
                    paymentLimitM = table.Column<int>(type: "int", nullable: false),
                    contractType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    company = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    inMissionM = table.Column<int>(type: "int", nullable: false),
                    month = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    year = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    period = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    holiday = table.Column<int>(type: "int", nullable: false),
                    DepHead = table.Column<bool>(type: "bit", nullable: false),
                    PrjHead = table.Column<bool>(type: "bit", nullable: false),
                    EngHead = table.Column<bool>(type: "bit", nullable: false),
                    GasDpt = table.Column<bool>(type: "bit", nullable: false),
                    SupDpt = table.Column<bool>(type: "bit", nullable: false),
                    WtrDpt = table.Column<bool>(type: "bit", nullable: false),
                    Ceo = table.Column<bool>(type: "bit", nullable: false),
                    NotAccept = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timesheet", x => x.autoNumber);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "546fb247-e0d4-4dc2-869e-9bc6a8b63a02", "AQAAAAIAAYagAAAAECYUPCqq0gxUfVnefVfkcYlG259t/bmeaD/NbDI6X7HhYbN2OPrBuB2GBv7B2ybdyw==", "c4952c72-d3d4-48ec-85f4-ed328d5a128b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8604c622-5c12-4bf6-9664-481e0c0ea405", "AQAAAAIAAYagAAAAEB1Hk8K9gGUQQEWTq9aMXK7CpfK33NknFoHtD9aj7hnAdp3/lQV+bp02YIedLhYILQ==", "48f3e069-0995-46c5-9ba4-4310e7238ef4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Timesheet");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c619988a-3440-4513-bc77-25194b4d455d", "AQAAAAIAAYagAAAAEIKd97vz2D1bcHa8TP75V96kp18nG3gxgajlHNn2dnMI//zyAWKkc0F0vcLkICHhww==", "b4e3fb5a-c389-432d-bc3a-5b86c6fe52aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "normal-user-id",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47bc0c59-451c-4c9f-82a4-d27427ed8c2d", "AQAAAAIAAYagAAAAEK4NUCLdLUh8p3WH0L/YMbxBOKQj7CJ+Ml7mqZh/k/8CrVxKfF/n6Sag3U90StqDfA==", "33d3b471-3575-4868-8a7e-133b59f8dced" });
        }
    }
}
