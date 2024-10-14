using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using MvcCOREApp.Models;
using MvcCOREApp.Services;

public class BaseController : Controller
{
    private readonly IMenuService _menuService;

    public BaseController(IMenuService menuService)
    {
        _menuService = menuService;
    }

    public override void OnActionExecuting(ActionExecutingContext context)
    {
        // Sample JSON data (normally, this will come from a database or API)
        List<MenuItem> flatMenuList = new List<MenuItem>
        {
        new MenuItem { MenuId = 1, MenuName = "Subscriber", HaveChild = true, ParentMenuId = 0 ,Url="",Title="Subscriber"},
        new MenuItem { MenuId = 2, MenuName = "Bulk", HaveChild = true, ParentMenuId = 0 ,Url="",Title="Bulk"},
        new MenuItem { MenuId = 3, MenuName = "CreateSubscriber", HaveChild = false, ParentMenuId = 1 ,Url="Subscriber",Title="Create Subscriber"},
        new MenuItem { MenuId = 4, MenuName = "AddConnection", HaveChild = true, ParentMenuId = 1 ,Url="Subscriber",Title="Add Connection"},
        new MenuItem { MenuId = 5, MenuName = "SingleConnection", HaveChild = false, ParentMenuId = 4 ,Url="Subscriber",Title="Single Connection"},
        new MenuItem { MenuId = 6, MenuName = "BulkConnection", HaveChild = false, ParentMenuId = 2 ,Url="Bulk",Title="Bulk Connection"}
        };

        ViewBag.MenuItems = _menuService.GetMenuItems(flatMenuList);
       
        base.OnActionExecuting(context);
    }
}
