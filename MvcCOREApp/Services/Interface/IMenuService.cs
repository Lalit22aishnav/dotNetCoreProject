using MvcCOREApp.Models;

namespace MvcCOREApp.Services
{
    public interface IMenuService
    {
        List<MenuItem> GetMenuItems(List<MenuItem> flatMenuList);  // Method to retrieve menu items
    }
}