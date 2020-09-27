using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
    public partial class UpdateEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BiometricID",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CurrentAddress",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Marital_Status",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermanentAddress",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlaceOfBirth",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SurName",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DivisionId",
                table: "Departments",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Business_Unit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Business_Unit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Division",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Business_UnitId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Division", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Division_Business_Unit_Business_UnitId",
                        column: x => x.Business_UnitId,
                        principalTable: "Business_Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BiometricID", "CurrentAddress", "DateOfBirth", "EmployeeId", "PermanentAddress", "PlaceOfBirth", "SurName" },
                values: new object[] { 1, "Mandug Davao City", new DateTime(1985, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Mandug Davao City", "Davao City", "Jr" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BiometricID", "CurrentAddress", "DateOfBirth", "EmployeeId", "PermanentAddress", "PhotoPath", "PlaceOfBirth", "SurName" },
                values: new object[] { 2, "Agdao Davao City", new DateTime(1995, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "General Generoso", "images/0.png", "General Generoso", "" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BiometricID", "CurrentAddress", "DateOfBirth", "Email", "EmployeeId", "FirstName", "Gender", "LastName", "PermanentAddress", "PhotoPath", "PlaceOfBirth", "Status", "SurName" },
                values: new object[] { 3, "Piapi Davao City", new DateTime(1995, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT@sonicsales.net", 3, "Joseph Vincent", 0, "Limbaroc", "Piapi Davao City", "images/0.png", "Davao City", 1, "" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BiometricID", "CurrentAddress", "DateOfBirth", "Email", "EmployeeId", "FirstName", "LastName", "Marital_Status", "PermanentAddress", "PlaceOfBirth", "SurName" },
                values: new object[] { 4, "Piapi Davao City", new DateTime(1992, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "ofelia.bernaldez@sonicsales.net", 4, "Ofelia", "Bernaldez", 1, "Piapi Davao City", "Davao City", "" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BiometricID", "CurrentAddress", "DateOfBirth", "EmployeeId", "Marital_Status", "PermanentAddress", "PhotoPath", "PlaceOfBirth", "SurName" },
                values: new object[] { 5, "Catalunan Grande Davao City", new DateTime(1982, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1, "Catalunan Grande Davao City", "images/0.png", "Manila City", "" });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DivisionId",
                table: "Departments",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_Division_Business_UnitId",
                table: "Division",
                column: "Business_UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Division_DivisionId",
                table: "Departments",
                column: "DivisionId",
                principalTable: "Division",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Division_DivisionId",
                table: "Departments");

            migrationBuilder.DropTable(
                name: "Division");

            migrationBuilder.DropTable(
                name: "Business_Unit");

            migrationBuilder.DropIndex(
                name: "IX_Departments_DivisionId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "BiometricID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CurrentAddress",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Marital_Status",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PermanentAddress",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PlaceOfBirth",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SurName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DivisionId",
                table: "Departments");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "DepartmentID" },
                values: new object[] { new DateTime(1981, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "DepartmentID", "PhotoPath" },
                values: new object[] { new DateTime(1990, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "images/1.png" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "DepartmentID", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[] { new DateTime(1995, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "admin@sonicsales.net", "Joanne", 1, "Sumangil", "images/1.png" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "DepartmentID", "Email", "FirstName", "LastName" },
                values: new object[] { new DateTime(1989, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "hr@sonicsales.net", "Jean", "Romero" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "DepartmentID", "PhotoPath" },
                values: new object[] { new DateTime(1983, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "images/1.png" });
        }
    }
}
