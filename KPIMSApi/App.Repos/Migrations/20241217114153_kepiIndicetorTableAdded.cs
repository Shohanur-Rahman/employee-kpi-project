using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KPIMS.Repos.Migrations
{
    /// <inheritdoc />
    public partial class kepiIndicetorTableAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KpiIndicators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KPILabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinPoint = table.Column<int>(type: "int", nullable: false),
                    MaxPoint = table.Column<int>(type: "int", nullable: false),
                    PerofrmanceBenefit = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KpiIndicators", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 17, 41, 52, 968, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 17, 41, 52, 968, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 17, 41, 52, 968, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 17, 41, 52, 968, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 17, 41, 52, 968, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 17, 41, 52, 968, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 17, 41, 52, 968, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 17, 41, 52, 968, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 17, 41, 52, 968, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 17, 41, 52, 968, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 17, 41, 52, 968, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 17, 41, 52, 968, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 17, 41, 52, 968, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 17, 41, 52, 968, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 17, 41, 52, 968, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 17, 41, 52, 968, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 41, 52, 982, DateTimeKind.Local).AddTicks(2906), "3rr96JMdTcjHGBbIdyyFk+7rT7jvd7Euee1Bzmm7qTk=", "C9urdtgyvENaKPSmniF+Zg==" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 41, 52, 982, DateTimeKind.Local).AddTicks(2914), "3rr96JMdTcjHGBbIdyyFk+7rT7jvd7Euee1Bzmm7qTk=", "C9urdtgyvENaKPSmniF+Zg==" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 17, 17, 41, 52, 982, DateTimeKind.Local).AddTicks(2917), "3rr96JMdTcjHGBbIdyyFk+7rT7jvd7Euee1Bzmm7qTk=", "C9urdtgyvENaKPSmniF+Zg==" });

            migrationBuilder.InsertData(
                table: "KpiIndicators",
                columns: new[] { "Id", "KPILabel", "MaxPoint", "MinPoint", "PerofrmanceBenefit" },
                values: new object[,]
                {
                    { 1, "Nothing satisfactory has been done", 50, 0, "(0%) Take care yourself" },
                    { 2, "Performane bellow average", 60, 51, "2% - 4%" },
                    { 3, "Average perofrmance", 70, 61, "5% - 8%" },
                    { 4, "Performance above average", 80, 71, "9% - 12%" },
                    { 5, "Good performer", 90, 81, "13% - 15%" },
                    { 6, "Best performer", 100, 90, "16% - 20%" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KpiIndicators");

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 52, 915, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 52, 915, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 52, 915, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 52, 915, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 52, 915, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 52, 915, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 52, 915, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 52, 915, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 52, 915, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 52, 915, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 52, 915, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 52, 915, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 52, 915, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 52, 915, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 52, 915, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 12, 17, 9, 48, 52, 915, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 17, 9, 48, 52, 933, DateTimeKind.Local).AddTicks(8934), "DmXYK+dvmN53l2J9EQp9XXp0R2TOTG3jQVbcY+bSl+w=", "kuVCUl+5xiHkobc2skvW0w==" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 17, 9, 48, 52, 933, DateTimeKind.Local).AddTicks(8948), "DmXYK+dvmN53l2J9EQp9XXp0R2TOTG3jQVbcY+bSl+w=", "kuVCUl+5xiHkobc2skvW0w==" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Password", "PasswordSalt" },
                values: new object[] { new DateTime(2024, 12, 17, 9, 48, 52, 933, DateTimeKind.Local).AddTicks(8951), "DmXYK+dvmN53l2J9EQp9XXp0R2TOTG3jQVbcY+bSl+w=", "kuVCUl+5xiHkobc2skvW0w==" });
        }
    }
}
