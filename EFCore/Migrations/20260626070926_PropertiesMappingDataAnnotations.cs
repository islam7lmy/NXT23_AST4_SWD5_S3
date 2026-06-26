using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore.Migrations
{
    /// <inheritdoc />
    public partial class PropertiesMappingDataAnnotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "EmployeeInfo",
                newSchema: "dbo");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "EmployeeInfo",
                newName: "EmpId");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                schema: "dbo",
                table: "EmployeeInfo",
                type: "money",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "dbo",
                table: "EmployeeInfo",
                type: "Varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                schema: "dbo",
                table: "EmployeeInfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeInfo",
                schema: "dbo",
                table: "EmployeeInfo",
                column: "EmpId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeInfo",
                schema: "dbo",
                table: "EmployeeInfo");

            migrationBuilder.DropColumn(
                name: "Email",
                schema: "dbo",
                table: "EmployeeInfo");

            migrationBuilder.RenameTable(
                name: "EmployeeInfo",
                schema: "dbo",
                newName: "Employees");

            migrationBuilder.RenameColumn(
                name: "EmpId",
                table: "Employees",
                newName: "Id");

            migrationBuilder.AlterColumn<double>(
                name: "Salary",
                table: "Employees",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "Varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");
        }
    }
}
