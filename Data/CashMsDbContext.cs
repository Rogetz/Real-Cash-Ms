using RealCashMs.Models;
using Microsoft.EntityFrameworkCore;

namespace RealCashMs.Data;

public class CashMsDbContext : DbContext{
    public CashMsDbContext(DbContextOptions<CashMsDbContext> options) : base(options){

    }
    public DbSet<Meal> meals{get;set;} = null!;
    public DbSet<Customer> customers{get;set;} = null!;
    public DbSet<MealsADay> mealsOfTheDay{get;set;} = null!;
    public DbSet<Cook> cooksTable{get;set;} = null!;
    public DbSet<CasualWorker> casualWorkersTable{get;set;} = null!;
    public DbSet<AccountMpesaDetails> mpesaDetailsTable{get;set;} = null!;
    public DbSet<Employee> employeeDetailsTable{get;set;} = null!;
    public DbSet<CustomerAlert> cAlertDetailsTable{get;set;} = null!;
    public DbSet<Department> departmentDetailsTable{get;set;} = null!;
    public DbSet<EmployeeAlert> eAlertDetailsTable{get;set;} = null!;
    public DbSet<PaymentDetails> paymentDetailsTable{get;set;} = null!;
    public DbSet<Profit> profitDetailsTable{get;set;} = null!;
    public DbSet<Reviews> reviewsDetailsTable{get;set;} = null!;
    public DbSet<Salary> salaryDetailsTable{get;set;} = null!;
    public DbSet<Stock> stockDetailsTable{get;set;} = null!;
    public DbSet<Supervisor> supervisorDetailsTable{get;set;} = null!;
    public DbSet<Suppliers> supplierDetailsTable{get;set;} = null!;
    public DbSet<StockAlert> StocksAlertTable{get;set;} = null!;
    public DbSet<OrderIssue> OrdersIssued{get;set;} = null!;
}