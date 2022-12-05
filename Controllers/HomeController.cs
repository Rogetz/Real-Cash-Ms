using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RealCashMs.Models;

namespace RealCashMs.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private Cart cartToUse;

    public HomeController(ILogger<HomeController> logger, Cart cartShared)
    {
        _logger = logger;
        cartToUse = cartShared;
    }

    [HttpGet]
    public IActionResult Index()
    {
        FileProcessor testProcessor = new FileProcessor();
        testProcessor.PrintFileNames();

        return View(testProcessor.testImgClass);
    }

    [HttpPost]
    public IActionResult Order(string ItemName,string ItemRealName, int price){
        ImageClass testOrder = new ImageClass();
        testOrder.ImgName = ItemName;
        testOrder.Name = ItemRealName;
        testOrder.Price = price;
        return View(testOrder);
    }
    public IActionResult Pay(int Amount, int PhoneNumber){
        // create the mpesa rest api client for requesting payment to a paybill.
        // after the mpesa api has worked, set the mpesaApi to "success". 

        // mpesaApi = null!;
        // note that I have just made it a success for the sake of testing
        // In real time however you'd have to eliminate that.
        //mpesaApi = "success";
        //if(mpesaApi == "success"){
            ViewBag.AmountPaid = Amount;
            ViewBag.PhoneNumberUsed = PhoneNumber; 
            myResult testResult = new myResult();
            testResult.ResultCalculator();
            return View("Pay",testResult);
        /*}
        else{
            return View();
        }*/

    }
    public IActionResult Cart(){
        return View();
    }

    // try learning on how to create a partial view for calling the add to cart functionality.
   [HttpPost]
    public void MyCart(string ItemName,string ItemRealName, int price ){
        ImageClass cartImageClass = new ImageClass();
        cartImageClass.ImgName = ItemName;
        cartImageClass.Name = ItemRealName;
        cartImageClass.Price = price;
        cartToUse.AddToCart(cartImageClass);  
        
    }
    [HttpGet]
    public IActionResult MyCart(){
        return View(cartToUse.imgObjects);
    }
    public IActionResult About(){
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult ContactCenter()
    {
        return View();
    }
    public IActionResult HelpCenter()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
