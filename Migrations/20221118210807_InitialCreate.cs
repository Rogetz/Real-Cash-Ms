using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealCashMs.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    EmailAddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    orderNo = table.Column<int>(type: "int", nullable: false),
                    comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    starsReviews = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.EmailAddress);
                });

            migrationBuilder.CreateTable(
                name: "departmentDetailsTable",
                columns: table => new
                {
                    departmentCode = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departmentDetailsTable", x => x.departmentCode);
                });

            migrationBuilder.CreateTable(
                name: "mealsOfTheDay",
                columns: table => new
                {
                    dayOfTheYear = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nameOfTheDay = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mealsOfTheDay", x => x.dayOfTheYear);
                });

            migrationBuilder.CreateTable(
                name: "profitDetailsTable",
                columns: table => new
                {
                    profitDayOfTheYear = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capital = table.Column<int>(type: "int", nullable: false),
                    returnsMade = table.Column<int>(type: "int", nullable: false),
                    profitMade = table.Column<int>(type: "int", nullable: false),
                    profit = table.Column<bool>(type: "bit", nullable: false),
                    loss = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profitDetailsTable", x => x.profitDayOfTheYear);
                });

            migrationBuilder.CreateTable(
                name: "salaryDetailsTable",
                columns: table => new
                {
                    jobGroup = table.Column<int>(type: "int", nullable: false),
                    salary = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_salaryDetailsTable", x => x.jobGroup);
                });

            migrationBuilder.CreateTable(
                name: "stockDetailsTable",
                columns: table => new
                {
                    stocksIdentifier = table.Column<int>(type: "int", nullable: false),
                    QuantityRemainingKg = table.Column<int>(type: "int", nullable: false),
                    QuantitySack = table.Column<int>(type: "int", nullable: false),
                    stockAlertPercentage = table.Column<int>(type: "int", nullable: false),
                    rateOfConsumptionPercentage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stockDetailsTable", x => x.stocksIdentifier);
                });

            migrationBuilder.CreateTable(
                name: "StocksAlertTable",
                columns: table => new
                {
                    stockAlertCode = table.Column<int>(type: "int", nullable: false),
                    stockLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StocksAlertTable", x => x.stockAlertCode);
                });

            migrationBuilder.CreateTable(
                name: "cAlertDetailsTable",
                columns: table => new
                {
                    AlertEmailAddres = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    quantityState = table.Column<int>(type: "int", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerDetailsEmailAddress = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cAlertDetailsTable", x => x.AlertEmailAddres);
                    table.ForeignKey(
                        name: "FK_cAlertDetailsTable_customers_customerDetailsEmailAddress",
                        column: x => x.customerDetailsEmailAddress,
                        principalTable: "customers",
                        principalColumn: "EmailAddress",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "casualWorkersTable",
                columns: table => new
                {
                    CasualWorkerNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OnDuty = table.Column<bool>(type: "bit", nullable: false),
                    dayOfTheYear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mealsOfTheDaydayOfTheYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_casualWorkersTable", x => x.CasualWorkerNo);
                    table.ForeignKey(
                        name: "FK_casualWorkersTable_mealsOfTheDay_mealsOfTheDaydayOfTheYear",
                        column: x => x.mealsOfTheDaydayOfTheYear,
                        principalTable: "mealsOfTheDay",
                        principalColumn: "dayOfTheYear",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "cooksTable",
                columns: table => new
                {
                    CookNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    onDuty = table.Column<bool>(type: "bit", nullable: false),
                    dayOfTheYear = table.Column<int>(type: "int", nullable: false),
                    mealCookeddayOfTheYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cooksTable", x => x.CookNo);
                    table.ForeignKey(
                        name: "FK_cooksTable_mealsOfTheDay_mealCookeddayOfTheYear",
                        column: x => x.mealCookeddayOfTheYear,
                        principalTable: "mealsOfTheDay",
                        principalColumn: "dayOfTheYear",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "meals",
                columns: table => new
                {
                    mealName = table.Column<int>(type: "int", nullable: false),
                    mealPrice = table.Column<int>(type: "int", nullable: false),
                    quantityRemaining = table.Column<int>(type: "int", nullable: false),
                    receiptNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerInstanceEmailAddress = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    dayOfTheYear = table.Column<int>(type: "int", nullable: false),
                    mealsOftheDaydayOfTheYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_meals", x => x.mealName);
                    table.ForeignKey(
                        name: "FK_meals_customers_customerInstanceEmailAddress",
                        column: x => x.customerInstanceEmailAddress,
                        principalTable: "customers",
                        principalColumn: "EmailAddress");
                    table.ForeignKey(
                        name: "FK_meals_mealsOfTheDay_mealsOftheDaydayOfTheYear",
                        column: x => x.mealsOftheDaydayOfTheYear,
                        principalTable: "mealsOfTheDay",
                        principalColumn: "dayOfTheYear",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "supervisorDetailsTable",
                columns: table => new
                {
                    supervisorNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    onDuty = table.Column<bool>(type: "bit", nullable: false),
                    dayOfTheYear = table.Column<int>(type: "int", nullable: false),
                    dayMealsdayOfTheYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supervisorDetailsTable", x => x.supervisorNo);
                    table.ForeignKey(
                        name: "FK_supervisorDetailsTable_mealsOfTheDay_dayMealsdayOfTheYear",
                        column: x => x.dayMealsdayOfTheYear,
                        principalTable: "mealsOfTheDay",
                        principalColumn: "dayOfTheYear",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mpesaDetailsTable",
                columns: table => new
                {
                    mpesaConfirmationCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    secondName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    currentAccountBalance = table.Column<int>(type: "int", nullable: false),
                    initialAccountBalance = table.Column<int>(type: "int", nullable: false),
                    amountPaid = table.Column<int>(type: "int", nullable: false),
                    profitDayOfTheYear = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mpesaDetailsTable", x => x.mpesaConfirmationCode);
                    table.ForeignKey(
                        name: "FK_mpesaDetailsTable_profitDetailsTable_profitDayOfTheYear",
                        column: x => x.profitDayOfTheYear,
                        principalTable: "profitDetailsTable",
                        principalColumn: "profitDayOfTheYear");
                });

            migrationBuilder.CreateTable(
                name: "employeeDetailsTable",
                columns: table => new
                {
                    EmployeeNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalID = table.Column<int>(type: "int", nullable: false),
                    departmentCode = table.Column<int>(type: "int", nullable: false),
                    departmentWorkingdepartmentCode = table.Column<int>(type: "int", nullable: false),
                    jobGroup = table.Column<int>(type: "int", nullable: true),
                    salaryClassjobGroup = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeeDetailsTable", x => x.EmployeeNo);
                    table.ForeignKey(
                        name: "FK_employeeDetailsTable_departmentDetailsTable_departmentWorkingdepartmentCode",
                        column: x => x.departmentWorkingdepartmentCode,
                        principalTable: "departmentDetailsTable",
                        principalColumn: "departmentCode",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employeeDetailsTable_salaryDetailsTable_salaryClassjobGroup",
                        column: x => x.salaryClassjobGroup,
                        principalTable: "salaryDetailsTable",
                        principalColumn: "jobGroup",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "supplierDetailsTable",
                columns: table => new
                {
                    companyCode = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pricing = table.Column<int>(type: "int", nullable: false),
                    stocksIdentifier = table.Column<int>(type: "int", nullable: false),
                    stockClassstocksIdentifier = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplierDetailsTable", x => x.companyCode);
                    table.ForeignKey(
                        name: "FK_supplierDetailsTable_stockDetailsTable_stockClassstocksIdentifier",
                        column: x => x.stockClassstocksIdentifier,
                        principalTable: "stockDetailsTable",
                        principalColumn: "stocksIdentifier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "paymentDetailsTable",
                columns: table => new
                {
                    receiptNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    timeOfTheDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    customerDetailsEmailAddress = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    mpesaConfirmationCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentDetailsTable", x => x.receiptNo);
                    table.ForeignKey(
                        name: "FK_paymentDetailsTable_customers_customerDetailsEmailAddress",
                        column: x => x.customerDetailsEmailAddress,
                        principalTable: "customers",
                        principalColumn: "EmailAddress");
                    table.ForeignKey(
                        name: "FK_paymentDetailsTable_mpesaDetailsTable_mpesaConfirmationCode",
                        column: x => x.mpesaConfirmationCode,
                        principalTable: "mpesaDetailsTable",
                        principalColumn: "mpesaConfirmationCode");
                });

            migrationBuilder.CreateTable(
                name: "eAlertDetailsTable",
                columns: table => new
                {
                    EmployeeAlertNo = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    employeeAlertType = table.Column<int>(type: "int", nullable: false),
                    complaint = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employeeInAlertEmployeeNo = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eAlertDetailsTable", x => x.EmployeeAlertNo);
                    table.ForeignKey(
                        name: "FK_eAlertDetailsTable_employeeDetailsTable_employeeInAlertEmployeeNo",
                        column: x => x.employeeInAlertEmployeeNo,
                        principalTable: "employeeDetailsTable",
                        principalColumn: "EmployeeNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reviewsDetailsTable",
                columns: table => new
                {
                    ratedEmployeeIdentifier = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeNo = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reviewsDetailsTable", x => x.ratedEmployeeIdentifier);
                    table.ForeignKey(
                        name: "FK_reviewsDetailsTable_employeeDetailsTable_EmployeeNo",
                        column: x => x.EmployeeNo,
                        principalTable: "employeeDetailsTable",
                        principalColumn: "EmployeeNo");
                });

            migrationBuilder.CreateTable(
                name: "OrdersIssued",
                columns: table => new
                {
                    orderNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    receiptNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    paymentDetailsreceiptNo = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersIssued", x => x.orderNo);
                    table.ForeignKey(
                        name: "FK_OrdersIssued_paymentDetailsTable_paymentDetailsreceiptNo",
                        column: x => x.paymentDetailsreceiptNo,
                        principalTable: "paymentDetailsTable",
                        principalColumn: "receiptNo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerReviews",
                columns: table => new
                {
                    CustomerClassEmailAddress = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    reviewsClassratedEmployeeIdentifier = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerReviews", x => new { x.CustomerClassEmailAddress, x.reviewsClassratedEmployeeIdentifier });
                    table.ForeignKey(
                        name: "FK_CustomerReviews_customers_CustomerClassEmailAddress",
                        column: x => x.CustomerClassEmailAddress,
                        principalTable: "customers",
                        principalColumn: "EmailAddress",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerReviews_reviewsDetailsTable_reviewsClassratedEmployeeIdentifier",
                        column: x => x.reviewsClassratedEmployeeIdentifier,
                        principalTable: "reviewsDetailsTable",
                        principalColumn: "ratedEmployeeIdentifier",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cAlertDetailsTable_customerDetailsEmailAddress",
                table: "cAlertDetailsTable",
                column: "customerDetailsEmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_casualWorkersTable_mealsOfTheDaydayOfTheYear",
                table: "casualWorkersTable",
                column: "mealsOfTheDaydayOfTheYear");

            migrationBuilder.CreateIndex(
                name: "IX_cooksTable_mealCookeddayOfTheYear",
                table: "cooksTable",
                column: "mealCookeddayOfTheYear");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerReviews_reviewsClassratedEmployeeIdentifier",
                table: "CustomerReviews",
                column: "reviewsClassratedEmployeeIdentifier");

            migrationBuilder.CreateIndex(
                name: "IX_eAlertDetailsTable_employeeInAlertEmployeeNo",
                table: "eAlertDetailsTable",
                column: "employeeInAlertEmployeeNo");

            migrationBuilder.CreateIndex(
                name: "IX_employeeDetailsTable_departmentWorkingdepartmentCode",
                table: "employeeDetailsTable",
                column: "departmentWorkingdepartmentCode");

            migrationBuilder.CreateIndex(
                name: "IX_employeeDetailsTable_salaryClassjobGroup",
                table: "employeeDetailsTable",
                column: "salaryClassjobGroup");

            migrationBuilder.CreateIndex(
                name: "IX_meals_customerInstanceEmailAddress",
                table: "meals",
                column: "customerInstanceEmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_meals_mealsOftheDaydayOfTheYear",
                table: "meals",
                column: "mealsOftheDaydayOfTheYear");

            migrationBuilder.CreateIndex(
                name: "IX_mpesaDetailsTable_profitDayOfTheYear",
                table: "mpesaDetailsTable",
                column: "profitDayOfTheYear");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersIssued_paymentDetailsreceiptNo",
                table: "OrdersIssued",
                column: "paymentDetailsreceiptNo");

            migrationBuilder.CreateIndex(
                name: "IX_paymentDetailsTable_customerDetailsEmailAddress",
                table: "paymentDetailsTable",
                column: "customerDetailsEmailAddress");

            migrationBuilder.CreateIndex(
                name: "IX_paymentDetailsTable_mpesaConfirmationCode",
                table: "paymentDetailsTable",
                column: "mpesaConfirmationCode",
                unique: true,
                filter: "[mpesaConfirmationCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_reviewsDetailsTable_EmployeeNo",
                table: "reviewsDetailsTable",
                column: "EmployeeNo",
                unique: true,
                filter: "[EmployeeNo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_supervisorDetailsTable_dayMealsdayOfTheYear",
                table: "supervisorDetailsTable",
                column: "dayMealsdayOfTheYear");

            migrationBuilder.CreateIndex(
                name: "IX_supplierDetailsTable_stockClassstocksIdentifier",
                table: "supplierDetailsTable",
                column: "stockClassstocksIdentifier");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cAlertDetailsTable");

            migrationBuilder.DropTable(
                name: "casualWorkersTable");

            migrationBuilder.DropTable(
                name: "cooksTable");

            migrationBuilder.DropTable(
                name: "CustomerReviews");

            migrationBuilder.DropTable(
                name: "eAlertDetailsTable");

            migrationBuilder.DropTable(
                name: "meals");

            migrationBuilder.DropTable(
                name: "OrdersIssued");

            migrationBuilder.DropTable(
                name: "StocksAlertTable");

            migrationBuilder.DropTable(
                name: "supervisorDetailsTable");

            migrationBuilder.DropTable(
                name: "supplierDetailsTable");

            migrationBuilder.DropTable(
                name: "reviewsDetailsTable");

            migrationBuilder.DropTable(
                name: "paymentDetailsTable");

            migrationBuilder.DropTable(
                name: "mealsOfTheDay");

            migrationBuilder.DropTable(
                name: "stockDetailsTable");

            migrationBuilder.DropTable(
                name: "employeeDetailsTable");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "mpesaDetailsTable");

            migrationBuilder.DropTable(
                name: "departmentDetailsTable");

            migrationBuilder.DropTable(
                name: "salaryDetailsTable");

            migrationBuilder.DropTable(
                name: "profitDetailsTable");
        }
    }
}
