using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealCashMs.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeyCreation2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeNo",
                table: "supervisorDetailsTable",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_supervisorDetailsTable_EmployeeNo",
                table: "supervisorDetailsTable",
                column: "EmployeeNo");

            migrationBuilder.AddForeignKey(
                name: "FK_supervisorDetailsTable_employeeDetailsTable_EmployeeNo",
                table: "supervisorDetailsTable",
                column: "EmployeeNo",
                principalTable: "employeeDetailsTable",
                principalColumn: "EmployeeNo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_supervisorDetailsTable_employeeDetailsTable_EmployeeNo",
                table: "supervisorDetailsTable");

            migrationBuilder.DropIndex(
                name: "IX_supervisorDetailsTable_EmployeeNo",
                table: "supervisorDetailsTable");

            migrationBuilder.DropColumn(
                name: "EmployeeNo",
                table: "supervisorDetailsTable");
        }
    }
}
