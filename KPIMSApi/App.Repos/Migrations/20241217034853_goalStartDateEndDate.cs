using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KPIMS.Repos.Migrations
{
    /// <inheritdoc />
    public partial class goalStartDateEndDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "GoalSets",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "GoalSets",
                type: "datetime2",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "GoalSets");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "GoalSets");

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
    }
}
