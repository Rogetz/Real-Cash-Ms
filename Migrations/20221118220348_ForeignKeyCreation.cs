using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealCashMs.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeyCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeNo",
                table: "cooksTable",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeNo",
                table: "casualWorkersTable",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_cooksTable_EmployeeNo",
                table: "cooksTable",
                column: "EmployeeNo",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_casualWorkersTable_EmployeeNo",
                table: "casualWorkersTable",
                column: "EmployeeNo",
                unique: true,
                filter: "[EmployeeNo] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_casualWorkersTable_employeeDetailsTable_EmployeeNo",
                table: "casualWorkersTable",
                column: "EmployeeNo",
                principalTable: "employeeDetailsTable",
                principalColumn: "EmployeeNo");

            migrationBuilder.AddForeignKey(
                name: "FK_cooksTable_employeeDetailsTable_EmployeeNo",
                table: "cooksTable",
                column: "EmployeeNo",
                principalTable: "employeeDetailsTable",
                principalColumn: "EmployeeNo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_casualWorkersTable_employeeDetailsTable_EmployeeNo",
                table: "casualWorkersTable");

            migrationBuilder.DropForeignKey(
                name: "FK_cooksTable_employeeDetailsTable_EmployeeNo",
                table: "cooksTable");

            migrationBuilder.DropIndex(
                name: "IX_cooksTable_EmployeeNo",
                table: "cooksTable");

            migrationBuilder.DropIndex(
                name: "IX_casualWorkersTable_EmployeeNo",
                table: "casualWorkersTable");

            migrationBuilder.DropColumn(
                name: "EmployeeNo",
                table: "cooksTable");

            migrationBuilder.DropColumn(
                name: "EmployeeNo",
                table: "casualWorkersTable");
        }
    }
}
