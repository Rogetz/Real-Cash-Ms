using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RealCashMs.Models;

namespace RealCashMs.Controllers;

public class SupervisorController : Controller {

    private readonly ILogger<SupervisorController> _logger;

    public SupervisorController(ILogger<SupervisorController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(){
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error(){
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });        
    }
}