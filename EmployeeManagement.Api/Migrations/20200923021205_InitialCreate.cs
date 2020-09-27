using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    DepartmentID = table.Column<int>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "HR" },
                    { 3, "GS" },
                    { 4, "Payroll" },
                    { 5, "IPPR" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DepartmentID", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(1981, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "robinson.chan@sonicsales.net", "Robinson", 0, "Chan", "images/1.png" },
                    { 2, new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "hr@sonicsales.net", "Nancy", 1, "Taypin", "images/1.png" },
                    { 3, new DateTime(1995, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "admin@sonicsales.net", "Joanne", 1, "Sumangil", "images/1.png" },
                    { 4, new DateTime(1989, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "hr@sonicsales.net", "Jean", 1, "Romero", "images/0.png" },
                    { 5, new DateTime(1983, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "carol.genavia@sonicsales.net", "Carol", 1, "Genavia", "images/1.png" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
