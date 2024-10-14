using MvcCOREApp.Models;

namespace MvcCOREApp.Services
{
    public class MenuService : IMenuService
    {
        public List<MenuItem> GetMenuItems(List<MenuItem> flatMenuList)
        {
            Console.WriteLine("Yoo",flatMenuList);
            // Create a dictionary to map menu items by their menuId
            var menuDict = flatMenuList.ToDictionary(m => m.MenuId, m => m);

            // This list will hold the top-level menu items
            List<MenuItem> menuHierarchy = new List<MenuItem>();

            foreach (var menuItem in flatMenuList)
            {
                if (menuItem.ParentMenuId == 0)
                {
                    // Top-level menu item
                    menuHierarchy.Add(menuItem);
                }
                else
                {
                    // Add this menu item to its parent's SubItems list
                    if (menuDict.TryGetValue(menuItem.ParentMenuId, out var parentMenu))
                    {
                        parentMenu.SubItems.Add(menuItem);
                    }
                }
            }
            return menuHierarchy;
        }
    }
}
