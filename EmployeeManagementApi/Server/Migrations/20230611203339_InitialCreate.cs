using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeManagementApi.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "HR" },
                    { 3, "Accounts" },
                    { 4, "Payroll" },
                    { 5, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "jan.mazur@email.com", "Jan", 0, "Mazur" },
                    { 2, new DateTime(1992, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "monika.medyna@email.com", "Monika", 1, "Medyna" },
                    { 3, new DateTime(1990, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "mariusz.kokos@email.com", "Mariusz", 0, "Kokos" },
                    { 4, new DateTime(1988, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "sebastian.sebczyk@email.com", "Sebastian", 0, "Sebczyk" },
                    { 5, new DateTime(1998, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "michal.marczyk@email.com", "Michal", 0, "Marczyk" },
                    { 6, new DateTime(1999, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "maria.zogan@email.com", "Maria", 1, "Zogan" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
