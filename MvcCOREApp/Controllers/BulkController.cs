using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcCOREApp.Models;
using MvcCOREApp.Services;

namespace MvcCOREApp.Controllers;

public class BulkController : BaseController
{
    private readonly ILogger<BulkController> _logger;

    // Constructor with both ILogger and IMenuService
    public BulkController(ILogger<BulkController> logger, IMenuService menuService) : base(menuService)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult BulkConnection()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
