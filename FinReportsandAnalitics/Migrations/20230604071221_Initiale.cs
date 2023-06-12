using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinReportsandAnalitics.Migrations
{
    /// <inheritdoc />
    public partial class Initiale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Inn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GuidForReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeOfRow = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameOfRow = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuidForReports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BalanceRepots",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    DateOfBalanse = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _1110 = table.Column<long>(type: "bigint", nullable: false),
                    _1120 = table.Column<long>(type: "bigint", nullable: false),
                    _1130 = table.Column<long>(type: "bigint", nullable: false),
                    _1140 = table.Column<long>(type: "bigint", nullable: false),
                    _1150 = table.Column<long>(type: "bigint", nullable: false),
                    _1160 = table.Column<long>(type: "bigint", nullable: false),
                    _1170 = table.Column<long>(type: "bigint", nullable: false),
                    _1180 = table.Column<long>(type: "bigint", nullable: false),
                    _1190 = table.Column<long>(type: "bigint", nullable: false),
                    _1100 = table.Column<long>(type: "bigint", nullable: false),
                    _1210 = table.Column<long>(type: "bigint", nullable: false),
                    _1220 = table.Column<long>(type: "bigint", nullable: false),
                    _1230 = table.Column<long>(type: "bigint", nullable: false),
                    _1240 = table.Column<long>(type: "bigint", nullable: false),
                    _1250 = table.Column<long>(type: "bigint", nullable: false),
                    _1260 = table.Column<long>(type: "bigint", nullable: false),
                    _1200 = table.Column<long>(type: "bigint", nullable: false),
                    _1600 = table.Column<long>(type: "bigint", nullable: false),
                    _1310 = table.Column<long>(type: "bigint", nullable: false),
                    _1320 = table.Column<long>(type: "bigint", nullable: false),
                    _1340 = table.Column<long>(type: "bigint", nullable: false),
                    _1350 = table.Column<long>(type: "bigint", nullable: false),
                    _1360 = table.Column<long>(type: "bigint", nullable: false),
                    _1370 = table.Column<long>(type: "bigint", nullable: false),
                    _1300 = table.Column<long>(type: "bigint", nullable: false),
                    _1410 = table.Column<long>(type: "bigint", nullable: false),
                    _1420 = table.Column<long>(type: "bigint", nullable: false),
                    _1430 = table.Column<long>(type: "bigint", nullable: false),
                    _1450 = table.Column<long>(type: "bigint", nullable: false),
                    _1400 = table.Column<long>(type: "bigint", nullable: false),
                    _1510 = table.Column<long>(type: "bigint", nullable: false),
                    _1520 = table.Column<long>(type: "bigint", nullable: false),
                    _1530 = table.Column<long>(type: "bigint", nullable: false),
                    _1540 = table.Column<long>(type: "bigint", nullable: false),
                    _1550 = table.Column<long>(type: "bigint", nullable: false),
                    _1500 = table.Column<long>(type: "bigint", nullable: false),
                    _1700 = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BalanceRepots", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BalanceRepots_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FinResultReports",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    DateOfBalanse = table.Column<DateTime>(type: "datetime2", nullable: false),
                    _2110 = table.Column<long>(type: "bigint", nullable: false),
                    _2120 = table.Column<long>(type: "bigint", nullable: false),
                    _2100 = table.Column<long>(type: "bigint", nullable: false),
                    _2210 = table.Column<long>(type: "bigint", nullable: false),
                    _2220 = table.Column<long>(type: "bigint", nullable: false),
                    _2200 = table.Column<long>(type: "bigint", nullable: false),
                    _2310 = table.Column<long>(type: "bigint", nullable: false),
                    _2320 = table.Column<long>(type: "bigint", nullable: false),
                    _2330 = table.Column<long>(type: "bigint", nullable: false),
                    _2340 = table.Column<long>(type: "bigint", nullable: false),
                    _2350 = table.Column<long>(type: "bigint", nullable: false),
                    _2300 = table.Column<long>(type: "bigint", nullable: false),
                    _2410 = table.Column<long>(type: "bigint", nullable: false),
                    _2411 = table.Column<long>(type: "bigint", nullable: false),
                    _2412 = table.Column<long>(type: "bigint", nullable: false),
                    _2460 = table.Column<long>(type: "bigint", nullable: false),
                    _2400 = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinResultReports", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FinResultReports_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BalanceRepots_CompanyId",
                table: "BalanceRepots",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_FinResultReports_CompanyId",
                table: "FinResultReports",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BalanceRepots");

            migrationBuilder.DropTable(
                name: "FinResultReports");

            migrationBuilder.DropTable(
                name: "GuidForReports");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Company");
        }
    }
}
