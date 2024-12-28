using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Timesheet.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PositionType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Filtering = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grouping = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: true),
                    Counter = table.Column<int>(type: "int", nullable: true),
                    Signed = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Timesheet",
                columns: table => new
                {
                    autoNumber = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    persCode = table.Column<int>(type: "int", nullable: false),
                    fName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    lName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    domainName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    userName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    date = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    discipline = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    prjCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    prjName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    phase = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    docCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    docName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    pPercent = table.Column<int>(type: "int", nullable: true),
                    missionM = table.Column<int>(type: "int", nullable: true),
                    homeWorkM = table.Column<int>(type: "int", nullable: true),
                    extraWork = table.Column<int>(type: "int", nullable: true),
                    vacationM = table.Column<int>(type: "int", nullable: true),
                    vacationPayM = table.Column<int>(type: "int", nullable: true),
                    delayPercM = table.Column<int>(type: "int", nullable: true),
                    iExitM = table.Column<int>(type: "int", nullable: true),
                    absenceM = table.Column<int>(type: "int", nullable: true),
                    overTimeM = table.Column<int>(type: "int", nullable: true),
                    dMWork = table.Column<float>(type: "real", nullable: true),
                    tMWork = table.Column<int>(type: "int", nullable: true),
                    timeSheetMWork = table.Column<int>(type: "int", nullable: true),
                    interTime = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    exitTime = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    dayOfWeek = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    extraMissionM = table.Column<int>(type: "int", nullable: true),
                    sumM_tMWork_extraWork_extraMission_homeWork_extraWorkFraction = table.Column<int>(type: "int", nullable: true),
                    flag = table.Column<int>(type: "int", nullable: true),
                    dailyPercent = table.Column<int>(type: "int", nullable: true),
                    extraWorkFraction = table.Column<int>(type: "int", nullable: true),
                    fNamePersian = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    lNamePersian = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    description1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    description2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    personnelDepartment = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    monthlyDue = table.Column<int>(type: "int", nullable: true),
                    overtimeLimitM = table.Column<int>(type: "int", nullable: true),
                    extraWorkLimitM = table.Column<int>(type: "int", nullable: true),
                    paymentLimitM = table.Column<int>(type: "int", nullable: true),
                    contractType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    company = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    inMissionM = table.Column<int>(type: "int", nullable: true),
                    month = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    year = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: true),
                    period = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    holiday = table.Column<int>(type: "int", nullable: true),
                    DepHead = table.Column<bool>(type: "bit", nullable: false),
                    PrjHead = table.Column<bool>(type: "bit", nullable: false),
                    EngHead = table.Column<bool>(type: "bit", nullable: false),
                    GasDpt = table.Column<bool>(type: "bit", nullable: false),
                    SupDpt = table.Column<bool>(type: "bit", nullable: false),
                    WtrDpt = table.Column<bool>(type: "bit", nullable: false),
                    Ceo = table.Column<bool>(type: "bit", nullable: false),
                    NotAccept = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timesheet", x => x.autoNumber);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", null },
                    { "2", null, "User", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Family", "IsAdmin", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PositionId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "admin-user-id", 0, "eaca700b-b29f-4344-9072-b09c76bc6dd2", null, false, "AdminFamily", true, false, null, "AdminName", null, "ADMIN", "Admin@123", "AQAAAAIAAYagAAAAELrUgbEXh9fwL9Dm/Q3DVge3nLmNPl3bgbewvfRYiem5eHRy5ap2t0p/7gBesQgk9g==", null, false, null, "e131a6b9-73d9-4cda-8da5-a8be48556de7", false, "admin" },
                    { "normal-user-id", 0, "f9e71b08-7deb-47e8-99b6-1a720311a2aa", null, false, "UserFamily", false, false, null, "UserName", null, "USER", "User@123", "AQAAAAIAAYagAAAAEIVOWRA7FsQTcb30NKLcdVdFrYT9D0I8Py1l2+Tcpqj5kuzC6e4lQMXdp1AH/rnEKA==", null, false, null, "86c3b249-4ad1-49cd-95ae-e3508ca8a39b", false, "user" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "admin-user-id" },
                    { "2", "normal-user-id" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropTable(
                name: "Timesheet");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
