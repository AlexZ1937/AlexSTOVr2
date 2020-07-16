using System.Web.Routing;

namespace AlexSTOv2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(null, "", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "list", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "list/{page}", "~/Pages/Listing.aspx");
            routes.MapPageRoute(null, "list/{category}/{page}", "~/Pages/Listing.aspx");

            routes.MapPageRoute("cart", "cart", "~/Pages/CartView.aspx");

            routes.MapPageRoute("checkout", "checkout", "~/Pages/Checkout.aspx");

            routes.MapPageRoute("admin_goodts", "admin/goodts", "~/Pages/Admin/Goodts.aspx");

            routes.MapPageRoute("admin_services", "admin/services", "~/Pages/Admin/Services.aspx");
        }
    }
}