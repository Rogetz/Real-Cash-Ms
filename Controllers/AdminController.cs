using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RealCashMs.Models;
// remove this namespace later its risky to use the database namespace directly.
using RealCashMs.Data;

namespace RealCashMs.Controllers;

// Never forget to inherit the Controller class for the Views to work and be recognnized.
public class AdminController : Controller{
    private readonly ILogger<AdminController> _logger;
    private IDatabaseInterface DbInterface;
    private Customer customerInstance{get;set;}

    private CashMsDbContext cashDbContext{get;}

    public AdminController(ILogger<AdminController> logger,IDatabaseInterface databaseI, Customer cstmInstance,CashMsDbContext cmsDb)
    {
        cashDbContext = cmsDb;
        customerInstance = cstmInstance;
        DbInterface = databaseI;
        _logger = logger;
    }

    public IActionResult Index(){
        return View();
    }
    public IActionResult Customers(){
        
        return View();
    }

    public IActionResult OrderManagement(){
        return View();
    }
    public IActionResult Stocks(){
        return View();
    }
    public IActionResult Employees(){
        return View();
    }
    public IActionResult Alert(){
        return View();
    }
    public IActionResult Meals(){
        IEnumerable<Meal> mealsAvailable = DbInterface.mealList;
        ViewBag.mealsCooked = mealsAvailable;
        // The IQueryable collection returned by the collections query.
        IQueryable<ICollection<Meal>> mealList = DbInterface.cutomers.Select(i => i.mealsOrdered);
        // I directly used the data model cause of this, I'll remove it and use an interface though.
        // come back to the GroupBy method, seems like it really needs some class type for it to group and in this case I used the meal identifier as an int, using int wont bring the results I wish for.
        //ViewBag.NoOfCustomersAMeal = cashDbContext.customers.GroupBy<mea>
       // ViewBag.CustomersPerMeal = 
        //ViewBag.MealsRemainingInPercentage = 
        ViewData["CustomersTable"] = DbInterface.cutomers;
        ViewBag.Greeetings = "Helloe world";
        return View(mealList);
    }
    [HttpPost]
    public IActionResult Meals(Meal mealToAdd){
        DbInterface.Add(mealToAdd);
        return View();
    }
    public IActionResult Profits(){
        return View();
    }
    public IActionResult RealTimeService(){
        return View();
    }
    public IActionResult Reviews(){
        return View();
    }
    public IActionResult CustomerEmployeeReview(){
        return View();
    }
    public IActionResult Comments(){
        return View();
    }
    public IActionResult Advantages(){
        return View();
    }
    public IActionResult MpesaRecordsTotals(){
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error(){
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}