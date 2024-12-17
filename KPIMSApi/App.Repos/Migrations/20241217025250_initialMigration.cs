using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KPIMS.Repos.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Designations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedId = table.Column<int>(type: "int", nullable: false),
                    UpdatedId = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrograsStates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrograsStates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedId = table.Column<int>(type: "int", nullable: false),
                    UpdatedId = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkItemTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkItemTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DesignationId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedId = table.Column<int>(type: "int", nullable: false),
                    UpdatedId = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Designations_DesignationId",
                        column: x => x.DesignationId,
                        principalTable: "Designations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonalEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PresentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermanentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hobby = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaritalStatus = table.Column<bool>(type: "bit", nullable: false),
                    SpouseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpouseMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPersionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPersionEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactPersionMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedId = table.Column<int>(type: "int", nullable: false),
                    UpdatedId = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeProfiles_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkItemDiscussions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArticleDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkItemId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedId = table.Column<int>(type: "int", nullable: false),
                    UpdatedId = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkItemDiscussions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkItemDiscussions_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedToId = table.Column<int>(type: "int", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    WorkTypeId = table.Column<int>(type: "int", nullable: false),
                    ParentWorkId = table.Column<int>(type: "int", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcceptanceCreteria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StoryPoint = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedId = table.Column<int>(type: "int", nullable: false),
                    UpdatedId = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkItems_Employees_AssignedToId",
                        column: x => x.AssignedToId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkItems_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkItems_WorkItemTypes_WorkTypeId",
                        column: x => x.WorkTypeId,
                        principalTable: "WorkItemTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkItems_WorkItems_ParentWorkId",
                        column: x => x.ParentWorkId,
                        principalTable: "WorkItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkItemLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkItemId = table.Column<int>(type: "int", nullable: false),
                    AssignedToId = table.Column<int>(type: "int", nullable: true),
                    LogType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    WorkTypeId = table.Column<int>(type: "int", nullable: false),
                    ParentWorkId = table.Column<int>(type: "int", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcceptanceCreteria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StoryPoint = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedId = table.Column<int>(type: "int", nullable: false),
                    UpdatedId = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkItemLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkItemLogs_Employees_AssignedToId",
                        column: x => x.AssignedToId,
                        principalTable: "Employees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkItemLogs_PrograsStates_StateId",
                        column: x => x.StateId,
                        principalTable: "PrograsStates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkItemLogs_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_WorkItemLogs_WorkItemTypes_WorkTypeId",
                        column: x => x.WorkTypeId,
                        principalTable: "WorkItemTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkItemLogs_WorkItems_ParentWorkId",
                        column: x => x.ParentWorkId,
                        principalTable: "WorkItems",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Designations",
                columns: new[] { "Id", "CreatedDate", "CreatedId", "IsDeleted", "Name", "OrderId", "UpdatedDate", "UpdatedId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2164), 0, false, "System Administrator", 1, null, 0 },
                    { 2, new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2172), 0, false, "Managing Director", 2, null, 0 },
                    { 3, new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2174), 0, false, "Deputy Managing Director", 3, null, 0 },
                    { 4, new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2175), 0, false, "General Manager", 4, null, 0 },
                    { 5, new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2177), 0, false, "Deputy General Manager", 5, null, 0 },
                    { 6, new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2178), 0, false, "Director", 6, null, 0 },
                    { 7, new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2180), 0, false, "Department Manager/Tech Lead\r\n", 7, null, 0 },
                    { 8, new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2181), 0, false, "Assistant Manager", 8, null, 0 },
                    { 9, new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2182), 0, false, "Senior Team Leaders", 9, null, 0 },
                    { 10, new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2184), 0, false, "Team Leaders/Lead Developer", 10, null, 0 },
                    { 11, new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2253), 0, false, "Assistant Team Leaders/Senior Software Engineer", 11, null, 0 },
                    { 12, new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2254), 0, false, "Quality Assurance Specialist", 12, null, 0 },
                    { 13, new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2256), 0, false, "Senior Executive Officer/ Software Engineer", 13, null, 0 },
                    { 14, new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2257), 0, false, "Executives Officer/ Associate Software Engineer", 14, null, 0 },
                    { 15, new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2259), 0, false, "Associate Executive Officer", 15, null, 0 },
                    { 16, new DateTime(2024, 12, 17, 8, 52, 49, 482, DateTimeKind.Local).AddTicks(2260), 0, false, "Trainee Executive Officer", 16, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "PrograsStates",
                columns: new[] { "Id", "Details", "Title" },
                values: new object[,]
                {
                    { 1, "Just created and planing about implementation", "New" },
                    { 2, "Development started and developer working currently", "Active" },
                    { 3, "Development closed and validating from specefic team", "Resolved" },
                    { 4, "Verified by owner and released to owner", "Closed" },
                    { 5, "Some resean it's put on hold", "On Hold" },
                    { 6, "Created but no longer need to develop", "Removed" }
                });

            migrationBuilder.InsertData(
                table: "WorkItemTypes",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Epic" },
                    { 2, "Feature" },
                    { 3, "Incident" },
                    { 4, "Bug" },
                    { 5, "User Story" },
                    { 6, "Task" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Avatar", "CreatedDate", "CreatedId", "DesignationId", "Email", "FirstName", "IsDeleted", "LastName", "Mobile", "Password", "PasswordSalt", "UpdatedDate", "UpdatedId" },
                values: new object[,]
                {
                    { 1, "images/avatar/1.png", new DateTime(2024, 12, 17, 8, 52, 49, 503, DateTimeKind.Local).AddTicks(4363), 0, 1, "rima@gmail.com", "Rima", false, "Akter", "", "6bHhvBZ9AChTCm+XHMFunAktGiPgjb3s2FuDx226Q24=", "C2Iq8qtSwij/hYghE5LkwQ==", null, 0 },
                    { 2, "images/avatar/1.png", new DateTime(2024, 12, 17, 8, 52, 49, 503, DateTimeKind.Local).AddTicks(4377), 0, 1, "admin@gmail.com", "System", false, "Admin", "", "6bHhvBZ9AChTCm+XHMFunAktGiPgjb3s2FuDx226Q24=", "C2Iq8qtSwij/hYghE5LkwQ==", null, 0 },
                    { 3, "images/avatar/1.png", new DateTime(2024, 12, 17, 8, 52, 49, 503, DateTimeKind.Local).AddTicks(4381), 0, 1, "it-admin@gmail.com", "IT", false, "Admin", "", "6bHhvBZ9AChTCm+XHMFunAktGiPgjb3s2FuDx226Q24=", "C2Iq8qtSwij/hYghE5LkwQ==", null, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeProfiles_EmployeeId",
                table: "EmployeeProfiles",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DesignationId",
                table: "Employees",
                column: "DesignationId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                table: "Employees",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WorkItemDiscussions_EmployeeId",
                table: "WorkItemDiscussions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkItemLogs_AssignedToId",
                table: "WorkItemLogs",
                column: "AssignedToId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkItemLogs_ParentWorkId",
                table: "WorkItemLogs",
                column: "ParentWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkItemLogs_ProjectId",
                table: "WorkItemLogs",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkItemLogs_StateId",
                table: "WorkItemLogs",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkItemLogs_WorkTypeId",
                table: "WorkItemLogs",
                column: "WorkTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkItems_AssignedToId",
                table: "WorkItems",
                column: "AssignedToId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkItems_ParentWorkId",
                table: "WorkItems",
                column: "ParentWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkItems_ProjectId",
                table: "WorkItems",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkItems_WorkTypeId",
                table: "WorkItems",
                column: "WorkTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeProfiles");

            migrationBuilder.DropTable(
                name: "WorkItemDiscussions");

            migrationBuilder.DropTable(
                name: "WorkItemLogs");

            migrationBuilder.DropTable(
                name: "PrograsStates");

            migrationBuilder.DropTable(
                name: "WorkItems");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "WorkItemTypes");

            migrationBuilder.DropTable(
                name: "Designations");
        }
    }
}
