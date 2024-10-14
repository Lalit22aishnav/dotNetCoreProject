using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcCOREApp.Models;
using MvcCOREApp.Services;

namespace MvcCOREApp.Controllers;

public class SubscriberController : BaseController
{
    private readonly ILogger<SubscriberController> _logger;

    // Constructor with both ILogger and IMenuService
    public SubscriberController(ILogger<SubscriberController> logger, IMenuService menuService) : base(menuService)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CreateSubscriber()
    {
        return View();
    }
    
    public IActionResult AddConnection()
    {
        return View();
    }
    public IActionResult SingleConnection()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
