using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RealCashMs.Models;


namespace RealCashMs.Controllers;

[Route("Api/[controller]")]
public class CartController : Controller
{

    private readonly ILogger<CartController> _logger;
    private Cart cartToUse;

    public CartController(ILogger<CartController> logger, Cart sharedCart)
    {
        _logger = logger;
        cartToUse = sharedCart;
    }

    [HttpGet]
    public List<ImageClass>  get(){
        return cartToUse.imgObjects;
    }
    [HttpGet("{id}")] 
    public ImageClass get(int id){
        if(cartToUse.imgObjects[id] != null){
            return cartToUse.imgObjects[id];
        }
        else{
            return null;
        }
    }
    public JsonResult post([FromBody]ImageClass postedImageClass){
        if(cartToUse.imgObjects.Any(i => i.ImgName == postedImageClass.ImgName )){
            // I've tricked the ImageClass into believing that the ImageClass isn't null by adding a new Image Class into it.
            ImageClass ImageClassTest = cartToUse.imgObjects.Find(i => i.ImgName == postedImageClass.ImgName) ?? new ImageClass("Tony","Tony",200);
            // try using a linq query to filter out the one imageClass containing that similar xtic so that you work on it.
            //cartToUse.imgObjects[cartToUse.imgObjects.IndexOf(postedImageClass)].Quantity += 1;
            ImageClassTest.Quantity += 1;
            return Json(postedImageClass);
        }
        else{
            cartToUse.AddToCart(postedImageClass);
            return Json(postedImageClass);
        }
    }
}










/*public class WelcomeController : Controller {

    private readonly ILogger<WelcomeController> _logger;

    public WelcomeController(ILogger<WelcomeController> logger){
        _logger = logger;
    }

    public IActionResult Index(){
        return View();
    }
}*/ 


/*
["api/Cart"]
public class CartController : Controller{
    private Cart cartToBeUsed;
    public CartController(Cart cartInstance){

        cartToBeUsed = cartInstance;
    }
    public string Get(){
        return "Hi its working";
    }

    
}*/