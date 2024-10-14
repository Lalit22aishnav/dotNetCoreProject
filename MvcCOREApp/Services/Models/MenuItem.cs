namespace MvcCOREApp.Models
{
    public class MenuItem
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string RouteUrl { get; set; }
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public bool HaveChild { get; set; }
        public int ParentMenuId { get; set; }
        public List<MenuItem> SubItems { get; set; } = new List<MenuItem>(); // Sub-menu items
    }
}