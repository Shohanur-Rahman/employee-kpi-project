using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KPIMS.Repos.Migrations
{
    /// <inheritdoc />
    public partial class addGoalTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GoalSets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoalOverview = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KeyPoints = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApproverId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedId = table.Column<int>(type: "int", nullable: false),
                    UpdatedId = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoalSets", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 7, 92, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 7, 92, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 7, 92, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 7, 92, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 7, 92, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 7, 92, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 7, 92, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 7, 92, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 7, 92, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 7, 92, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 7, 92, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 7, 92, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 7, 92, DateTimeKind.Local).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 7, 92, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 7, 92, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 7, 92, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 17, 9, 48, 7, 113, DateTimeKind.Local).AddTicks(7460), "bj7Iq9HMfKRnCyl+QJrO3lqZeTbfXSNEuD1VfvoFMW4=", "ZFwOBgOO23c+ejU3tjHI8A==" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 17, 9, 48, 7, 113, DateTimeKind.Local).AddTicks(7478), "bj7Iq9HMfKRnCyl+QJrO3lqZeTbfXSNEuD1VfvoFMW4=", "ZFwOBgOO23c+ejU3tjHI8A==" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 17, 9, 48, 7, 113, DateTimeKind.Local).AddTicks(7481), "bj7Iq9HMfKRnCyl+QJrO3lqZeTbfXSNEuD1VfvoFMW4=", "ZFwOBgOO23c+ejU3tjHI8A==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoalSets");

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 17, 8, 52, 49, 503, DateTimeKind.Local).AddTicks(4363), "6bHhvBZ9AChTCm+XHMFunAktGiPgjb3s2FuDx226Q24=", "C2Iq8qtSwij/hYghE5LkwQ==" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 17, 8, 52, 49, 503, DateTimeKind.Local).AddTicks(4377), "6bHhvBZ9AChTCm+XHMFunAktGiPgjb3s2FuDx226Q24=", "C2Iq8qtSwij/hYghE5LkwQ==" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 17, 8, 52, 49, 503, DateTimeKind.Local).AddTicks(4381), "6bHhvBZ9AChTCm+XHMFunAktGiPgjb3s2FuDx226Q24=", "C2Iq8qtSwij/hYghE5LkwQ==" });
        }
    }
}
